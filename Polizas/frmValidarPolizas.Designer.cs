namespace SATeC.Polizas {
	partial class frmValidarPolizas {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdValidar = new System.Windows.Forms.Button();
            this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
            this.CodigoAgrupadorSAT = new AdvancedDataGridView.TreeGridColumn();
            this.NombreCuentaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisteCuentaRelacionSAT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTransacciones = new System.Windows.Forms.Label();
            this.cmdCheques = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdTransferencias = new System.Windows.Forms.Button();
            this.cmdComprobantes = new System.Windows.Forms.Button();
            this.cmdComprobantesNacionalOtros = new System.Windows.Forms.Button();
            this.cmdComprobantesExtranjeros = new System.Windows.Forms.Button();
            this.cmdOtrosMetodosPago = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTransacciones = new SATeC.SATecDataGridView();
            this.TransaccionNumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransaccionCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransaccionConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransaccionDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransaccionHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPolizas = new SATeC.SATecDataGridView();
            this.NumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdValidar
            // 
            this.cmdValidar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdValidar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdValidar.FlatAppearance.BorderSize = 0;
            this.cmdValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdValidar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidar.ForeColor = System.Drawing.Color.White;
            this.cmdValidar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdValidar.Location = new System.Drawing.Point(3, 112);
            this.cmdValidar.Name = "cmdValidar";
            this.cmdValidar.Size = new System.Drawing.Size(329, 40);
            this.cmdValidar.TabIndex = 4;
            this.cmdValidar.Text = "&Validar y Convertir a Formato XML";
            this.cmdValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdValidar.UseVisualStyleBackColor = true;
            this.cmdValidar.Click += new System.EventHandler(this.cmdValidar_Click);
            // 
            // lblEjercicioPeriodo
            // 
            this.lblEjercicioPeriodo.AutoSize = true;
            this.lblEjercicioPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblEjercicioPeriodo.Location = new System.Drawing.Point(12, 15);
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
            this.lblEjercicioPeriodoSeleccionado.Location = new System.Drawing.Point(138, 15);
            this.lblEjercicioPeriodoSeleccionado.Name = "lblEjercicioPeriodoSeleccionado";
            this.lblEjercicioPeriodoSeleccionado.Size = new System.Drawing.Size(140, 23);
            this.lblEjercicioPeriodoSeleccionado.TabIndex = 7;
            this.lblEjercicioPeriodoSeleccionado.Text = "2014 - 08 Agosto";
            // 
            // CodigoAgrupadorSAT
            // 
            this.CodigoAgrupadorSAT.DefaultNodeImage = null;
            this.CodigoAgrupadorSAT.DividerWidth = 1;
            this.CodigoAgrupadorSAT.HeaderText = "Código Agrupador";
            this.CodigoAgrupadorSAT.MinimumWidth = 130;
            this.CodigoAgrupadorSAT.Name = "CodigoAgrupadorSAT";
            this.CodigoAgrupadorSAT.ReadOnly = true;
            this.CodigoAgrupadorSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoAgrupadorSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoAgrupadorSAT.Width = 130;
            // 
            // NombreCuentaSAT
            // 
            this.NombreCuentaSAT.DividerWidth = 1;
            this.NombreCuentaSAT.HeaderText = "Nombre de la Cuenta del SAT";
            this.NombreCuentaSAT.MinimumWidth = 340;
            this.NombreCuentaSAT.Name = "NombreCuentaSAT";
            this.NombreCuentaSAT.ReadOnly = true;
            this.NombreCuentaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuentaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCuentaSAT.Width = 340;
            // 
            // SaldoInicial
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0.00;(#,##0.00)";
            this.SaldoInicial.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaldoInicial.DividerWidth = 1;
            this.SaldoInicial.HeaderText = "Saldo Inicial";
            this.SaldoInicial.MinimumWidth = 115;
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.ReadOnly = true;
            this.SaldoInicial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaldoInicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaldoInicial.Width = 115;
            // 
            // Cargos
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00;(#,##0.00)";
            this.Cargos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cargos.DividerWidth = 1;
            this.Cargos.HeaderText = "Cargos del Mes";
            this.Cargos.MinimumWidth = 120;
            this.Cargos.Name = "Cargos";
            this.Cargos.ReadOnly = true;
            this.Cargos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cargos.Width = 120;
            // 
            // Abonos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00;(#,##0.00)";
            this.Abonos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Abonos.DividerWidth = 1;
            this.Abonos.HeaderText = "Abonos del Mes";
            this.Abonos.MinimumWidth = 120;
            this.Abonos.Name = "Abonos";
            this.Abonos.ReadOnly = true;
            this.Abonos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Abonos.Width = 120;
            // 
            // SaldoFinal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0.00;(#,##0.00)";
            this.SaldoFinal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SaldoFinal.DividerWidth = 1;
            this.SaldoFinal.HeaderText = "Saldo Final";
            this.SaldoFinal.MinimumWidth = 115;
            this.SaldoFinal.Name = "SaldoFinal";
            this.SaldoFinal.ReadOnly = true;
            this.SaldoFinal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaldoFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaldoFinal.Width = 115;
            // 
            // ExisteCuentaRelacionSAT
            // 
            this.ExisteCuentaRelacionSAT.HeaderText = "ExisteCuentaRelacionSAT";
            this.ExisteCuentaRelacionSAT.MinimumWidth = 30;
            this.ExisteCuentaRelacionSAT.Name = "ExisteCuentaRelacionSAT";
            this.ExisteCuentaRelacionSAT.ReadOnly = true;
            this.ExisteCuentaRelacionSAT.Visible = false;
            this.ExisteCuentaRelacionSAT.Width = 30;
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTransacciones.AutoSize = true;
            this.lblTransacciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacciones.ForeColor = System.Drawing.Color.White;
            this.lblTransacciones.Location = new System.Drawing.Point(8, 298);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(118, 23);
            this.lblTransacciones.TabIndex = 12;
            this.lblTransacciones.Text = "Transacciones";
            // 
            // cmdCheques
            // 
            this.cmdCheques.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCheques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdCheques.FlatAppearance.BorderSize = 0;
            this.cmdCheques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCheques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheques.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheques.ForeColor = System.Drawing.Color.White;
            this.cmdCheques.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheques.Location = new System.Drawing.Point(321, 2);
            this.cmdCheques.Name = "cmdCheques";
            this.cmdCheques.Size = new System.Drawing.Size(137, 40);
            this.cmdCheques.TabIndex = 14;
            this.cmdCheques.Text = "Cheques";
            this.cmdCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCheques.UseVisualStyleBackColor = true;
            this.cmdCheques.Click += new System.EventHandler(this.cmdCheques_Click);
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
            this.cmdCerrar.Location = new System.Drawing.Point(327, 112);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(106, 40);
            this.cmdCerrar.TabIndex = 21;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdTransferencias
            // 
            this.cmdTransferencias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdTransferencias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdTransferencias.FlatAppearance.BorderSize = 0;
            this.cmdTransferencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdTransferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdTransferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTransferencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTransferencias.ForeColor = System.Drawing.Color.White;
            this.cmdTransferencias.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdTransferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdTransferencias.Location = new System.Drawing.Point(323, 38);
            this.cmdTransferencias.Name = "cmdTransferencias";
            this.cmdTransferencias.Size = new System.Drawing.Size(188, 40);
            this.cmdTransferencias.TabIndex = 22;
            this.cmdTransferencias.Text = "Transferencias";
            this.cmdTransferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTransferencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdTransferencias.UseVisualStyleBackColor = true;
            this.cmdTransferencias.Click += new System.EventHandler(this.cmdTransferencias_Click);
            // 
            // cmdComprobantes
            // 
            this.cmdComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdComprobantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdComprobantes.FlatAppearance.BorderSize = 0;
            this.cmdComprobantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprobantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprobantes.ForeColor = System.Drawing.Color.White;
            this.cmdComprobantes.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdComprobantes.Location = new System.Drawing.Point(0, 2);
            this.cmdComprobantes.Name = "cmdComprobantes";
            this.cmdComprobantes.Size = new System.Drawing.Size(272, 40);
            this.cmdComprobantes.TabIndex = 23;
            this.cmdComprobantes.Text = "Comprobantes Nacional";
            this.cmdComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdComprobantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdComprobantes.UseVisualStyleBackColor = true;
            this.cmdComprobantes.Click += new System.EventHandler(this.cmdComprobantes_Click);
            // 
            // cmdComprobantesNacionalOtros
            // 
            this.cmdComprobantesNacionalOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdComprobantesNacionalOtros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdComprobantesNacionalOtros.FlatAppearance.BorderSize = 0;
            this.cmdComprobantesNacionalOtros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantesNacionalOtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantesNacionalOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprobantesNacionalOtros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprobantesNacionalOtros.ForeColor = System.Drawing.Color.White;
            this.cmdComprobantesNacionalOtros.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdComprobantesNacionalOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdComprobantesNacionalOtros.Location = new System.Drawing.Point(0, 38);
            this.cmdComprobantesNacionalOtros.Name = "cmdComprobantesNacionalOtros";
            this.cmdComprobantesNacionalOtros.Size = new System.Drawing.Size(292, 40);
            this.cmdComprobantesNacionalOtros.TabIndex = 24;
            this.cmdComprobantesNacionalOtros.Text = "Comprobantes Nacional Otros";
            this.cmdComprobantesNacionalOtros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdComprobantesNacionalOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdComprobantesNacionalOtros.UseVisualStyleBackColor = true;
            this.cmdComprobantesNacionalOtros.Click += new System.EventHandler(this.cmdComprobantesNacionalOtros_Click);
            // 
            // cmdComprobantesExtranjeros
            // 
            this.cmdComprobantesExtranjeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdComprobantesExtranjeros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdComprobantesExtranjeros.FlatAppearance.BorderSize = 0;
            this.cmdComprobantesExtranjeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantesExtranjeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdComprobantesExtranjeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprobantesExtranjeros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprobantesExtranjeros.ForeColor = System.Drawing.Color.White;
            this.cmdComprobantesExtranjeros.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdComprobantesExtranjeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdComprobantesExtranjeros.Location = new System.Drawing.Point(1, 73);
            this.cmdComprobantesExtranjeros.Name = "cmdComprobantesExtranjeros";
            this.cmdComprobantesExtranjeros.Size = new System.Drawing.Size(331, 40);
            this.cmdComprobantesExtranjeros.TabIndex = 25;
            this.cmdComprobantesExtranjeros.Text = "Comprobantes Extranjeros";
            this.cmdComprobantesExtranjeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdComprobantesExtranjeros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdComprobantesExtranjeros.UseVisualStyleBackColor = true;
            this.cmdComprobantesExtranjeros.Click += new System.EventHandler(this.cmdComprobantesExtranjeros_Click);
            // 
            // cmdOtrosMetodosPago
            // 
            this.cmdOtrosMetodosPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOtrosMetodosPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdOtrosMetodosPago.FlatAppearance.BorderSize = 0;
            this.cmdOtrosMetodosPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdOtrosMetodosPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdOtrosMetodosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOtrosMetodosPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOtrosMetodosPago.ForeColor = System.Drawing.Color.White;
            this.cmdOtrosMetodosPago.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdOtrosMetodosPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOtrosMetodosPago.Location = new System.Drawing.Point(325, 73);
            this.cmdOtrosMetodosPago.Name = "cmdOtrosMetodosPago";
            this.cmdOtrosMetodosPago.Size = new System.Drawing.Size(239, 40);
            this.cmdOtrosMetodosPago.TabIndex = 26;
            this.cmdOtrosMetodosPago.Text = "Otros Metodos de Pago";
            this.cmdOtrosMetodosPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOtrosMetodosPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdOtrosMetodosPago.UseVisualStyleBackColor = true;
            this.cmdOtrosMetodosPago.Click += new System.EventHandler(this.cmdOtrosMetodosPago_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdComprobantes);
            this.panel1.Controls.Add(this.cmdCerrar);
            this.panel1.Controls.Add(this.cmdOtrosMetodosPago);
            this.panel1.Controls.Add(this.cmdComprobantesNacionalOtros);
            this.panel1.Controls.Add(this.cmdTransferencias);
            this.panel1.Controls.Add(this.cmdComprobantesExtranjeros);
            this.panel1.Controls.Add(this.cmdCheques);
            this.panel1.Controls.Add(this.cmdValidar);
            this.panel1.Location = new System.Drawing.Point(323, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 182);
            this.panel1.TabIndex = 27;
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToAddRows = false;
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.AllowUserToResizeColumns = false;
            this.dgvTransacciones.AllowUserToResizeRows = false;
            this.dgvTransacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransacciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransacciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransacciones.ColumnHeadersHeight = 25;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransaccionNumeroPoliza,
            this.TransaccionCuenta,
            this.DescCuenta,
            this.TransaccionConcepto,
            this.TransaccionDebe,
            this.TransaccionHaber});
            this.dgvTransacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTransacciones.EnableHeadersVisualStyles = false;
            this.dgvTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvTransacciones.Location = new System.Drawing.Point(5, 324);
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
            this.dgvTransacciones.Size = new System.Drawing.Size(944, 165);
            this.dgvTransacciones.TabIndex = 13;
            // 
            // TransaccionNumeroPoliza
            // 
            this.TransaccionNumeroPoliza.DividerWidth = 1;
            this.TransaccionNumeroPoliza.HeaderText = "Número de Póliza";
            this.TransaccionNumeroPoliza.MinimumWidth = 300;
            this.TransaccionNumeroPoliza.Name = "TransaccionNumeroPoliza";
            this.TransaccionNumeroPoliza.ReadOnly = true;
            this.TransaccionNumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransaccionNumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransaccionNumeroPoliza.Visible = false;
            this.TransaccionNumeroPoliza.Width = 300;
            // 
            // TransaccionCuenta
            // 
            this.TransaccionCuenta.DividerWidth = 1;
            this.TransaccionCuenta.HeaderText = "Cuenta";
            this.TransaccionCuenta.MinimumWidth = 300;
            this.TransaccionCuenta.Name = "TransaccionCuenta";
            this.TransaccionCuenta.ReadOnly = true;
            this.TransaccionCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransaccionCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransaccionCuenta.Width = 300;
            // 
            // DescCuenta
            // 
            this.DescCuenta.HeaderText = "Descripción Cuenta";
            this.DescCuenta.MinimumWidth = 700;
            this.DescCuenta.Name = "DescCuenta";
            this.DescCuenta.ReadOnly = true;
            this.DescCuenta.Width = 700;
            // 
            // TransaccionConcepto
            // 
            this.TransaccionConcepto.DividerWidth = 1;
            this.TransaccionConcepto.HeaderText = "Concepto";
            this.TransaccionConcepto.MinimumWidth = 700;
            this.TransaccionConcepto.Name = "TransaccionConcepto";
            this.TransaccionConcepto.ReadOnly = true;
            this.TransaccionConcepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransaccionConcepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransaccionConcepto.Width = 700;
            // 
            // TransaccionDebe
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0.00;(#,##0.00)";
            this.TransaccionDebe.DefaultCellStyle = dataGridViewCellStyle6;
            this.TransaccionDebe.DividerWidth = 1;
            this.TransaccionDebe.HeaderText = "Debe";
            this.TransaccionDebe.MinimumWidth = 300;
            this.TransaccionDebe.Name = "TransaccionDebe";
            this.TransaccionDebe.ReadOnly = true;
            this.TransaccionDebe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransaccionDebe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransaccionDebe.Width = 300;
            // 
            // TransaccionHaber
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,##0.00;(#,##0.00)";
            this.TransaccionHaber.DefaultCellStyle = dataGridViewCellStyle7;
            this.TransaccionHaber.DividerWidth = 1;
            this.TransaccionHaber.HeaderText = "Haber";
            this.TransaccionHaber.MinimumWidth = 300;
            this.TransaccionHaber.Name = "TransaccionHaber";
            this.TransaccionHaber.ReadOnly = true;
            this.TransaccionHaber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransaccionHaber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransaccionHaber.Width = 300;
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AllowUserToAddRows = false;
            this.dgvPolizas.AllowUserToDeleteRows = false;
            this.dgvPolizas.AllowUserToResizeColumns = false;
            this.dgvPolizas.AllowUserToResizeRows = false;
            this.dgvPolizas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPolizas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPolizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPolizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPolizas.ColumnHeadersHeight = 25;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPoliza,
            this.FechaPoliza});
            this.dgvPolizas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPolizas.EnableHeadersVisualStyles = false;
            this.dgvPolizas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvPolizas.Location = new System.Drawing.Point(12, 46);
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
            this.dgvPolizas.Size = new System.Drawing.Size(305, 235);
            this.dgvPolizas.TabIndex = 8;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // NumeroPoliza
            // 
            this.NumeroPoliza.DataPropertyName = "NumeroPoliza";
            this.NumeroPoliza.DividerWidth = 1;
            this.NumeroPoliza.HeaderText = "Número de Póliza";
            this.NumeroPoliza.MinimumWidth = 130;
            this.NumeroPoliza.Name = "NumeroPoliza";
            this.NumeroPoliza.ReadOnly = true;
            this.NumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroPoliza.Width = 130;
            // 
            // FechaPoliza
            // 
            this.FechaPoliza.DataPropertyName = "FechaPoliza";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaPoliza.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaPoliza.DividerWidth = 1;
            this.FechaPoliza.HeaderText = "Fecha de la Póliza";
            this.FechaPoliza.MinimumWidth = 125;
            this.FechaPoliza.Name = "FechaPoliza";
            this.FechaPoliza.ReadOnly = true;
            this.FechaPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaPoliza.Width = 150;
            // 
            // frmValidarPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(961, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.lblTransacciones);
            this.Controls.Add(this.dgvPolizas);
            this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
            this.Controls.Add(this.lblEjercicioPeriodo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmValidarPolizas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Pólizas";
            this.Load += new System.EventHandler(this.frmValidarPolizas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
		private AdvancedDataGridView.TreeGridColumn CodigoAgrupadorSAT;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuentaSAT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaldoInicial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cargos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Abonos;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ExisteCuentaRelacionSAT;
		private SATecDataGridView dgvPolizas;
		private System.Windows.Forms.Label lblTransacciones;
		private SATecDataGridView dgvTransacciones;
		private System.Windows.Forms.Button cmdCheques;
		private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdTransferencias;
        private System.Windows.Forms.Button cmdComprobantes;
        private System.Windows.Forms.Button cmdComprobantesNacionalOtros;
        private System.Windows.Forms.Button cmdComprobantesExtranjeros;
        private System.Windows.Forms.Button cmdOtrosMetodosPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionNumeroPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaccionHaber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPoliza;
	}
}