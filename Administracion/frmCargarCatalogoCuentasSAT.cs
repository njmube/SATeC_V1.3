using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.OleDb;

namespace SATeC.Administracion {
    public partial class frmCargarCatalogoCuentasSAT : Form {

        private SortedDictionary<string, string> dicCuentasExistentes = new SortedDictionary<string, string>();
		private DataGridViewCellStyle csCuentaNueva = new DataGridViewCellStyle();
		private DataGridViewCellStyle csCuentaExistente = new DataGridViewCellStyle();
		private DataGridViewCellStyle csCuentaError = new DataGridViewCellStyle();

        public frmCargarCatalogoCuentasSAT() {
            InitializeComponent();
        }

        private void frmCargarCatalogoCuentasSAT_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;

			csCuentaNueva.ForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
			csCuentaNueva.BackColor = System.Drawing.Color.White;
			csCuentaNueva.SelectionForeColor = System.Drawing.Color.FromArgb(0, 130, 153);
			csCuentaNueva.SelectionBackColor = System.Drawing.Color.White;

			csCuentaExistente.ForeColor = System.Drawing.Color.Black;
			csCuentaExistente.BackColor = System.Drawing.Color.Yellow;
			csCuentaExistente.SelectionForeColor = System.Drawing.Color.Black;
			csCuentaExistente.SelectionBackColor = System.Drawing.Color.Yellow;

			csCuentaError.ForeColor = System.Drawing.Color.Black;
			csCuentaError.BackColor = System.Drawing.Color.Red;
			csCuentaError.SelectionForeColor = System.Drawing.Color.Black;
			csCuentaError.SelectionBackColor = System.Drawing.Color.Red;


            dgvCatalogoCuentasSAT.Columns["IDCuentaSAT"].Visible = false;
			dgvCatalogoCuentasSAT.Columns["Nueva"].Visible = false;
			dgvCatalogoCuentasSAT.Columns["Error"].Visible = false;

            limpiaDatos();
        }

        private void limpiaDatos() {
			this.chkPrimerFilaNombresColumnas.Checked = false; 
            this.txtArchivoCatalogoCuentas.Text = string.Empty;
            this.txtPathArchivoCatalogoCuentas.Text = string.Empty;
            this.dgvCatalogoCuentasSAT.Rows.Clear();
            //this.cmdImportar.Visible = false;
            //this.dgvCatalogoCuentasSAT.Visible = false;
            //this.lstvDescripciones.Visible = false;
        }

        //VHJC Funcion que carga a memoria todas las cuentas existentes del Catalogo de Cuentas del SAT para verificar si las nuevas ya existen
        private void cargarCuentasExistentes() {

            dicCuentasExistentes.Clear();

            OleDbDataReader drCuentasExistentes = Database.obtenRegistros("SELECT Codigo_Agrupador, Nombre_Cuenta FROM SATeC_CatalogoCuentasSAT ORDER BY Codigo_Agrupador");
            while(drCuentasExistentes.Read()) {
                dicCuentasExistentes.Add(drCuentasExistentes["Codigo_Agrupador"].ToString(), drCuentasExistentes["Nombre_Cuenta"].ToString());
            }
        }


		//VHJC Cuando se da clic en el boton para seleccionar el archivo
        private void lblSeleccionarArchivo_Click(object sender, EventArgs e) {

			dgvCatalogoCuentasSAT.Visible = true;
			lstvDescripciones.Visible = false;
			cmdImportar.Visible = false;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos TXT(*.txt, *.csv)|*.txt; *.csv";
            openFileDialog1.Title = "Seleccione el archivo TXT del Catálogo de Cuentas del SAT";

            // VHJC Muestra la ventana para seleccionar el archivo
            // Si el usuario selecciona un archivo txt y le clic en el boton OK, se carga la informacion del archivo TXT
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				Cursor = Cursors.WaitCursor;
				General.cambiaMensajeStatus(this, "Cargando Catálogo de Cuentas del SAT desde el archivo TXT...");

                txtArchivoCatalogoCuentas.Text = openFileDialog1.SafeFileName;
                txtPathArchivoCatalogoCuentas.Text = openFileDialog1.FileName;

				//VHJC Se cargan las cuentas existentes para validar cuales son nuevas y cuales no
				cargarCuentasExistentes();
				
				//VHJC Se cargan las cuentas del archivo TXT al grid para su visualizacion
				dgvCatalogoCuentasSAT.Rows.Clear();

				string Error = string.Empty;

				if(validaArchivoTXT(out Error)) {
					if(cargarArchivoGrid(out Error)) {
						dgvCatalogoCuentasSAT.Visible = true;
						cmdImportar.Visible = true;
						lstvDescripciones.Visible = true;
					} else {
						General.muestraMensaje("Ocurrio un error al abrir el archivo TXT del Catálogo de Cuentas del SAT.\n" + Error);
					}
				}

				General.cambiaMensajeStatus(this, "");
				Cursor = Cursors.Default;
            }
        }

        //VHJC Funcion para validar que la informacion del archivo TXT seleccionado este completa y correcta
        private bool validaArchivoTXT(out string Error) {
            bool Valida = true;
            Error = string.Empty;
            General.cambiaMensajeStatus(this, "Validando archivo TXT del Catálogo de Cuentas del SAT...");


            return Valida;
        }


        //VHJC Carga el archivo TXT seleccionado en el Grid para verificar las cuentas
        private bool cargarArchivoGrid(out string Error) {
            bool Cargado = true;
            Error = string.Empty;

            General.cambiaMensajeStatus(this, "Cargando datos del archivo TXT del Catálogo de Cuentas del SAT...");

            StreamReader streamReader = new StreamReader(txtPathArchivoCatalogoCuentas.Text, Encoding.Default);
            //string[] totalData = new string[File.ReadAllLines(txtPathArchivoCatalogoCuentas.Text).Length];
            //string[] Datos = streamReader.ReadLine().Split(',');
            int CountCuenta = 0;
            bool PrimerFilaNombresColumnas = (CountCuenta == 0 && chkPrimerFilaNombresColumnas.Checked);

            DataGridViewRow dgvrCuenta = new DataGridViewRow();
            DataGridViewTextBoxCell cllIDCuenta = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cllCodigoAgrupador = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cllNombreCuenta = new DataGridViewTextBoxCell();
            DataGridViewCheckBoxCell cllNuevo = new DataGridViewCheckBoxCell();
            DataGridViewCheckBoxCell cllError = new DataGridViewCheckBoxCell();

            while(!streamReader.EndOfStream) {
                try {
                    string Linea = streamReader.ReadLine();
                    char[] separator = {','};
                    string[] Datos = Linea.Split(separator, 2);
                    if(PrimerFilaNombresColumnas) {
                        PrimerFilaNombresColumnas = false;
                        continue;
                    }
                    CountCuenta++;

                    dgvrCuenta = new DataGridViewRow();
                    cllIDCuenta = new DataGridViewTextBoxCell();
                    cllCodigoAgrupador = new DataGridViewTextBoxCell();
                    cllNombreCuenta = new DataGridViewTextBoxCell();
                    cllNuevo = new DataGridViewCheckBoxCell();
                    cllError = new DataGridViewCheckBoxCell();

                    cllIDCuenta.Value = CountCuenta;
                    cllCodigoAgrupador.Value = Datos[0];
                    cllNombreCuenta.Value = Datos[1].Replace("\"", "");

                    dgvrCuenta.Cells.Add(cllIDCuenta);
                    dgvrCuenta.Cells.Add(cllCodigoAgrupador);
                    dgvrCuenta.Cells.Add(cllNombreCuenta);

                    //VHJC Si la cuenta existe en la base de datos la marcamos como "Existente"
                    if(existeCuenta(Datos[0])) {
                        dgvrCuenta.DefaultCellStyle = csCuentaExistente;
                        cllNuevo.Value = false;
                        //VHJC Si no existe la marcamos como "Nueva"
                    } else {
                        dgvrCuenta.DefaultCellStyle = csCuentaNueva;
                        cllNuevo.Value = true;
                    }

                    dgvrCuenta.Cells.Add(cllNuevo);

                    cllError.Value = false;
                } catch(Exception ex) {
                    cllError.Value = true;
                    Error = ex.Message;
                    Cargado = false;
                    continue;
                } finally {
                    if(CountCuenta > 0) {
                        dgvrCuenta.Cells.Add(cllError);
                        dgvCatalogoCuentasSAT.Rows.Add(dgvrCuenta);
                    }
                }
            }

            return Cargado;
        }

        //VHJC Funcion que verifica si existe la cuenta que se esta leyendo del archivo TXT
        private bool existeCuenta(string CodigoAgrupador) {
            bool Existe = false;

            if(dicCuentasExistentes.ContainsKey(CodigoAgrupador))
                Existe = true;

            return Existe;
        }

        //VHJC Cuando se da clic en el boton de Importar...
        private void cmdImportar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string Error = string.Empty;
            int CuentasNuevas = 0;
            
            //VHJC Se valida que el Grid tenga informacion correcta para subir a la base de datos
            if(validaGridCuentas(out Error, out CuentasNuevas)) {
                if(subeArchivoTXT(out Error, out CuentasNuevas)) {
                    General.muestraMensaje("Se han cargado exitosamente " + CuentasNuevas + " nuevas Cuentas al Catálogo de Cuentas del SAT.");
                    limpiaDatos();
                } else {
                    General.muestraMensaje("Ocurrio un error al cargar la informacion del Catálogo de Cuentas del SAT a la Base de Datos.\n" + Error);
                }
            } else {
                if(CuentasNuevas == 0) {
                    General.muestraMensaje("No existen cuentas nuevas para cargar al\nCatálogo de Cuentas del SAT, favor de verificar.");
                }
            }
            
            General.cambiaMensajeStatus(this, "");
            Cursor = Cursors.Default;
        }

        //VHJC Funcion que valida el grid de las cuentas del SAT
        private bool validaGridCuentas(out string Error, out int CuentasNuevas) {
            bool Valida = true;
            Error = string.Empty;
            CuentasNuevas = 0;

			SortedDictionary<string, string> dicCodigosAgrupadoresArchivo = new SortedDictionary<string, string>();

            General.cambiaMensajeStatus(this, "Verificando Cuentas nuevas...");

			//VHJC Por cada una de las cuentas que se subieron desde el archivo TXT
            foreach(DataGridViewRow dgvrCuenta in dgvCatalogoCuentasSAT.Rows) {

				string CodigoAgrupadorSAT = dgvrCuenta.Cells["CodigoAgrupador"].Value.ToString();
				string CuentaSAT = dgvrCuenta.Cells["NombreCuenta"].Value.ToString();

				//VHJC Si la cuenta es nueva, se suma al contador para guardar solo las nuevas
                bool NuevaCuenta = bool.Parse(dgvrCuenta.Cells["Nueva"].Value.ToString());
				if(NuevaCuenta) {
					CuentasNuevas++;

					//VHJC Verificamos que el codigo agrupador no exista ya dentro del archivo TXT
					if(dicCodigosAgrupadoresArchivo.ContainsKey(CodigoAgrupadorSAT)) {

						string CuentaSATExistente = dicCodigosAgrupadoresArchivo[CodigoAgrupadorSAT];

						//VHJC Si el codigo agrupador ya existe se manda mensaje de error al usuario
						General.muestraMensaje("El archivo ya cuenta con un Código Agrupador " + CodigoAgrupadorSAT + " con Nombre de Cuenta \"" + CuentaSATExistente + "\", favor de validar.");

						dgvCatalogoCuentasSAT.CurrentCell = dgvrCuenta.Cells["CodigoAgrupador"];
						dgvCatalogoCuentasSAT.CurrentRow.Cells["CodigoAgrupador"].Style = csCuentaError;
						dgvCatalogoCuentasSAT.CurrentRow.Cells["NombreCuenta"].Style = csCuentaError;
						dgvCatalogoCuentasSAT.CurrentRow.Cells["Error"].Value = "True";

						Valida = false;
						break;
					} else {
						//VHJC Si no existe se agrega al array en memoria para poder compararlo despues
						dicCodigosAgrupadoresArchivo.Add(CodigoAgrupadorSAT, CuentaSAT);
					}
				}

            }

            if(CuentasNuevas == 0)
                Valida = false;

            return Valida;
        }

        //VHJC Funcion para subir la informacion del archivo TXT, despues de haber sido validado, a la Base de Datos
        private bool subeArchivoTXT(out string Error, out int CountCuentasNuevas) {
            bool Subido = true;
            Error = string.Empty;
            General.cambiaMensajeStatus(this, "Importando archivo TXT del Catálogo de Cuentas del SAT...");

            CountCuentasNuevas = 0;

            string SQL = string.Empty;

            foreach(DataGridViewRow dgvrCuenta in dgvCatalogoCuentasSAT.Rows) 
            {
                bool NuevaCuenta = bool.Parse(dgvrCuenta.Cells["Nueva"].Value.ToString());
                string CodigoAgrupador = dgvrCuenta.Cells["CodigoAgrupador"].Value.ToString();
                string NombreCuenta = dgvrCuenta.Cells["NombreCuenta"].Value.ToString();

                if (NuevaCuenta)
                {
                    CountCuentasNuevas++;
                    SQL += "INSERT INTO SATeC_CatalogoCuentasSAT (Codigo_Agrupador, Codigo_Agrupador_Entero, Codigo_Agrupador_Decimal, Nombre_Cuenta) VALUES (";
                    SQL += "'" + CodigoAgrupador + "',";

                    string[] Agrupadores;
                    string Codigo_Agrupador_Entero = String.Empty;
                    string Codigo_Agrupador_Decimal = String.Empty;

                    if (CodigoAgrupador.Contains("."))
                    {
                        Agrupadores = CodigoAgrupador.Split('.');

                        Codigo_Agrupador_Entero = Agrupadores[0];
                        Codigo_Agrupador_Decimal = Agrupadores[1];
                    }
                    else
                    {
                        Codigo_Agrupador_Entero = CodigoAgrupador;
                        Codigo_Agrupador_Decimal = "0";
                    }

                    SQL += "'" + Codigo_Agrupador_Entero + "', ";
                    SQL += "'" + Codigo_Agrupador_Decimal + "', ";
                    SQL += "'" + NombreCuenta + "')\n";
                }
            }

            if(CountCuentasNuevas > 0) {
                if(!Database.ejecutaQuery(SQL, true)) {
                    Subido = false;
                    Error = Database.Error;
                }
            }

            return Subido;
        }

        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (General.muestraMensajePregunta("¿Esta seguro de eliminar el Catalogo de Cuentas del SAT?") == System.Windows.Forms.DialogResult.Yes)
            {
                string SQL = string.Empty;

                string total = Database.obtenerDato("SELECT COUNT(ID_CuentaSAT) TOTAL FROM SATeC_CatalogoCuentasSAT");

                if (total.Equals("0"))
                {
                    General.muestraMensaje("No existen datos del catalogo de cuentas del SAT.");
                }
                else
                {
                    SQL += "TRUNCATE TABLE SATeC_CatalogoCuentasSAT";

                    if (Database.ejecutaQuery(SQL, false))
                    {
                        General.muestraMensaje("El Catalogo de Cuentas del SAT se elimino de forma exitosa.");
                        this.Close();
                    }
                    else
                    {
                        General.muestraMensaje("Ocurrio un error al intentar eliminar el Catalogo de Cuentas del SAT. " + Database.Error);
                    }
                }
            }
        }

    }
}
