using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace SATeC.Administracion {
    public partial class frmCatalogoDeCuentasAuxiliares_Datos : Form {

        public string IDCatalogoDeCuentasAuxiliares = string.Empty;

		//VHJC Array que contiene los numeros de los catalogos auxiliares existentes para no poder guardar con el mismo numero
		private HashSet<string> CatalogosDeCuentasAuxiliaresExistentes = new HashSet<string>();

		//VHJC Array que contiene las cuentas ya existentes del catalogo de cuentas al que esta asociado el catalogo de cuentas auxiliares
		private Dictionary<string, List<string>> CuentasExistentesCatalogoDeCuentas = new Dictionary<string, List<string>>();

		//VHJC Array que contiene las cuentas auxiliares ya existentes del catalogo de cuentas auxiliares
		private Dictionary<string, List<string>> CuentasAuxiliaresExistentesCatalogoDeCuentasAuxiliares = new Dictionary<string, List<string>>();

        StringBuilder sbLogErrores = new StringBuilder();

        public frmCatalogoDeCuentasAuxiliares_Datos() {
            InitializeComponent();
        }

        private void frmCatalogosDeCuentasAuxiliares_Datos_Load(object sender, EventArgs e) {
			cargarCatalogosDeCuentasAuxiliaresExistentes();
			obtenerCatalogosDeCuentas();
            limipaDatos();

            if(IDCatalogoDeCuentasAuxiliares != string.Empty) {
                obtenerCatalogoDeCuentasAuxiliaresDatos();
            }
        }

		//VHJC Funcion que carga los Catalogos de Cuentas Auxiliares existentes en la base de datos
		private void cargarCatalogosDeCuentasAuxiliaresExistentes() {
			Cursor.Current = Cursors.WaitCursor;

			string SQL = "SELECT Numero_CatalogoCuentasAuxiliares FROM SATeC_CatalogosCuentasAuxiliares ";
			if(IDCatalogoDeCuentasAuxiliares != string.Empty)
				SQL += "WHERE ID_CatalogoCuentasAuxiliares <> " + IDCatalogoDeCuentasAuxiliares + " ";
			SQL += "ORDER BY Numero_CatalogoCuentasAuxiliares";
			OleDbDataReader drCatalogosDeCuentasAuxiliaresExistentes = Database.obtenRegistros(SQL);

			while(drCatalogosDeCuentasAuxiliaresExistentes.Read()) {
				CatalogosDeCuentasAuxiliaresExistentes.Add(drCatalogosDeCuentasAuxiliaresExistentes["Numero_CatalogoCuentasAuxiliares"].ToString());
			}

			Cursor.Current = Cursors.Default;
		}

        //VHJC Funcion que obtiene los catalogos de cuentas maestros para ligar al catalogo de cuentas auxiliares
        private void obtenerCatalogosDeCuentas() {
            OleDbDataReader drCatalogosCuentas = Database.obtenRegistros("SELECT ID_CatalogoCuentas, Nombre_CatalogoCuentas FROM SATeC_CatalogosCuentas ORDER BY Nombre_CatalogoCuentas");
            while(drCatalogosCuentas.Read()) {
                cmbCatalogoCuentas.Items.Add(new ListItem(drCatalogosCuentas["ID_CatalogoCuentas"].ToString(), drCatalogosCuentas["Nombre_CatalogoCuentas"].ToString()));
            }
        }

        //VHJC Funcion que limpia los controles para la captura de los datos del Catalogo de Cuentas Auxiliares
        private void limipaDatos() {
            this.txtIDCatalogoCuentasAuxiliares.Text = string.Empty;
            this.txtNumeroCatalogoCuentasAuxiliar.Text = string.Empty;
            this.txtNombreCatalogoCuentasAuxiliares.Text = string.Empty;
            txtArchivoCatalogoCuentasAuxiliares.Text = string.Empty;
            this.cmbCatalogoCuentas.ResetText();
            this.dgvCatalogoCuentasAuxiliares.Rows.Clear();

			dgvCatalogoCuentasAuxiliares.Columns["YaGuardado"].Visible = false;
			dgvCatalogoCuentasAuxiliares.Columns["ExisteCuentaPadre"].Visible = false;
            dgvCatalogoCuentasAuxiliares.Columns["Almacenado"].Visible = false;
        }

        //VHJC Obtiene los datos del catalogo de cuentas auxiliares que se selecciono
        private void obtenerCatalogoDeCuentasAuxiliaresDatos() {
			Cursor.Current = Cursors.WaitCursor; 

            OleDbDataReader drCatalogoDeCuentasAuxiliares = Database.obtenRegistros("SELECT Numero_CatalogoCuentasAuxiliares, Nombre_CatalogoCuentasAuxiliares, ID_CatalogoCuentas FROM SATeC_CatalogosCuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares=" + IDCatalogoDeCuentasAuxiliares);
			if(drCatalogoDeCuentasAuxiliares != null) {
				drCatalogoDeCuentasAuxiliares.Read();

                this.txtIDCatalogoCuentasAuxiliares.Text = IDCatalogoDeCuentasAuxiliares;
				this.txtNumeroCatalogoCuentasAuxiliar.Text = drCatalogoDeCuentasAuxiliares["Numero_CatalogoCuentasAuxiliares"].ToString();
				this.txtNombreCatalogoCuentasAuxiliares.Text = drCatalogoDeCuentasAuxiliares["Nombre_CatalogoCuentasAuxiliares"].ToString();
				General.buscaEnCombo(this.cmbCatalogoCuentas, drCatalogoDeCuentasAuxiliares["ID_CatalogoCuentas"].ToString());

				drCatalogoDeCuentasAuxiliares.Close();
				drCatalogoDeCuentasAuxiliares.Dispose();

				cargarCuentasCatalogoDeCuentas();
				cargarCuentasCatalogoDeCuentasAuxiliares();
            } else {
                General.muestraMensaje("Ocurrio un error al obtener los datos del Catálogo de Cuentas Auxiliares: " + Database.Error);
            }

			Cursor.Current = Cursors.Default;
        }

		//VHJC Obtiene las cuentas del catalogo de cuentas que esta ligado
		private void cargarCuentasCatalogoDeCuentas() {
			Cursor.Current = Cursors.WaitCursor;

			CuentasExistentesCatalogoDeCuentas.Clear();

			//VHJC Se cargan todas las cuentas que ya esten guardadas en la base de datos
			OleDbDataReader drCuentasCatalogoDeCuentas = Database.obtenRegistros("SELECT Cuenta, DescripcionCuenta, Naturaleza FROM SATeC_CatalogoCuentas_Cuentas WHERE ID_CatalogoCuentas = " + ((ListItem)cmbCatalogoCuentas.SelectedItem).Valor);
			while(drCuentasCatalogoDeCuentas.Read()) {
				string Cuenta = drCuentasCatalogoDeCuentas["Cuenta"].ToString();
				string DescripcionCuenta = drCuentasCatalogoDeCuentas["DescripcionCuenta"].ToString();
				string NaturalezaCuenta = drCuentasCatalogoDeCuentas["Naturaleza"].ToString();

				List<string> DatosCuenta = new List<string>();
				DatosCuenta.Add(DescripcionCuenta);
				DatosCuenta.Add(NaturalezaCuenta);

				CuentasExistentesCatalogoDeCuentas.Add(Cuenta, DatosCuenta);
			}

			drCuentasCatalogoDeCuentas.Close();
			drCuentasCatalogoDeCuentas.Dispose();

			Cursor.Current = Cursors.Default;
		}

		//VHJC Obtiene las cuentas del catalogo de cuentas auxiliares que se selecciono
		private void cargarCuentasCatalogoDeCuentasAuxiliares() {
			CuentasAuxiliaresExistentesCatalogoDeCuentasAuxiliares.Clear();

			//VHJC Primero se agrega un renglon todo en blanco para hacer la separacion
			int RegistroEnBlanco = dgvCatalogoCuentasAuxiliares.Rows.Add("", "", "", "", true, true, false);

			for(int i = 0; i < 4; i++) {
				dgvCatalogoCuentasAuxiliares.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentasAuxiliares.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentasAuxiliares.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentasAuxiliares.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
			}

			//VHJC Se cargan todas las cuentas que ya esten guardadas en la base de datos
            OleDbDataReader drCuentasCatalogoDeCuentas = Database.obtenRegistros("SELECT CuentaPadre, CuentaAuxiliar, DescripcionCuentaAuxiliar, Naturaleza FROM SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares = " + IDCatalogoDeCuentasAuxiliares + " ORDER BY CuentaPadre, CuentaAuxiliar");
			while(drCuentasCatalogoDeCuentas.Read()) {
				string CuentaPadre = drCuentasCatalogoDeCuentas["CuentaPadre"].ToString();
				string CuentaAuxiliar = drCuentasCatalogoDeCuentas["CuentaAuxiliar"].ToString();
				string DescripcionCuentaAuxiliar = drCuentasCatalogoDeCuentas["DescripcionCuentaAuxiliar"].ToString();
				string NaturalezaCuentaAuxiliar = drCuentasCatalogoDeCuentas["Naturaleza"].ToString();

				dgvCatalogoCuentasAuxiliares.Rows.Add(CuentaPadre, CuentaAuxiliar, DescripcionCuentaAuxiliar, NaturalezaCuentaAuxiliar, true, true, true);

				List<string> DatosCuentaAuxiliar = new List<string>();
				DatosCuentaAuxiliar.Add(DescripcionCuentaAuxiliar);
				DatosCuentaAuxiliar.Add(NaturalezaCuentaAuxiliar);

				CuentasAuxiliaresExistentesCatalogoDeCuentasAuxiliares.Add(CuentaPadre + "-" + CuentaAuxiliar, DatosCuentaAuxiliar);
			}
		}

		//VHJC Cuando se da clic en el boton "..." para seleccionar el archivo del catalogo de cuentas
		private void cmdAbrirArchivo_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			if(cmbCatalogoCuentas.Text == string.Empty) {
				General.muestraMensaje("Favor de seleccionar el Catálogo de Cuentas al que pertenecera el Catálogo de Cuentas Auxiliar");
			} else {

				OpenFileDialog openFileDialog1 = new OpenFileDialog();
				openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
				openFileDialog1.Title = "Seleccione el archivo TXT del Catálogo de Cuentas";

				// VHJC Muestra la ventana para seleccionar el archivo
				// Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
				if(openFileDialog1.ShowDialog() == DialogResult.OK) {
					txtArchivoCatalogoCuentasAuxiliares.Text = openFileDialog1.SafeFileName;
					txtPathArchivoCatalogoCuentasAuxiliares.Text = openFileDialog1.FileName;

					string Error = string.Empty;

					if(!cargaArchivoCatalogoCuentasAuxiliaresTXT(out Error)) {
						General.muestraMensaje("Ocurrio un error al cargar el archivo TXT del Catálogo de Cuentas Auxiliares.\n" + Error);
					}
				}
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Funcion que carga el contenido de archivo TXT al grid
		private bool cargaArchivoCatalogoCuentasAuxiliaresTXT(out string Error) {
			Cursor.Current = Cursors.WaitCursor;

			bool Cargado = true;
			Error = string.Empty;

			bool FirstRow = true;
			bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

            List<string> listaNaturaleza = new List<string>();
            listaNaturaleza.Add("D");
            listaNaturaleza.Add("A");

			string Separador = string.Empty;
			//VHJC Por default el separador es ","
			char[] separator = { ',' };

			try {
				dgvCatalogoCuentasAuxiliares.Rows.Clear();

				TextFieldParser txtReader = new TextFieldParser(txtPathArchivoCatalogoCuentasAuxiliares.Text, Encoding.Default);
				txtReader.TextFieldType = FieldType.Delimited;
				txtReader.SetDelimiters(",");
				txtReader.HasFieldsEnclosedInQuotes = true;

				//VHJC Por cada una de las lineas del archivo TXT
				while(!txtReader.EndOfData) {
					//VHJC Se verifica la primer linea para ver si el archivo viene separado por TABS o por comas...
					if(FirstRow) {
						//VHJC Se lee la primer linea...
						string firstRow = txtReader.PeekChars(1000);

						//VHJC Si la primer linea viene con un tab, entonces el separador pasa a ser "Tab"
						if(firstRow.Contains("\t"))
							txtReader.SetDelimiters("\t");

						FirstRow = false;
					}

					//VHJC Si esta marcada la opcion de "Primero fila con nombres de columnas", se salta la primer linea
					if(PrimerFilaNombresColumnas) {
						txtReader.ReadLine();
						PrimerFilaNombresColumnas = false;
						continue;
					}

					//VHJC Variable que va a contener los datos de cada cuenta
					string[] DatosCuenta = txtReader.ReadFields();

                    if (DatosCuenta.Count() != 6)
                    {
                        Error = "El numero de campos del formato de carga es 6: Ano, Mes, Cuenta, Auxiliar, Descripcion y Naturaleza. Verifique.";
                        return false;
                    }

                    string anio = DatosCuenta[0];
                    string mes = DatosCuenta[1];
					string CuentaPadre = DatosCuenta[2];
					string CuentaAuxiliar = DatosCuenta[3];
					string DescripcionCuentaAuxiliar = DatosCuenta[4];
					string NaturalezaCuentaAuxiliar = DatosCuenta[5];

                    List<string> encontrado = listaNaturaleza.FindAll(item => item == NaturalezaCuentaAuxiliar);

                    if (encontrado.Count == 0)
                    {
                        Error = "Los valores permitidos para el campo Naturaleza son D / N. Verifique.";
                        return false;
                    }

					//VHJC Se verifica si la Cuenta ya esta guardada
					bool ExisteCuenta = CuentasAuxiliaresExistentesCatalogoDeCuentasAuxiliares.ContainsKey(CuentaPadre + "-" + CuentaAuxiliar);

					//VHJC Se verifica si la cuenta padre existe en el catalogo de cuentas seleccionado
					bool ExisteCuentaPadre = CuentasExistentesCatalogoDeCuentas.ContainsKey(CuentaPadre);

					bool ErrorCuenta = (CuentaPadre == string.Empty && CuentaAuxiliar == string.Empty && DescripcionCuentaAuxiliar == string.Empty && NaturalezaCuentaAuxiliar == string.Empty);

					int RegistroAgregado = dgvCatalogoCuentasAuxiliares.Rows.Add(CuentaPadre, CuentaAuxiliar, DescripcionCuentaAuxiliar, NaturalezaCuentaAuxiliar, ExisteCuenta, ExisteCuentaPadre, false);

					//VHJC Si la cuenta ya existe se marca el registro en amarillo
					if(ExisteCuenta) {
						for(int i = 0; i < dgvCatalogoCuentasAuxiliares.Columns.Count; i++) {
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}

					//VHJC Si la cuenta padre no existe se marca el registro en rojo
					if(!ExisteCuentaPadre) {
						for(int i = 0; i < dgvCatalogoCuentasAuxiliares.Columns.Count; i++) {
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Red;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Red;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvCatalogoCuentasAuxiliares.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}
				}

				txtReader.Close();
				txtReader.Dispose();

			} catch(Exception ex) {
				Cargado = false;

                sbLogErrores = new StringBuilder();
                sbLogErrores.AppendLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + " | Error en el proceso de carga del archivo de Catalogo de Auxiliares. | Exception: " + ex.Message);

                if (sbLogErrores.Length > 0)
                {
                    string StartupPath = INI.Read("Repositorio", "Ruta");

                    using (StreamWriter writer = new StreamWriter(StartupPath + "\\LogErrores_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", true))
                    {
                        writer.WriteLine(sbLogErrores.ToString());
                        writer.Close();
                    }
                }

                Error = "Verifique formato del archivo";
			}

			if(CuentasAuxiliaresExistentesCatalogoDeCuentasAuxiliares.Keys.Count > 0) {
				cargarCuentasCatalogoDeCuentasAuxiliares();
			}

			Cursor.Current = Cursors.Default;

			return Cargado;
		}

		//VHJC Guarda los datos del Catalogo de Cuentas Auxiliares
        private void cmdGuardar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;
            bool Salir = false;

            if (validaCatalogoDeCuentasAuxiliaresDatos())
            {
                if (IDCatalogoDeCuentasAuxiliares == string.Empty)
                {
                    SQL = "INSERT INTO SATeC_CatalogosCuentasAuxiliares (Numero_CatalogoCuentasAuxiliares, Nombre_CatalogoCuentasAuxiliares, ID_CatalogoCuentas, Fecha_Alta, ID_Usuario_Alta) VALUES(";
                    SQL += "'" + txtNumeroCatalogoCuentasAuxiliar.Text + "', ";
                    SQL += "'" + txtNombreCatalogoCuentasAuxiliares.Text + "', ";
                    SQL += "" + ((ListItem)cmbCatalogoCuentas.SelectedItem).Valor + ", ";
                    SQL += "getdate(), ";
                    SQL += General.UsuarioActual.ID.ToString();
                    SQL += ")\n";

                    SQL += "DECLARE @ID_CatalogoCuentasAuxiliares int = @@IDENTITY \n";
                }
                else
                {
                    SQL = "UPDATE SATeC_CatalogosCuentasAuxiliares SET ";
                    SQL += "Numero_CatalogoCuentasAuxiliares='" + txtNumeroCatalogoCuentasAuxiliar.Text + "', ";
                    SQL += "Nombre_CatalogoCuentasAuxiliares='" + txtNombreCatalogoCuentasAuxiliares.Text + "', ";
                    SQL += "ID_CatalogoCuentas=" + ((ListItem)cmbCatalogoCuentas.SelectedItem).Valor + " ";
                    SQL += "WHERE ID_CatalogoCuentasAuxiliares='" + txtIDCatalogoCuentasAuxiliares.Text + "'";
                    SQL += "\n";

                    SQL += "DECLARE @ID_CatalogoCuentasAuxiliares int = " + IDCatalogoDeCuentasAuxiliares + "\n";
                }

                foreach (DataGridViewRow dgvrCuentaAuxiliar in dgvCatalogoCuentasAuxiliares.Rows)
                {
                    if (!bool.Parse(dgvrCuentaAuxiliar.Cells["Almacenado"].Value.ToString()))
                    {
                        if (!String.IsNullOrEmpty(dgvrCuentaAuxiliar.Cells["CuentaPadre"].Value.ToString()))
                        {
                            SQL += "IF NOT EXISTS ( SELECT 1 FROM SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares = @ID_CatalogoCuentasAuxiliares AND CuentaPadre = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaPadre"].Value + "' ";
                            SQL += "AND CuentaAuxiliar = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaAuxiliar"].Value + "' ) \n";

                            SQL += "INSERT INTO SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares (ID_CatalogoCuentasAuxiliares, CuentaPadre, CuentaAuxiliar, DescripcionCuentaAuxiliar, Naturaleza) VALUES(";
                            SQL += "@ID_CatalogoCuentasAuxiliares, ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaPadre"].Value + "', ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaAuxiliar"].Value + "', ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["DescripcionCuentaAuxiliar"].Value.ToString().Replace("'", "''") + "', ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["NaturalezaCuentaAuxiliar"].Value + "')\n";

                            SQL += "ELSE ";

                            SQL += "UPDATE SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares SET DescripcionCuentaAuxiliar = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["DescripcionCuentaAuxiliar"].Value.ToString().Replace("'", "''") + "', ";
                            SQL += "Naturaleza = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["NaturalezaCuentaAuxiliar"].Value + "' ";
                            SQL += "WHERE ID_CatalogoCuentasAuxiliares = ";
                            SQL += "@ID_CatalogoCuentasAuxiliares ";
                            SQL += "AND CuentaPadre = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaPadre"].Value + "' ";
                            SQL += "AND CuentaAuxiliar = ";
                            SQL += "'" + dgvrCuentaAuxiliar.Cells["CuentaAuxiliar"].Value + "' \n";
                        }
                    }
                }

                if (Database.ejecutaQuery(SQL, true))
                {
                    Salir = true;
                    General.muestraMensaje("Los datos del Catálogo de Cuentas Auxiliares se han guardado con exito.");
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos del Catálogo de Cuentas Auxiliares: " + Database.Error);
                }
            }

            Cursor = Cursors.Default;

            if(Salir)
                this.Close();
        }

        //VHJC Funcion que valida que los datos del Catalogo de Cuentas Auxilaires esten completos y correctos
		private bool validaCatalogoDeCuentasAuxiliaresDatos() {
            bool Valida = true;

            if(txtNumeroCatalogoCuentasAuxiliar.Text == string.Empty) {
                General.muestraMensaje("El número del Catalogo de Cuentas Auxilaires no puede estar en blanco, favor de revisar.");
                txtNumeroCatalogoCuentasAuxiliar.Focus();
                Valida = false;
			} else if(CatalogosDeCuentasAuxiliaresExistentes.Contains(txtNumeroCatalogoCuentasAuxiliar.Text)) {
				General.muestraMensaje("El número del Catálogo de Cuentas Auxiliares ya existe en la base de datos, favor de revisar.");
				txtNumeroCatalogoCuentasAuxiliar.Focus();
				Valida = false;
            } else if(txtNombreCatalogoCuentasAuxiliares.Text == string.Empty) {
                General.muestraMensaje("El nombre del Catalogo de Cuentas Auxiliares no puede estar en blanco, favor de revisar.");
                txtNombreCatalogoCuentasAuxiliares.Focus();
                Valida = false;
            } else if(cmbCatalogoCuentas.Text == string.Empty) {
                General.muestraMensaje("Debe seleccionar el Catálogo de Cuentas maestro al que se ligara el Catalogo de Cuentas Auxilaires.");
                cmbCatalogoCuentas.Focus();
                Valida = false;
            } else if(txtArchivoCatalogoCuentasAuxiliares.Text == string.Empty) {
                General.muestraMensaje("Debe seleccionar el archivo TXT del Catálogo de Cuentas Auxilaires.");
                txtArchivoCatalogoCuentasAuxiliares.Focus();
                Valida = false;
            } else if(dgvCatalogoCuentasAuxiliares.Rows.Count == 0) {
                General.muestraMensaje("El archivo TXT del Catálogo de Cuentas Auxilaires no es correcto, favor de revisar.");
                txtArchivoCatalogoCuentasAuxiliares.Focus();
                Valida = false;
			
			}
            else if (ExisteNombreCatalogoCuentasAuxiliar(txtNombreCatalogoCuentasAuxiliares.Text.Trim()))
            {
                General.muestraMensaje("¡El nombre del Catálogo de Cuentas Auxiliar Ya Existe!, favor de revisar.");
                txtNombreCatalogoCuentasAuxiliares.Focus();
                Valida = false;
            }           
            else {
				//VHJC Por cada una de las cuentas mostradas
				foreach(DataGridViewRow dgvrCuentaAuxiliar in dgvCatalogoCuentasAuxiliares.Rows) {

                        //if(dgvrCuentaAuxiliar.Cells["CuentaPadre"].Value.ToString() == string.Empty) {
                        //    General.muestraMensaje("La Cuenta Padre no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                        //    dgvCatalogoCuentasAuxiliares.CurrentCell = dgvrCuentaAuxiliar.Cells["CuentaPadre"];
                        //    Valida = false;
                        //    break;
                        //} else if(dgvrCuentaAuxiliar.Cells["CuentaAuxiliar"].Value.ToString() == string.Empty) {
                        //    General.muestraMensaje("La Cuenta Auxiliar no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                        //    dgvCatalogoCuentasAuxiliares.CurrentCell = dgvrCuentaAuxiliar.Cells["CuentaAuxiliar"];
                        //    Valida = false;
                        //    break;
                        //} else if(dgvrCuentaAuxiliar.Cells["DescripcionCuentaAuxiliar"].Value.ToString() == string.Empty) {
                        //    General.muestraMensaje("La Descripción de la Cuenta Auxiliar no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                        //    dgvCatalogoCuentasAuxiliares.CurrentCell = dgvrCuentaAuxiliar.Cells["DescripcionCuentaAuxiliar"];
                        //    Valida = false;
                        //    break;
                        //} else if(dgvrCuentaAuxiliar.Cells["NaturalezaCuentaAuxiliar"].Value.ToString() == string.Empty) {
                        //    General.muestraMensaje("La Naturaleza de la Cuenta Auxiliar no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                        //    dgvCatalogoCuentasAuxiliares.CurrentCell = dgvrCuentaAuxiliar.Cells["NaturalezaCuentaAuxiliar"];
                        //    Valida = false;
                        //    break;
                        //} else if(!bool.Parse(dgvrCuentaAuxiliar.Cells["ExisteCuentaPadre"].Value.ToString())) {
                        //    General.muestraMensaje("La Cuenta Padre no existe en el Catálogo de Cuentas, favor de verificar el archivo TXT y volverlo a cargar.");
                        //    dgvCatalogoCuentasAuxiliares.CurrentCell = dgvrCuentaAuxiliar.Cells["CuentaPadre"];
                        //    Valida = false;
                        //    break;

                        //}
					
				}

				
			}

            return Valida;
        }

		//VHJC Cuando se da clic en el boton cancelar, se pregunta si quiere salir sin guardar los datos
        private void cmdCancelar_Click(object sender, EventArgs e) {
            if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos del Catálogo de Cuentas Auxiliares?") == DialogResult.Yes) {
                this.Close();
            }
        }

		private void dgvCatalogoCuentasAuxiliares_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
			DataGridViewRow dgvRow = dgvCatalogoCuentasAuxiliares.Rows[e.RowIndex];

			if(dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153)) {

				Font fnt = new Font(dgvCatalogoCuentasAuxiliares.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

				Rectangle rct = dgvCatalogoCuentasAuxiliares.GetRowDisplayRectangle(dgvRow.Index, true);
				rct.Height -= 1;

				SizeF s = e.Graphics.MeasureString("Cuentas Auxiliares ya guardadas", fnt);
				float lefts = (rct.Width / 2) - (s.Width / 2);
				float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

				SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
				e.Graphics.FillRectangle(brush, rct);

				e.Graphics.DrawString("Cuentas Auxiliares ya guardadas", fnt, Brushes.White, lefts, tops);
			}
		}
		private void cmbCatalogoCuentas_SelectedIndexChanged(object sender, EventArgs e) {
			cargarCuentasCatalogoDeCuentas();
		}
        private bool ExisteNombreCatalogoCuentasAuxiliar(string nombre)
        {
            try
            {
                string resultado = String.Empty;

                if(!String.IsNullOrEmpty(IDCatalogoDeCuentasAuxiliares))
                    resultado = Database.obtenerDato("DECLARE @resultado INT SET @resultado = 0 IF EXISTS( select 1 from SATeC_CatalogosCuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares != " + IDCatalogoDeCuentasAuxiliares + " AND UPPER(Nombre_CatalogoCuentasAuxiliares) = UPPER('" + nombre + "') ) 	SET @resultado = 1 SELECT @resultado resultado");
                else
                    resultado = Database.obtenerDato("DECLARE @resultado INT SET @resultado = 0 IF EXISTS( select 1 from SATeC_CatalogosCuentasAuxiliares WHERE UPPER(Nombre_CatalogoCuentasAuxiliares) = UPPER('" + nombre + "') ) 	SET @resultado = 1 SELECT @resultado resultado");

                if (resultado.Equals("1"))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}