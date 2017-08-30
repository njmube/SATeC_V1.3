namespace SATeC.Balanza {
	partial class frmValidarBalanzaImportadaConCodigoAgrupadorSAT {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdValidar = new System.Windows.Forms.Button();
            this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
            this.tgvBalanza = new AdvancedDataGridView.TreeGridView();
            this.CodigoAgrupadorSAT = new AdvancedDataGridView.TreeGridColumn();
            this.NombreCuentaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisteCuentaRelacionSAT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvBalanza = new SATeC.SATecDataGridView();
            this.BalanzaCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanzaSaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanzaCargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanzaAbonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanzaSaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tgvBalanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanza)).BeginInit();
            this.SuspendLayout();
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
            this.cmdCancelar.Location = new System.Drawing.Point(818, 0);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(154, 40);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
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
            this.cmdValidar.Location = new System.Drawing.Point(516, 430);
            this.cmdValidar.Name = "cmdValidar";
            this.cmdValidar.Size = new System.Drawing.Size(256, 40);
            this.cmdValidar.TabIndex = 4;
            this.cmdValidar.Text = "&Convertir a Formato XML";
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
            this.lblEjercicioPeriodo.Size = new System.Drawing.Size(152, 23);
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
            // tgvBalanza
            // 
            this.tgvBalanza.AllowUserToAddRows = false;
            this.tgvBalanza.AllowUserToDeleteRows = false;
            this.tgvBalanza.AllowUserToResizeColumns = false;
            this.tgvBalanza.AllowUserToResizeRows = false;
            this.tgvBalanza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgvBalanza.BackgroundColor = System.Drawing.Color.White;
            this.tgvBalanza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tgvBalanza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvBalanza.ColumnHeadersHeight = 25;
            this.tgvBalanza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tgvBalanza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAgrupadorSAT,
            this.NombreCuentaSAT,
            this.SaldoInicial,
            this.Cargos,
            this.Abonos,
            this.SaldoFinal,
            this.ExisteCuentaRelacionSAT});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tgvBalanza.DefaultCellStyle = dataGridViewCellStyle6;
            this.tgvBalanza.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tgvBalanza.EnableHeadersVisualStyles = false;
            this.tgvBalanza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.tgvBalanza.ImageList = null;
            this.tgvBalanza.Location = new System.Drawing.Point(12, 43);
            this.tgvBalanza.Name = "tgvBalanza";
            this.tgvBalanza.ReadOnly = true;
            this.tgvBalanza.RowHeadersVisible = false;
            this.tgvBalanza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tgvBalanza.ShowCellErrors = false;
            this.tgvBalanza.ShowCellToolTips = false;
            this.tgvBalanza.ShowEditingIcon = false;
            this.tgvBalanza.Size = new System.Drawing.Size(965, 381);
            this.tgvBalanza.TabIndex = 3;
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
            this.NombreCuentaSAT.MinimumWidth = 500;
            this.NombreCuentaSAT.Name = "NombreCuentaSAT";
            this.NombreCuentaSAT.ReadOnly = true;
            this.NombreCuentaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuentaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCuentaSAT.Width = 500;
            // 
            // SaldoInicial
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00;(#,##0.00)";
            this.SaldoInicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaldoInicial.DividerWidth = 1;
            this.SaldoInicial.HeaderText = "Saldo Inicial";
            this.SaldoInicial.MinimumWidth = 300;
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.ReadOnly = true;
            this.SaldoInicial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaldoInicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaldoInicial.Width = 300;
            // 
            // Cargos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00;(#,##0.00)";
            this.Cargos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cargos.DividerWidth = 1;
            this.Cargos.HeaderText = "Cargos del Mes";
            this.Cargos.MinimumWidth = 300;
            this.Cargos.Name = "Cargos";
            this.Cargos.ReadOnly = true;
            this.Cargos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cargos.Width = 300;
            // 
            // Abonos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0.00;(#,##0.00)";
            this.Abonos.DefaultCellStyle = dataGridViewCellStyle4;
            this.Abonos.DividerWidth = 1;
            this.Abonos.HeaderText = "Abonos del Mes";
            this.Abonos.MinimumWidth = 300;
            this.Abonos.Name = "Abonos";
            this.Abonos.ReadOnly = true;
            this.Abonos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Abonos.Width = 300;
            // 
            // SaldoFinal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0.00;(#,##0.00)";
            this.SaldoFinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.SaldoFinal.DividerWidth = 1;
            this.SaldoFinal.HeaderText = "Saldo Final";
            this.SaldoFinal.MinimumWidth = 300;
            this.SaldoFinal.Name = "SaldoFinal";
            this.SaldoFinal.ReadOnly = true;
            this.SaldoFinal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaldoFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaldoFinal.Width = 300;
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
            // dgvBalanza
            // 
            this.dgvBalanza.AllowUserToAddRows = false;
            this.dgvBalanza.AllowUserToDeleteRows = false;
            this.dgvBalanza.AllowUserToResizeColumns = false;
            this.dgvBalanza.AllowUserToResizeRows = false;
            this.dgvBalanza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBalanza.BackgroundColor = System.Drawing.Color.White;
            this.dgvBalanza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalanza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBalanza.ColumnHeadersHeight = 40;
            this.dgvBalanza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBalanza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BalanzaCuenta,
            this.BalanzaSaldoInicial,
            this.BalanzaCargos,
            this.BalanzaAbonos,
            this.BalanzaSaldoFinal});
            this.dgvBalanza.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBalanza.EnableHeadersVisualStyles = false;
            this.dgvBalanza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanza.Location = new System.Drawing.Point(271, 73);
            this.dgvBalanza.Name = "dgvBalanza";
            this.dgvBalanza.ReadOnly = true;
            this.dgvBalanza.RowHeadersVisible = false;
            this.dgvBalanza.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvBalanza.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBalanza.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanza.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvBalanza.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanza.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalanza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBalanza.ShowCellErrors = false;
            this.dgvBalanza.ShowCellToolTips = false;
            this.dgvBalanza.ShowEditingIcon = false;
            this.dgvBalanza.Size = new System.Drawing.Size(506, 336);
            this.dgvBalanza.TabIndex = 9;
            this.dgvBalanza.Visible = false;
            // 
            // BalanzaCuenta
            // 
            this.BalanzaCuenta.DividerWidth = 1;
            this.BalanzaCuenta.HeaderText = "Cuenta";
            this.BalanzaCuenta.MinimumWidth = 200;
            this.BalanzaCuenta.Name = "BalanzaCuenta";
            this.BalanzaCuenta.ReadOnly = true;
            this.BalanzaCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BalanzaCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanzaCuenta.Width = 200;
            // 
            // BalanzaSaldoInicial
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,##0.00;(#,##0.00)";
            this.BalanzaSaldoInicial.DefaultCellStyle = dataGridViewCellStyle8;
            this.BalanzaSaldoInicial.DividerWidth = 1;
            this.BalanzaSaldoInicial.HeaderText = "Saldo Inicial";
            this.BalanzaSaldoInicial.MinimumWidth = 250;
            this.BalanzaSaldoInicial.Name = "BalanzaSaldoInicial";
            this.BalanzaSaldoInicial.ReadOnly = true;
            this.BalanzaSaldoInicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanzaSaldoInicial.Width = 250;
            // 
            // BalanzaCargos
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,##0.00;(#,##0.00)";
            this.BalanzaCargos.DefaultCellStyle = dataGridViewCellStyle9;
            this.BalanzaCargos.DividerWidth = 1;
            this.BalanzaCargos.HeaderText = "Cargos del Mes";
            this.BalanzaCargos.MinimumWidth = 250;
            this.BalanzaCargos.Name = "BalanzaCargos";
            this.BalanzaCargos.ReadOnly = true;
            this.BalanzaCargos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanzaCargos.Width = 250;
            // 
            // BalanzaAbonos
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0.00;(#,##0.00)";
            this.BalanzaAbonos.DefaultCellStyle = dataGridViewCellStyle10;
            this.BalanzaAbonos.DividerWidth = 1;
            this.BalanzaAbonos.HeaderText = "Abonos del Mes";
            this.BalanzaAbonos.MinimumWidth = 250;
            this.BalanzaAbonos.Name = "BalanzaAbonos";
            this.BalanzaAbonos.ReadOnly = true;
            this.BalanzaAbonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanzaAbonos.Width = 250;
            // 
            // BalanzaSaldoFinal
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,##0.00;(#,##0.00)";
            this.BalanzaSaldoFinal.DefaultCellStyle = dataGridViewCellStyle11;
            this.BalanzaSaldoFinal.DividerWidth = 1;
            this.BalanzaSaldoFinal.HeaderText = "Saldo Final";
            this.BalanzaSaldoFinal.MinimumWidth = 250;
            this.BalanzaSaldoFinal.Name = "BalanzaSaldoFinal";
            this.BalanzaSaldoFinal.ReadOnly = true;
            this.BalanzaSaldoFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BalanzaSaldoFinal.Width = 250;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::SATeC.Properties.Resources.Descargar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(778, 430);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(181, 40);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "&Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmValidarBalanzaImportadaConCodigoAgrupadorSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvBalanza);
            this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
            this.Controls.Add(this.lblEjercicioPeriodo);
            this.Controls.Add(this.tgvBalanza);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdValidar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmValidarBalanzaImportadaConCodigoAgrupadorSAT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Balanza Importada con Código Agrupador del SAT";
            this.Load += new System.EventHandler(this.frmValidarBalanzaImportadaConCodigoAgrupadorSAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgvBalanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
        private AdvancedDataGridView.TreeGridView tgvBalanza;
        private SATecDataGridView dgvBalanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanzaCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanzaSaldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanzaCargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanzaAbonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanzaSaldoFinal;
        private AdvancedDataGridView.TreeGridColumn CodigoAgrupadorSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuentaSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExisteCuentaRelacionSAT;
        private System.Windows.Forms.Button btnExportar;
	}
}