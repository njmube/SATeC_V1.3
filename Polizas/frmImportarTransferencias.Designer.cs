namespace SATeC.Polizas {
	partial class frmImportarTransferencias {
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
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Error [ Cuenta No Existe / Datos de Bancos Faltantes ]", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Codigo Moneda No Valido", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Clave Banco No Valido", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblArchivoPolizas = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivoTransferencias = new System.Windows.Forms.TextBox();
            this.cmdAbrirArchivo = new System.Windows.Forms.Button();
            this.txtPathArchivoTransferencias = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvTransferencias = new SATeC.SATecDataGridView();
            this.NumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaContablePoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoOrigenNacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoOrigenExtranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoDestinoNacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoDestinoExtranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistePoliza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YaGuardado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BancosValidos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArchivoPolizas
            // 
            this.lblArchivoPolizas.AutoSize = true;
            this.lblArchivoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoPolizas.ForeColor = System.Drawing.Color.White;
            this.lblArchivoPolizas.Location = new System.Drawing.Point(2, 38);
            this.lblArchivoPolizas.Name = "lblArchivoPolizas";
            this.lblArchivoPolizas.Size = new System.Drawing.Size(176, 23);
            this.lblArchivoPolizas.TabIndex = 7;
            this.lblArchivoPolizas.Text = "Archivo de las Pólizas:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArchivoTransferencias
            // 
            this.txtArchivoTransferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoTransferencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoTransferencias.ForeColor = System.Drawing.Color.White;
            this.txtArchivoTransferencias.Location = new System.Drawing.Point(149, 66);
            this.txtArchivoTransferencias.MaxLength = 500;
            this.txtArchivoTransferencias.Name = "txtArchivoTransferencias";
            this.txtArchivoTransferencias.ReadOnly = true;
            this.txtArchivoTransferencias.Size = new System.Drawing.Size(336, 30);
            this.txtArchivoTransferencias.TabIndex = 8;
            this.txtArchivoTransferencias.Text = "1234567890";
            // 
            // cmdAbrirArchivo
            // 
            this.cmdAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.Location = new System.Drawing.Point(484, 66);
            this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
            this.cmdAbrirArchivo.Size = new System.Drawing.Size(25, 25);
            this.cmdAbrirArchivo.TabIndex = 2;
            this.cmdAbrirArchivo.Text = "...";
            this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
            this.cmdAbrirArchivo.UseVisualStyleBackColor = true;
            this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
            // 
            // txtPathArchivoTransferencias
            // 
            this.txtPathArchivoTransferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoTransferencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoTransferencias.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoTransferencias.Location = new System.Drawing.Point(149, 73);
            this.txtPathArchivoTransferencias.MaxLength = 500;
            this.txtPathArchivoTransferencias.Name = "txtPathArchivoTransferencias";
            this.txtPathArchivoTransferencias.ReadOnly = true;
            this.txtPathArchivoTransferencias.Size = new System.Drawing.Size(336, 23);
            this.txtPathArchivoTransferencias.TabIndex = 9;
            this.txtPathArchivoTransferencias.Text = "1234567890";
            this.txtPathArchivoTransferencias.Visible = false;
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.AutoSize = true;
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.White;
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(176, 35);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(421, 27);
            this.chkPrimerFilaNombresColumnas.TabIndex = 1;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // lblEjercicioPeriodo
            // 
            this.lblEjercicioPeriodo.AutoSize = true;
            this.lblEjercicioPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblEjercicioPeriodo.Location = new System.Drawing.Point(25, 9);
            this.lblEjercicioPeriodo.Name = "lblEjercicioPeriodo";
            this.lblEjercicioPeriodo.Size = new System.Drawing.Size(151, 23);
            this.lblEjercicioPeriodo.TabIndex = 6;
            this.lblEjercicioPeriodo.Text = "Ejercicio / Periodo:";
            // 
            // lblEjercicioPeriodoSeleccionado
            // 
            this.lblEjercicioPeriodoSeleccionado.AutoSize = true;
            this.lblEjercicioPeriodoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioPeriodoSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblEjercicioPeriodoSeleccionado.Location = new System.Drawing.Point(145, 9);
            this.lblEjercicioPeriodoSeleccionado.Name = "lblEjercicioPeriodoSeleccionado";
            this.lblEjercicioPeriodoSeleccionado.Size = new System.Drawing.Size(140, 23);
            this.lblEjercicioPeriodoSeleccionado.TabIndex = 10;
            this.lblEjercicioPeriodoSeleccionado.Text = "2014 - 08 Agosto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmdCancelar.Location = new System.Drawing.Point(658, 469);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(123, 40);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.White;
            this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(513, 469);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(119, 40);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            listViewItem4.UseItemStyleForSubItems = false;
            listViewItem5.UseItemStyleForSubItems = false;
            this.lstvDescripciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lstvDescripciones.Location = new System.Drawing.Point(603, 26);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(396, 113);
            this.lstvDescripciones.TabIndex = 28;
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
            this.Descripcion.Width = 700;
            // 
            // dgvTransferencias
            // 
            this.dgvTransferencias.AllowUserToAddRows = false;
            this.dgvTransferencias.AllowUserToDeleteRows = false;
            this.dgvTransferencias.AllowUserToResizeColumns = false;
            this.dgvTransferencias.AllowUserToResizeRows = false;
            this.dgvTransferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransferencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferencias.ColumnHeadersHeight = 25;
            this.dgvTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPoliza,
            this.CuentaContablePoliza,
            this.CuentaOrigen,
            this.BancoOrigenNacional,
            this.BancoOrigenExtranjero,
            this.CuentaDestino,
            this.BancoDestinoNacional,
            this.BancoDestinoExtranjero,
            this.Fecha,
            this.Beneficiario,
            this.RFC,
            this.Monto,
            this.Moneda,
            this.TipodeCambio,
            this.Clave,
            this.ExistePoliza,
            this.YaGuardado,
            this.BancosValidos});
            this.dgvTransferencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTransferencias.EnableHeadersVisualStyles = false;
            this.dgvTransferencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvTransferencias.Location = new System.Drawing.Point(6, 145);
            this.dgvTransferencias.MultiSelect = false;
            this.dgvTransferencias.Name = "dgvTransferencias";
            this.dgvTransferencias.ReadOnly = true;
            this.dgvTransferencias.RowHeadersVisible = false;
            this.dgvTransferencias.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransferencias.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferencias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvTransferencias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvTransferencias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransferencias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferencias.ShowCellErrors = false;
            this.dgvTransferencias.ShowCellToolTips = false;
            this.dgvTransferencias.ShowEditingIcon = false;
            this.dgvTransferencias.Size = new System.Drawing.Size(1265, 296);
            this.dgvTransferencias.TabIndex = 3;
            this.dgvTransferencias.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTransferencias_RowPostPaint);
            // 
            // NumeroPoliza
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.NumeroPoliza.DefaultCellStyle = dataGridViewCellStyle2;
            this.NumeroPoliza.DividerWidth = 1;
            this.NumeroPoliza.HeaderText = "Número de Póliza";
            this.NumeroPoliza.MinimumWidth = 300;
            this.NumeroPoliza.Name = "NumeroPoliza";
            this.NumeroPoliza.ReadOnly = true;
            this.NumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroPoliza.Width = 300;
            // 
            // CuentaContablePoliza
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.CuentaContablePoliza.DefaultCellStyle = dataGridViewCellStyle3;
            this.CuentaContablePoliza.DividerWidth = 1;
            this.CuentaContablePoliza.HeaderText = "Cuenta Contable";
            this.CuentaContablePoliza.MinimumWidth = 200;
            this.CuentaContablePoliza.Name = "CuentaContablePoliza";
            this.CuentaContablePoliza.ReadOnly = true;
            this.CuentaContablePoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaContablePoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaContablePoliza.Width = 200;
            // 
            // CuentaOrigen
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.CuentaOrigen.DefaultCellStyle = dataGridViewCellStyle4;
            this.CuentaOrigen.DividerWidth = 1;
            this.CuentaOrigen.HeaderText = "Cuenta Origen";
            this.CuentaOrigen.MinimumWidth = 200;
            this.CuentaOrigen.Name = "CuentaOrigen";
            this.CuentaOrigen.ReadOnly = true;
            this.CuentaOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaOrigen.Width = 200;
            // 
            // BancoOrigenNacional
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.BancoOrigenNacional.DefaultCellStyle = dataGridViewCellStyle5;
            this.BancoOrigenNacional.DividerWidth = 1;
            this.BancoOrigenNacional.HeaderText = "Banco Origen Nacional";
            this.BancoOrigenNacional.MinimumWidth = 300;
            this.BancoOrigenNacional.Name = "BancoOrigenNacional";
            this.BancoOrigenNacional.ReadOnly = true;
            this.BancoOrigenNacional.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BancoOrigenNacional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BancoOrigenNacional.Width = 300;
            // 
            // BancoOrigenExtranjero
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.BancoOrigenExtranjero.DefaultCellStyle = dataGridViewCellStyle6;
            this.BancoOrigenExtranjero.HeaderText = "Banco Origen Extranjero";
            this.BancoOrigenExtranjero.MinimumWidth = 300;
            this.BancoOrigenExtranjero.Name = "BancoOrigenExtranjero";
            this.BancoOrigenExtranjero.ReadOnly = true;
            this.BancoOrigenExtranjero.Width = 300;
            // 
            // CuentaDestino
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.CuentaDestino.DefaultCellStyle = dataGridViewCellStyle7;
            this.CuentaDestino.DividerWidth = 1;
            this.CuentaDestino.HeaderText = "Cuenta Destino";
            this.CuentaDestino.MinimumWidth = 200;
            this.CuentaDestino.Name = "CuentaDestino";
            this.CuentaDestino.ReadOnly = true;
            this.CuentaDestino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaDestino.Width = 200;
            // 
            // BancoDestinoNacional
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.BancoDestinoNacional.DefaultCellStyle = dataGridViewCellStyle8;
            this.BancoDestinoNacional.HeaderText = "Banco Destino Nacional";
            this.BancoDestinoNacional.MinimumWidth = 300;
            this.BancoDestinoNacional.Name = "BancoDestinoNacional";
            this.BancoDestinoNacional.ReadOnly = true;
            this.BancoDestinoNacional.Width = 300;
            // 
            // BancoDestinoExtranjero
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.BancoDestinoExtranjero.DefaultCellStyle = dataGridViewCellStyle9;
            this.BancoDestinoExtranjero.HeaderText = "Banco Destino Extranjero";
            this.BancoDestinoExtranjero.MinimumWidth = 300;
            this.BancoDestinoExtranjero.Name = "BancoDestinoExtranjero";
            this.BancoDestinoExtranjero.ReadOnly = true;
            this.BancoDestinoExtranjero.Width = 300;
            // 
            // Fecha
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle10;
            this.Fecha.DividerWidth = 1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 120;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 120;
            // 
            // Beneficiario
            // 
            this.Beneficiario.DividerWidth = 1;
            this.Beneficiario.HeaderText = "Beneficiario";
            this.Beneficiario.MinimumWidth = 500;
            this.Beneficiario.Name = "Beneficiario";
            this.Beneficiario.ReadOnly = true;
            this.Beneficiario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Beneficiario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Beneficiario.Width = 500;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 150;
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            this.RFC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RFC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RFC.Width = 150;
            // 
            // Monto
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle11;
            this.Monto.DividerWidth = 1;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 300;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Monto.Width = 300;
            // 
            // Moneda
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.Moneda.DefaultCellStyle = dataGridViewCellStyle12;
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // TipodeCambio
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle13.Format = "N5";
            dataGridViewCellStyle13.NullValue = "0.00000";
            this.TipodeCambio.DefaultCellStyle = dataGridViewCellStyle13;
            this.TipodeCambio.HeaderText = "Tipo de Cambio";
            this.TipodeCambio.MinimumWidth = 200;
            this.TipodeCambio.Name = "TipodeCambio";
            this.TipodeCambio.ReadOnly = true;
            this.TipodeCambio.Width = 200;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 100;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // ExistePoliza
            // 
            this.ExistePoliza.HeaderText = "ExistePoliza";
            this.ExistePoliza.MinimumWidth = 50;
            this.ExistePoliza.Name = "ExistePoliza";
            this.ExistePoliza.ReadOnly = true;
            this.ExistePoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExistePoliza.Visible = false;
            this.ExistePoliza.Width = 50;
            // 
            // YaGuardado
            // 
            this.YaGuardado.HeaderText = "YaGuardado";
            this.YaGuardado.MinimumWidth = 50;
            this.YaGuardado.Name = "YaGuardado";
            this.YaGuardado.ReadOnly = true;
            this.YaGuardado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YaGuardado.Visible = false;
            this.YaGuardado.Width = 50;
            // 
            // BancosValidos
            // 
            this.BancosValidos.HeaderText = "BancosValidos";
            this.BancosValidos.Name = "BancosValidos";
            this.BancosValidos.ReadOnly = true;
            this.BancosValidos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BancosValidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BancosValidos.Visible = false;
            // 
            // frmImportarTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(1274, 551);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
            this.Controls.Add(this.lblEjercicioPeriodo);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.dgvTransferencias);
            this.Controls.Add(this.cmdAbrirArchivo);
            this.Controls.Add(this.lblArchivoPolizas);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtArchivoTransferencias);
            this.Controls.Add(this.txtPathArchivoTransferencias);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarTransferencias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias de las Pólizas";
            this.Load += new System.EventHandler(this.frmImportarTransferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label lblArchivoPolizas;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtArchivoTransferencias;
		private System.Windows.Forms.Button cmdAbrirArchivo;
		private System.Windows.Forms.TextBox txtPathArchivoTransferencias;
		private SATecDataGridView dgvTransferencias;
		private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
		private System.Windows.Forms.ListView lstvDescripciones;
		private System.Windows.Forms.ColumnHeader Index;
		private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaContablePoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoOrigenNacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoOrigenExtranjero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoDestinoNacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoDestinoExtranjero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExistePoliza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YaGuardado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BancosValidos;
	}
}