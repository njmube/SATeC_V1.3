using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Globalization;

namespace SATeC.Administracion {
    public partial class frmEjercicioPeriodo_Datos : Form {

        public string IDEjercicioPeriodo = string.Empty;
        private bool Loaded = false;
		private HashSet<string> EjerciciosPeriodosExistentes = new HashSet<string>();

        public frmEjercicioPeriodo_Datos() 
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
            InitializeComponent();
        }
        private void frmEjercicioPeriodo_Datos_Load(object sender, EventArgs e) {
            limpiaDatos();
			cargarEjerciciosPeriodosExistentes();
            if(IDEjercicioPeriodo != string.Empty) 
            {
                obtenerEjercicioPeriodoDatos();
                dtpEjercicio.Enabled = false;
                cmbPeriodo.Enabled = false;
                cmdGuardar.Enabled = false;
            }
            Loaded = true;
        }
		private void cargarEjerciciosPeriodosExistentes() {
			Cursor.Current = Cursors.WaitCursor;

			string SQL = "SELECT Ejercicio+'-'+Periodo AS EjercicioPeriodo FROM SATeC_EjerciciosPeriodos ";
			if(IDEjercicioPeriodo != string.Empty)
				SQL += "WHERE ID_EjercicioPeriodo <> " + IDEjercicioPeriodo + " ";
			SQL += "ORDER BY Ejercicio+'-'+Periodo";
			OleDbDataReader drEjerciciosPeriodosExistentes = Database.obtenRegistros(SQL);

			while(drEjerciciosPeriodosExistentes.Read()) {
				EjerciciosPeriodosExistentes.Add(drEjerciciosPeriodosExistentes["EjercicioPeriodo"].ToString());
			}

			Cursor.Current = Cursors.Default;
		}
        private void limpiaDatos() {
            DateTime dtMaxDate = DateTime.Parse("31/12/" + DateTime.Today.Year.ToString());
            this.dtpEjercicio.Value = DateTime.Today;
            this.dtpEjercicio.MaxDate = dtMaxDate;
            this.cmbPeriodo.SelectedIndex = cmbPeriodo.FindStringExact(DateTime.Today.ToString("MM - MMMM"));
        }

        //VHJC Obtiene los datos de la socied que se selecciono
        private void obtenerEjercicioPeriodoDatos() {
            OleDbDataReader drEjercicioPeriodo = Database.obtenRegistros("SELECT Ejercicio, Periodo, Mes FROM SATeC_EjerciciosPeriodos WHERE ID_EjercicioPeriodo=" + IDEjercicioPeriodo);
            if(drEjercicioPeriodo != null) {
                drEjercicioPeriodo.Read();

                this.dtpEjercicio.Text = DateTime.Parse("01/01/" + drEjercicioPeriodo["Ejercicio"].ToString()).ToString();
                this.cmbPeriodo.Text = drEjercicioPeriodo["Periodo"].ToString() + " - " + drEjercicioPeriodo["Mes"].ToString();

                drEjercicioPeriodo.Close();
                drEjercicioPeriodo.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }
        }

        //VHJC Cuando cambie el año se tiene que cambiar la fecha de cierre del periodo
        private void dtpEjercicio_ValueChanged(object sender, EventArgs e) {
            if(this.Loaded)
                estableceUltimoDiaMes();
        }

        //VHJC Cuando cambie el mes se tiene que cambiar la fecha de cierre del periodo
        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e) {
            estableceUltimoDiaMes();
        }

        //VHJC Funcion que establece el ultimo dia del mes en el control de Fecha de Cierre
        private void estableceUltimoDiaMes() {
            int Year = dtpEjercicio.Value.Year;
            string[] DatosMonth = cmbPeriodo.Text.Split('-');
            int Month = int.Parse(DatosMonth[0].ToString().Trim());
            int Day = 1;

            DateTime dtUltimoDiaMes = DateTime.MinValue;

            if (Month <= 12)
            {
                dtUltimoDiaMes = General.obtenerUltimoDiaMes(new DateTime(Year, Month, Day));
            }
            else{
                dtUltimoDiaMes = new DateTime(Year, 12, 31);
            }
        }

        //VHJC Cuando se da clic en el boton guardar
        private void cmdGuardar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;
            bool Salir = false;

            //VHJC Si los datos del usuario estan completos y correctos..
            if(validaEjercicioPeriodoDatos()) {
                string[] DatosPeriodo = cmbPeriodo.Text.Split('-');

                //VHJC Si es un usuario nuevo se guarda
                if(IDEjercicioPeriodo == string.Empty) {
                    SQL = "INSERT INTO SATeC_EjerciciosPeriodos (Ejercicio, Periodo, Mes, Fecha_Cierre_Periodo, Periodo_Liberado) VALUES(";
                    SQL += "'" + dtpEjercicio.Text + "', ";
                    SQL += "'" + DatosPeriodo[0].ToString().Trim() + "', ";
                    SQL += "'" + DatosPeriodo[1].ToString().Trim() + "', ";
                    //SQL += "'" + dtpFechaCierre.Text + "', ";
                    SQL += "NULL, ";
                    SQL += "NULL ";
                    SQL += ")";
                    //VHJC Si es un usuario existente se modifica
                } else {
                    SQL = "UPDATE SATeC_EjerciciosPeriodos SET ";
                    SQL += "Ejercicio='" + dtpEjercicio.Text + "', ";
                    SQL += "Periodo='" + DatosPeriodo[0].ToString().Trim() + "', ";
                    SQL += "Mes='" + DatosPeriodo[1].ToString().Trim() + "', ";
                    SQL += "Fecha_Cierre_Periodo= NULL";
                    SQL += "Periodo_Liberado = NULL ";
                    SQL += "WHERE ID_EjercicioPeriodo=" + IDEjercicioPeriodo;
                }

				if(Database.ejecutaQuery(SQL, false)) {
                    Salir = true;
                    General.muestraMensaje("Los datos del Ejercicio / Periodo se han guardado con exito.");
                } else {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos del Ejercicio / Periodo: " + Database.Error);
                }
            }

            Cursor = Cursors.Default;
            if(Salir)
                this.Close();
        }

        //VHJC Funcion que valida que los datos del Ejercicio / Periodo esten completos y correctos
        private bool validaEjercicioPeriodoDatos() {
            bool Valida = true;

			string[] DatosPeriodo = cmbPeriodo.Text.Split('-');

            if(dtpEjercicio.Text == string.Empty) {
                General.muestraMensaje("El Ejercicio no puede estar en blanco, favor de revisar.");
                dtpEjercicio.Focus();
                Valida = false;
            } else if(cmbPeriodo.Text == string.Empty) {
                General.muestraMensaje("El Periodo no puede estar en blanco, favor de revisar.");
                cmbPeriodo.Focus();
                Valida = false;
			} else if(EjerciciosPeriodosExistentes.Contains(dtpEjercicio.Text + "-" + DatosPeriodo[0].ToString().Trim())) {
                General.muestraMensaje("El Ejercicio/Periodo ya existe en la base de datos, favor de revisar.");
                dtpEjercicio.Focus();
                Valida = false;
            }

            return Valida;
        }
        private void cmdCancelar_Click(object sender, EventArgs e) {
            if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos del Ejercicio / Periodo?") == DialogResult.Yes) {
                this.Close();
            }
        }
        
    }
}
