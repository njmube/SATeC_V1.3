namespace SATeC.Administracion {
    partial class frmCatalogoDeCuentasAuxiliares_Datos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtNombreCatalogoCuentasAuxiliares = new System.Windows.Forms.TextBox();
            this.lblNombreCuentaAuxiliar_SubCuenta = new System.Windows.Forms.Label();
            this.lblNumeroCatalogoCuentasAuxiliar = new System.Windows.Forms.Label();
            this.txtNumeroCatalogoCuentasAuxiliar = new System.Windows.Forms.TextBox();
            this.lblCatalogoDeCuentas = new System.Windows.Forms.Label();
            this.cmbCatalogoCuentas = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtIDCatalogoCuentasAuxiliares = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.txtPathArchivoCatalogoCuentasAuxiliares = new System.Windows.Forms.TextBox();
            this.cmdAbrirArchivo = new System.Windows.Forms.Button();
            this.txtArchivoCatalogoCuentasAuxiliares = new System.Windows.Forms.TextBox();
            this.lblArchivoCatalogoCuentas = new System.Windows.Forms.Label();
            this.dgvCatalogoCuentasAuxiliares = new SATeC.SATecDataGridView();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CuentaPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaAuxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCuentaAuxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturalezaCuentaAuxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YaGuardado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExisteCuentaPadre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Almacenado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentasAuxiliares)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCatalogoCuentasAuxiliares
            // 
            this.txtNombreCatalogoCuentasAuxiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtNombreCatalogoCuentasAuxiliares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCatalogoCuentasAuxiliares.ForeColor = System.Drawing.Color.White;
            this.txtNombreCatalogoCuentasAuxiliares.Location = new System.Drawing.Point(340, 51);
            this.txtNombreCatalogoCuentasAuxiliares.MaxLength = 200;
            this.txtNombreCatalogoCuentasAuxiliares.Multiline = true;
            this.txtNombreCatalogoCuentasAuxiliares.Name = "txtNombreCatalogoCuentasAuxiliares";
            this.txtNombreCatalogoCuentasAuxiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombreCatalogoCuentasAuxiliares.Size = new System.Drawing.Size(355, 90);
            this.txtNombreCatalogoCuentasAuxiliares.TabIndex = 1;
            this.txtNombreCatalogoCuentasAuxiliares.Text = "123456789012345678901234567890123456789012345678901234567890123456789012345678901" +
    "23456789012345678901234567890123456789012345678901234567890123456789012345678901" +
    "234567890123456789012345678901234567890";
            // 
            // lblNombreCuentaAuxiliar_SubCuenta
            // 
            this.lblNombreCuentaAuxiliar_SubCuenta.AutoSize = true;
            this.lblNombreCuentaAuxiliar_SubCuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCuentaAuxiliar_SubCuenta.ForeColor = System.Drawing.Color.White;
            this.lblNombreCuentaAuxiliar_SubCuenta.Location = new System.Drawing.Point(12, 51);
            this.lblNombreCuentaAuxiliar_SubCuenta.Name = "lblNombreCuentaAuxiliar_SubCuenta";
            this.lblNombreCuentaAuxiliar_SubCuenta.Size = new System.Drawing.Size(331, 23);
            this.lblNombreCuentaAuxiliar_SubCuenta.TabIndex = 10;
            this.lblNombreCuentaAuxiliar_SubCuenta.Text = "Nombre del Catálogo de Cuentas Auxiliar:";
            // 
            // lblNumeroCatalogoCuentasAuxiliar
            // 
            this.lblNumeroCatalogoCuentasAuxiliar.AutoSize = true;
            this.lblNumeroCatalogoCuentasAuxiliar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCatalogoCuentasAuxiliar.ForeColor = System.Drawing.Color.White;
            this.lblNumeroCatalogoCuentasAuxiliar.Location = new System.Drawing.Point(88, 21);
            this.lblNumeroCatalogoCuentasAuxiliar.Name = "lblNumeroCatalogoCuentasAuxiliar";
            this.lblNumeroCatalogoCuentasAuxiliar.Size = new System.Drawing.Size(235, 23);
            this.lblNumeroCatalogoCuentasAuxiliar.TabIndex = 9;
            this.lblNumeroCatalogoCuentasAuxiliar.Text = "Catálogo de Cuentas Auxiliar:";
            // 
            // txtNumeroCatalogoCuentasAuxiliar
            // 
            this.txtNumeroCatalogoCuentasAuxiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtNumeroCatalogoCuentasAuxiliar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCatalogoCuentasAuxiliar.ForeColor = System.Drawing.Color.White;
            this.txtNumeroCatalogoCuentasAuxiliar.Location = new System.Drawing.Point(340, 21);
            this.txtNumeroCatalogoCuentasAuxiliar.MaxLength = 10;
            this.txtNumeroCatalogoCuentasAuxiliar.Name = "txtNumeroCatalogoCuentasAuxiliar";
            this.txtNumeroCatalogoCuentasAuxiliar.Size = new System.Drawing.Size(80, 30);
            this.txtNumeroCatalogoCuentasAuxiliar.TabIndex = 0;
            this.txtNumeroCatalogoCuentasAuxiliar.Text = "1234567890";
            // 
            // lblCatalogoDeCuentas
            // 
            this.lblCatalogoDeCuentas.AutoSize = true;
            this.lblCatalogoDeCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoDeCuentas.ForeColor = System.Drawing.Color.White;
            this.lblCatalogoDeCuentas.Location = new System.Drawing.Point(136, 150);
            this.lblCatalogoDeCuentas.Name = "lblCatalogoDeCuentas";
            this.lblCatalogoDeCuentas.Size = new System.Drawing.Size(174, 23);
            this.lblCatalogoDeCuentas.TabIndex = 11;
            this.lblCatalogoDeCuentas.Text = "Catalogo de Cuentas:";
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
            this.cmbCatalogoCuentas.Location = new System.Drawing.Point(336, 147);
            this.cmbCatalogoCuentas.Name = "cmbCatalogoCuentas";
            this.cmbCatalogoCuentas.Size = new System.Drawing.Size(355, 31);
            this.cmbCatalogoCuentas.TabIndex = 2;
            this.cmbCatalogoCuentas.ValueMember = "Valor";
            this.cmbCatalogoCuentas.SelectedIndexChanged += new System.EventHandler(this.cmbCatalogoCuentas_SelectedIndexChanged);
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
            this.cmdCancelar.Location = new System.Drawing.Point(475, 612);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(137, 40);
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
            this.cmdGuardar.Location = new System.Drawing.Point(353, 612);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(116, 40);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtIDCatalogoCuentasAuxiliares
            // 
            this.txtIDCatalogoCuentasAuxiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtIDCatalogoCuentasAuxiliares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCatalogoCuentasAuxiliares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCatalogoCuentasAuxiliares.ForeColor = System.Drawing.Color.White;
            this.txtIDCatalogoCuentasAuxiliares.Location = new System.Drawing.Point(380, 0);
            this.txtIDCatalogoCuentasAuxiliares.MaxLength = 50;
            this.txtIDCatalogoCuentasAuxiliares.Name = "txtIDCatalogoCuentasAuxiliares";
            this.txtIDCatalogoCuentasAuxiliares.Size = new System.Drawing.Size(261, 23);
            this.txtIDCatalogoCuentasAuxiliares.TabIndex = 8;
            this.txtIDCatalogoCuentasAuxiliares.TabStop = false;
            this.txtIDCatalogoCuentasAuxiliares.Text = "IDCatalogoCuentasAuxiliares";
            this.txtIDCatalogoCuentasAuxiliares.Visible = false;
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.AutoSize = true;
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.White;
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(332, 183);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(421, 27);
            this.chkPrimerFilaNombresColumnas.TabIndex = 3;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // txtPathArchivoCatalogoCuentasAuxiliares
            // 
            this.txtPathArchivoCatalogoCuentasAuxiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoCatalogoCuentasAuxiliares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoCatalogoCuentasAuxiliares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoCatalogoCuentasAuxiliares.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoCatalogoCuentasAuxiliares.Location = new System.Drawing.Point(282, 216);
            this.txtPathArchivoCatalogoCuentasAuxiliares.MaxLength = 500;
            this.txtPathArchivoCatalogoCuentasAuxiliares.Name = "txtPathArchivoCatalogoCuentasAuxiliares";
            this.txtPathArchivoCatalogoCuentasAuxiliares.ReadOnly = true;
            this.txtPathArchivoCatalogoCuentasAuxiliares.Size = new System.Drawing.Size(336, 23);
            this.txtPathArchivoCatalogoCuentasAuxiliares.TabIndex = 14;
            this.txtPathArchivoCatalogoCuentasAuxiliares.Text = "1234567890";
            this.txtPathArchivoCatalogoCuentasAuxiliares.Visible = false;
            // 
            // cmdAbrirArchivo
            // 
            this.cmdAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.Location = new System.Drawing.Point(676, 211);
            this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
            this.cmdAbrirArchivo.Size = new System.Drawing.Size(25, 25);
            this.cmdAbrirArchivo.TabIndex = 4;
            this.cmdAbrirArchivo.Text = "...";
            this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
            this.cmdAbrirArchivo.UseVisualStyleBackColor = true;
            this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
            // 
            // txtArchivoCatalogoCuentasAuxiliares
            // 
            this.txtArchivoCatalogoCuentasAuxiliares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoCatalogoCuentasAuxiliares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoCatalogoCuentasAuxiliares.ForeColor = System.Drawing.Color.White;
            this.txtArchivoCatalogoCuentasAuxiliares.Location = new System.Drawing.Point(335, 209);
            this.txtArchivoCatalogoCuentasAuxiliares.MaxLength = 500;
            this.txtArchivoCatalogoCuentasAuxiliares.Name = "txtArchivoCatalogoCuentasAuxiliares";
            this.txtArchivoCatalogoCuentasAuxiliares.ReadOnly = true;
            this.txtArchivoCatalogoCuentasAuxiliares.Size = new System.Drawing.Size(336, 30);
            this.txtArchivoCatalogoCuentasAuxiliares.TabIndex = 0;
            this.txtArchivoCatalogoCuentasAuxiliares.Text = "1234567890";
            // 
            // lblArchivoCatalogoCuentas
            // 
            this.lblArchivoCatalogoCuentas.AutoSize = true;
            this.lblArchivoCatalogoCuentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoCatalogoCuentas.ForeColor = System.Drawing.Color.White;
            this.lblArchivoCatalogoCuentas.Location = new System.Drawing.Point(62, 186);
            this.lblArchivoCatalogoCuentas.Name = "lblArchivoCatalogoCuentas";
            this.lblArchivoCatalogoCuentas.Size = new System.Drawing.Size(264, 23);
            this.lblArchivoCatalogoCuentas.TabIndex = 12;
            this.lblArchivoCatalogoCuentas.Text = "Archivo del Catálogo de Cuentas:";
            // 
            // dgvCatalogoCuentasAuxiliares
            // 
            this.dgvCatalogoCuentasAuxiliares.AllowUserToAddRows = false;
            this.dgvCatalogoCuentasAuxiliares.AllowUserToDeleteRows = false;
            this.dgvCatalogoCuentasAuxiliares.AllowUserToResizeColumns = false;
            this.dgvCatalogoCuentasAuxiliares.AllowUserToResizeRows = false;
            this.dgvCatalogoCuentasAuxiliares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogoCuentasAuxiliares.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasAuxiliares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoCuentasAuxiliares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogoCuentasAuxiliares.ColumnHeadersHeight = 25;
            this.dgvCatalogoCuentasAuxiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogoCuentasAuxiliares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuentaPadre,
            this.CuentaAuxiliar,
            this.DescripcionCuentaAuxiliar,
            this.NaturalezaCuentaAuxiliar,
            this.YaGuardado,
            this.ExisteCuentaPadre,
            this.Almacenado});
            this.dgvCatalogoCuentasAuxiliares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCatalogoCuentasAuxiliares.EnableHeadersVisualStyles = false;
            this.dgvCatalogoCuentasAuxiliares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasAuxiliares.Location = new System.Drawing.Point(3, 240);
            this.dgvCatalogoCuentasAuxiliares.Name = "dgvCatalogoCuentasAuxiliares";
            this.dgvCatalogoCuentasAuxiliares.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogoCuentasAuxiliares.RowHeadersVisible = false;
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogoCuentasAuxiliares.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoCuentasAuxiliares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCuentasAuxiliares.ShowCellErrors = false;
            this.dgvCatalogoCuentasAuxiliares.ShowCellToolTips = false;
            this.dgvCatalogoCuentasAuxiliares.ShowEditingIcon = false;
            this.dgvCatalogoCuentasAuxiliares.Size = new System.Drawing.Size(783, 366);
            this.dgvCatalogoCuentasAuxiliares.TabIndex = 5;
            this.dgvCatalogoCuentasAuxiliares.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCatalogoCuentasAuxiliares_RowPostPaint);
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
            this.lstvDescripciones.Location = new System.Drawing.Point(792, 240);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(144, 84);
            this.lstvDescripciones.TabIndex = 31;
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
            // CuentaPadre
            // 
            this.CuentaPadre.HeaderText = "Cuenta Padre";
            this.CuentaPadre.MinimumWidth = 100;
            this.CuentaPadre.Name = "CuentaPadre";
            this.CuentaPadre.ReadOnly = true;
            this.CuentaPadre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaPadre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CuentaAuxiliar
            // 
            this.CuentaAuxiliar.DividerWidth = 1;
            this.CuentaAuxiliar.HeaderText = "Cuenta Auxiliar";
            this.CuentaAuxiliar.MinimumWidth = 110;
            this.CuentaAuxiliar.Name = "CuentaAuxiliar";
            this.CuentaAuxiliar.ReadOnly = true;
            this.CuentaAuxiliar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaAuxiliar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaAuxiliar.Width = 110;
            // 
            // DescripcionCuentaAuxiliar
            // 
            this.DescripcionCuentaAuxiliar.DividerWidth = 1;
            this.DescripcionCuentaAuxiliar.HeaderText = "Descripción de la Cuenta Auxiliar";
            this.DescripcionCuentaAuxiliar.MinimumWidth = 310;
            this.DescripcionCuentaAuxiliar.Name = "DescripcionCuentaAuxiliar";
            this.DescripcionCuentaAuxiliar.ReadOnly = true;
            this.DescripcionCuentaAuxiliar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionCuentaAuxiliar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DescripcionCuentaAuxiliar.Width = 310;
            // 
            // NaturalezaCuentaAuxiliar
            // 
            this.NaturalezaCuentaAuxiliar.DividerWidth = 1;
            this.NaturalezaCuentaAuxiliar.HeaderText = "Naturaleza";
            this.NaturalezaCuentaAuxiliar.MinimumWidth = 90;
            this.NaturalezaCuentaAuxiliar.Name = "NaturalezaCuentaAuxiliar";
            this.NaturalezaCuentaAuxiliar.ReadOnly = true;
            this.NaturalezaCuentaAuxiliar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NaturalezaCuentaAuxiliar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NaturalezaCuentaAuxiliar.Width = 90;
            // 
            // YaGuardado
            // 
            this.YaGuardado.HeaderText = "YaGuardado";
            this.YaGuardado.MinimumWidth = 50;
            this.YaGuardado.Name = "YaGuardado";
            this.YaGuardado.ReadOnly = true;
            this.YaGuardado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YaGuardado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.YaGuardado.Width = 50;
            // 
            // ExisteCuentaPadre
            // 
            this.ExisteCuentaPadre.HeaderText = "ExisteCuentaPadre";
            this.ExisteCuentaPadre.MinimumWidth = 50;
            this.ExisteCuentaPadre.Name = "ExisteCuentaPadre";
            this.ExisteCuentaPadre.ReadOnly = true;
            this.ExisteCuentaPadre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExisteCuentaPadre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ExisteCuentaPadre.Width = 50;
            // 
            // Almacenado
            // 
            this.Almacenado.HeaderText = "Almacenado";
            this.Almacenado.Name = "Almacenado";
            this.Almacenado.ReadOnly = true;
            this.Almacenado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Almacenado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Almacenado.Visible = false;
            // 
            // frmCatalogoDeCuentasAuxiliares_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(948, 664);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.txtArchivoCatalogoCuentasAuxiliares);
            this.Controls.Add(this.dgvCatalogoCuentasAuxiliares);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.txtPathArchivoCatalogoCuentasAuxiliares);
            this.Controls.Add(this.cmdAbrirArchivo);
            this.Controls.Add(this.lblArchivoCatalogoCuentas);
            this.Controls.Add(this.txtIDCatalogoCuentasAuxiliares);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmbCatalogoCuentas);
            this.Controls.Add(this.lblCatalogoDeCuentas);
            this.Controls.Add(this.txtNumeroCatalogoCuentasAuxiliar);
            this.Controls.Add(this.lblNumeroCatalogoCuentasAuxiliar);
            this.Controls.Add(this.txtNombreCatalogoCuentasAuxiliares);
            this.Controls.Add(this.lblNombreCuentaAuxiliar_SubCuenta);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogoDeCuentasAuxiliares_Datos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Catálogo de Cuentas Auxiliares";
            this.Load += new System.EventHandler(this.frmCatalogosDeCuentasAuxiliares_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCuentasAuxiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCatalogoCuentasAuxiliares;
        private System.Windows.Forms.Label lblNombreCuentaAuxiliar_SubCuenta;
        private System.Windows.Forms.Label lblNumeroCatalogoCuentasAuxiliar;
        private System.Windows.Forms.TextBox txtNumeroCatalogoCuentasAuxiliar;
        private System.Windows.Forms.Label lblCatalogoDeCuentas;
        private System.Windows.Forms.ComboBox cmbCatalogoCuentas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtIDCatalogoCuentasAuxiliares;
        private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
        private System.Windows.Forms.TextBox txtPathArchivoCatalogoCuentasAuxiliares;
        private System.Windows.Forms.Button cmdAbrirArchivo;
        private System.Windows.Forms.TextBox txtArchivoCatalogoCuentasAuxiliares;
        private System.Windows.Forms.Label lblArchivoCatalogoCuentas;
		private SATecDataGridView dgvCatalogoCuentasAuxiliares;
		private System.Windows.Forms.ListView lstvDescripciones;
		private System.Windows.Forms.ColumnHeader Index;
		private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaAuxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCuentaAuxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturalezaCuentaAuxiliar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YaGuardado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExisteCuentaPadre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Almacenado;
    }
}