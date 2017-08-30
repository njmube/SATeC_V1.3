namespace SATeC.Administracion {
    partial class frmCargarCatalogoCuentasSAT {
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "  ",
            "",
            "     "}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.White, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Nuevo", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Yellow, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Existente", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Error", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblModulo = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.txtArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.lblArchivoCatalogoCuentas = new System.Windows.Forms.Label();
            this.lblSeleccionarArchivo = new System.Windows.Forms.Label();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdImportar = new System.Windows.Forms.Button();
            this.txtPathArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.dgvCatalogoCuentasSAT = new SATeC.SATecDataGridView();
            this.IDCuentaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAgrupador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nueva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentasSAT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BackColor = System.Drawing.Color.White;
            this.lblModulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModulo.Location = new System.Drawing.Point(1, 3);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(341, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogo de Cuentas del SAT";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Borrar";
            this.dataGridViewImageColumn1.Image = global::SATeC.Properties.Resources.Borrar_24x24;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdCerrar.FlatAppearance.BorderSize = 0;
            this.cmdCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.ForeColor = System.Drawing.Color.White;
            this.cmdCerrar.Image = global::SATeC.Properties.Resources.Cerrar_32x32;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(751, 143);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(121, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // txtArchivoCatalogoCuentas
            // 
            this.txtArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtArchivoCatalogoCuentas.Location = new System.Drawing.Point(264, 72);
            this.txtArchivoCatalogoCuentas.MaxLength = 500;
            this.txtArchivoCatalogoCuentas.Name = "txtArchivoCatalogoCuentas";
            this.txtArchivoCatalogoCuentas.ReadOnly = true;
            this.txtArchivoCatalogoCuentas.Size = new System.Drawing.Size(355, 23);
            this.txtArchivoCatalogoCuentas.TabIndex = 23;
            this.txtArchivoCatalogoCuentas.Text = "1234567890";
            // 
            // lblArchivoCatalogoCuentas
            // 
            this.lblArchivoCatalogoCuentas.AutoSize = true;
            this.lblArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblArchivoCatalogoCuentas.Location = new System.Drawing.Point(-4, 46);
            this.lblArchivoCatalogoCuentas.Name = "lblArchivoCatalogoCuentas";
            this.lblArchivoCatalogoCuentas.Size = new System.Drawing.Size(264, 23);
            this.lblArchivoCatalogoCuentas.TabIndex = 22;
            this.lblArchivoCatalogoCuentas.Text = "Archivo del Catálogo de Cuentas:";
            // 
            // lblSeleccionarArchivo
            // 
            this.lblSeleccionarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblSeleccionarArchivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarArchivo.ForeColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarArchivo.Location = new System.Drawing.Point(625, 72);
            this.lblSeleccionarArchivo.Name = "lblSeleccionarArchivo";
            this.lblSeleccionarArchivo.Size = new System.Drawing.Size(25, 22);
            this.lblSeleccionarArchivo.TabIndex = 25;
            this.lblSeleccionarArchivo.Text = "...";
            this.lblSeleccionarArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSeleccionarArchivo.UseCompatibleTextRendering = true;
            this.lblSeleccionarArchivo.Click += new System.EventHandler(this.lblSeleccionarArchivo_Click);
            // 
            // lstvDescripciones
            // 
            this.lstvDescripciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDescripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lstvDescripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvDescripciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.ID,
            this.Color,
            this.Descripcion});
            this.lstvDescripciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem5.UseItemStyleForSubItems = false;
            listViewItem6.UseItemStyleForSubItems = false;
            listViewItem7.UseItemStyleForSubItems = false;
            listViewItem8.UseItemStyleForSubItems = false;
            this.lstvDescripciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lstvDescripciones.Location = new System.Drawing.Point(751, 250);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(144, 124);
            this.lstvDescripciones.TabIndex = 26;
            this.lstvDescripciones.UseCompatibleStateImageBehavior = false;
            this.lstvDescripciones.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 1;
            // 
            // ID
            // 
            this.ID.Width = 5;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 45;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 80;
            // 
            // cmdImportar
            // 
            this.cmdImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdImportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdImportar.FlatAppearance.BorderSize = 0;
            this.cmdImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImportar.ForeColor = System.Drawing.Color.White;
            this.cmdImportar.Image = global::SATeC.Properties.Resources.Agregar_32x32;
            this.cmdImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImportar.Location = new System.Drawing.Point(751, 97);
            this.cmdImportar.Name = "cmdImportar";
            this.cmdImportar.Size = new System.Drawing.Size(123, 40);
            this.cmdImportar.TabIndex = 27;
            this.cmdImportar.Text = "Importar";
            this.cmdImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdImportar.UseVisualStyleBackColor = false;
            this.cmdImportar.Click += new System.EventHandler(this.cmdImportar_Click);
            // 
            // txtPathArchivoCatalogoCuentas
            // 
            this.txtPathArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoCatalogoCuentas.Location = new System.Drawing.Point(348, 10);
            this.txtPathArchivoCatalogoCuentas.MaxLength = 500;
            this.txtPathArchivoCatalogoCuentas.Name = "txtPathArchivoCatalogoCuentas";
            this.txtPathArchivoCatalogoCuentas.ReadOnly = true;
            this.txtPathArchivoCatalogoCuentas.Size = new System.Drawing.Size(355, 23);
            this.txtPathArchivoCatalogoCuentas.TabIndex = 28;
            this.txtPathArchivoCatalogoCuentas.Text = "1234567890";
            this.txtPathArchivoCatalogoCuentas.Visible = false;
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(264, 44);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(338, 25);
            this.chkPrimerFilaNombresColumnas.TabIndex = 29;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // dgvCatalogoCuentasSAT
            // 
            this.dgvCatalogoCuentasSAT.AllowUserToAddRows = false;
            this.dgvCatalogoCuentasSAT.AllowUserToDeleteRows = false;
            this.dgvCatalogoCuentasSAT.AllowUserToResizeColumns = false;
            this.dgvCatalogoCuentasSAT.AllowUserToResizeRows = false;
            this.dgvCatalogoCuentasSAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogoCuentasSAT.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasSAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoCuentasSAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogoCuentasSAT.ColumnHeadersHeight = 25;
            this.dgvCatalogoCuentasSAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogoCuentasSAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCuentaSAT,
            this.CodigoAgrupador,
            this.NombreCuenta,
            this.Nueva,
            this.Error});
            this.dgvCatalogoCuentasSAT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogoCuentasSAT.EnableHeadersVisualStyles = false;
            this.dgvCatalogoCuentasSAT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasSAT.Location = new System.Drawing.Point(0, 97);
            this.dgvCatalogoCuentasSAT.Name = "dgvCatalogoCuentasSAT";
            this.dgvCatalogoCuentasSAT.ReadOnly = true;
            this.dgvCatalogoCuentasSAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogoCuentasSAT.RowHeadersVisible = false;
            this.dgvCatalogoCuentasSAT.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasSAT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogoCuentasSAT.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasSAT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasSAT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasSAT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoCuentasSAT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCatalogoCuentasSAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCuentasSAT.ShowCellErrors = false;
            this.dgvCatalogoCuentasSAT.ShowCellToolTips = false;
            this.dgvCatalogoCuentasSAT.ShowEditingIcon = false;
            this.dgvCatalogoCuentasSAT.Size = new System.Drawing.Size(724, 397);
            this.dgvCatalogoCuentasSAT.TabIndex = 20;
            // 
            // IDCuentaSAT
            // 
            this.IDCuentaSAT.DividerWidth = 1;
            this.IDCuentaSAT.HeaderText = "IDCuentaSAT";
            this.IDCuentaSAT.Name = "IDCuentaSAT";
            this.IDCuentaSAT.ReadOnly = true;
            this.IDCuentaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDCuentaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CodigoAgrupador
            // 
            this.CodigoAgrupador.DividerWidth = 1;
            this.CodigoAgrupador.HeaderText = "Código Agrupador";
            this.CodigoAgrupador.MinimumWidth = 200;
            this.CodigoAgrupador.Name = "CodigoAgrupador";
            this.CodigoAgrupador.ReadOnly = true;
            this.CodigoAgrupador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoAgrupador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoAgrupador.Width = 200;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.DividerWidth = 1;
            this.NombreCuenta.HeaderText = "Nombre de la Cuenta";
            this.NombreCuenta.MinimumWidth = 500;
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            this.NombreCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCuenta.Width = 500;
            // 
            // Nueva
            // 
            this.Nueva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nueva.DividerWidth = 1;
            this.Nueva.HeaderText = "Nueva";
            this.Nueva.MinimumWidth = 70;
            this.Nueva.Name = "Nueva";
            this.Nueva.ReadOnly = true;
            this.Nueva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nueva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nueva.Width = 70;
            // 
            // Error
            // 
            this.Error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Error.DividerWidth = 1;
            this.Error.HeaderText = "Error";
            this.Error.MinimumWidth = 60;
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            this.Error.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Error.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Error.Width = 60;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::SATeC.Properties.Resources.Borrar_24x24;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(753, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 40);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCargarCatalogoCuentasSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 501);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtArchivoCatalogoCuentas);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.txtPathArchivoCatalogoCuentas);
            this.Controls.Add(this.cmdImportar);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.lblSeleccionarArchivo);
            this.Controls.Add(this.lblArchivoCatalogoCuentas);
            this.Controls.Add(this.dgvCatalogoCuentasSAT);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarCatalogoCuentasSAT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas";
            this.Load += new System.EventHandler(this.frmCargarCatalogoCuentasSAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentasSAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvCatalogoCuentasSAT;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txtArchivoCatalogoCuentas;
        private System.Windows.Forms.Label lblArchivoCatalogoCuentas;
        private System.Windows.Forms.Label lblSeleccionarArchivo;
        private System.Windows.Forms.ListView lstvDescripciones;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.Button cmdImportar;
        private System.Windows.Forms.TextBox txtPathArchivoCatalogoCuentas;
        private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
		private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCuentaSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.Button btnEliminar;
    }
}