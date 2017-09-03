namespace SATeC.Polizas
{
    partial class frmImportarOtroMetodoPago
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))), new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Clave Metodo Pago No Valido", System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPathArchivoComprobantes = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lstvDescripciones = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdAbrirArchivo = new System.Windows.Forms.Button();
            this.txtArchivoComprobantes = new System.Windows.Forms.TextBox();
            this.chkPrimerFilaNombresColumnas = new System.Windows.Forms.CheckBox();
            this.lblArchivoPolizas = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
            this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvComprobantes = new SATeC.SATecDataGridView();
            this.NumeroPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetPagoPol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipCamb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistePoliza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YaGuardado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathArchivoComprobantes
            // 
            this.txtPathArchivoComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtPathArchivoComprobantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathArchivoComprobantes.ForeColor = System.Drawing.Color.White;
            this.txtPathArchivoComprobantes.Location = new System.Drawing.Point(228, 80);
            this.txtPathArchivoComprobantes.MaxLength = 500;
            this.txtPathArchivoComprobantes.Name = "txtPathArchivoComprobantes";
            this.txtPathArchivoComprobantes.ReadOnly = true;
            this.txtPathArchivoComprobantes.Size = new System.Drawing.Size(336, 30);
            this.txtPathArchivoComprobantes.TabIndex = 43;
            this.txtPathArchivoComprobantes.Text = "1234567890";
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
            this.cmdCancelar.Location = new System.Drawing.Point(561, 446);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(121, 40);
            this.cmdCancelar.TabIndex = 42;
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
            this.cmdGuardar.Location = new System.Drawing.Point(405, 446);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(122, 40);
            this.cmdGuardar.TabIndex = 41;
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
            this.lstvDescripciones.Location = new System.Drawing.Point(742, 12);
            this.lstvDescripciones.MultiSelect = false;
            this.lstvDescripciones.Name = "lstvDescripciones";
            this.lstvDescripciones.Scrollable = false;
            this.lstvDescripciones.ShowGroups = false;
            this.lstvDescripciones.Size = new System.Drawing.Size(279, 107);
            this.lstvDescripciones.TabIndex = 39;
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
            // cmdAbrirArchivo
            // 
            this.cmdAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.cmdAbrirArchivo.Location = new System.Drawing.Point(568, 80);
            this.cmdAbrirArchivo.Name = "cmdAbrirArchivo";
            this.cmdAbrirArchivo.Size = new System.Drawing.Size(26, 27);
            this.cmdAbrirArchivo.TabIndex = 38;
            this.cmdAbrirArchivo.Text = "...";
            this.cmdAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrirArchivo.UseCompatibleTextRendering = true;
            this.cmdAbrirArchivo.UseVisualStyleBackColor = true;
            this.cmdAbrirArchivo.Click += new System.EventHandler(this.cmdAbrirArchivo_Click);
            // 
            // txtArchivoComprobantes
            // 
            this.txtArchivoComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.txtArchivoComprobantes.ForeColor = System.Drawing.Color.White;
            this.txtArchivoComprobantes.Location = new System.Drawing.Point(229, 80);
            this.txtArchivoComprobantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtArchivoComprobantes.MaxLength = 500;
            this.txtArchivoComprobantes.Name = "txtArchivoComprobantes";
            this.txtArchivoComprobantes.ReadOnly = true;
            this.txtArchivoComprobantes.Size = new System.Drawing.Size(121, 30);
            this.txtArchivoComprobantes.TabIndex = 37;
            this.txtArchivoComprobantes.Text = "1234567890";
            // 
            // chkPrimerFilaNombresColumnas
            // 
            this.chkPrimerFilaNombresColumnas.AutoSize = true;
            this.chkPrimerFilaNombresColumnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.chkPrimerFilaNombresColumnas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPrimerFilaNombresColumnas.ForeColor = System.Drawing.Color.White;
            this.chkPrimerFilaNombresColumnas.Location = new System.Drawing.Point(229, 53);
            this.chkPrimerFilaNombresColumnas.Margin = new System.Windows.Forms.Padding(4);
            this.chkPrimerFilaNombresColumnas.Name = "chkPrimerFilaNombresColumnas";
            this.chkPrimerFilaNombresColumnas.Size = new System.Drawing.Size(425, 27);
            this.chkPrimerFilaNombresColumnas.TabIndex = 36;
            this.chkPrimerFilaNombresColumnas.Text = "Primer fila de datos contiene nombres de columnas";
            this.chkPrimerFilaNombresColumnas.UseVisualStyleBackColor = true;
            // 
            // lblArchivoPolizas
            // 
            this.lblArchivoPolizas.AutoSize = true;
            this.lblArchivoPolizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblArchivoPolizas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArchivoPolizas.ForeColor = System.Drawing.Color.White;
            this.lblArchivoPolizas.Location = new System.Drawing.Point(27, 57);
            this.lblArchivoPolizas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivoPolizas.Name = "lblArchivoPolizas";
            this.lblArchivoPolizas.Size = new System.Drawing.Size(176, 23);
            this.lblArchivoPolizas.TabIndex = 35;
            this.lblArchivoPolizas.Text = "Archivo de las Pólizas:";
            // 
            // lblEjercicioPeriodoSeleccionado
            // 
            this.lblEjercicioPeriodoSeleccionado.AutoSize = true;
            this.lblEjercicioPeriodoSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblEjercicioPeriodoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEjercicioPeriodoSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblEjercicioPeriodoSeleccionado.Location = new System.Drawing.Point(224, 20);
            this.lblEjercicioPeriodoSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjercicioPeriodoSeleccionado.Name = "lblEjercicioPeriodoSeleccionado";
            this.lblEjercicioPeriodoSeleccionado.Size = new System.Drawing.Size(130, 23);
            this.lblEjercicioPeriodoSeleccionado.TabIndex = 34;
            this.lblEjercicioPeriodoSeleccionado.Text = "2015 - 01 Enero";
            // 
            // lblEjercicioPeriodo
            // 
            this.lblEjercicioPeriodo.AutoSize = true;
            this.lblEjercicioPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblEjercicioPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEjercicioPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblEjercicioPeriodo.Location = new System.Drawing.Point(27, 20);
            this.lblEjercicioPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjercicioPeriodo.Name = "lblEjercicioPeriodo";
            this.lblEjercicioPeriodo.Size = new System.Drawing.Size(151, 23);
            this.lblEjercicioPeriodo.TabIndex = 33;
            this.lblEjercicioPeriodo.Text = "Ejercicio / Periodo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.MetPagoPol,
            this.Fecha,
            this.Benef,
            this.RFC,
            this.Monto,
            this.Moneda,
            this.TipCamb,
            this.Clave,
            this.ExistePoliza,
            this.YaGuardado});
            this.dgvComprobantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvComprobantes.EnableHeadersVisualStyles = false;
            this.dgvComprobantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvComprobantes.Location = new System.Drawing.Point(12, 125);
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
            this.dgvComprobantes.Size = new System.Drawing.Size(1009, 315);
            this.dgvComprobantes.TabIndex = 44;
            this.dgvComprobantes.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvComprobantes_RowPostPaint);
            // 
            // NumeroPoliza
            // 
            this.NumeroPoliza.DividerWidth = 1;
            this.NumeroPoliza.Frozen = true;
            this.NumeroPoliza.HeaderText = "Número de Póliza";
            this.NumeroPoliza.MinimumWidth = 130;
            this.NumeroPoliza.Name = "NumeroPoliza";
            this.NumeroPoliza.ReadOnly = true;
            this.NumeroPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroPoliza.Width = 130;
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.DividerWidth = 1;
            this.NumeroCuenta.HeaderText = "Número de Cuenta";
            this.NumeroCuenta.MinimumWidth = 150;
            this.NumeroCuenta.Name = "NumeroCuenta";
            this.NumeroCuenta.ReadOnly = true;
            this.NumeroCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroCuenta.Width = 150;
            // 
            // MetPagoPol
            // 
            this.MetPagoPol.HeaderText = "Clave Metodo Pago";
            this.MetPagoPol.Name = "MetPagoPol";
            this.MetPagoPol.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // Benef
            // 
            this.Benef.HeaderText = "Beneficiario";
            this.Benef.MinimumWidth = 300;
            this.Benef.Name = "Benef";
            this.Benef.ReadOnly = true;
            this.Benef.Width = 300;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 180;
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            this.RFC.Width = 200;
            // 
            // Monto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 200;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 200;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // TipCamb
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.Format = "N5";
            dataGridViewCellStyle3.NullValue = "0.00000";
            this.TipCamb.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipCamb.HeaderText = "Tipo de Cambio";
            this.TipCamb.Name = "TipCamb";
            this.TipCamb.ReadOnly = true;
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
            // frmImportarOtroMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1033, 498);
            this.Controls.Add(this.dgvComprobantes);
            this.Controls.Add(this.txtPathArchivoComprobantes);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.cmdAbrirArchivo);
            this.Controls.Add(this.txtArchivoComprobantes);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.lblArchivoPolizas);
            this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
            this.Controls.Add(this.lblEjercicioPeriodo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarOtroMetodoPago";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otro Método de Pago";
            this.Load += new System.EventHandler(this.frmImportarOtroMetodoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathArchivoComprobantes;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ListView lstvDescripciones;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.Button cmdAbrirArchivo;
        private System.Windows.Forms.TextBox txtArchivoComprobantes;
        private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
        private System.Windows.Forms.Label lblArchivoPolizas;
        private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
        private System.Windows.Forms.Label lblEjercicioPeriodo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private SATecDataGridView dgvComprobantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetPagoPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benef;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipCamb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExistePoliza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YaGuardado;
    }
}