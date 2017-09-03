namespace SATeC {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIDUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_CatalogosCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_CatalogosCuentasAuxiliares = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_Sociedades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_EjerciciosPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracionCatalogoCuentasSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_CargaMapeoCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_BorrarBaseDeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion_mapeoMetodosPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogoDeCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBalanza = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBalanza_ImportarBalanza = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarLaBalanzaAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolizas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolizas_ImportarPolizas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolizas_ImportarDatosComplementarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolizas_ValidarPolizas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPolizas_ConsultarPolizasFormatoXML = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarLasPólizasAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTextboxBlank = new System.Windows.Forms.ToolStripTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picMainBackground = new System.Windows.Forms.PictureBox();
            this.tlsSociedadSeleccionada = new System.Windows.Forms.ToolStrip();
            this.lblSociedad = new System.Windows.Forms.ToolStripLabel();
            this.lblNumeroSociedadSeleccionada = new System.Windows.Forms.ToolStripLabel();
            this.lblNombreSociedad = new System.Windows.Forms.ToolStripLabel();
            this.lblNombreSociedadSeleccionada = new System.Windows.Forms.ToolStripLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.stsMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainBackground)).BeginInit();
            this.tlsSociedadSeleccionada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.AllowMerge = false;
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblFecha,
            this.lblIDUsuario});
            this.stsMain.Location = new System.Drawing.Point(0, 628);
            this.stsMain.Name = "stsMain";
            this.stsMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsMain.Size = new System.Drawing.Size(982, 29);
            this.stsMain.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(802, 24);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "lblStatus";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblFecha.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(68, 24);
            this.lblFecha.Text = "lblFecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(95, 24);
            this.lblIDUsuario.Text = "lblIDUsuario";
            // 
            // lblSistema
            // 
            this.lblSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistema.BackColor = System.Drawing.Color.White;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblSistema.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSistema.Location = new System.Drawing.Point(896, -2);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(86, 30);
            this.lblSistema.TabIndex = 13;
            this.lblSistema.Text = "SATeC";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracion,
            this.mnuCatalogoDeCuentas,
            this.mnuBalanza,
            this.mnuPolizas,
            this.mnuSalir,
            this.mnuTextboxBlank});
            this.mnuMain.Location = new System.Drawing.Point(0, 84);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(982, 32);
            this.mnuMain.TabIndex = 16;
            // 
            // mnuAdministracion
            // 
            this.mnuAdministracion.AutoSize = false;
            this.mnuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracion_Usuarios,
            this.mnuAdministracion_CatalogosCuentas,
            this.mnuAdministracion_CatalogosCuentasAuxiliares,
            this.mnuAdministracion_Sociedades,
            this.mnuAdministracion_EjerciciosPeriodos,
            this.mnuAdministracionCatalogoCuentasSAT,
            this.mnuAdministracion_CargaMapeoCuentas,
            this.mnuAdministracion_BorrarBaseDeDatos,
            this.mnuAdministracion_mapeoMetodosPago});
            this.mnuAdministracion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion.ForeColor = System.Drawing.Color.White;
            this.mnuAdministracion.Name = "mnuAdministracion";
            this.mnuAdministracion.Size = new System.Drawing.Size(200, 32);
            this.mnuAdministracion.Text = "Administración";
            // 
            // mnuAdministracion_Usuarios
            // 
            this.mnuAdministracion_Usuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_Usuarios.Name = "mnuAdministracion_Usuarios";
            this.mnuAdministracion_Usuarios.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_Usuarios.Text = "Usuarios";
            this.mnuAdministracion_Usuarios.Click += new System.EventHandler(this.mnuAdministracion_Usuarios_Click);
            // 
            // mnuAdministracion_CatalogosCuentas
            // 
            this.mnuAdministracion_CatalogosCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_CatalogosCuentas.Name = "mnuAdministracion_CatalogosCuentas";
            this.mnuAdministracion_CatalogosCuentas.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_CatalogosCuentas.Text = "Catálogos de Cuentas";
            this.mnuAdministracion_CatalogosCuentas.Click += new System.EventHandler(this.mnuAdministracion_CatalogosCuentas_Click);
            // 
            // mnuAdministracion_CatalogosCuentasAuxiliares
            // 
            this.mnuAdministracion_CatalogosCuentasAuxiliares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_CatalogosCuentasAuxiliares.Name = "mnuAdministracion_CatalogosCuentasAuxiliares";
            this.mnuAdministracion_CatalogosCuentasAuxiliares.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_CatalogosCuentasAuxiliares.Text = "Catálogos de Cuentas Auxiliares";
            this.mnuAdministracion_CatalogosCuentasAuxiliares.Click += new System.EventHandler(this.mnuAdministracion_CatalogosCuentasAuxiliares_Click);
            // 
            // mnuAdministracion_Sociedades
            // 
            this.mnuAdministracion_Sociedades.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_Sociedades.Name = "mnuAdministracion_Sociedades";
            this.mnuAdministracion_Sociedades.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_Sociedades.Text = "Sociedades";
            this.mnuAdministracion_Sociedades.Click += new System.EventHandler(this.mnuAdministracion_Sociedades_Click);
            // 
            // mnuAdministracion_EjerciciosPeriodos
            // 
            this.mnuAdministracion_EjerciciosPeriodos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_EjerciciosPeriodos.Name = "mnuAdministracion_EjerciciosPeriodos";
            this.mnuAdministracion_EjerciciosPeriodos.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_EjerciciosPeriodos.Text = "Ejercicios y Periodos";
            this.mnuAdministracion_EjerciciosPeriodos.Click += new System.EventHandler(this.mnuAdministracion_EjerciciosPeriodos_Click);
            // 
            // mnuAdministracionCatalogoCuentasSAT
            // 
            this.mnuAdministracionCatalogoCuentasSAT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracionCatalogoCuentasSAT.Name = "mnuAdministracionCatalogoCuentasSAT";
            this.mnuAdministracionCatalogoCuentasSAT.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracionCatalogoCuentasSAT.Text = "Cargar Catálogo de Cuentas del SAT";
            this.mnuAdministracionCatalogoCuentasSAT.Click += new System.EventHandler(this.mnuAdministracionCatalogoCuentasSAT_Click);
            // 
            // mnuAdministracion_CargaMapeoCuentas
            // 
            this.mnuAdministracion_CargaMapeoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuAdministracion_CargaMapeoCuentas.Name = "mnuAdministracion_CargaMapeoCuentas";
            this.mnuAdministracion_CargaMapeoCuentas.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_CargaMapeoCuentas.Text = "Carga Mapeo Cuentas";
            this.mnuAdministracion_CargaMapeoCuentas.Click += new System.EventHandler(this.mnuAdministracion_CargaMapeoCuentas_Click);
            // 
            // mnuAdministracion_BorrarBaseDeDatos
            // 
            this.mnuAdministracion_BorrarBaseDeDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdministracion_BorrarBaseDeDatos.Name = "mnuAdministracion_BorrarBaseDeDatos";
            this.mnuAdministracion_BorrarBaseDeDatos.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_BorrarBaseDeDatos.Text = "Borrar Base de Datos";
            this.mnuAdministracion_BorrarBaseDeDatos.Click += new System.EventHandler(this.mnuAdministracion_BorrarBaseDeDatos_Click);
            // 
            // mnuAdministracion_mapeoMetodosPago
            // 
            this.mnuAdministracion_mapeoMetodosPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuAdministracion_mapeoMetodosPago.Name = "mnuAdministracion_mapeoMetodosPago";
            this.mnuAdministracion_mapeoMetodosPago.Size = new System.Drawing.Size(368, 28);
            this.mnuAdministracion_mapeoMetodosPago.Text = "Mapeo Métodos de Pago";
            this.mnuAdministracion_mapeoMetodosPago.Click += new System.EventHandler(this.mnuAdministracion_mapeoMetodosPago_Click);
            // 
            // mnuCatalogoDeCuentas
            // 
            this.mnuCatalogoDeCuentas.AutoSize = false;
            this.mnuCatalogoDeCuentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT,
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad,
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT,
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML,
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem,
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem});
            this.mnuCatalogoDeCuentas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuCatalogoDeCuentas.ForeColor = System.Drawing.Color.White;
            this.mnuCatalogoDeCuentas.Name = "mnuCatalogoDeCuentas";
            this.mnuCatalogoDeCuentas.Size = new System.Drawing.Size(250, 32);
            this.mnuCatalogoDeCuentas.Text = "Catálogo de Cuentas";
            // 
            // mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT
            // 
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT.Name = "mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT";
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT.Size = new System.Drawing.Size(520, 28);
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT.Text = "Consultar Catálogo de Cuentas del SAT";
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT.Click += new System.EventHandler(this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT_Click);
            // 
            // mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad
            // 
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad.Name = "mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad";
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad.Size = new System.Drawing.Size(520, 28);
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad.Text = "Consultar Catálogo de Cuentas de la Sociedad";
            this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad.Click += new System.EventHandler(this.mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad_Click);
            // 
            // mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT
            // 
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT.Name = "mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT";
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT.Size = new System.Drawing.Size(520, 28);
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT.Text = "Convertir Catálogo a Código agrupador de cuentas SAT ";
            this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT.Click += new System.EventHandler(this.mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT_Click);
            // 
            // mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML
            // 
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML.Name = "mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML";
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML.Size = new System.Drawing.Size(520, 28);
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML.Text = "Consultar Catálogos en formato XML ";
            this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML.Click += new System.EventHandler(this.mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML_Click);
            // 
            // enviarCatálogoDeCuentasAlSATToolStripMenuItem
            // 
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem.Name = "enviarCatálogoDeCuentasAlSATToolStripMenuItem";
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem.Size = new System.Drawing.Size(520, 28);
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem.Text = "Enviar Catálogos de Cuentas al SAT ";
            this.enviarCatálogoDeCuentasAlSATToolStripMenuItem.Visible = false;
            // 
            // consultarCatálogosEnviadosAlSATToolStripMenuItem
            // 
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem.Name = "consultarCatálogosEnviadosAlSATToolStripMenuItem";
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem.Size = new System.Drawing.Size(520, 28);
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem.Text = "Consultar Catálogos enviados al SAT ";
            this.consultarCatálogosEnviadosAlSATToolStripMenuItem.Visible = false;
            // 
            // mnuBalanza
            // 
            this.mnuBalanza.AutoSize = false;
            this.mnuBalanza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBalanza_ImportarBalanza,
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad,
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT,
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML,
            this.enviarLaBalanzaAlSATToolStripMenuItem,
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem});
            this.mnuBalanza.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuBalanza.ForeColor = System.Drawing.Color.White;
            this.mnuBalanza.Name = "mnuBalanza";
            this.mnuBalanza.Size = new System.Drawing.Size(100, 32);
            this.mnuBalanza.Text = "Balanza";
            // 
            // mnuBalanza_ImportarBalanza
            // 
            this.mnuBalanza_ImportarBalanza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuBalanza_ImportarBalanza.Name = "mnuBalanza_ImportarBalanza";
            this.mnuBalanza_ImportarBalanza.Size = new System.Drawing.Size(606, 28);
            this.mnuBalanza_ImportarBalanza.Text = "Importar Balanza";
            this.mnuBalanza_ImportarBalanza.Click += new System.EventHandler(this.mnuBalanza_ImportarBalanza_Click);
            // 
            // mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad
            // 
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Name = "mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad";
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Size = new System.Drawing.Size(606, 28);
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Text = "Validar Balanza Importada con Catálogo de Cuentas de la Sociedad";
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Visible = false;
            this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad.Click += new System.EventHandler(this.mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad_Click);
            // 
            // mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT
            // 
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT.Name = "mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT";
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT.Size = new System.Drawing.Size(606, 28);
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT.Text = "Validar Balanza con Código Agrupador del SAT";
            this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT.Click += new System.EventHandler(this.mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT_Click);
            // 
            // mnuBalanza_ConsultarBalanzaImportadaConFormatoXML
            // 
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML.Name = "mnuBalanza_ConsultarBalanzaImportadaConFormatoXML";
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML.Size = new System.Drawing.Size(606, 28);
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML.Text = "Consultar Balanza Importada en formato XML";
            this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML.Click += new System.EventHandler(this.mnuBalanza_ConsultarBalanzaImportadaConFormatoXML_Click);
            // 
            // enviarLaBalanzaAlSATToolStripMenuItem
            // 
            this.enviarLaBalanzaAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.enviarLaBalanzaAlSATToolStripMenuItem.Name = "enviarLaBalanzaAlSATToolStripMenuItem";
            this.enviarLaBalanzaAlSATToolStripMenuItem.Size = new System.Drawing.Size(606, 28);
            this.enviarLaBalanzaAlSATToolStripMenuItem.Text = "Enviar la Balanza al SAT";
            this.enviarLaBalanzaAlSATToolStripMenuItem.Visible = false;
            // 
            // consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem
            // 
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem.Name = "consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem";
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem.Size = new System.Drawing.Size(606, 28);
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem.Text = "Consulta de las Balanzas enviadas al SAT";
            this.consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem.Visible = false;
            // 
            // mnuPolizas
            // 
            this.mnuPolizas.AutoSize = false;
            this.mnuPolizas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPolizas_ImportarPolizas,
            this.mnuPolizas_ImportarDatosComplementarios,
            this.mnuPolizas_ValidarPolizas,
            this.mnuPolizas_ConsultarPolizasFormatoXML,
            this.enviarLasPólizasAlSATToolStripMenuItem,
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem});
            this.mnuPolizas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuPolizas.ForeColor = System.Drawing.Color.White;
            this.mnuPolizas.Name = "mnuPolizas";
            this.mnuPolizas.Size = new System.Drawing.Size(94, 32);
            this.mnuPolizas.Text = "Pólizas";
            // 
            // mnuPolizas_ImportarPolizas
            // 
            this.mnuPolizas_ImportarPolizas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuPolizas_ImportarPolizas.Name = "mnuPolizas_ImportarPolizas";
            this.mnuPolizas_ImportarPolizas.Size = new System.Drawing.Size(367, 28);
            this.mnuPolizas_ImportarPolizas.Text = "Importar Pólizas";
            this.mnuPolizas_ImportarPolizas.Click += new System.EventHandler(this.mnuPolizas_ImportarPolizas_Click);
            // 
            // mnuPolizas_ImportarDatosComplementarios
            // 
            this.mnuPolizas_ImportarDatosComplementarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuPolizas_ImportarDatosComplementarios.Name = "mnuPolizas_ImportarDatosComplementarios";
            this.mnuPolizas_ImportarDatosComplementarios.Size = new System.Drawing.Size(367, 28);
            this.mnuPolizas_ImportarDatosComplementarios.Text = "Importar Datos Complementarios";
            this.mnuPolizas_ImportarDatosComplementarios.Click += new System.EventHandler(this.mnuPolizas_ImportarDatosComplementarios_Click);
            // 
            // mnuPolizas_ValidarPolizas
            // 
            this.mnuPolizas_ValidarPolizas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuPolizas_ValidarPolizas.Name = "mnuPolizas_ValidarPolizas";
            this.mnuPolizas_ValidarPolizas.Size = new System.Drawing.Size(367, 28);
            this.mnuPolizas_ValidarPolizas.Text = "Validar Pólizas";
            this.mnuPolizas_ValidarPolizas.Click += new System.EventHandler(this.mnuPolizas_ValidarPolizas_Click);
            // 
            // mnuPolizas_ConsultarPolizasFormatoXML
            // 
            this.mnuPolizas_ConsultarPolizasFormatoXML.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuPolizas_ConsultarPolizasFormatoXML.Name = "mnuPolizas_ConsultarPolizasFormatoXML";
            this.mnuPolizas_ConsultarPolizasFormatoXML.Size = new System.Drawing.Size(367, 28);
            this.mnuPolizas_ConsultarPolizasFormatoXML.Text = "Consultar Pólizas en formato XML";
            this.mnuPolizas_ConsultarPolizasFormatoXML.Click += new System.EventHandler(this.mnuPolizas_ConsultarPolizasFormatoXML_Click);
            // 
            // enviarLasPólizasAlSATToolStripMenuItem
            // 
            this.enviarLasPólizasAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.enviarLasPólizasAlSATToolStripMenuItem.Name = "enviarLasPólizasAlSATToolStripMenuItem";
            this.enviarLasPólizasAlSATToolStripMenuItem.Size = new System.Drawing.Size(367, 28);
            this.enviarLasPólizasAlSATToolStripMenuItem.Text = "Enviar las Pólizas al SAT";
            this.enviarLasPólizasAlSATToolStripMenuItem.Visible = false;
            // 
            // consultarLasPólizasEnviadasAlSATToolStripMenuItem
            // 
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem.Name = "consultarLasPólizasEnviadasAlSATToolStripMenuItem";
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem.Size = new System.Drawing.Size(367, 28);
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem.Text = "Consultar las Pólizas enviadas al SAT";
            this.consultarLasPólizasEnviadasAlSATToolStripMenuItem.Visible = false;
            // 
            // mnuSalir
            // 
            this.mnuSalir.AutoSize = false;
            this.mnuSalir.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuSalir.ForeColor = System.Drawing.Color.White;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(80, 32);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuTextboxBlank
            // 
            this.mnuTextboxBlank.AcceptsReturn = true;
            this.mnuTextboxBlank.AcceptsTab = true;
            this.mnuTextboxBlank.AutoSize = false;
            this.mnuTextboxBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.mnuTextboxBlank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mnuTextboxBlank.Enabled = false;
            this.mnuTextboxBlank.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuTextboxBlank.Name = "mnuTextboxBlank";
            this.mnuTextboxBlank.Size = new System.Drawing.Size(340, 32);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(682, 28);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(298, 20);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "Contablidad por Medios Electrónicos v1.3";
            // 
            // picMainBackground
            // 
            this.picMainBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.picMainBackground.Location = new System.Drawing.Point(0, 0);
            this.picMainBackground.Name = "picMainBackground";
            this.picMainBackground.Size = new System.Drawing.Size(982, 52);
            this.picMainBackground.TabIndex = 17;
            this.picMainBackground.TabStop = false;
            // 
            // tlsSociedadSeleccionada
            // 
            this.tlsSociedadSeleccionada.AllowMerge = false;
            this.tlsSociedadSeleccionada.AutoSize = false;
            this.tlsSociedadSeleccionada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tlsSociedadSeleccionada.GripMargin = new System.Windows.Forms.Padding(0);
            this.tlsSociedadSeleccionada.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsSociedadSeleccionada.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsSociedadSeleccionada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSociedad,
            this.lblNumeroSociedadSeleccionada,
            this.lblNombreSociedad,
            this.lblNombreSociedadSeleccionada});
            this.tlsSociedadSeleccionada.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsSociedadSeleccionada.Location = new System.Drawing.Point(0, 52);
            this.tlsSociedadSeleccionada.Name = "tlsSociedadSeleccionada";
            this.tlsSociedadSeleccionada.ShowItemToolTips = false;
            this.tlsSociedadSeleccionada.Size = new System.Drawing.Size(982, 32);
            this.tlsSociedadSeleccionada.Stretch = true;
            this.tlsSociedadSeleccionada.TabIndex = 22;
            this.tlsSociedadSeleccionada.DoubleClick += new System.EventHandler(this.tlsSociedadSeleccionada_DoubleClick);
            // 
            // lblSociedad
            // 
            this.lblSociedad.AutoSize = false;
            this.lblSociedad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblSociedad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSociedad.Name = "lblSociedad";
            this.lblSociedad.Size = new System.Drawing.Size(70, 32);
            this.lblSociedad.Text = "Sociedad:";
            this.lblSociedad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumeroSociedadSeleccionada
            // 
            this.lblNumeroSociedadSeleccionada.AutoSize = false;
            this.lblNumeroSociedadSeleccionada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblNumeroSociedadSeleccionada.Name = "lblNumeroSociedadSeleccionada";
            this.lblNumeroSociedadSeleccionada.Size = new System.Drawing.Size(150, 32);
            this.lblNumeroSociedadSeleccionada.Text = "0000001";
            this.lblNumeroSociedadSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreSociedad
            // 
            this.lblNombreSociedad.AutoSize = false;
            this.lblNombreSociedad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblNombreSociedad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreSociedad.Name = "lblNombreSociedad";
            this.lblNombreSociedad.Size = new System.Drawing.Size(170, 32);
            this.lblNombreSociedad.Text = "Nombre de la Sociedad:";
            this.lblNombreSociedad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreSociedadSeleccionada
            // 
            this.lblNombreSociedadSeleccionada.AutoSize = false;
            this.lblNombreSociedadSeleccionada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblNombreSociedadSeleccionada.Name = "lblNombreSociedadSeleccionada";
            this.lblNombreSociedadSeleccionada.Size = new System.Drawing.Size(590, 32);
            this.lblNombreSociedadSeleccionada.Text = "Sociedad de Prueba";
            this.lblNombreSociedadSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::SATeC.Properties.Resources.SATeC_Transparente;
            this.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(144, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 657);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.tlsSociedadSeleccionada);
            this.Controls.Add(this.picMainBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATeC - Contabilidad por Medios Electrónicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainBackground)).EndInit();
            this.tlsSociedadSeleccionada.ResumeLayout(false);
            this.tlsSociedadSeleccionada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblIDUsuario;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion;
        private System.Windows.Forms.PictureBox picMainBackground;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_Sociedades;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_CatalogosCuentas;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_CatalogosCuentasAuxiliares;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_EjerciciosPeriodos;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogoDeCuentas;
        private System.Windows.Forms.ToolStripMenuItem mnuBalanza;
        private System.Windows.Forms.ToolStripMenuItem mnuPolizas;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripTextBox mnuTextboxBlank;
        private System.Windows.Forms.ToolStrip tlsSociedadSeleccionada;
        private System.Windows.Forms.ToolStripLabel lblSociedad;
        private System.Windows.Forms.ToolStripLabel lblNumeroSociedadSeleccionada;
        private System.Windows.Forms.ToolStripLabel lblNombreSociedad;
        private System.Windows.Forms.ToolStripLabel lblNombreSociedadSeleccionada;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSociedad;
		private System.Windows.Forms.ToolStripMenuItem mnuCatalogoDeCuentas_ConvertirCatalogoCodigoAgrupadorDeCuentasSAT;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogoDeCuentas_ConsultarCatalogosFormatoXML;
        private System.Windows.Forms.ToolStripMenuItem enviarCatálogoDeCuentasAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCatálogosEnviadosAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBalanza_ImportarBalanza;
		private System.Windows.Forms.ToolStripMenuItem mnuBalanza_ValidarBalanzaImportadaConCatalogoCuentasSociedad;
		private System.Windows.Forms.ToolStripMenuItem mnuBalanza_ValidarBalanzaImportadaConCodigoAgrupadorSAT;
        private System.Windows.Forms.ToolStripMenuItem mnuBalanza_ConsultarBalanzaImportadaConFormatoXML;
        private System.Windows.Forms.ToolStripMenuItem enviarLaBalanzaAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLasBalanzasEnviadasAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPolizas_ImportarPolizas;
		private System.Windows.Forms.ToolStripMenuItem mnuPolizas_ValidarPolizas;
        private System.Windows.Forms.ToolStripMenuItem mnuPolizas_ConsultarPolizasFormatoXML;
        private System.Windows.Forms.ToolStripMenuItem enviarLasPólizasAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLasPólizasEnviadasAlSATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracionCatalogoCuentasSAT;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogoDeCuentas_ConsultarCatalogoCuentasSAT;
		private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_BorrarBaseDeDatos;
		private System.Windows.Forms.ToolStripMenuItem mnuPolizas_ImportarDatosComplementarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_CargaMapeoCuentas;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion_mapeoMetodosPago;
    }
}