namespace SATeC.Polizas {
	partial class frmImportarPolizas {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.lblArchivoPolizas = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtArchivoPolizas = new System.Windows.Forms.TextBox();
			this.cmdAbrirArchivo = new System.Windows.Forms.Button();
			this.txtPathArchivoPolizas = new System.Windows.Forms.TextBox();
			this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
			this.cmbEjercicioPeriodo = new System.Windows.Forms.ComboBox();
			this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
			this.lblTransacciones = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNoPolizas = new System.Windows.Forms.TextBox();
			this.txtTotalHaber = new System.Windows.Forms.TextBox();
			this.txtTotalDebe = new System.Windows.Forms.TextBox();
			this.lblModulo = new System.Windows.Forms.Label();
			this.cmdCerrar = new System.Windows.Forms.Button();
			this.dgvTransacciones = new SATeC.SATecDataGridView();
			this.TransaccionNumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaccionTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvPolizas = new SATeC.SATecDataGridView();
			this.IDTipoPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ConceptoPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdGuardar.FlatAppearance.BorderSize = 0;
			this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.ForeColor = System.Drawing.Color.White;
			this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.Location = new System.Drawing.Point(884, 458);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(100, 40);
			this.cmdGuardar.TabIndex = 4;
			this.cmdGuardar.Text = "&Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdGuardar.UseVisualStyleBackColor = false;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// lblArchivoPolizas
			// 
			this.lblArchivoPolizas.AutoSize = true;
			this.lblArchivoPolizas.BackColor = System.Drawing.Color.White;
			this.lblArchivoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArchivoPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.lblArchivoPolizas.Location = new System.Drawing.Point(5, 72);
			this.lblArchivoPolizas.Name = "lblArchivoPolizas";
			this.lblArchivoPolizas.Size = new System.Drawing.Size(142, 19);
			this.lblArchivoPolizas.TabIndex = 7;
			this.lblArchivoPolizas.Text = "Archivo de las Pólizas:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtArchivoPolizas
			// 
			this.txtArchivoPolizas.BackColor = System.Drawing.Color.White;
			this.txtArchivoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArchivoPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtArchivoPolizas.Location = new System.Drawing.Point(152, 100);
			this.txtArchivoPolizas.MaxLength = 500;
			this.txtArchivoPolizas.Name = "txtArchivoPolizas";
			this.txtArchivoPolizas.ReadOnly = true;
			this.txtArchivoPolizas.Size = new System.Drawing.Size(336, 25);
			this.txtArchivoPolizas.TabIndex = 8;
			this.txtArchivoPolizas.Text = "1234567890";
			// 
			// cmdAbrirArchivo
			// 
			this.cmdAbrirArchivo.BackColor = System.Drawing.Color.White;
			this.cmdAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdAbrirArchivo.Location = new System.Drawing.Point(489, 100);
			this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
			this.cmdAbrirArchivo.Size = new System.Drawing.Size(25, 25);
			this.cmdAbrirArchivo.TabIndex = 2;
			this.cmdAbrirArchivo.Text = "...";
			this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
			this.cmdAbrirArchivo.UseVisualStyleBackColor = false;
			this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
			// 
			// txtPathArchivoPolizas
			// 
			this.txtPathArchivoPolizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtPathArchivoPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPathArchivoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPathArchivoPolizas.ForeColor = System.Drawing.Color.White;
			this.txtPathArchivoPolizas.Location = new System.Drawing.Point(152, 107);
			this.txtPathArchivoPolizas.MaxLength = 500;
			this.txtPathArchivoPolizas.Name = "txtPathArchivoPolizas";
			this.txtPathArchivoPolizas.ReadOnly = true;
			this.txtPathArchivoPolizas.Size = new System.Drawing.Size(336, 18);
			this.txtPathArchivoPolizas.TabIndex = 9;
			this.txtPathArchivoPolizas.Text = "1234567890";
			this.txtPathArchivoPolizas.Visible = false;
			// 
			// chkPrimerFilaNombresColumnas
			// 
			this.chkPrimerFilaNombresColumnas.AutoSize = true;
			this.chkPrimerFilaNombresColumnas.BackColor = System.Drawing.Color.White;
			this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(152, 71);
			this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
			this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(338, 23);
			this.chkPrimerFilaNombresColumnas.TabIndex = 1;
			this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
			this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = false;
			// 
			// cmbEjercicioPeriodo
			// 
			this.cmbEjercicioPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmbEjercicioPeriodo.DisplayMember = "Texto";
			this.cmbEjercicioPeriodo.DropDownHeight = 100;
			this.cmbEjercicioPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEjercicioPeriodo.ForeColor = System.Drawing.Color.White;
			this.cmbEjercicioPeriodo.FormattingEnabled = true;
			this.cmbEjercicioPeriodo.IntegralHeight = false;
			this.cmbEjercicioPeriodo.Location = new System.Drawing.Point(152, 40);
			this.cmbEjercicioPeriodo.MaxDropDownItems = 12;
			this.cmbEjercicioPeriodo.Name = "cmbEjercicioPeriodo";
			this.cmbEjercicioPeriodo.Size = new System.Drawing.Size(150, 25);
			this.cmbEjercicioPeriodo.TabIndex = 0;
			this.cmbEjercicioPeriodo.ValueMember = "Valor";
			// 
			// lblEjercicioPeriodo
			// 
			this.lblEjercicioPeriodo.AutoSize = true;
			this.lblEjercicioPeriodo.BackColor = System.Drawing.Color.White;
			this.lblEjercicioPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEjercicioPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.lblEjercicioPeriodo.Location = new System.Drawing.Point(28, 43);
			this.lblEjercicioPeriodo.Name = "lblEjercicioPeriodo";
			this.lblEjercicioPeriodo.Size = new System.Drawing.Size(120, 19);
			this.lblEjercicioPeriodo.TabIndex = 6;
			this.lblEjercicioPeriodo.Text = "Ejercicio / Periodo:";
			// 
			// lblTransacciones
			// 
			this.lblTransacciones.AutoSize = true;
			this.lblTransacciones.BackColor = System.Drawing.Color.White;
			this.lblTransacciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.lblTransacciones.Location = new System.Drawing.Point(2, 303);
			this.lblTransacciones.Name = "lblTransacciones";
			this.lblTransacciones.Size = new System.Drawing.Size(105, 19);
			this.lblTransacciones.TabIndex = 11;
			this.lblTransacciones.Text = "Transacciones:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.label1.Location = new System.Drawing.Point(564, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 19);
			this.label1.TabIndex = 12;
			this.label1.Text = "No. Pólizas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.label2.Location = new System.Drawing.Point(564, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 19);
			this.label2.TabIndex = 13;
			this.label2.Text = "Total Debe:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.label3.Location = new System.Drawing.Point(564, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Total Haber:";
			// 
			// txtNoPolizas
			// 
			this.txtNoPolizas.BackColor = System.Drawing.Color.White;
			this.txtNoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtNoPolizas.Location = new System.Drawing.Point(648, 40);
			this.txtNoPolizas.MaxLength = 500;
			this.txtNoPolizas.Name = "txtNoPolizas";
			this.txtNoPolizas.ReadOnly = true;
			this.txtNoPolizas.Size = new System.Drawing.Size(80, 25);
			this.txtNoPolizas.TabIndex = 15;
			this.txtNoPolizas.Text = "1234567890";
			this.txtNoPolizas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalHaber
			// 
			this.txtTotalHaber.BackColor = System.Drawing.Color.White;
			this.txtTotalHaber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalHaber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtTotalHaber.Location = new System.Drawing.Point(648, 100);
			this.txtTotalHaber.MaxLength = 500;
			this.txtTotalHaber.Name = "txtTotalHaber";
			this.txtTotalHaber.ReadOnly = true;
			this.txtTotalHaber.Size = new System.Drawing.Size(150, 25);
			this.txtTotalHaber.TabIndex = 16;
			this.txtTotalHaber.Text = "12345678901234567890";
			this.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalDebe
			// 
			this.txtTotalDebe.BackColor = System.Drawing.Color.White;
			this.txtTotalDebe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalDebe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtTotalDebe.Location = new System.Drawing.Point(648, 71);
			this.txtTotalDebe.MaxLength = 500;
			this.txtTotalDebe.Name = "txtTotalDebe";
			this.txtTotalDebe.ReadOnly = true;
			this.txtTotalDebe.Size = new System.Drawing.Size(150, 25);
			this.txtTotalDebe.TabIndex = 17;
			this.txtTotalDebe.Text = "12345678901234567890";
			this.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.lblModulo.Size = new System.Drawing.Size(158, 25);
			this.lblModulo.TabIndex = 19;
			this.lblModulo.Text = "Importar Pólizas";
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
			this.cmdCerrar.Location = new System.Drawing.Point(894, 3);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.Size = new System.Drawing.Size(90, 40);
			this.cmdCerrar.TabIndex = 20;
			this.cmdCerrar.Text = "Cerrar";
			this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCerrar.UseVisualStyleBackColor = false;
			this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
			// 
			// dgvTransacciones
			// 
			this.dgvTransacciones.AllowUserToAddRows = false;
			this.dgvTransacciones.AllowUserToDeleteRows = false;
			this.dgvTransacciones.AllowUserToResizeColumns = false;
			this.dgvTransacciones.AllowUserToResizeRows = false;
			this.dgvTransacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTransacciones.BackgroundColor = System.Drawing.Color.White;
			this.dgvTransacciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTransacciones.ColumnHeadersHeight = 25;
			this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransaccionNumeroPoliza,
            this.TransaccionCuenta,
            this.IDTransaccion,
            this.TransaccionConcepto,
            this.TransaccionDebe,
            this.TransaccionHaber,
            this.TransaccionMoneda,
            this.TransaccionTipoCambio});
			this.dgvTransacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvTransacciones.EnableHeadersVisualStyles = false;
			this.dgvTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvTransacciones.Location = new System.Drawing.Point(5, 325);
			this.dgvTransacciones.MultiSelect = false;
			this.dgvTransacciones.Name = "dgvTransacciones";
			this.dgvTransacciones.ReadOnly = true;
			this.dgvTransacciones.RowHeadersVisible = false;
			this.dgvTransacciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dgvTransacciones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvTransacciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvTransacciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.dgvTransacciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvTransacciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTransacciones.ShowCellErrors = false;
			this.dgvTransacciones.ShowCellToolTips = false;
			this.dgvTransacciones.ShowEditingIcon = false;
			this.dgvTransacciones.Size = new System.Drawing.Size(971, 131);
			this.dgvTransacciones.TabIndex = 10;
			// 
			// TransaccionNumeroPoliza
			// 
			this.TransaccionNumeroPoliza.DividerWidth = 1;
			this.TransaccionNumeroPoliza.HeaderText = "Número de Póliza";
			this.TransaccionNumeroPoliza.MinimumWidth = 130;
			this.TransaccionNumeroPoliza.Name = "TransaccionNumeroPoliza";
			this.TransaccionNumeroPoliza.ReadOnly = true;
			this.TransaccionNumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionNumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionNumeroPoliza.Visible = false;
			this.TransaccionNumeroPoliza.Width = 130;
			// 
			// TransaccionCuenta
			// 
			this.TransaccionCuenta.DividerWidth = 1;
			this.TransaccionCuenta.HeaderText = "Cuenta";
			this.TransaccionCuenta.MinimumWidth = 150;
			this.TransaccionCuenta.Name = "TransaccionCuenta";
			this.TransaccionCuenta.ReadOnly = true;
			this.TransaccionCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionCuenta.Width = 150;
			// 
			// IDTransaccion
			// 
			this.IDTransaccion.HeaderText = "#";
			this.IDTransaccion.MinimumWidth = 50;
			this.IDTransaccion.Name = "IDTransaccion";
			this.IDTransaccion.ReadOnly = true;
			this.IDTransaccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.IDTransaccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.IDTransaccion.Width = 50;
			// 
			// TransaccionConcepto
			// 
			this.TransaccionConcepto.DividerWidth = 1;
			this.TransaccionConcepto.HeaderText = "Concepto";
			this.TransaccionConcepto.MinimumWidth = 350;
			this.TransaccionConcepto.Name = "TransaccionConcepto";
			this.TransaccionConcepto.ReadOnly = true;
			this.TransaccionConcepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionConcepto.Width = 350;
			// 
			// TransaccionDebe
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "#,##0.00;(#,##0.00)";
			this.TransaccionDebe.DefaultCellStyle = dataGridViewCellStyle2;
			this.TransaccionDebe.DividerWidth = 1;
			this.TransaccionDebe.HeaderText = "Debe";
			this.TransaccionDebe.MinimumWidth = 110;
			this.TransaccionDebe.Name = "TransaccionDebe";
			this.TransaccionDebe.ReadOnly = true;
			this.TransaccionDebe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionDebe.Width = 110;
			// 
			// TransaccionHaber
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "#,##0.00;(#,##0.00)";
			this.TransaccionHaber.DefaultCellStyle = dataGridViewCellStyle3;
			this.TransaccionHaber.DividerWidth = 1;
			this.TransaccionHaber.HeaderText = "Haber";
			this.TransaccionHaber.MinimumWidth = 110;
			this.TransaccionHaber.Name = "TransaccionHaber";
			this.TransaccionHaber.ReadOnly = true;
			this.TransaccionHaber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionHaber.Width = 110;
			// 
			// TransaccionMoneda
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TransaccionMoneda.DefaultCellStyle = dataGridViewCellStyle4;
			this.TransaccionMoneda.DividerWidth = 1;
			this.TransaccionMoneda.HeaderText = "Moneda";
			this.TransaccionMoneda.MinimumWidth = 60;
			this.TransaccionMoneda.Name = "TransaccionMoneda";
			this.TransaccionMoneda.ReadOnly = true;
			this.TransaccionMoneda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionMoneda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionMoneda.Width = 60;
			// 
			// TransaccionTipoCambio
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "#,##0.00;(#,##0.00)";
			this.TransaccionTipoCambio.DefaultCellStyle = dataGridViewCellStyle5;
			this.TransaccionTipoCambio.DividerWidth = 1;
			this.TransaccionTipoCambio.HeaderText = "Tipo de Cambio";
			this.TransaccionTipoCambio.MinimumWidth = 120;
			this.TransaccionTipoCambio.Name = "TransaccionTipoCambio";
			this.TransaccionTipoCambio.ReadOnly = true;
			this.TransaccionTipoCambio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TransaccionTipoCambio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TransaccionTipoCambio.Width = 120;
			// 
			// dgvPolizas
			// 
			this.dgvPolizas.AllowUserToAddRows = false;
			this.dgvPolizas.AllowUserToDeleteRows = false;
			this.dgvPolizas.AllowUserToResizeColumns = false;
			this.dgvPolizas.AllowUserToResizeRows = false;
			this.dgvPolizas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPolizas.BackgroundColor = System.Drawing.Color.White;
			this.dgvPolizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPolizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvPolizas.ColumnHeadersHeight = 25;
			this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTipoPoliza,
            this.TipoPoliza,
            this.NumeroPoliza,
            this.FechaPoliza,
            this.ConceptoPoliza});
			this.dgvPolizas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvPolizas.EnableHeadersVisualStyles = false;
			this.dgvPolizas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvPolizas.Location = new System.Drawing.Point(5, 131);
			this.dgvPolizas.MultiSelect = false;
			this.dgvPolizas.Name = "dgvPolizas";
			this.dgvPolizas.ReadOnly = true;
			this.dgvPolizas.RowHeadersVisible = false;
			this.dgvPolizas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dgvPolizas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvPolizas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvPolizas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvPolizas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvPolizas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPolizas.ShowCellErrors = false;
			this.dgvPolizas.ShowCellToolTips = false;
			this.dgvPolizas.ShowEditingIcon = false;
			this.dgvPolizas.Size = new System.Drawing.Size(971, 169);
			this.dgvPolizas.TabIndex = 3;
			this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
			// 
			// IDTipoPoliza
			// 
			this.IDTipoPoliza.DividerWidth = 1;
			this.IDTipoPoliza.HeaderText = "IDTipoPoliza";
			this.IDTipoPoliza.MinimumWidth = 80;
			this.IDTipoPoliza.Name = "IDTipoPoliza";
			this.IDTipoPoliza.ReadOnly = true;
			this.IDTipoPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.IDTipoPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.IDTipoPoliza.Visible = false;
			this.IDTipoPoliza.Width = 80;
			// 
			// TipoPoliza
			// 
			this.TipoPoliza.DividerWidth = 1;
			this.TipoPoliza.HeaderText = "Tipo de Póliza";
			this.TipoPoliza.MinimumWidth = 100;
			this.TipoPoliza.Name = "TipoPoliza";
			this.TipoPoliza.ReadOnly = true;
			this.TipoPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TipoPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// NumeroPoliza
			// 
			this.NumeroPoliza.DividerWidth = 1;
			this.NumeroPoliza.HeaderText = "Número de Póliza";
			this.NumeroPoliza.MinimumWidth = 125;
			this.NumeroPoliza.Name = "NumeroPoliza";
			this.NumeroPoliza.ReadOnly = true;
			this.NumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NumeroPoliza.Width = 125;
			// 
			// FechaPoliza
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FechaPoliza.DefaultCellStyle = dataGridViewCellStyle7;
			this.FechaPoliza.DividerWidth = 1;
			this.FechaPoliza.HeaderText = "Fecha de la Póliza";
			this.FechaPoliza.MinimumWidth = 125;
			this.FechaPoliza.Name = "FechaPoliza";
			this.FechaPoliza.ReadOnly = true;
			this.FechaPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.FechaPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.FechaPoliza.Width = 125;
			// 
			// ConceptoPoliza
			// 
			dataGridViewCellStyle8.NullValue = null;
			this.ConceptoPoliza.DefaultCellStyle = dataGridViewCellStyle8;
			this.ConceptoPoliza.DividerWidth = 1;
			this.ConceptoPoliza.HeaderText = "Concepto de la Póliza";
			this.ConceptoPoliza.MinimumWidth = 600;
			this.ConceptoPoliza.Name = "ConceptoPoliza";
			this.ConceptoPoliza.ReadOnly = true;
			this.ConceptoPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ConceptoPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ConceptoPoliza.Width = 600;
			// 
			// frmImportarPolizas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(980, 500);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.lblModulo);
			this.Controls.Add(this.txtTotalDebe);
			this.Controls.Add(this.txtTotalHaber);
			this.Controls.Add(this.txtNoPolizas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTransacciones);
			this.Controls.Add(this.dgvTransacciones);
			this.Controls.Add(this.cmbEjercicioPeriodo);
			this.Controls.Add(this.lblEjercicioPeriodo);
			this.Controls.Add(this.chkPrimerFilaNombresColumnas);
			this.Controls.Add(this.dgvPolizas);
			this.Controls.Add(this.cmdAbrirArchivo);
			this.Controls.Add(this.lblArchivoPolizas);
			this.Controls.Add(this.txtArchivoPolizas);
			this.Controls.Add(this.txtPathArchivoPolizas);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmImportarPolizas";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Importar Pólizas";
			this.Load += new System.EventHandler(this.frmImportarPolizas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label lblArchivoPolizas;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtArchivoPolizas;
		private System.Windows.Forms.Button cmdAbrirArchivo;
		private System.Windows.Forms.TextBox txtPathArchivoPolizas;
		private SATecDataGridView dgvPolizas;
		private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
		private System.Windows.Forms.ComboBox cmbEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private SATecDataGridView dgvTransacciones;
		private System.Windows.Forms.Label lblTransacciones;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNoPolizas;
		private System.Windows.Forms.TextBox txtTotalHaber;
		private System.Windows.Forms.TextBox txtTotalDebe;
		private System.Windows.Forms.Label lblModulo;
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDTipoPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionNumeroPoliza;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionCuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDTransaccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionConcepto;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionDebe;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionHaber;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionMoneda;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionTipoCambio;
	}
}