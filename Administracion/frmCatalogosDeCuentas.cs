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
    public partial class frmCatalogosDeCuentas : Form {

        public frmCatalogosDeCuentas() {
            InitializeComponent();
        }
        private void frmCatalogosDeCuentas_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarCatalogosDeCuentas();
        }
        private void cargarCatalogosDeCuentas() {
            Cursor.Current = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Catálogos de Cuentas...");

            dgvCatalogosDeCuentas.Rows.Clear();

            OleDbDataReader drCatalogosDeCuentas = Database.obtenRegistros("SELECT ID_CatalogoCuentas, Numero_CatalogoCuentas, Nombre_CatalogoCuentas, Fecha_Alta, Liberado FROM SATeC_CatalogosCuentas ORDER BY Nombre_CatalogoCuentas");
            while(drCatalogosDeCuentas.Read()) {
                DataGridViewRow dgvrCatalogoDeCuentas = new DataGridViewRow();
                DataGridViewTextBoxCell cllIDCatalogoCuentas = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllNumeroCatalogoCuentas = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllNombreCatalogoCuentas = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllFechaAlta = new DataGridViewTextBoxCell();

                cllIDCatalogoCuentas.Value = drCatalogosDeCuentas["ID_CatalogoCuentas"].ToString();
                cllNumeroCatalogoCuentas.Value = drCatalogosDeCuentas["Numero_CatalogoCuentas"].ToString();
                cllNombreCatalogoCuentas.Value = drCatalogosDeCuentas["Nombre_CatalogoCuentas"].ToString();
                cllFechaAlta.Value = drCatalogosDeCuentas["Fecha_Alta"].ToString();

                dgvrCatalogoDeCuentas.Cells.Add(cllIDCatalogoCuentas);
                dgvrCatalogoDeCuentas.Cells.Add(cllNumeroCatalogoCuentas);
                dgvrCatalogoDeCuentas.Cells.Add(cllNombreCatalogoCuentas);
                dgvrCatalogoDeCuentas.Cells.Add(cllFechaAlta);

                dgvCatalogosDeCuentas.Rows.Add(dgvrCatalogoDeCuentas);
            }

            drCatalogosDeCuentas.Close();
            drCatalogosDeCuentas.Dispose();

            General.cambiaMensajeStatus(this, "");
            Cursor.Current = Cursors.Default;
        }
        private void cmdNuevo_Click(object sender, EventArgs e) {
            frmCatalogoDeCuentas_Datos CatalogoDeCuentas = new frmCatalogoDeCuentas_Datos();
            CatalogoDeCuentas.ShowDialog(this);

            cargarCatalogosDeCuentas();
        }
        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void dgvCatalogosDeCuentas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvCatalogosDeCuentas.Columns["Borrar"].Index) {
                string Mensaje = "Esta accion borrara todas las cuentas, el catálogo de cuentas y dejara sin relacion a las sociedades que tenian asociado este Catálogo de Cuentas.\nEsta seguro de borrar el Catálogo de Cuentas '" + dgvCatalogosDeCuentas.Rows[e.RowIndex].Cells["NombreCatalogoCuentas"].Value.ToString() + "'?";
                if(General.muestraMensajePregunta(Mensaje) == System.Windows.Forms.DialogResult.Yes) {
                    
                    string ID_CatalogoCuentas = dgvCatalogosDeCuentas.Rows[e.RowIndex].Cells["IDCatalogoCuentas"].Value.ToString();
                    string permitirEliminar = Database.obtenerDato("SATeC_PermitirEliminarDatos", CommandType.StoredProcedure, ID_CatalogoCuentas, "1");

                    if (permitirEliminar.Equals("0"))
                    {
                        General.muestraMensaje("El catalogo de cuentas no puede ser eliminado debido a que aun existen dependencias [Cuentas Auxiliares, Balanza, Polizas]. Favor de validar");
                    }
                    else
                    {
                        string SQL = "DELETE FROM SATeC_CatalogoCuentas_Cuentas WHERE ID_CatalogoCuentas = " + ID_CatalogoCuentas + " DELETE FROM SATeC_CatalogosCuentas WHERE ID_CatalogoCuentas = " + ID_CatalogoCuentas;

                        if (Database.ejecutaQuery(SQL, true))
                        {
                            General.muestraMensaje("El Catálogo de Cuentas ha sido borrado con exito.");
                            cargarCatalogosDeCuentas();
                        }
                        else
                        {
                            General.muestraMensaje("Ocurrio un error al tratar de borrar el Catálogo de Cuentas.\n" + Database.Error);
                        }
                    }
                }
            }
        }
        private void dgvCatalogosDeCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            frmCatalogoDeCuentas_Datos CatalogoDeCuentas = new frmCatalogoDeCuentas_Datos();
            CatalogoDeCuentas.IDCatalogoCuentas = dgvCatalogosDeCuentas.Rows[e.RowIndex].Cells["IDCatalogoCuentas"].Value.ToString();
            CatalogoDeCuentas.ShowDialog(this);

            cargarCatalogosDeCuentas();
        }
    }
}
