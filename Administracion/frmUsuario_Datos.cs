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
    public partial class frmUsuario_Datos : Form {

        public string ClaveUsuario = string.Empty;
		private HashSet<string> UsuariosExistentes = new HashSet<string>();

        public frmUsuario_Datos() {
            InitializeComponent();
        }

        private void frmUsuario_Datos_Load(object sender, EventArgs e) {

            cmbNivelUsuario.Items.Add(new ListItem("1", "Administrador"));
            cmbNivelUsuario.Items.Add(new ListItem("2", "Usuario"));
            cmbNivelUsuario.Items.Add(new ListItem("3", "Instalador"));

			cargarUsuariosExistentes();

            if(ClaveUsuario == string.Empty) {
                limipaDatos();
            } else {
                limipaDatos();
                txtClaveUsuario.TabStop = false;
                txtClaveUsuario.ReadOnly = true;
                txtNombreUsuario.Select();
                obtenerUsuarioDatos();
            }
        }

		//VHJC Funcion que carga los usuarios existentes en la base de datos
		private void cargarUsuariosExistentes() {
			Cursor.Current = Cursors.WaitCursor;

			string SQL = "SELECT Clave_Usuario FROM SATeC_Usuarios ";
			if(ClaveUsuario != string.Empty)
				SQL += "WHERE Clave_Usuario != '" + ClaveUsuario + "' ";
			SQL += "ORDER BY Clave_Usuario";
			OleDbDataReader drUsuariosExistentes = Database.obtenRegistros(SQL);

			while(drUsuariosExistentes.Read()) {
				UsuariosExistentes.Add(drUsuariosExistentes["Clave_Usuario"].ToString());
			}

			Cursor.Current = Cursors.Default;
		}

        //VHJC Funcion que limpia los controles para la captura de los datos del Usario
        private void limipaDatos() {
            this.txtClaveUsuario.Text = string.Empty;
            this.txtNombreUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.cmbNivelUsuario.ResetText();
        }

        //VHJC Obtiene los datos del Usuario que se selecciono
        private void obtenerUsuarioDatos() {
            OleDbDataReader drUsuario = Database.obtenRegistros("SELECT Clave_Usuario, Nombre_Usuario, Contraseña_Usuario, Nivel_Usuario FROM SATeC_Usuarios WHERE Clave_Usuario='" + ClaveUsuario + "'");
            if(drUsuario != null) {
                drUsuario.Read();

                this.txtClaveUsuario.Text = drUsuario["Clave_Usuario"].ToString();
                this.txtNombreUsuario.Text = drUsuario["Nombre_Usuario"].ToString();
                this.txtContraseña.Text = General.desencripta(drUsuario["Contraseña_Usuario"].ToString());
                General.buscaEnCombo(this.cmbNivelUsuario, drUsuario["Nivel_Usuario"].ToString());
                
                drUsuario.Close();
                drUsuario.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string SQL = string.Empty;
            bool Salir = false;

            //VHJC Si los datos del usuario estan completos y correctos..
            if(validaUsuarioDatos()) {
                //VHJC Si es un usuario nuevo se guarda
                if(ClaveUsuario == string.Empty) {
                    SQL = "INSERT INTO SATeC_Usuarios (Clave_Usuario, Nombre_Usuario, Contraseña_Usuario, Fecha_Alta, Nivel_Usuario, Bloqueo_Usuario) VALUES(";
                    SQL += "'" + txtClaveUsuario.Text + "', ";
                    SQL += "'" + txtNombreUsuario.Text + "', ";
                    SQL += "'" + General.encripta(txtContraseña.Text) + "', ";
                    SQL += "getdate(), ";
                    SQL += "" + ((ListItem)cmbNivelUsuario.SelectedItem).Valor + ", ";
                    SQL += "'False')";
                    //VHJC Si es un usuario existente se modifica
                } else {
                    SQL = "UPDATE SATeC_Usuarios SET ";
                    //SQL += "Clave_Usuario='" + txtClaveUsuario.Text + "', ";
                    SQL += "Nombre_Usuario='" + txtNombreUsuario.Text + "', ";
                    SQL += "Contraseña_Usuario='" + General.encripta(txtContraseña.Text) + "', ";
                    SQL += "Nivel_Usuario=" + ((ListItem)cmbNivelUsuario.SelectedItem).Valor + " ";
                    SQL += "WHERE Clave_Usuario='" + txtClaveUsuario.Text + "'";
                }

				if(Database.ejecutaQuery(SQL, false)) {
                    Salir = true;
                    General.muestraMensaje("Los datos del usuario se han guardado con exito.");
                } else {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los datos del usuario: " + Database.Error);
                }
            }

            Cursor = Cursors.Default;
            if(Salir)
                this.Close();
        }

        //VHJC Funcion que valida que los datos del usuario esten completos y correctos
        private bool validaUsuarioDatos() {
            bool Valida = true;

            if(txtClaveUsuario.Text == string.Empty) {
                General.muestraMensaje("La clave del usuario no puede estar en blanco, favor de revisar.");
                txtClaveUsuario.Focus();
                Valida = false;
			}else if(UsuariosExistentes.Contains(txtClaveUsuario.Text)){
                General.muestraMensaje("La clave del usuario ya existe en la base de datos, favor de revisar.");
                txtClaveUsuario.Focus();
                Valida = false;
            }else if(txtNombreUsuario.Text == string.Empty ) {
                General.muestraMensaje("El nombre del usuario no puede estar en blanco, favor de revisar.");
                txtNombreUsuario.Focus();
                Valida = false;
            }else if(txtContraseña.Text == string.Empty) {
                General.muestraMensaje("La contraseña no puede estar vacía, favor de revisar.");
                txtContraseña.Focus();
                Valida = false;
			} else if(txtContraseña.Text == txtClaveUsuario.Text) {
				General.muestraMensaje("La contraseña no puede ser igual a la clave del usuario, favor de revisar.");
				txtContraseña.Focus();
				Valida = false;
			} else if(cmbNivelUsuario.Text == string.Empty) {
                General.muestraMensaje("Debe seleccionar el nivel del usuario.");
                cmbNivelUsuario.Focus();
                Valida = false;
            }

            return Valida;
        }

        private void cmdCancelar_Click(object sender, EventArgs e) {
            if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos del usuario?") == DialogResult.Yes) {
                this.Close();
            }
        }

    }
}
