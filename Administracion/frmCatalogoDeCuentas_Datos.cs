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
using System.Diagnostics;

namespace SATeC.Administracion {
    public partial class frmCatalogoDeCuentas_Datos : Form {

        public string IDCatalogoCuentas = string.Empty;

		//VHJC Array que contiene los numeros de los catalogos existentes para no poder guardar con el mismo numero
		private HashSet<string> CatalogosDeCuentasExistentes = new HashSet<string>();

		//VHJC Array que contiene las cuentas ya existentes del catalogo de cuentas
		private Dictionary<string, List<string>> CuentasExistentesCatalogoDeCuentas = new Dictionary<string, List<string>>();

        private int totalCuentas = 0;

        StringBuilder sbLogErrores = new StringBuilder();

        public frmCatalogoDeCuentas_Datos() {
            InitializeComponent();
        }

        private void frmCatalogoDeCuentas_Datos_Load(object sender, EventArgs e) {
			cargarCatalogosDeCuentaExistentes();
			limipaDatos();

            if(IDCatalogoCuentas != string.Empty) {
                obtenerCatalogoDeCuentasDatos();
            }
        }

		//VHJC Funcion que carga los Catalogos de Cuentas existentes en la base de datos
		private void cargarCatalogosDeCuentaExistentes() {
			Cursor.Current = Cursors.WaitCursor;

			string SQL = "SELECT Numero_CatalogoCuentas FROM SATeC_CatalogosCuentas ";
			if(IDCatalogoCuentas != string.Empty)
				SQL += "WHERE ID_CatalogoCuentas <> " + IDCatalogoCuentas + " ";
			SQL += "ORDER BY Numero_CatalogoCuentas";
			OleDbDataReader drCatalogosDeCuentasExistentes = Database.obtenRegistros(SQL);

			while(drCatalogosDeCuentasExistentes.Read()) {
				CatalogosDeCuentasExistentes.Add(drCatalogosDeCuentasExistentes["Numero_CatalogoCuentas"].ToString());
			}

			Cursor.Current = Cursors.Default;
		}

        //VHJC Funcion que limpia los controles para la captura de los datos del Usario
        private void limipaDatos() {
            this.txtIDCatalogoCuentas.Text = string.Empty;
            this.txtNumeroCatalogoCuentas.Text = string.Empty;
            this.txtNombreCatalogoCuentas.Text = string.Empty;
            this.txtArchivoCatalogoCuentas.Text = string.Empty;
            this.txtPathArchivoCatalogoCuentas.Text = string.Empty;

			dgvCatalogoCuentas.Columns["YaGuardado"].Visible = false;
            dgvCatalogoCuentas.Columns["Almacenado"].Visible = false;
        }

        //VHJC Obtiene los datos del catalogo de cuentas que se selecciono
        private void obtenerCatalogoDeCuentasDatos() {
			Cursor.Current = Cursors.WaitCursor; 
			
			OleDbDataReader drCatalogoDeCuentas = Database.obtenRegistros("SELECT Numero_CatalogoCuentas, Nombre_CatalogoCuentas, Liberado FROM SATeC_CatalogosCuentas WHERE ID_CatalogoCuentas = " + IDCatalogoCuentas);
            if(drCatalogoDeCuentas != null) {
                drCatalogoDeCuentas.Read();

                this.txtIDCatalogoCuentas.Text = IDCatalogoCuentas;
                this.txtNumeroCatalogoCuentas.Text = drCatalogoDeCuentas["Numero_CatalogoCuentas"].ToString();
                this.txtNombreCatalogoCuentas.Text = drCatalogoDeCuentas["Nombre_CatalogoCuentas"].ToString();

                drCatalogoDeCuentas.Close();
                drCatalogoDeCuentas.Dispose();

				cargarCuentasCatalogoDeCuentas();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }

			Cursor.Current = Cursors.Default;
		}

		//VHJC Obtiene las cuentas del catalogo de cuentas que se selecciono
		private void cargarCuentasCatalogoDeCuentas() {

			CuentasExistentesCatalogoDeCuentas.Clear();

			//VHJC Primero se agrega un renglon todo en blanco para hacer la separacion
			int RegistroEnBlanco = dgvCatalogoCuentas.Rows.Add("", "", "", true, false);

			for(int i = 0; i < 3; i++) {
				dgvCatalogoCuentas.Rows[RegistroEnBlanco].Cells[i].Style.BackColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentas.Rows[RegistroEnBlanco].Cells[i].Style.SelectionBackColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentas.Rows[RegistroEnBlanco].Cells[i].Style.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
				dgvCatalogoCuentas.Rows[RegistroEnBlanco].Cells[i].Style.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
			}

			//VHJC Se cargan todas las cuentas que ya esten guardadas en la base de datos
			OleDbDataReader drCuentasCatalogoDeCuentas = Database.obtenRegistros("SELECT Cuenta, DescripcionCuenta, Naturaleza FROM SATeC_CatalogoCuentas_Cuentas WHERE ID_CatalogoCuentas = " + IDCatalogoCuentas);
			while(drCuentasCatalogoDeCuentas.Read()) {
				string Cuenta = drCuentasCatalogoDeCuentas["Cuenta"].ToString();
				string DescripcionCuenta = drCuentasCatalogoDeCuentas["DescripcionCuenta"].ToString();
				string NaturalezaCuenta = drCuentasCatalogoDeCuentas["Naturaleza"].ToString();

				dgvCatalogoCuentas.Rows.Add(Cuenta, DescripcionCuenta, NaturalezaCuenta, true, true);

				List<string> DatosCuenta = new List<string>();
				DatosCuenta.Add(DescripcionCuenta);
				DatosCuenta.Add(NaturalezaCuenta);

				CuentasExistentesCatalogoDeCuentas.Add(Cuenta, DatosCuenta);
			}
		}

        //VHJC Cuando se da clic en el boton "..." para seleccionar el archivo del catalogo de cuentas
        private void cmdAbrirArchivo_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT del Catálogo de Cuentas";

            // VHJC Muestra la ventana para seleccionar el archivo
            // Si el usuario selecciona un archivo txt y le clic en el boton OK, se regresa el nombre del archivo para despues validarlo
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                txtArchivoCatalogoCuentas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoCatalogoCuentas.Text = openFileDialog1.FileName;

                string Error = string.Empty;

                if(!cargaArchivoCatalogoCuentasTXT(out Error)) {
                    General.muestraMensaje("Ocurrio un error al cargar el archivo del Catálogo de Cuentas.\n" + Error);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        //VHJC Funcion que carga el contenido de archivo TXT al grid
        private bool cargaArchivoCatalogoCuentasTXT(out string Error) {
			Cursor.Current = Cursors.WaitCursor;

            bool Cargado = true;
            Error = string.Empty;
            totalCuentas = 0;

			bool FirstRow = true;
			bool PrimerFilaNombresColumnas = chkPrimerFilaNombresColumnas.Checked;

            List<string> listaNaturaleza = new List<string>();
            listaNaturaleza.Add("D");
            listaNaturaleza.Add("A");

            string Separador = string.Empty;
            //VHJC Por default el separador es ","
            char[] separator = { ',' };

            try {
                dgvCatalogoCuentas.Rows.Clear();

				TextFieldParser txtReader = new TextFieldParser(txtPathArchivoCatalogoCuentas.Text, Encoding.Default);
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

					if(PrimerFilaNombresColumnas) {
						txtReader.ReadLine();
						PrimerFilaNombresColumnas = false;
						continue;
					}

					string[] DatosCuenta = txtReader.ReadFields();

                    if (DatosCuenta.Count() != 5)
                    {
                        Error = "El numero de campos del formato de carga es 5: Ano, Mes, Cuenta, Descripcion y Naturaleza. Verifique.";
                        return false;
                    }

                    string anio = DatosCuenta[0];
                    string mes = DatosCuenta[1];
                    string Cuenta = DatosCuenta[2];
					string DescripcionCuenta = DatosCuenta[3];
					string Naturaleza = DatosCuenta[4];                    

                    List<string> encontrado = listaNaturaleza.FindAll(item => item == Naturaleza);

                    if (encontrado.Count == 0)
                    {
                        Error = "Los valores permitidos para el campo Naturaleza son D / N. Verifique.";
                        return false;
                    }
                    
					bool ExisteCuenta = CuentasExistentesCatalogoDeCuentas.ContainsKey(Cuenta);

					bool ErrorCuenta = (Cuenta == string.Empty && DescripcionCuenta == string.Empty && Naturaleza == string.Empty);

					int RegistroAgregado = dgvCatalogoCuentas.Rows.Add(Cuenta, DescripcionCuenta, Naturaleza, ExisteCuenta, false);

                    totalCuentas++;

					//VHJC Si la cuenta ya existe se marca el registro en amarillo
					if(ExisteCuenta) {
						for(int i = 0; i < dgvCatalogoCuentas.Columns.Count; i++) {
							dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.BackColor = System.Drawing.Color.Yellow;
							dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.SelectionBackColor = System.Drawing.Color.Yellow;
							dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.ForeColor = System.Drawing.Color.Black;
							dgvCatalogoCuentas.Rows[RegistroAgregado].Cells[i].Style.SelectionForeColor = System.Drawing.Color.Black;
						}
					}
                }

				txtReader.Close();
				txtReader.Dispose();

            } catch(Exception ex) {
                Cargado = false;

                sbLogErrores = new StringBuilder();
                sbLogErrores.AppendLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + " | Error en el proceso de carga del archivo de Catalogo de Cuentas. | Exception: " + ex.Message);

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

			if(CuentasExistentesCatalogoDeCuentas.Keys.Count > 0) {
				cargarCuentasCatalogoDeCuentas();
			}

			Cursor.Current = Cursors.Default;

            return Cargado;
        }

        //VHJC Guarda los datos del Catalogo de Cuentas
        private void cmdGuardar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;
            bool Salir = false;

            if(validaCatalogoDeCuentasDatos()) {
                if(IDCatalogoCuentas == string.Empty) {
                    SQL = "INSERT INTO SATeC_CatalogosCuentas (Numero_CatalogoCuentas, Nombre_CatalogoCuentas, Fecha_Alta, ID_Usuario_Alta) VALUES(";
                    SQL += "'" + txtNumeroCatalogoCuentas.Text + "', ";
                    SQL += "'" + txtNombreCatalogoCuentas.Text + "', ";
                    SQL += "getdate(), ";
                    SQL += General.UsuarioActual.ID + ")\n";
                    
                    SQL += "DECLARE @ID_CatalogoCuentas int = @@IDENTITY\n";
                } else {
                    SQL = "UPDATE SATeC_CatalogosCuentas SET ";
                    SQL += "Numero_CatalogoCuentas='" + txtNumeroCatalogoCuentas.Text + "', ";
                    SQL += "Nombre_CatalogoCuentas='" + txtNombreCatalogoCuentas.Text + "' ";
                    SQL += "WHERE ID_CatalogoCuentas='" + txtIDCatalogoCuentas.Text + "'";
					SQL += "\n";

                    SQL += "DECLARE @ID_CatalogoCuentas int = " + IDCatalogoCuentas + " \n \n";
				}

				foreach(DataGridViewRow dgvrCuenta in dgvCatalogoCuentas.Rows) 
                {
                    if (!bool.Parse(dgvrCuenta.Cells["Almacenado"].Value.ToString()))
                    {
                        if (!String.IsNullOrEmpty(dgvrCuenta.Cells["Cuenta"].Value.ToString()))
                        {
                            SQL += "IF NOT EXISTS ( SELECT 1 FROM SATeC_CatalogoCuentas_Cuentas WHERE ID_CatalogoCuentas = @ID_CatalogoCuentas AND Cuenta = ";
                            SQL += "'" + dgvrCuenta.Cells["Cuenta"].Value + "' ) \n ";

                            SQL += "INSERT INTO SATeC_CatalogoCuentas_Cuentas (ID_CatalogoCuentas, Cuenta, DescripcionCuenta, Naturaleza) VALUES(";
                            SQL += "@ID_CatalogoCuentas, ";
                            SQL += "'" + dgvrCuenta.Cells["Cuenta"].Value + "', ";
                            SQL += "'" + dgvrCuenta.Cells["DescripcionCuenta"].Value.ToString().Replace("'", "''") + "', ";
                            SQL += "'" + dgvrCuenta.Cells["Naturaleza"].Value + "')\n";

                            SQL += "ELSE ";

                            SQL += "UPDATE SATeC_CatalogoCuentas_Cuentas SET DescripcionCuenta = ";
                            SQL += "'" + dgvrCuenta.Cells["DescripcionCuenta"].Value.ToString().Replace("'", "''") + "', ";
                            SQL += "Naturaleza = ";
                            SQL += "'" + dgvrCuenta.Cells["Naturaleza"].Value + "' ";
                            SQL += "WHERE ID_CatalogoCuentas = @ID_CatalogoCuentas ";
                            SQL += "AND Cuenta = ";
                            SQL += "'" + dgvrCuenta.Cells["Cuenta"].Value + "' \n";
                        }
                    }
				}

                if(Database.ejecutaQuery(SQL, true)) {
                    Salir = true;
                    General.muestraMensaje("Los datos del Catálogo de Cuentas se han guardado con exito.");
                } else {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos del Catálogo de Cuentas: " + Database.Error);
                }
            }

            Cursor = Cursors.Default;

            if(Salir)
                this.Close();
        }
        private bool validaCatalogoDeCuentasDatos() 
        {
            bool Valida = true;

            if(txtNumeroCatalogoCuentas.Text == string.Empty) {
                General.muestraMensaje("El número del Catálogo de Cuentas no puede estar en blanco, favor de revisar.");
                txtNumeroCatalogoCuentas.Focus();
                Valida = false;
			} else if(CatalogosDeCuentasExistentes.Contains(txtNumeroCatalogoCuentas.Text)) {
				General.muestraMensaje("El número del Catálogo de Cuentas ya existe en la base de datos, favor de revisar.");
				txtNumeroCatalogoCuentas.Focus();
				Valida = false;
			} else if(txtNombreCatalogoCuentas.Text == string.Empty) {
                General.muestraMensaje("El nombre del Catálogo de Cuentas no puede estar en blanco, favor de revisar.");
                txtNombreCatalogoCuentas.Focus();
                Valida = false;
            }else if(txtArchivoCatalogoCuentas.Text == string.Empty) {
				General.muestraMensaje("Debe seleccionar el archivo TXT del Catálogo de Cuentas.");
                cmdAbrirArchivo.Focus();
                Valida = false;
			} else if(dgvCatalogoCuentas.Rows.Count == 0) {
				General.muestraMensaje("El archivo TXT del Catálogo de Cuentas Auxilaires no es correcto, favor de revisar.");
				txtArchivoCatalogoCuentas.Focus();
				Valida = false;
			}
            else if (ExisteNombreCatalogoCuentas(txtNombreCatalogoCuentas.Text.Trim()))
            {
                General.muestraMensaje("¡El nombre del Catálogo de Cuentas Ya Existe!, favor de revisar.");
                txtNombreCatalogoCuentas.Focus();
                Valida = false;
            }
            // VERSION DEMO RESTRINGIDA.
            //else if (totalCuentas > int.Parse(Properties.Resources.TotalCuentas))
            //{
            //    General.muestraMensaje("La version Demo solo permite guardar hasta " + Properties.Resources.TotalCuentas + " Cuentas de Mayor. Solicite la version completa.");
            //    txtNombreCatalogoCuentas.Focus();
            //    Valida = false;
            //}
            else
            {
                //VHJC Por cada una de las cuentas mostradas
                foreach (DataGridViewRow dgvrCuenta in dgvCatalogoCuentas.Rows)
                {
                    //if (!(dgvrCuenta.Cells["Cuenta"].Value.ToString() == string.Empty) && !(dgvrCuenta.Cells["DescripcionCuenta"].Value.ToString() == string.Empty) && !(dgvrCuenta.Cells["Naturaleza"].Value.ToString() == string.Empty))
                    //{
                    //    if (dgvrCuenta.Cells["Cuenta"].Value.ToString() == string.Empty)
                    //    {
                    //        General.muestraMensaje("La Cuenta no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                    //        dgvCatalogoCuentas.CurrentCell = dgvrCuenta.Cells["Cuenta"];
                    //        Valida = false;
                    //        break;
                    //    }
                    //    else if (dgvrCuenta.Cells["DescripcionCuenta"].Value.ToString() == string.Empty)
                    //    {
                    //        General.muestraMensaje("La Descripción de la Cuenta no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                    //        dgvCatalogoCuentas.CurrentCell = dgvrCuenta.Cells["DescripcionCuenta"];
                    //        Valida = false;
                    //        break;
                    //    }
                    //    else if (dgvrCuenta.Cells["Naturaleza"].Value.ToString() == string.Empty)
                    //    {
                    //        General.muestraMensaje("La Naturaleza de la Cuenta no puede estar vacia, favor de verificar el archivo TXT y volverlo a cargar.");
                    //        dgvCatalogoCuentas.CurrentCell = dgvrCuenta.Cells["Naturaleza"];
                    //        Valida = false;
                    //        break;
                    //    }
                    //}
                    //else
                    //{
                    //    General.muestraMensaje("La Cuenta/Descripción/Naturaleza no puede estar vacia, favor de verificar el archivo y volverlo a cargar.");
                    //    dgvCatalogoCuentas.CurrentCell = dgvrCuenta.Cells["Cuenta"];
                    //    Valida = false;
                    //    break;
                    //}
                }
            }

            return Valida;
        }
        private bool ExisteNombreCatalogoCuentas(string nombre)
        {
            try
            {
                string resultado = String.Empty;

                if(!String.IsNullOrEmpty(IDCatalogoCuentas))
                    resultado = Database.obtenerDato("DECLARE @resultado INT SET @resultado = 0 IF EXISTS( select 1 from SATeC_CatalogosCuentas WHERE ID_CatalogoCuentas != " + IDCatalogoCuentas + " AND UPPER(Nombre_CatalogoCuentas) = UPPER('" + nombre + "') ) SET @resultado = 1 SELECT @resultado resultado");
                else
                    resultado = Database.obtenerDato("DECLARE @resultado INT SET @resultado = 0 IF EXISTS( select 1 from SATeC_CatalogosCuentas WHERE UPPER(Nombre_CatalogoCuentas) = UPPER('" + nombre + "') ) SET @resultado = 1 SELECT @resultado resultado");

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


        //VHJC Cuando se da clic en el boton cancelar, se pregunta si quiere salir sin guardar los datos
        private void cmdCancelar_Click(object sender, EventArgs e) {
            if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos del Catálogo de Cuentas?") == DialogResult.Yes) {
                this.Close();
            }
        }

		private void dgvCatalogoCuentas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
			DataGridViewRow dgvRow = dgvCatalogoCuentas.Rows[e.RowIndex];

			if(dgvRow.Cells[0].Style.BackColor == System.Drawing.Color.FromArgb(0, 130, 153)) {

				Font fnt = new Font(dgvCatalogoCuentas.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Point);

				Rectangle rct = dgvCatalogoCuentas.GetRowDisplayRectangle(dgvRow.Index, true);
				rct.Height -= 1;

				SizeF s = e.Graphics.MeasureString("Cuentas ya guardadas", fnt);
				float lefts = (rct.Width / 2) - (s.Width / 2);
				float tops = rct.Top + ((rct.Height / 2) - (s.Height / 2));

				SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(0, 130, 153));
				e.Graphics.FillRectangle(brush, rct);

				e.Graphics.DrawString("Cuentas ya guardadas", fnt, Brushes.White, lefts, tops);
			}
        }

    }

}
