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
    public partial class frmLogin : Form {

        private int intentosLogin = 0;

        public frmLogin() {
            InitializeComponent();
        }

		private void frmLogin_Load(object sender, EventArgs e) {
			//txtUsuario.Focus();
			try {
				if(INI.existeINI()) {
					if(INI.KeyExists("SATeC", "SATeC")) {

					    //VHJC Se verifica si la version es Demo
					    General.verificaSiEsDemo();

					    //VHJC Si la version es Demo verificamos la fecha de caducidad
					    if(General.EsDemo) {
					        //VHJC Si no tiene fecha de caducidad, se establece la fecha de caducidad hoy + 7 dias
					        if(General.FechaDemo == string.Empty) {
					            string FechaInicioDemo = DateTime.Today.ToString("dd/MM/yyyy");
					            FechaInicioDemo = "DEMO," + FechaInicioDemo;

					            INI.Write("SATeC", "SATeC", FechaInicioDemo);

					        } else {
					            //VHJC Si la fecha de caducidad ya expiro se manda mensaje y se cierra el programa

								DateTime FechaCaducidadDemo = DateTime.Parse(General.FechaDemo).AddDays(7);

								if(DateTime.Today > FechaCaducidadDemo) {
					                General.muestraMensaje("El tiempo de la versión DEMO ha caducado, favor de reportarlo a su área de sistemas.");
					                Application.Exit();
					            }
					        }
					    }

						txtUsuario.Text = INI.Read("SATeC", "Usuario");
						if(txtUsuario.Text != string.Empty) {
							txtContraseña.Select();
							txtContraseña.Focus();
							this.ActiveControl = txtContraseña;
						}
					} else {
						General.muestraMensaje("El archivo de configuración se encuentra dañado, favor de reportarlo a su área de sistemas.");
						Application.Exit();
					}
				}
			} catch(Exception Ex) {
				General.muestraMensaje(Ex.Message);
			}
		}

        private void cmdAceptar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            try {
                if(validaUsuario()) {
                    frmMain mainWindow = new frmMain();
                    mainWindow.Show();

                    this.Hide();
                }
            } catch(Exception Ex) {
                txtContraseña.SelectAll();
                txtContraseña.Focus();
                General.muestraMensaje(Ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void cmdCancelar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //VHJC
        //Funcion que valida si el usuario existe en la base de datos,
        //si existe, establece los datos del usuario
        private bool validaUsuario() {
            bool bReturn = true;
            string sUsuario = txtUsuario.Text;
            string sContraseña = General.encripta(txtContraseña.Text);

            string stemp = General.desencripta(sContraseña);

            //VHJC Se busca un usuario con el nombre de usuario que se captura en pantalla
            string sSQL = "SELECT ID_Usuario, Nombre_Usuario, Contraseña_Usuario, Nivel_Usuario, Bloqueo_Usuario FROM SATeC_Usuarios WHERE Clave_Usuario = '" + sUsuario + "'";

            try {
                OleDbDataReader drUsuario = Database.obtenRegistros(sSQL);

                //VHJC Si se encuentra un usuario con el nombre de usuario que se capturo en pantalla
                if(drUsuario.HasRows) {
                    drUsuario.Read();

                    //VHJC Si el usuario esta bloqueado se manda mensaje sin hacer nada
                    if(bool.Parse(drUsuario["Bloqueo_Usuario"].ToString())) {
                        General.muestraMensaje("El usuario se encuentra bloqueado, solicite apoyo al administrador del sistema.");
                        txtUsuario.SelectAll();
                        txtUsuario.Focus();
                        bReturn = false;
                    //VHJC Si el usuario no esta bloqueado se valida
                    } else {

                        if(drUsuario["Contraseña_Usuario"].ToString() == sContraseña) {

                            INI.Write("SATeC", "Usuario", txtUsuario.Text);
                            Usuario UsuarioActual = new Usuario();
                            UsuarioActual.ID = int.Parse(drUsuario["ID_Usuario"].ToString());
                            UsuarioActual.Nombre = drUsuario["Nombre_Usuario"].ToString();
                            UsuarioActual.Administrador = (int.Parse(drUsuario["Nivel_Usuario"].ToString()) == 1);

                            General.UsuarioActual = UsuarioActual;
                        } else {
                            General.muestraMensaje("La contraseña es incorrecta, favor de verificar.");
                            txtContraseña.SelectAll();
                            txtContraseña.Focus();
                            bReturn = false;

                            intentosLogin++;
                            if(intentosLogin >= 3) {
                                General.muestraMensaje("Ha intentado 3 veces acceder al sistema sin exito, su usuario ha sido bloqueado, solicite apoyo al administrador del sistema.");
                                bloqueaUsuario();
                            }
                        }
                    }

                //VHJC Si no se encuentra un usuario con el nombre de usuario que se capturo en pantalla
                } else {
                    General.muestraMensaje("El nombre de usuario no existe, favor de verificar.");
                    txtUsuario.SelectAll();
                    txtUsuario.Focus();
                    bReturn = false;
                }

                drUsuario.Close();
                drUsuario.Dispose();
            } catch(Exception Ex) {
                throw new Exception(Ex.Message);
            }

            return bReturn;
        }

        private void bloqueaUsuario() {
            string sUsuario = txtUsuario.Text;
            string SQL = "UPDATE SATeC_Usuarios SET Bloqueo_Usuario = 'True' WHERE Clave_Usuario = '" + sUsuario + "'";
            try {
				Database.ejecutaQuery(SQL, false);
            }catch (Exception Ex) {
                throw new Exception(Ex.Message);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Return)
                txtContraseña.Focus();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Return)
                cmdAceptar.PerformClick();
        }

		private void txtUsuario_Enter(object sender, EventArgs e) {
			txtUsuario.SelectAll();
		}

		private void txtUsuario_Leave(object sender, EventArgs e) {
			txtUsuario.Select(1, 0);
		}

		private void txtContraseña_Enter(object sender, EventArgs e) {
			txtContraseña.SelectAll();
		}

		private void txtContraseña_Leave(object sender, EventArgs e) {
			txtContraseña.Select(1, 0);
		}


    }
}
