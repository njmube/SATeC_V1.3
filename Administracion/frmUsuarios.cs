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
    public partial class frmUsuarios : Form {
        public frmUsuarios() {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e) {
            this.Dock = DockStyle.Fill;
            foreach(DataGridViewColumn dgvHeader in dgvUsuarios.Columns) {
                dgvHeader.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            cargarUsuarios();
        }

        private void cargarUsuarios() {
            Cursor = Cursors.WaitCursor;
            General.cambiaMensajeStatus(this, "Cargando Usuarios desde la Base de Datos...");

            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();

            string usuarioRoot = Properties.Resources.ROOT;

            OleDbDataReader drUsuarios = Database.obtenRegistros("SELECT ID_Usuario, Clave_Usuario, Nombre_Usuario, Nivel_Usuario FROM SATeC_Usuarios WHERE UPPER(Clave_Usuario) <> '" + usuarioRoot.ToUpper()   + "' ORDER BY Nombre_Usuario");
            if(drUsuarios != null) {
                while(drUsuarios.Read()) {
                    int iRowAdded = dgvUsuarios.Rows.Add();
                    DataGridViewRow dgvrRowAdded = dgvUsuarios.Rows[iRowAdded];
                    dgvrRowAdded.Cells["ClaveUsuario"].Value = drUsuarios["Clave_Usuario"].ToString(); ;
                    dgvrRowAdded.Cells["NombreUsuario"].Value = drUsuarios["Nombre_Usuario"].ToString();
                    dgvrRowAdded.Cells["NivelUsuario"].Value = drUsuarios["Nivel_Usuario"].ToString();
                }
                drUsuarios.Close();
                drUsuarios.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }

            General.cambiaMensajeStatus(this, "");
            Cursor = Cursors.Default;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > -1) {
                if(e.ColumnIndex == dgvUsuarios.Columns["Borrar"].Index) {

                    string ClaveUsuario = dgvUsuarios["ClaveUsuario", e.RowIndex].Value.ToString();

                    if(General.muestraMensajePregunta("¿Está seguro de borrar al usuario '" + ClaveUsuario + "'?") == DialogResult.Yes) {
                        string SQL = "DELETE FROM SATeC_Usuarios WHERE Clave_Usuario='" + ClaveUsuario + "'";
                        try {
							if(Database.ejecutaQuery(SQL, false)) {
                                General.muestraMensaje("El usuario ha sido borrado con exito.");
                                cargarUsuarios();
                            } else {
                                General.muestraMensaje("Ocurrio un error al borrar el usuario: " + Database.Error);
                            }
                        } catch(Exception Ex) {
                            General.muestraMensaje("Ocurrio un error al borrar el usuario: " + Ex.Message);
                        }
                    }
                }
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex > -1) {
                Cursor = Cursors.WaitCursor;
                General.cambiaMensajeStatus(this, "Cargando datos del Usuarios desde la Base de Datos...");

                frmUsuario_Datos UsuarioDatos = new frmUsuario_Datos();
                UsuarioDatos.ClaveUsuario = dgvUsuarios["ClaveUsuario", e.RowIndex].Value.ToString();
                UsuarioDatos.ShowDialog(this);
                
                cargarUsuarios();

                General.cambiaMensajeStatus(this, "");
                Cursor = Cursors.Default;
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e) {
            frmUsuario_Datos UsuarioDatos = new frmUsuario_Datos();
            UsuarioDatos.ShowDialog(this);

            cargarUsuarios();
        }

        private void cmdCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
