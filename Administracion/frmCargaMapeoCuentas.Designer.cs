namespace SATeC.Administracion
{
    partial class frmCargaMapeoCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.txtPathArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.cmdImportar = new System.Windows.Forms.Button();
            this.txtArchivoCatalogoCuentas = new System.Windows.Forms.TextBox();
            this.lblSeleccionarArchivo = new System.Windows.Forms.Label();
            this.lblArchivoCatalogoCuentas = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCatalogoCuentas = new System.Windows.Forms.ComboBox();
            this.lblCatalogoDeCuentas = new System.Windows.Forms.Label();
            this.dgvCatalogoCuentas = new SATeC.SATecDataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAgrupador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisteCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(258, 61);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(439, 33);
            this.chkPrimerFilaNombresColumnas.TabIndex = 39;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // txtPathArchivoCatalogoCuentas
            // 
            this.txtPathArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoCatalogoCuentas.Location = new System.Drawing.Point(555, 2);
            this.txtPathArchivoCatalogoCuentas.MaxLength = 500;
            this.txtPathArchivoCatalogoCuentas.Name = "txtPathArchivoCatalogoCuentas";
            this.txtPathArchivoCatalogoCuentas.ReadOnly = true;
            this.txtPathArchivoCatalogoCuentas.Size = new System.Drawing.Size(355, 23);
            this.txtPathArchivoCatalogoCuentas.TabIndex = 38;
            this.txtPathArchivoCatalogoCuentas.Text = "1234567890";
            this.txtPathArchivoCatalogoCuentas.Visible = false;
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
            this.cmdImportar.Location = new System.Drawing.Point(779, 35);
            this.cmdImportar.Name = "cmdImportar";
            this.cmdImportar.Size = new System.Drawing.Size(121, 40);
            this.cmdImportar.TabIndex = 37;
            this.cmdImportar.Text = "Importar";
            this.cmdImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdImportar.UseVisualStyleBackColor = false;
            this.cmdImportar.Click += new System.EventHandler(this.cmdImportar_Click);
            // 
            // txtArchivoCatalogoCuentas
            // 
            this.txtArchivoCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoCatalogoCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.txtArchivoCatalogoCuentas.Location = new System.Drawing.Point(258, 92);
            this.txtArchivoCatalogoCuentas.MaxLength = 500;
            this.txtArchivoCatalogoCuentas.Name = "txtArchivoCatalogoCuentas";
            this.txtArchivoCatalogoCuentas.ReadOnly = true;
            this.txtArchivoCatalogoCuentas.Size = new System.Drawing.Size(325, 23);
            this.txtArchivoCatalogoCuentas.TabIndex = 34;
            this.txtArchivoCatalogoCuentas.Text = "1234567890";
            // 
            // lblSeleccionarArchivo
            // 
            this.lblSeleccionarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblSeleccionarArchivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarArchivo.ForeColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarArchivo.Location = new System.Drawing.Point(589, 92);
            this.lblSeleccionarArchivo.Name = "lblSeleccionarArchivo";
            this.lblSeleccionarArchivo.Size = new System.Drawing.Size(20, 27);
            this.lblSeleccionarArchivo.TabIndex = 35;
            this.lblSeleccionarArchivo.Text = "...";
            this.lblSeleccionarArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSeleccionarArchivo.UseCompatibleTextRendering = true;
            this.lblSeleccionarArchivo.Click += new System.EventHandler(this.lblSeleccionarArchivo_Click);
            // 
            // lblArchivoCatalogoCuentas
            // 
            this.lblArchivoCatalogoCuentas.AutoSize = true;
            this.lblArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblArchivoCatalogoCuentas.Location = new System.Drawing.Point(12, 88);
            this.lblArchivoCatalogoCuentas.Name = "lblArchivoCatalogoCuentas";
            this.lblArchivoCatalogoCuentas.Size = new System.Drawing.Size(244, 23);
            this.lblArchivoCatalogoCuentas.TabIndex = 33;
            this.lblArchivoCatalogoCuentas.Text = "Archivo de Mapeo de Cuentas:";
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
            this.cmdCerrar.Location = new System.Drawing.Point(779, 87);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(121, 40);
            this.cmdCerrar.TabIndex = 31;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
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
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BackColor = System.Drawing.Color.White;
            this.lblModulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModulo.Location = new System.Drawing.Point(5, 2);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(300, 32);
            this.lblModulo.TabIndex = 30;
            this.lblModulo.Text = "Carga Mapeo de Cuentas";
            // 
            // lstvDescripciones
            // 
            this.lstvDescripciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDescripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lstvDescripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvDescripciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.ID,
            this.ColorH,
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
            this.lstvDescripciones.Location = new System.Drawing.Point(743, 133);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(157, 123);
            this.lstvDescripciones.TabIndex = 40;
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
            // ColorH
            // 
            this.ColorH.Text = "Color";
            this.ColorH.Width = 45;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 80;
            // 
            // cmbCatalogoCuentas
            // 
            this.cmbCatalogoCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmbCatalogoCuentas.DisplayMember = "Texto";
            this.cmbCatalogoCuentas.DropDownHeight = 100;
            this.cmbCatalogoCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.cmbCatalogoCuentas.FormattingEnabled = true;
            this.cmbCatalogoCuentas.IntegralHeight = false;
            this.cmbCatalogoCuentas.Location = new System.Drawing.Point(258, 32);
            this.cmbCatalogoCuentas.Name = "cmbCatalogoCuentas";
            this.cmbCatalogoCuentas.Size = new System.Drawing.Size(261, 31);
            this.cmbCatalogoCuentas.TabIndex = 41;
            this.cmbCatalogoCuentas.ValueMember = "Valor";
            // 
            // lblCatalogoDeCuentas
            // 
            this.lblCatalogoDeCuentas.AutoSize = true;
            this.lblCatalogoDeCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoDeCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblCatalogoDeCuentas.Location = new System.Drawing.Point(78, 35);
            this.lblCatalogoDeCuentas.Name = "lblCatalogoDeCuentas";
            this.lblCatalogoDeCuentas.Size = new System.Drawing.Size(174, 23);
            this.lblCatalogoDeCuentas.TabIndex = 42;
            this.lblCatalogoDeCuentas.Text = "Catalogo de Cuentas:";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogoCuentas.ColumnHeadersHeight = 25;
            this.dgvCatalogoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogoCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Subcta,
            this.CodigoAgrupador,
            this.ExisteCuenta,
            this.Fallo});
            this.dgvCatalogoCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogoCuentas.EnableHeadersVisualStyles = false;
            this.dgvCatalogoCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.Location = new System.Drawing.Point(12, 133);
            this.dgvCatalogoCuentas.Name = "dgvCatalogoCuentas";
            this.dgvCatalogoCuentas.ReadOnly = true;
            this.dgvCatalogoCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogoCuentas.RowHeadersVisible = false;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCuentas.ShowCellErrors = false;
            this.dgvCatalogoCuentas.ShowCellToolTips = false;
            this.dgvCatalogoCuentas.ShowEditingIcon = false;
            this.dgvCatalogoCuentas.Size = new System.Drawing.Size(725, 340);
            this.dgvCatalogoCuentas.TabIndex = 32;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 100;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Subcta
            // 
            this.Subcta.HeaderText = "Subcta";
            this.Subcta.MinimumWidth = 100;
            this.Subcta.Name = "Subcta";
            this.Subcta.ReadOnly = true;
            // 
            // CodigoAgrupador
            // 
            this.CodigoAgrupador.HeaderText = "CodigoAgrupador";
            this.CodigoAgrupador.MinimumWidth = 150;
            this.CodigoAgrupador.Name = "CodigoAgrupador";
            this.CodigoAgrupador.ReadOnly = true;
            this.CodigoAgrupador.Width = 150;
            // 
            // ExisteCuenta
            // 
            this.ExisteCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExisteCuenta.DividerWidth = 1;
            this.ExisteCuenta.HeaderText = "ExisteCuenta";
            this.ExisteCuenta.MinimumWidth = 70;
            this.ExisteCuenta.Name = "ExisteCuenta";
            this.ExisteCuenta.ReadOnly = true;
            this.ExisteCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExisteCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExisteCuenta.Visible = false;
            this.ExisteCuenta.Width = 70;
            // 
            // Fallo
            // 
            this.Fallo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fallo.DividerWidth = 1;
            this.Fallo.HeaderText = "Fallo";
            this.Fallo.MinimumWidth = 500;
            this.Fallo.Name = "Fallo";
            this.Fallo.ReadOnly = true;
            this.Fallo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fallo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fallo.Width = 500;
            // 
            // frmCargaMapeoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 510);
            this.Controls.Add(this.cmbCatalogoCuentas);
            this.Controls.Add(this.lblCatalogoDeCuentas);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.txtPathArchivoCatalogoCuentas);
            this.Controls.Add(this.cmdImportar);
            this.Controls.Add(this.dgvCatalogoCuentas);
            this.Controls.Add(this.txtArchivoCatalogoCuentas);
            this.Controls.Add(this.lblSeleccionarArchivo);
            this.Controls.Add(this.lblArchivoCatalogoCuentas);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargaMapeoCuentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Carga Mapeo Cuentas";
            this.Load += new System.EventHandler(this.frmCargaMapeoCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
        private System.Windows.Forms.TextBox txtPathArchivoCatalogoCuentas;
        private System.Windows.Forms.Button cmdImportar;
        private SATecDataGridView dgvCatalogoCuentas;
        //private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.TextBox txtArchivoCatalogoCuentas;
        private System.Windows.Forms.Label lblSeleccionarArchivo;
        private System.Windows.Forms.Label lblArchivoCatalogoCuentas;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ListView lstvDescripciones;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ColorH;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ComboBox cmbCatalogoCuentas;
        private System.Windows.Forms.Label lblCatalogoDeCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExisteCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fallo;

    }
}