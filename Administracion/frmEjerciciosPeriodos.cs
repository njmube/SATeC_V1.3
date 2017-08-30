using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC.Administracion {
    public partial class frmEjerciciosPeriodos : Form {
        public frmEjerciciosPeriodos() {
            InitializeComponent();
        }

        private void frmEjerciciosPeriodos_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            foreach(DataGridViewColumn dgvHeader in dgvEjerciciosPeriodos.Columns) {
                dgvHeader.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            cargarEjerciciosPeriodos();
        }

        //VHJC Funcion que carga los Ejercicios Periodos desde la Base de Datos
        private void cargarEjerciciosPeriodos() {
            Cursor = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Ejercicios y Periodos desde la Base de Datos...");

            dgvEjerciciosPeriodos.Rows.Clear();
            dgvEjerciciosPeriodos.Refresh();

            OleDbDataReader drEjerciciosPeriodos = Database.obtenRegistros("SELECT ID_EjercicioPeriodo, Ejercicio, Periodo, Mes FROM SATeC_EjerciciosPeriodos ORDER BY Ejercicio, Periodo");
            if(drEjerciciosPeriodos != null) {
                while(drEjerciciosPeriodos.Read()) {
                    int iRowAdded = dgvEjerciciosPeriodos.Rows.Add();
                    DataGridViewRow dgvrRowAdded = dgvEjerciciosPeriodos.Rows[iRowAdded];
                    dgvrRowAdded.Cells["IDEjercicioPeriodo"].Value = drEjerciciosPeriodos["ID_EjercicioPeriodo"].ToString();
                    dgvrRowAdded.Cells["Ejercicio"].Value = drEjerciciosPeriodos["Ejercicio"].ToString();
                    dgvrRowAdded.Cells["Periodo"].Value = drEjerciciosPeriodos["Periodo"].ToString();
                    dgvrRowAdded.Cells["Mes"].Value = drEjerciciosPeriodos["Mes"].ToString();
                }
                drEjerciciosPeriodos.Close();
                drEjerciciosPeriodos.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }

            General.cambiaMensajeStatus(this, "");
            Cursor = Cursors.Default;
        }

        private void cmdNuevo_Click(object sender, EventArgs e) {
            frmEjercicioPeriodo_Datos EjercicioPeriodoDatos = new frmEjercicioPeriodo_Datos();
            EjercicioPeriodoDatos.ShowDialog(this);

            cargarEjerciciosPeriodos();
        }

        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvEjerciciosPeriodos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > -1) {
                if (e.ColumnIndex == dgvEjerciciosPeriodos.Columns["Borrar"].Index)
                {
                    string IDEjercicioPeriodo = dgvEjerciciosPeriodos["IDEjercicioPeriodo", e.RowIndex].Value.ToString();
                    string EjercicioPeriodo = dgvEjerciciosPeriodos["Mes", e.RowIndex].Value.ToString() + " de " + dgvEjerciciosPeriodos["Ejercicio", e.RowIndex].Value.ToString();

                    if (General.muestraMensajePregunta("¿Está seguro de borrar el Ejercicio / Periodo '" + EjercicioPeriodo + "'?") == DialogResult.Yes)
                    {
                        string permitirEliminar = Database.obtenerDato("SATeC_PermitirEliminarPeriodo", CommandType.StoredProcedure, IDEjercicioPeriodo);

                        if (permitirEliminar.Equals("1"))
                        {
                            General.muestraMensaje("El Periodo no puede ser eliminado debido a que aun existen dependencias [Cuentas Contables, Balanza, Polizas]. Favor de validar");
                        }
                        else
                        {
                            string SQL = "DELETE FROM SATeC_EjerciciosPeriodos WHERE ID_EjercicioPeriodo='" + IDEjercicioPeriodo + "'";

                            try
                            {
                                if (Database.ejecutaQuery(SQL, false))
                                {
                                    General.muestraMensaje("El Ejercicio / Periodo ha sido borrado con exito.");
                                    cargarEjerciciosPeriodos();
                                }
                                else
                                {
                                    General.muestraMensaje("Ocurrio un error al borrar el Ejercicio / Periodo: " + Database.Error);
                                }
                            }
                            catch (Exception Ex)
                            {
                                General.muestraMensaje("Ocurrio un error al borrar el Ejercicio / Periodo: " + Ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void dgvEjerciciosPeriodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > -1) {
                Cursor = Cursors.WaitCursor;
                General.cambiaMensajeStatus(this, "Cargando datos de la Ejercicio / Periodo desde la Base de Datos...");

                frmEjercicioPeriodo_Datos EjercicioPeriodoDatos = new frmEjercicioPeriodo_Datos();
                EjercicioPeriodoDatos.IDEjercicioPeriodo = dgvEjerciciosPeriodos["IDEjercicioPeriodo", e.RowIndex].Value.ToString();
                EjercicioPeriodoDatos.ShowDialog(this);

                cargarEjerciciosPeriodos();

                General.cambiaMensajeStatus(this, "");
                Cursor = Cursors.Default;
            }
        }
    }
}
