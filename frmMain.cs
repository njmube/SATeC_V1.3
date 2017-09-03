using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SATeC
{
    public partial class frmMain : Form
    {

        frmSociedades Sociedades = new frmSociedades();

        public frmMain()
        {
            InitializeComponent();
            mnuMain.Renderer = new menuRenderer();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            General.cambiaMensajeStatus(this, "");
            lblIDUsuario.Text = General.UsuarioActual.Nombre;
            lblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            mnuAdministracion.Visible = General.UsuarioActual.Administrador;
            tlsSociedadSeleccionada.Visible = false;

            if (General.UsuarioActual.Administrador)
            {
                mnuMain.Visible = true;
            }
            else
            {
                mnuMain.Visible = false;
                Sociedades.MdiParent = this;
                Sociedades.Show();
            }

            foreach (ToolStripMenuItem opcion in mnuAdministracion.DropDownItems)
            {
                if (opcion.Text.Equals("Borrar Base de Datos"))
                {
                    string usuario = General.UsuarioActual.Nombre.ToLower();

                    if (!usuario.Equals("inventiva"))
                    {
                        opcion.Visible = false;
                    }
                }
            }
        }

        //VHJC Funcion que muestra la barra de la Sociedad seleccionada para trabajar
        public void muestraBarraSociedadSeleccionada(ToolStripMenuItem MenuLlamada)
        {
            this.lblNumeroSociedadSeleccionada.Text = General.Numero_SociedadSeleccionada;
            this.lblNombreSociedadSeleccionada.Text = General.Nombre_SociedadSeleccionada;
            //lblNombreSociedadSeleccionada.AutoSize = true;
            this.tlsSociedadSeleccionada.Visible = true;
            mnuMain.Visible = true;

            if (MenuLlamada != null)
                MenuLlamada.PerformClick();
        }

        //VHJC Cuando se da doble clic en la barra de la Sociedad seleccionada, se muestra la lista de Sociedades existentes para seleccionar una
        private void tlsSociedadSeleccionada_DoubleClick(object sender, EventArgs e)
        {
            tlsSociedadSeleccionada.Visible = false;

            frmSociedades Sociedades = new frmSociedades();
            Sociedades.MdiParent = this;
            Sociedades.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Render for menuStrip
        private class menuRenderer : ToolStripProfessionalRenderer
        {

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs myMenu)
            {
                if (myMenu.Item.GetType() != typeof(TextBox))
                {
                    Rectangle rc = new Rectangle(Point.Empty, myMenu.Item.Size);
                    myMenu.Item.ForeColor = Color.White;
                    //Background Color of the Menu : Color.FromArgb(0, 130, 153)
                    //Hover Color on the menu : Color.FromArgb(0, 121, 143)
                    Color color = myMenu.Item.Selected ? Color.FromArgb(0, 121, 143) : Color.FromArgb(0, 130, 153);
                    SolidBrush brush = new SolidBrush(color);
                    myMenu.Graphics.FillRectangle(brush, rc);
                }
            }

            protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs mySeparator)
            {
                //VHJC For backgruond color
                Rectangle backgroundColor = mySeparator.Item.Bounds;
                backgroundColor.Location = new Point(0, 0);
                SolidBrush brush = new SolidBrush(Color.FromArgb(0, 130, 153));
                mySeparator.Graphics.FillRectangle(brush, backgroundColor);

                //VHJC For separator line color
                Rectangle separatorline = mySeparator.Item.ContentRectangle; //new Rectangle(Point.Empty, mySeparator.Item.Size);
                brush = new SolidBrush(Color.FromArgb(0, 121, 143));
                mySeparator.Graphics.FillRectangle(brush, separatorline);

            }

            public menuRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(0, 130, 153); }
            }
        }
        #endregion

        #region Administracion

        private void mnuAdministracion_Usuarios_Click(object sender, EventArgs e)
        {
            Administracion.frmUsuarios Usuarios = new Administracion.frmUsuarios();
            Usuarios.MdiParent = this;
            Usuarios.Show();
        }
        private void mnuAdministracion_CatalogosCuentas_Click(object sender, EventArgs e)
        {
            Administracion.frmCatalogosDeCuentas CatalogoDeCuentas = new Administracion.frmCatalogosDeCuentas();
            CatalogoDeCuentas.MdiParent = this;
            CatalogoDeCuentas.Show();
        }
        private void mnuAdministracion_CatalogosCuentasAuxiliares_Click(object sender, EventArgs e)
        {
            Administracion.frmCatalogosDeCuentasAuxiliares CatalogosDeCuentasAuxiliares = new Administracion.frmCatalogosDeCuentasAuxiliares();
            CatalogosDeCuentasAuxiliares.MdiParent = this;
            CatalogosDeCuentasAuxiliares.Show();
        }
        private void mnuAdministracion_Sociedades_Click(object sender, EventArgs e)
        {
            Administracion.frmSociedades Sociedades = new Administracion.frmSociedades();
            Sociedades.MdiParent = this;
            Sociedades.Show();
        }
        private void mnuAdministracion_EjerciciosPeriodos_Click(object sender, EventArgs e)
        {
            Administracion.frmEjerciciosPeriodos EjerciciosPeriodos = new Administracion.frmEjerciciosPeriodos();
            EjerciciosPeriodos.MdiParent = this;
            EjerciciosPeriodos.Show();
        }
        private void mnuAdministracionCatalogoCuentasSAT_Click(object sender, EventArgs e)
        {
            Administracion.frmCargarCatalogoCuentasSAT CargarCatalogoCuentasSAT = new Administracion.frmCargarCatalogoCuentasSAT();
            CargarCatalogoCuentasSAT.MdiParent = this;
            CargarCatalogoCuentasSAT.Show();
        }
        private void mnuAdministracion_CargaMapeoCuentas_Click(object sender, EventArgs e)
        {
            Administracion.frmCargaMapeoCuentas CargarMapeoCuentas = new Administracion.frmCargaMapeoCuentas();
            CargarMapeoCuentas.MdiParent = this;
            CargarMapeoCuentas.Show();
        }
        private void mnuAdministracion_BorrarBaseDeDatos_Click(object sender, EventArgs e)
        {
            if (Database.ejecutaQuery("borrarBaseDeDatos", CommandType.StoredProcedure))
            {
                General.muestraMensaje("Se borró toda la información de la base de datos.");
            }
            else
            {
                General.muestraMensaje("Ocurrio un error al tratar de borrar la información de la base de datos.\n" + Database.Error);
            }
        }
        private void mnuAdministracion_mapeoMetodosPago_Click(object sender, EventArgs e)
        {
            Administracion.frmMapeoMetodosPago mapeoMetodosPago = new Administracion.frmMapeoMetodosPago();
            mapeoMetodosPago.MdiParent = this;
            mapeoMetodosPago.Show();
        }

        #endregion

        #region Catalogos de Cuentas
        private void mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT_Click(object sender, EventArgs e)
        {
            CatalogoDeCuentas.frmConsultarCatalogoCuentasSAT ConsultarCatalogoCuentasSAT = new CatalogoDeCuentas.frmConsultarCatalogoCuentasSAT();
            ConsultarCatalogoCuentasSAT.MdiParent = this;
            ConsultarCatalogoCuentasSAT.Show();
        }

        private void mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                CatalogoDeCuentas.frmConsultarCatalogoDeCuentasSociedad CatalogoCuentasSociedad = new CatalogoDeCuentas.frmConsultarCatalogoDeCuentasSociedad();
                CatalogoCuentasSociedad.MdiParent = this;
                CatalogoCuentasSociedad.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad;
                Sociedades.Show();
            }
        }

        private void mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                CatalogoDeCuentas.frmRelacionDeCuentasConCodigoAgrupadorSAT ConvertirCatalogoDeCuentasACodigoAgrupadorSAT = new CatalogoDeCuentas.frmRelacionDeCuentasConCodigoAgrupadorSAT();
                //ConvertirCatalogoDeCuentasACodigoAgrupadorSAT.MdiParent = this;
                ConvertirCatalogoDeCuentasACodigoAgrupadorSAT.ShowDialog();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT;
                Sociedades.Show();
            }
        }

        private void mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                CatalogoDeCuentas.frmConsultarCatalogosFormatoXML ConsultarCatalogosFormatoXML = new CatalogoDeCuentas.frmConsultarCatalogosFormatoXML();
                ConsultarCatalogosFormatoXML.MdiParent = this;
                ConsultarCatalogosFormatoXML.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML;
                Sociedades.Show();
            }
        }

        #endregion

        #region Balanza
        private void mnuBalanza_ImportarBalanza_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Balanza.frmImportarBalanza ImportarBalanza = new Balanza.frmImportarBalanza();
                ImportarBalanza.ShowDialog();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuBalanza_ImportarBalanza;
                Sociedades.Show();
            }
        }

        private void mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Balanza.frmConsultarBalanzasImportadas ConsultarBalanzasImportadas = new Balanza.frmConsultarBalanzasImportadas();
                ConsultarBalanzasImportadas.MdiParent = this;
                ConsultarBalanzasImportadas.TipoConsultaPolizasImportadas = TipoConsultaBalanzaImportada.ConCatalogoDeCuentasSociedad;
                ConsultarBalanzasImportadas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad;
                Sociedades.Show();
            }
        }

        private void mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Balanza.frmConsultarBalanzasImportadas ConsultarBalanzasImportadas = new Balanza.frmConsultarBalanzasImportadas();
                ConsultarBalanzasImportadas.MdiParent = this;
                ConsultarBalanzasImportadas.TipoConsultaPolizasImportadas = TipoConsultaBalanzaImportada.ConCodigoAgrupadorSAT;
                ConsultarBalanzasImportadas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT;
                Sociedades.Show();
            }
        }

        private void mnuBalanza_ConsultarBalanzaImportadaConFormatoXML_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Balanza.frmConsultarBalanzasImportadas ConsultarBalanzasImportadas = new Balanza.frmConsultarBalanzasImportadas();
                ConsultarBalanzasImportadas.MdiParent = this;
                ConsultarBalanzasImportadas.TipoConsultaPolizasImportadas = TipoConsultaBalanzaImportada.ConFormatoXML;
                ConsultarBalanzasImportadas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML;
                Sociedades.Show();
            }
        }
        #endregion

        #region Polizas
        private void mnuPolizas_ImportarPolizas_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                //string RFCAll = Properties.Resources.RFCALL;
                //string RFCSeleccionado = Database.obtenerDato("SELECT RFC_Sociedad FROM SATeC_Sociedades WHERE ID_Sociedad = " + General.ID_SociedadSeleccionada.ToString());

                //if (RFCAll.ToUpper().Trim().Equals(RFCSeleccionado.ToUpper().Trim()))
                //{
                //    Polizas.frmImportarPolizas ImportarPolizas = new Polizas.frmImportarPolizas();
                //    ImportarPolizas.Show();
                //}
                //else
                //{
                //    frmSociedades Sociedades = new frmSociedades();
                //    Sociedades.MdiParent = this;
                //    Sociedades.MenuLlamada = this.mnuPolizas_ImportarPolizas;
                //    Sociedades.Show();
                //    General.muestraMensaje("El RFC de la sociedad seleccionada no tiene permitido la importación de Polizas.");
                //}

                Polizas.frmImportarPolizas ImportarPolizas = new Polizas.frmImportarPolizas();
                ImportarPolizas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuPolizas_ImportarPolizas;
                Sociedades.Show();
            }
        }

        private void mnuPolizas_ImportarDatosComplementarios_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Polizas.frmConsultarPolizas ConsultarPolizas = new Polizas.frmConsultarPolizas();
                ConsultarPolizas.ConsultaPolizasImportadas = TipoConsultaPolizasImportadas.ImportarDatosComplementarios;
                ConsultarPolizas.MdiParent = this;
                ConsultarPolizas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuPolizas_ImportarDatosComplementarios;
                Sociedades.Show();
            }
        }

        private void mnuPolizas_ValidarPolizas_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Polizas.frmConsultarPolizas ConsultarPolizas = new Polizas.frmConsultarPolizas();
                ConsultarPolizas.ConsultaPolizasImportadas = TipoConsultaPolizasImportadas.Importadas;
                ConsultarPolizas.MdiParent = this;
                ConsultarPolizas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuPolizas_ValidarPolizas;
                Sociedades.Show();
            }
        }

        private void mnuPolizas_ConsultarPolizasFormatoXML_Click(object sender, EventArgs e)
        {
            if (General.verificaSociedadSeleccionada())
            {
                Polizas.frmConsultarPolizas ConsultarPolizas = new Polizas.frmConsultarPolizas();
                ConsultarPolizas.ConsultaPolizasImportadas = TipoConsultaPolizasImportadas.ConvertidasXML;
                ConsultarPolizas.MdiParent = this;
                ConsultarPolizas.Show();
            }
            else
            {
                frmSociedades Sociedades = new frmSociedades();
                Sociedades.MdiParent = this;
                Sociedades.MenuLlamada = this.mnuPolizas_ConsultarPolizasFormatoXML;
                Sociedades.Show();
            }
        }

        #endregion
    }
}