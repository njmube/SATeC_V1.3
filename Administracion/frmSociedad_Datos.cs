using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using System.IO;

namespace SATeC.Administracion {
    public partial class frmSociedad_Datos : Form {

        public string NumeroSociedad = string.Empty;
		private HashSet<string> SociedadesExistentes = new HashSet<string>();

        public frmSociedad_Datos() {
            InitializeComponent();
        }

        private void frmSociedad_Datos_Load(object sender, EventArgs e) {

			cargarSociedadesExistentes();

            obtenerCatalogosDeCuentas();

            if(NumeroSociedad == string.Empty) {
                limipaDatos();
            } else {
                limipaDatos();
                txtNoSociedad.TabStop = false;
                txtNoSociedad.ReadOnly = true;
                txtRFCSociedad.Select();

                obtenerSociedadDatos();
            }
        }

		//VHJC Funcion que cargar las Sociedades Existentes para verificar que una nueva no exista
		private void cargarSociedadesExistentes() {
			Cursor.Current = Cursors.WaitCursor;

			string SQL = "SELECT Numero_Sociedad FROM SATeC_Sociedades ";
			if(NumeroSociedad != string.Empty)
				SQL += "WHERE Numero_Sociedad <> '" + NumeroSociedad + "' ";
			SQL += "ORDER BY Numero_Sociedad";
			OleDbDataReader drSociedadesExistentes = Database.obtenRegistros(SQL);

			while(drSociedadesExistentes.Read()) {
				SociedadesExistentes.Add(drSociedadesExistentes["Numero_Sociedad"].ToString());
			}

			Cursor.Current = Cursors.Default;
		}

		//VHJC Funcion que obtiene los Catalogos de Cuentas existentes en la base de datos
        private void obtenerCatalogosDeCuentas() {
            OleDbDataReader drCatalogosCuentas = Database.obtenRegistros("SELECT ID_CatalogoCuentas, Nombre_CatalogoCuentas FROM SATeC_CatalogosCuentas ORDER BY Nombre_CatalogoCuentas");
            while(drCatalogosCuentas.Read()) {
                cmbCatalogoCuentasSociedad.Items.Add(new ListItem(drCatalogosCuentas["ID_CatalogoCuentas"].ToString(), drCatalogosCuentas["Nombre_CatalogoCuentas"].ToString()));
            }
        }

        //VHJC Funcion que limpia los controles para la captura de los datos del Usario
        private void limipaDatos() {
            this.txtNoSociedad.Text = string.Empty;
            this.txtRFCSociedad.Text = string.Empty;
            this.txtNombreSociedad.Text = string.Empty;
            this.cmbCatalogoCuentasSociedad.ResetText();
        }

        //VHJC Obtiene los datos de la socied que se selecciono
        private void obtenerSociedadDatos() {
            OleDbDataReader drSociedad = Database.obtenRegistros("SELECT ID_Sociedad, Numero_Sociedad, RFC_Sociedad, Nombre_Sociedad, ID_CatalogoCuentas FROM SATeC_Sociedades WHERE Numero_Sociedad='" + NumeroSociedad + "'");
            if(drSociedad != null) {
                drSociedad.Read();

                this.lblIdSociedad.Text = drSociedad["ID_Sociedad"].ToString().Trim();
                this.txtNoSociedad.Text = drSociedad["Numero_Sociedad"].ToString().Trim();
                this.txtRFCSociedad.Text = drSociedad["RFC_Sociedad"].ToString().Trim();
                this.txtNombreSociedad.Text = drSociedad["Nombre_Sociedad"].ToString().Trim();
                General.buscaEnCombo(this.cmbCatalogoCuentasSociedad, drSociedad["ID_CatalogoCuentas"].ToString().Trim());

                drSociedad.Close();
                drSociedad.Dispose();
            } else {
                General.muestraMensaje("Error: " + Database.Error);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int total = int.Parse(Database.obtenerDato("SELECT COUNT(ID_Sociedad) Total FROM SATeC_Sociedades"));
            int totalRFCS = int.Parse(Properties.Resources.TotalRFC);

            if (total > totalRFCS)
            {
                General.muestraMensaje("El numero total de Sociedades registradas para esta licencia es hasta: " + totalRFCS.ToString() + " favor de contactar al proveedor para solicitar el incremento correspondiente.");
                Cursor = Cursors.Default;
                this.Close();
            }
            else
            {
                string RFCS = Properties.Resources.RFCS;
                string[] elementos = RFCS.Split(',');
                List<string> listaRFC = elementos.ToList();

                string existe = listaRFC.Find(item => item.ToUpper().Trim() == txtRFCSociedad.Text.ToUpper().Trim());

                if (String.IsNullOrEmpty(existe))
                {
                    General.muestraMensaje("El RFC '" + txtRFCSociedad.Text.ToUpper() + "' no esta registrado dentro de la licencia proporcionada, favor de contactar al proveedor para solicitar el alta correspondiente.");
                    Cursor = Cursors.Default;
                    this.Close();
                }
                else
                {
                    RegistraSociedad();
                }
            }

            //RegistraSociedad();
        }
        private void RegistraSociedad()
        {
            Cursor = Cursors.WaitCursor;

            string SQL = string.Empty;
            bool Salir = false;

            if (validaSociedadDatos())
            {
                if (NumeroSociedad == string.Empty)
                {
                    string existe = Database.obtenerDato("DECLARE @resultado INT SET @resultado = 0 IF EXISTS( select 1 from SATeC_Sociedades WHERE UPPER(RFC_Sociedad) = UPPER('" + txtRFCSociedad.Text.Trim() + "') ) SET @resultado = 1 SELECT @resultado resultado");

                    if (existe.Equals("1"))
                    {
                        General.muestraMensaje("El RFC de la Sociedad Ya Existe.");
                        txtRFCSociedad.Focus();
                    }

                    

                    string idCatalogoCuentas = ((ListItem)cmbCatalogoCuentasSociedad.SelectedItem).Valor.ToString();
                    string nombreSociedad = txtNombreSociedad.Text.Trim();

                    SQL += "INSERT INTO SATeC_Sociedades (Numero_Sociedad, RFC_Sociedad, Nombre_Sociedad, ID_CatalogoCuentas, Fecha_Alta) VALUES(";
                    SQL += "'" + txtNoSociedad.Text.Trim() + "', ";
                    SQL += "'" + txtRFCSociedad.Text.Trim() + "', ";
                    SQL += "'" + nombreSociedad  + "', ";
                    SQL += "'" + idCatalogoCuentas + "', ";
                    SQL += "getdate()) \n";

                    SQL += "DECLARE @ID_Sociedad smallint = SCOPE_IDENTITY() \n";

                    SQL += "EXEC SATeC_ReplicarCuentasSociedadNueva @ID_Sociedad, " + ((ListItem)cmbCatalogoCuentasSociedad.SelectedItem).Valor + " \n";
                }
                else
                {
                    SQL += "EXEC SATeC_ReplicarCuentasSociedadNueva " + lblIdSociedad.Text + ", " + ((ListItem)cmbCatalogoCuentasSociedad.SelectedItem).Valor + " \n";
                    SQL += "UPDATE SATeC_Sociedades SET ";
                    SQL += "RFC_Sociedad = '" + txtRFCSociedad.Text.Trim() + "', ";                    
                    SQL += "Nombre_Sociedad = '" + txtNombreSociedad.Text.Trim() + "', ";
                    SQL += "ID_CatalogoCuentas = " + ((ListItem)cmbCatalogoCuentasSociedad.SelectedItem).Valor + " ";
                    SQL += "WHERE ID_Sociedad = " + lblIdSociedad.Text + " ";
                    SQL += "AND Numero_Sociedad = '" + txtNoSociedad.Text.Trim() + "' \n";
                }

                if (Database.ejecutaQuery(SQL, true))
                {
                    Salir = true;
                    General.muestraMensaje("Los Datos de la Sociedad se han guardado con exito y se han registrado las cuentas del Catalogo de Cuentas asociado.");
                }
                else
                {
                    General.muestraMensaje("Ocurrio un error al tratar de guardar los Datos de la sociedad: " + Database.Error);
                }
            }

            Cursor = Cursors.Default;
            
            if (Salir)
                this.Close();
        }
        private bool validaSociedadDatos() {
            bool Valida = true;

            if(txtNoSociedad.Text == string.Empty) {
                General.muestraMensaje("El número de la sociedad no puede estar en blanco, favor de revisar.");
                txtNoSociedad.Focus();
                Valida = false;
			}else if(SociedadesExistentes.Contains(txtNoSociedad.Text.Trim())) {
				General.muestraMensaje("El número de la sociedad ya existe en la base de datos, favor de revisar.");
				txtNoSociedad.SelectAll();
				txtNoSociedad.Focus();
				Valida = false;
            } else if(txtRFCSociedad.Text == string.Empty) {
                General.muestraMensaje("El RFC de la sociedad no puede estar en blanco, favor de revisar.");
                txtRFCSociedad.Focus();
                Valida = false;
            } else if(txtNombreSociedad.Text == string.Empty) {
                General.muestraMensaje("El nombre de la sociedad no puede estar en blanco, favor de revisar.");
                txtNombreSociedad.Focus();
                Valida = false;
            } else if(cmbCatalogoCuentasSociedad.Text == string.Empty) {
                General.muestraMensaje("Debe seleccionar el catálogo  de cuentas de la sociedad.");
                cmbCatalogoCuentasSociedad.Focus();
                Valida = false;
            }

            return Valida;
        }
        private void cmdCancelar_Click(object sender, EventArgs e) {
            if(General.muestraMensajePregunta("¿Esta seguro de salir sin guardar los datos de la sociedad?") == DialogResult.Yes) {
                this.Close();
            }
        }

    }
}
