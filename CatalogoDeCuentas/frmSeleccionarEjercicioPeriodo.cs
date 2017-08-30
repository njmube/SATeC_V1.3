using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC.CatalogoDeCuentas {
	public partial class frmSeleccionarEjercicioPeriodo : Form {

		public string EjercicioSeleccionado { get; set; }
		public string PeriodoSeleccionado { get; set; }

		public frmSeleccionarEjercicioPeriodo() {
			InitializeComponent();
		}

		private void frmSeleccionarEjercicioPeriodo_Load(object sender, EventArgs e) {
            cargarEjerciciosPeriodos();
		}

		//VHJC Funcion que carga los Ejercicios Periodos No Liberados desde la Base de Datos
		private void cargarEjerciciosPeriodos() {
			Cursor = Cursors.WaitCursor;

			dgvEjerciciosPeriodos.Rows.Clear();
			dgvEjerciciosPeriodos.Refresh();

            OleDbDataReader drEjerciciosPeriodos = Database.obtenRegistros("SELECT Ejercicio, Periodo, Mes FROM SATeC_EjerciciosPeriodos ORDER BY Ejercicio, Periodo");
			if(drEjerciciosPeriodos != null) {
				if(drEjerciciosPeriodos.HasRows) {
					while(drEjerciciosPeriodos.Read()) {
						int iRowAdded = dgvEjerciciosPeriodos.Rows.Add();
						DataGridViewRow dgvrRowAdded = dgvEjerciciosPeriodos.Rows[iRowAdded];
						dgvrRowAdded.Cells["Ejercicio"].Value = drEjerciciosPeriodos["Ejercicio"].ToString();
						dgvrRowAdded.Cells["Periodo"].Value = drEjerciciosPeriodos["Periodo"].ToString();
						dgvrRowAdded.Cells["Mes"].Value = drEjerciciosPeriodos["Mes"].ToString();
					}
					drEjerciciosPeriodos.Close();
					drEjerciciosPeriodos.Dispose();
				} else {
					cmdSeleccionar.Enabled = false;
				}
			} else {
				General.muestraMensaje("Error: " + Database.Error);
			}

			Cursor = Cursors.Default;
		}

		private void dgvEjerciciosPeriodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex > -1) {
				cmdSeleccionar.PerformClick();
			}
		}

		private void cmdSeleccionar_Click(object sender, EventArgs e) {
			if(dgvEjerciciosPeriodos.CurrentRow != null) {
				this.EjercicioSeleccionado = dgvEjerciciosPeriodos.CurrentRow.Cells["Ejercicio"].Value.ToString();
				this.PeriodoSeleccionado = dgvEjerciciosPeriodos.CurrentRow.Cells["Periodo"].Value.ToString();
				this.Close();
			} else {
				this.EjercicioSeleccionado = string.Empty;
				this.PeriodoSeleccionado = string.Empty;
			}
		}

		private void cmdCancelar_Click(object sender, EventArgs e) {
			this.EjercicioSeleccionado = string.Empty;
			this.PeriodoSeleccionado = string.Empty;
		}

	}
}
