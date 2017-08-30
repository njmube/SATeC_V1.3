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
    public partial class frmCatalogosDeCuentasAuxiliares : Form {
        public frmCatalogosDeCuentasAuxiliares() {
            InitializeComponent();
        }

        private void frmCatalogosDeCuentasAuxiliares_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarCatalogosDeCuentasAuxiliares();
        }

        //VHJC Funcion que carga y muestra los Catalogos de Cuentas Auxiliares
        private void cargarCatalogosDeCuentasAuxiliares() {
            Cursor.Current = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Catálogos de Cuentas Auxiliares...");

            dgvCatalogosDeCuentasAuxiliares.Rows.Clear();

            OleDbDataReader drCatalogosDeCuentasAuxiliares = Database.obtenRegistros("SELECT ID_CatalogoCuentasAuxiliares, Numero_CatalogoCuentasAuxiliares, Nombre_CatalogoCuentasAuxiliares, Nombre_CatalogoCuentas, CCA.Fecha_Alta, CCA.ID_CatalogoCuentas FROM SATeC_CatalogosCuentasAuxiliares CCA LEFT JOIN SATeC_CatalogosCuentas CC ON CC.ID_CatalogoCuentas = CCA.ID_CatalogoCuentas ORDER BY Nombre_CatalogoCuentasAuxiliares");
            while(drCatalogosDeCuentasAuxiliares.Read()) {
                DataGridViewRow dgvrCatalogoDeCuentasAuxiliares = new DataGridViewRow();
                DataGridViewTextBoxCell cllIDCatalogoCuentasAuxiliares = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllNumeroCatalogoCuentasAuxiliares = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllNombreCatalogoCuentasAuxiliares = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllNombreCatalogoCuentas = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllFechaAlta = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cllID_CatalogoCuentas = new DataGridViewTextBoxCell();

                cllIDCatalogoCuentasAuxiliares.Value = drCatalogosDeCuentasAuxiliares["ID_CatalogoCuentasAuxiliares"].ToString();
                cllNumeroCatalogoCuentasAuxiliares.Value = drCatalogosDeCuentasAuxiliares["Numero_CatalogoCuentasAuxiliares"].ToString();
                cllNombreCatalogoCuentasAuxiliares.Value = drCatalogosDeCuentasAuxiliares["Nombre_CatalogoCuentasAuxiliares"].ToString();
				cllNombreCatalogoCuentas.Value = drCatalogosDeCuentasAuxiliares["Nombre_CatalogoCuentas"].ToString();
                cllFechaAlta.Value = drCatalogosDeCuentasAuxiliares["Fecha_Alta"].ToString();
                cllID_CatalogoCuentas.Value = drCatalogosDeCuentasAuxiliares["ID_CatalogoCuentas"].ToString();

                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllIDCatalogoCuentasAuxiliares);
                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllNumeroCatalogoCuentasAuxiliares);
                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllNombreCatalogoCuentasAuxiliares);
                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllNombreCatalogoCuentas);
                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllFechaAlta);
                dgvrCatalogoDeCuentasAuxiliares.Cells.Add(cllID_CatalogoCuentas);

                dgvCatalogosDeCuentasAuxiliares.Rows.Add(dgvrCatalogoDeCuentasAuxiliares);
            }

            drCatalogosDeCuentasAuxiliares.Close();
            drCatalogosDeCuentasAuxiliares.Dispose();

            General.cambiaMensajeStatus(this, "");
            Cursor.Current = Cursors.Default;
        }

        //VHJC Cuando se da clic en en el boton "Nuevo" se muestra la pantalla para capturar los datos de un nuevo Catalogo de Cuentas Auxiliares
        private void cmdNuevo_Click(object sender, EventArgs e) {
            frmCatalogoDeCuentasAuxiliares_Datos CatalogoDeCuentasAuxiliares = new frmCatalogoDeCuentasAuxiliares_Datos();
            CatalogoDeCuentasAuxiliares.ShowDialog(this);

            cargarCatalogosDeCuentasAuxiliares();
        }

        //VHJC Cuanto se da clic en el boton de "Cerrar"
        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        //VHJC Cuando se da clic en la imagen "Borrar" de la lista de Catalogos de Cuentas Auxiliares
        private void dgvCatalogosDeCuentasAuxiliares_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.ColumnIndex == dgvCatalogosDeCuentasAuxiliares.Columns["Borrar"].Index)
            {
                string Mensaje = "Esta accion borrara todas las cuentas auxiliares relacionadas a las sociedades que tenian asociado este Catálogo de Cuentas Auxiliares.\nEsta seguro de borrar el Catálogo de Cuentas Auxiliares '" + dgvCatalogosDeCuentasAuxiliares.Rows[e.RowIndex].Cells["NombreCatalogoCuentasAuxiliares"].Value.ToString() + "'?";

                if (General.muestraMensajePregunta(Mensaje) == System.Windows.Forms.DialogResult.Yes)
                {
                    string ID_CatalogoCuentas = dgvCatalogosDeCuentasAuxiliares.Rows[e.RowIndex].Cells["ID_CatalogoCuentas"].Value.ToString();

                    string permitirEliminar = Database.obtenerDato("SATeC_PermitirEliminarDatos", CommandType.StoredProcedure, ID_CatalogoCuentas, "5");

                    if (permitirEliminar.Equals("0"))
                    {
                        General.muestraMensaje("El catalogo de cuentas auxiliar no puede ser eliminado debido a que aun existen dependencias [Cuentas Auxiliares, Balanza, Polizas]. Favor de validar");
                    }
                    else
                    {
                        string ID_CatalogoCuentasAuxiliares = dgvCatalogosDeCuentasAuxiliares.Rows[e.RowIndex].Cells["IDCatalogoCuentasAuxiliares"].Value.ToString();
                        string SQL = "DELETE FROM SATeC_CatalogoCuentasAuxiliares_CuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares = " + ID_CatalogoCuentasAuxiliares + " DELETE FROM SATeC_CatalogosCuentasAuxiliares WHERE ID_CatalogoCuentasAuxiliares = " + ID_CatalogoCuentasAuxiliares;

                        if (Database.ejecutaQuery(SQL, true))
                        {
                            General.muestraMensaje("El Catálogo de Cuentas Auxiliares ha sido borrado con exito.");
                            cargarCatalogosDeCuentasAuxiliares();
                        }
                        else
                        {
                            General.muestraMensaje("Ocurrio un error al tratar de borrar el Catálogo de Cuentas Auxiliares.\n" + Database.Error);
                        }
                    }
                }
            }
        }

        //VHJC Cuando se da doble clic en cualquier columna de cualquier elemento de la lista de Catalogos de Cuentas Auxiliares
        private void dgvCatalogosDeCuentasAuxiliares_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            frmCatalogoDeCuentasAuxiliares_Datos CatalogoDeCuentasAuxiliares = new frmCatalogoDeCuentasAuxiliares_Datos();
            CatalogoDeCuentasAuxiliares.IDCatalogoDeCuentasAuxiliares = dgvCatalogosDeCuentasAuxiliares.Rows[e.RowIndex].Cells["IDCatalogoCuentasAuxiliares"].Value.ToString();
            CatalogoDeCuentasAuxiliares.ShowDialog(this);

            cargarCatalogosDeCuentasAuxiliares();
        }
    }
}
