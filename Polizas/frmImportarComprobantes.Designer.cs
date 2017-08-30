﻿namespace SATeC.Polizas {
	partial class frmImportarComprobantes {
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Codigo Moneda No Valido", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblArchivoPolizas = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivoComprobantes = new System.Windows.Forms.TextBox();
            this.cmdAbrirArchivo = new System.Windows.Forms.Button();
            this.txtPathArchivoComprobantes = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvComprobantes = new SATeC.SATecDataGridView();
            this.NumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UUID_CFDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistePoliza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YaGuardado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
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
            // txtArchivoComprobantes
            // 
            this.txtArchivoComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoComprobantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoComprobantes.ForeColor = System.Drawing.Color.White;
            this.txtArchivoComprobantes.Location = new System.Drawing.Point(185, 68);
            this.txtArchivoComprobantes.MaxLength = 500;
            this.txtArchivoComprobantes.Name = "txtArchivoComprobantes";
            this.txtArchivoComprobantes.ReadOnly = true;
            this.txtArchivoComprobantes.Size = new System.Drawing.Size(336, 30);
            this.txtArchivoComprobantes.TabIndex = 8;
            this.txtArchivoComprobantes.Text = "1234567890";
            // 
            // cmdAbrirArchivo
            // 
            this.cmdAbrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.Location = new System.Drawing.Point(527, 73);
            this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
            this.cmdAbrirArchivo.Size = new System.Drawing.Size(25, 25);
            this.cmdAbrirArchivo.TabIndex = 2;
            this.cmdAbrirArchivo.Text = "...";
            this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
            this.cmdAbrirArchivo.UseVisualStyleBackColor = true;
            this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
            // 
            // txtPathArchivoComprobantes
            // 
            this.txtPathArchivoComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathArchivoComprobantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoComprobantes.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoComprobantes.Location = new System.Drawing.Point(12, 69);
            this.txtPathArchivoComprobantes.MaxLength = 500;
            this.txtPathArchivoComprobantes.Name = "txtPathArchivoComprobantes";
            this.txtPathArchivoComprobantes.ReadOnly = true;
            this.txtPathArchivoComprobantes.Size = new System.Drawing.Size(336, 23);
            this.txtPathArchivoComprobantes.TabIndex = 9;
            this.txtPathArchivoComprobantes.Text = "1234567890";
            this.txtPathArchivoComprobantes.Visible = false;
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.AutoSize = true;
            this.chkPrimerFilaNombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.White;
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(185, 36);
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
            this.cmdCancelar.Location = new System.Drawing.Point(557, 487);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(126, 40);
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
            this.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.White;
            this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(407, 487);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(116, 40);
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
            this.lstvDescripciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstvDescripciones.Location = new System.Drawing.Point(618, 27);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(224, 82);
            this.lstvDescripciones.TabIndex = 27;
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
            this.Descripcion.Width = 300;
            // 
            // dgvComprobantes
            // 
            this.dgvComprobantes.AllowUserToAddRows = false;
            this.dgvComprobantes.AllowUserToDeleteRows = false;
            this.dgvComprobantes.AllowUserToResizeColumns = false;
            this.dgvComprobantes.AllowUserToResizeRows = false;
            this.dgvComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprobantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvComprobantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprobantes.ColumnHeadersHeight = 25;
            this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPoliza,
            this.NumeroCuenta,
            this.UUID_CFDI,
            this.RFC,
            this.MontoTotal,
            this.Moneda,
            this.TipodeCambio,
            this.Clave,
            this.ExistePoliza,
            this.YaGuardado});
            this.dgvComprobantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvComprobantes.EnableHeadersVisualStyles = false;
            this.dgvComprobantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvComprobantes.Location = new System.Drawing.Point(6, 115);
            this.dgvComprobantes.MultiSelect = false;
            this.dgvComprobantes.Name = "dgvComprobantes";
            this.dgvComprobantes.ReadOnly = true;
            this.dgvComprobantes.RowHeadersVisible = false;
            this.dgvComprobantes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvComprobantes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComprobantes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvComprobantes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvComprobantes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvComprobantes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprobantes.ShowCellErrors = false;
            this.dgvComprobantes.ShowCellToolTips = false;
            this.dgvComprobantes.ShowEditingIcon = false;
            this.dgvComprobantes.Size = new System.Drawing.Size(1005, 335);
            this.dgvComprobantes.TabIndex = 3;
            this.dgvComprobantes.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvComprobantes_RowPostPaint);
            // 
            // NumeroPoliza
            // 
            this.NumeroPoliza.DividerWidth = 1;
            this.NumeroPoliza.HeaderText = "Número de Póliza";
            this.NumeroPoliza.MinimumWidth = 300;
            this.NumeroPoliza.Name = "NumeroPoliza";
            this.NumeroPoliza.ReadOnly = true;
            this.NumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroPoliza.Width = 300;
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.HeaderText = "NumeroCuenta";
            this.NumeroCuenta.MinimumWidth = 300;
            this.NumeroCuenta.Name = "NumeroCuenta";
            this.NumeroCuenta.ReadOnly = true;
            this.NumeroCuenta.Width = 300;
            // 
            // UUID_CFDI
            // 
            this.UUID_CFDI.DividerWidth = 1;
            this.UUID_CFDI.HeaderText = "Clave UUID del CFDI";
            this.UUID_CFDI.MinimumWidth = 500;
            this.UUID_CFDI.Name = "UUID_CFDI";
            this.UUID_CFDI.ReadOnly = true;
            this.UUID_CFDI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UUID_CFDI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UUID_CFDI.Width = 500;
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
            // MontoTotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.MontoTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.MontoTotal.DividerWidth = 1;
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 300;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MontoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MontoTotal.Width = 300;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.MinimumWidth = 10;
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // TipodeCambio
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.Format = "N5";
            dataGridViewCellStyle3.NullValue = "0.00000";
            this.TipodeCambio.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipodeCambio.HeaderText = "Tipo de Cambio";
            this.TipodeCambio.MinimumWidth = 50;
            this.TipodeCambio.Name = "TipodeCambio";
            this.TipodeCambio.ReadOnly = true;
            this.TipodeCambio.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
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
            // frmImportarComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1095, 587);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
            this.Controls.Add(this.lblEjercicioPeriodo);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.dgvComprobantes);
            this.Controls.Add(this.cmdAbrirArchivo);
            this.Controls.Add(this.lblArchivoPolizas);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtArchivoComprobantes);
            this.Controls.Add(this.txtPathArchivoComprobantes);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarComprobantes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes de las Pólizas";
            this.Load += new System.EventHandler(this.frmImportarComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label lblArchivoPolizas;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtArchivoComprobantes;
		private System.Windows.Forms.Button cmdAbrirArchivo;
		private System.Windows.Forms.TextBox txtPathArchivoComprobantes;
		private SATecDataGridView dgvComprobantes;
		private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
		private System.Windows.Forms.ListView lstvDescripciones;
		private System.Windows.Forms.ColumnHeader Index;
		private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UUID_CFDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExistePoliza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YaGuardado;
	}
}