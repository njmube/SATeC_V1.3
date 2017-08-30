using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SATeC {
    public partial class frmSociedades : Form {

        public ToolStripMenuItem MenuLlamada { set; get; }

        public frmSociedades() {
            InitializeComponent();
        }

        private void frmSociedades_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            cargarSociedades();
        }

        //VHJC Funcion que carga las sociedades existentes en la lista para seleccionar con la que se quiera trabajar.
        private void cargarSociedades() {
            Cursor = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Sociedades desde la Base de Datos...");

            dgvSociedades.Rows.Clear();
            dgvSociedades.Refresh();

            OleDbDataReader drSociedades = Database.obtenRegistros("SELECT ID_Sociedad, Numero_Sociedad, Nombre_Sociedad, RFC_Sociedad, Nombre_CatalogoCuentas FROM SATeC_Sociedades S LEFT JOIN SATeC_CatalogosCuentas CC ON CC.ID_CatalogoCuentas = S.ID_CatalogoCuentas ORDER BY Numero_Sociedad");
            if(drSociedades != null) {
                while(drSociedades.Read()) {
                    int iRowAdded = dgvSociedades.Rows.Add();
                    DataGridViewRow dgvrRowAdded = dgvSociedades.Rows[iRowAdded];
                    dgvrRowAdded.Cells["IDSociedad"].Value = drSociedades["ID_Sociedad"].ToString();
                    dgvrRowAdded.Cells["NumeroSociedad"].Value = drSociedades["Numero_Sociedad"].ToString(); ;
                    dgvrRowAdded.Cells["NombreSociedad"].Value = drSociedades["Nombre_Sociedad"].ToString();
					dgvrRowAdded.Cells["RFCSociedad"].Value = drSociedades["RFC_Sociedad"].ToString();
                    dgvrRowAdded.Cells["CatalogoCuentas"].Value = drSociedades["Nombre_CatalogoCuentas"].ToString();
                }
                drSociedades.Close();
                drSociedades.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }

            General.cambiaMensajeStatus(this, "");
            Cursor = Cursors.Default;
        }


        //VHJC Cuando se da doble clic para seleccionar la Sociedad con la que se va a trabajar se muestra la barra superior y se cierra esta ventana
        private void dgvSociedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                General.ID_SociedadSeleccionada = int.Parse(dgvSociedades.Rows[e.RowIndex].Cells["IDSociedad"].Value.ToString());
                General.Numero_SociedadSeleccionada = dgvSociedades.Rows[e.RowIndex].Cells["NumeroSociedad"].Value.ToString();
                General.Nombre_SociedadSeleccionada = dgvSociedades.Rows[e.RowIndex].Cells["NombreSociedad"].Value.ToString();
				General.RFC_SociedadSeleccionada = dgvSociedades.Rows[e.RowIndex].Cells["RFCSociedad"].Value.ToString();
				((frmMain)this.MdiParent).muestraBarraSociedadSeleccionada(MenuLlamada);
				
				this.Close();
            }
        }

		private void frmSociedades_FormClosing(object sender, FormClosingEventArgs e) {
			dgvSociedades.Dispose();
			this.Dispose(true);

			GC.Collect();
		}

    }
}
