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
    public partial class frmSociedades : Form {

        public frmSociedades() {
            InitializeComponent();
        }

        private void frmSociedades_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarSociedades();
        }

        //VHJC Funcion que carga la informacion de las sociedades dada de alta en la base de datos
        private void cargarSociedades() {
            Cursor = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Sociedades desde la Base de Datos...");

            dgvSociedades.Rows.Clear();
            dgvSociedades.Refresh();

            OleDbDataReader drSociedades = Database.obtenRegistros("SELECT Numero_Sociedad, RFC_Sociedad, Nombre_Sociedad, Nombre_CatalogoCuentas, ID_Sociedad FROM dbo.SATeC_Sociedades S LEFT JOIN SATeC_CatalogosCuentas CC ON CC.ID_CatalogoCuentas = S.ID_CatalogoCuentas ORDER BY Numero_Sociedad");
            if(drSociedades != null) {
                while(drSociedades.Read()) {
                    int iRowAdded = dgvSociedades.Rows.Add();
                    DataGridViewRow dgvrRowAdded = dgvSociedades.Rows[iRowAdded];
                    dgvrRowAdded.Cells["NumeroSociedad"].Value = drSociedades["Numero_Sociedad"].ToString(); ;
                    dgvrRowAdded.Cells["RFCSociedad"].Value = drSociedades["RFC_Sociedad"].ToString();
                    dgvrRowAdded.Cells["NombreSociedad"].Value = drSociedades["Nombre_Sociedad"].ToString();
                    dgvrRowAdded.Cells["CatalogoCuentas"].Value = drSociedades["Nombre_CatalogoCuentas"].ToString();
                    dgvrRowAdded.Cells["ID_Sociedad"].Value = drSociedades["ID_Sociedad"].ToString();
                }
                drSociedades.Close();
                drSociedades.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }

            General.cambiaMensajeStatus(this, "");
            Cursor = Cursors.Default;
        }

        private void cmdNuevo_Click(object sender, EventArgs e) {
            Administracion.frmSociedad_Datos SociedadDatos = new frmSociedad_Datos();
            SociedadDatos.ShowDialog(this);

            cargarSociedades();
        }

        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvSociedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvSociedades.Columns["Borrar"].Index)
                {
                    string Numero_Sociedad = dgvSociedades["NumeroSociedad", e.RowIndex].Value.ToString();
                    string ID_Sociedad = dgvSociedades["ID_Sociedad", e.RowIndex].Value.ToString();

                    if (General.muestraMensajePregunta("¿Está seguro de borrar la sociedad '" + Numero_Sociedad + "'?") == DialogResult.Yes)
                    {
                        string permitirEliminar = Database.obtenerDato("SATeC_PermitirEliminarSociedad", CommandType.StoredProcedure, ID_Sociedad);

                        if (permitirEliminar.Equals("1"))
                        {
                            General.muestraMensaje("La Sociedad no puede ser eliminada debido a que aun existen dependencias [Cuentas Contables, Balanza, Polizas]. Favor de validar");
                        }
                        else
                        {
                            string SQL = "DELETE FROM SATeC_Sociedades WHERE ID_Sociedad = " + ID_Sociedad;

                            try
                            {
                                if (Database.ejecutaQuery(SQL, false))
                                {
                                    General.muestraMensaje("La Sociedad ha sido eliminada exitosamente.");
                                    cargarSociedades();
                                }
                                else
                                {
                                    General.muestraMensaje("Ocurrio un error al borrar la sociedad: " + Database.Error);
                                }
                            }
                            catch (Exception Ex)
                            {
                                General.muestraMensaje("Ocurrio un error al borrar la sociedad: " + Ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void dgvSociedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > -1) {
                Cursor = Cursors.WaitCursor;
                General.cambiaMensajeStatus(this, "Cargando datos de la sociedad desde la Base de Datos...");

                frmSociedad_Datos SociedadDatos = new frmSociedad_Datos();

                SociedadDatos.NumeroSociedad = dgvSociedades["NumeroSociedad", e.RowIndex].Value.ToString();
                SociedadDatos.ShowDialog(this);

                cargarSociedades();

                General.cambiaMensajeStatus(this, "");
                Cursor = Cursors.Default;
            }
        }


    }
}
