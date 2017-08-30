namespace SATeC.Administracion {
    partial class frmCatalogoDeCuentas_Datos {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.White, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Nuevo", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Yellow, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Existente", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Error", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombreCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.lblNombreCatalogoCuentas = new System.Windows.Forms.Label();
            this.lblCuentaSubCuenta = new System.Windows.Forms.Label();
            this.txtNumeroCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtIDCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.lblArchivoCatalogoCuentas = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.cmdAbrirArchivo = new System.Windows.Forms.Button();
            this.txtPathArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvCatalogoCuentas = new SATeC.SATecDataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YaGuardado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Almacenado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCatalogoCuentas
            // 
            this.txtNombreCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtNombreCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtNombreCatalogoCuentas.Location = new System.Drawing.Point(279, 51);
            this.txtNombreCatalogoCuentas.MaxLength = 200;
            this.txtNombreCatalogoCuentas.Multiline = true;
            this.txtNombreCatalogoCuentas.Name = "txtNombreCatalogoCuentas";
            this.txtNombreCatalogoCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombreCatalogoCuentas.Size = new System.Drawing.Size(355, 90);
            this.txtNombreCatalogoCuentas.TabIndex = 1;
            this.txtNombreCatalogoCuentas.Text = "123456789012345678901234567890123456789012345678901234567890123456789012345678901" +
    "23456789012345678901234567890123456789012345678901234567890123456789012345678901" +
    "234567890123456789012345678901234567890";
            // 
            // lblNombreCatalogoCuentas
            // 
            this.lblNombreCatalogoCuentas.AutoSize = true;
            this.lblNombreCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.lblNombreCatalogoCuentas.Location = new System.Drawing.Point(12, 51);
            this.lblNombreCatalogoCuentas.Name = "lblNombreCatalogoCuentas";
            this.lblNombreCatalogoCuentas.Size = new System.Drawing.Size(216, 19);
            this.lblNombreCatalogoCuentas.TabIndex = 10;
            this.lblNombreCatalogoCuentas.Text = "Nombre del Catálogo de Cuentas:";
            // 
            // lblCuentaSubCuenta
            // 
            this.lblCuentaSubCuenta.AutoSize = true;
            this.lblCuentaSubCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaSubCuenta.ForeColor = System.Drawing.Color.White;
            this.lblCuentaSubCuenta.Location = new System.Drawing.Point(88, 20);
            this.lblCuentaSubCuenta.Name = "lblCuentaSubCuenta";
            this.lblCuentaSubCuenta.Size = new System.Drawing.Size(140, 19);
            this.lblCuentaSubCuenta.TabIndex = 9;
            this.lblCuentaSubCuenta.Text = "Catálogo de Cuentas:";
            // 
            // txtNumeroCatalogoCuentas
            // 
            this.txtNumeroCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtNumeroCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtNumeroCatalogoCuentas.Location = new System.Drawing.Point(278, 21);
            this.txtNumeroCatalogoCuentas.MaxLength = 4;
            this.txtNumeroCatalogoCuentas.Name = "txtNumeroCatalogoCuentas";
            this.txtNumeroCatalogoCuentas.Size = new System.Drawing.Size(35, 25);
            this.txtNumeroCatalogoCuentas.TabIndex = 0;
            this.txtNumeroCatalogoCuentas.Text = "1234";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Image = global::SATeC.Properties.Resources.Cancelar_32x32;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(400, 602);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(120, 40);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.White;
            this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(279, 602);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(115, 40);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtIDCatalogoCuentas
            // 
            this.txtIDCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtIDCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtIDCatalogoCuentas.Location = new System.Drawing.Point(335, 0);
            this.txtIDCatalogoCuentas.MaxLength = 50;
            this.txtIDCatalogoCuentas.Name = "txtIDCatalogoCuentas";
            this.txtIDCatalogoCuentas.Size = new System.Drawing.Size(261, 18);
            this.txtIDCatalogoCuentas.TabIndex = 8;
            this.txtIDCatalogoCuentas.TabStop = false;
            this.txtIDCatalogoCuentas.Text = "IDCatalogoCuentas";
            this.txtIDCatalogoCuentas.Visible = false;
            // 
            // lblArchivoCatalogoCuentas
            // 
            this.lblArchivoCatalogoCuentas.AutoSize = true;
            this.lblArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.lblArchivoCatalogoCuentas.Location = new System.Drawing.Point(16, 151);
            this.lblArchivoCatalogoCuentas.Name = "lblArchivoCatalogoCuentas";
            this.lblArchivoCatalogoCuentas.Size = new System.Drawing.Size(212, 19);
            this.lblArchivoCatalogoCuentas.TabIndex = 11;
            this.lblArchivoCatalogoCuentas.Text = "Archivo del Catálogo de Cuentas:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArchivoCatalogoCuentas
            // 
            this.txtArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtArchivoCatalogoCuentas.Location = new System.Drawing.Point(278, 169);
            this.txtArchivoCatalogoCuentas.MaxLength = 500;
            this.txtArchivoCatalogoCuentas.Name = "txtArchivoCatalogoCuentas";
            this.txtArchivoCatalogoCuentas.ReadOnly = true;
            this.txtArchivoCatalogoCuentas.Size = new System.Drawing.Size(336, 25);
            this.txtArchivoCatalogoCuentas.TabIndex = 12;
            this.txtArchivoCatalogoCuentas.Text = "1234567890";
            // 
            // cmdAbrirArchivo
            // 
            this.cmdAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.Location = new System.Drawing.Point(620, 172);
            this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
            this.cmdAbrirArchivo.Size = new System.Drawing.Size(25, 25);
            this.cmdAbrirArchivo.TabIndex = 3;
            this.cmdAbrirArchivo.Text = "...";
            this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
            this.cmdAbrirArchivo.UseVisualStyleBackColor = true;
            this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
            // 
            // txtPathArchivoCatalogoCuentas
            // 
            this.txtPathArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoCatalogoCuentas.Location = new System.Drawing.Point(20, 174);
            this.txtPathArchivoCatalogoCuentas.MaxLength = 500;
            this.txtPathArchivoCatalogoCuentas.Name = "txtPathArchivoCatalogoCuentas";
            this.txtPathArchivoCatalogoCuentas.ReadOnly = true;
            this.txtPathArchivoCatalogoCuentas.Size = new System.Drawing.Size(336, 18);
            this.txtPathArchivoCatalogoCuentas.TabIndex = 13;
            this.txtPathArchivoCatalogoCuentas.Text = "1234567890";
            this.txtPathArchivoCatalogoCuentas.Visible = false;
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.AutoSize = true;
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.White;
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(280, 144);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(338, 23);
            this.chkPrimerFilaNombresColumnas.TabIndex = 2;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // lstvDescripciones
            // 
            this.lstvDescripciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDescripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lstvDescripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvDescripciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Color,
            this.Descripcion});
            this.lstvDescripciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            listViewItem3.UseItemStyleForSubItems = false;
            this.lstvDescripciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstvDescripciones.Location = new System.Drawing.Point(710, 200);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(124, 87);
            this.lstvDescripciones.TabIndex = 30;
            this.lstvDescripciones.UseCompatibleStateImageBehavior = false;
            this.lstvDescripciones.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 0;
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
            // dgvCatalogoCuentas
            // 
            this.dgvCatalogoCuentas.AllowUserToAddRows = false;
            this.dgvCatalogoCuentas.AllowUserToDeleteRows = false;
            this.dgvCatalogoCuentas.AllowUserToResizeColumns = false;
            this.dgvCatalogoCuentas.AllowUserToResizeRows = false;
            this.dgvCatalogoCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogoCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogoCuentas.ColumnHeadersHeight = 25;
            this.dgvCatalogoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogoCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.DescripcionCuenta,
            this.Naturaleza,
            this.YaGuardado,
            this.Almacenado});
            this.dgvCatalogoCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCatalogoCuentas.EnableHeadersVisualStyles = false;
            this.dgvCatalogoCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.Location = new System.Drawing.Point(12, 200);
            this.dgvCatalogoCuentas.Name = "dgvCatalogoCuentas";
            this.dgvCatalogoCuentas.ReadOnly = true;
            this.dgvCatalogoCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogoCuentas.RowHeadersVisible = false;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCatalogoCuentas.ShowCellErrors = false;
            this.dgvCatalogoCuentas.ShowCellToolTips = false;
            this.dgvCatalogoCuentas.ShowEditingIcon = false;
            this.dgvCatalogoCuentas.Size = new System.Drawing.Size(692, 367);
            this.dgvCatalogoCuentas.TabIndex = 4;
            this.dgvCatalogoCuentas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCatalogoCuentas_RowPostPaint);
            // 
            // Cuenta
            // 
            this.Cuenta.DividerWidth = 1;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 300;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cuenta.Width = 300;
            // 
            // DescripcionCuenta
            // 
            this.DescripcionCuenta.DividerWidth = 1;
            this.DescripcionCuenta.HeaderText = "Descripción de la Cuenta";
            this.DescripcionCuenta.MinimumWidth = 500;
            this.DescripcionCuenta.Name = "DescripcionCuenta";
            this.DescripcionCuenta.ReadOnly = true;
            this.DescripcionCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DescripcionCuenta.Width = 500;
            // 
            // Naturaleza
            // 
            this.Naturaleza.DividerWidth = 1;
            this.Naturaleza.HeaderText = "Naturaleza";
            this.Naturaleza.MinimumWidth = 90;
            this.Naturaleza.Name = "Naturaleza";
            this.Naturaleza.ReadOnly = true;
            this.Naturaleza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Naturaleza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Naturaleza.Width = 90;
            // 
            // YaGuardado
            // 
            this.YaGuardado.HeaderText = "YaGuardado";
            this.YaGuardado.MinimumWidth = 20;
            this.YaGuardado.Name = "YaGuardado";
            this.YaGuardado.ReadOnly = true;
            this.YaGuardado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YaGuardado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.YaGuardado.Width = 20;
            // 
            // Almacenado
            // 
            this.Almacenado.HeaderText = "Almacenado";
            this.Almacenado.Name = "Almacenado";
            this.Almacenado.ReadOnly = true;
            this.Almacenado.Visible = false;
            // 
            // frmCatalogoDeCuentas_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(835, 654);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.txtArchivoCatalogoCuentas);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.dgvCatalogoCuentas);
            this.Controls.Add(this.txtPathArchivoCatalogoCuentas);
            this.Controls.Add(this.cmdAbrirArchivo);
            this.Controls.Add(this.lblArchivoCatalogoCuentas);
            this.Controls.Add(this.txtIDCatalogoCuentas);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtNumeroCatalogoCuentas);
            this.Controls.Add(this.lblCuentaSubCuenta);
            this.Controls.Add(this.txtNombreCatalogoCuentas);
            this.Controls.Add(this.lblNombreCatalogoCuentas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogoDeCuentas_Datos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Catálogo de Cuentas";
            this.Load += new System.EventHandler(this.frmCatalogoDeCuentas_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCatalogoCuentas;
        private System.Windows.Forms.Label lblNombreCatalogoCuentas;
        private System.Windows.Forms.Label lblCuentaSubCuenta;
        private System.Windows.Forms.TextBox txtNumeroCatalogoCuentas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtIDCatalogoCuentas;
        private System.Windows.Forms.Label lblArchivoCatalogoCuentas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArchivoCatalogoCuentas;
        private System.Windows.Forms.Button cmdAbrirArchivo;
        private System.Windows.Forms.TextBox txtPathArchivoCatalogoCuentas;
        private SATecDataGridView dgvCatalogoCuentas;
		private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
		private System.Windows.Forms.ListView lstvDescripciones;
		private System.Windows.Forms.ColumnHeader Index;
		private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naturaleza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YaGuardado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacenado;
    }
}