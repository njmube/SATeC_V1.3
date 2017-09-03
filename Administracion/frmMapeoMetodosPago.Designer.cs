namespace SATeC.Administracion
{
    partial class frmMapeoMetodosPago
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "  ",
            "",
            "     "}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.White, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Nuevo", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Yellow, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Existente", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, ""),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red, new System.Drawing.Font("Segoe UI", 10F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Error", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153))))), new System.Drawing.Font("Segoe UI", 10F))}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvMetodosPago = new SATeC.SATecDataGridView();
            this.ClaveSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisteClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPago)).BeginInit();
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
            this.cmdImportar.Location = new System.Drawing.Point(1060, 35);
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
            this.cmdCerrar.Location = new System.Drawing.Point(1060, 87);
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
            this.lblModulo.Size = new System.Drawing.Size(374, 32);
            this.lblModulo.TabIndex = 30;
            this.lblModulo.Text = "Carga Mapeo Métodos de Pago";
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
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            listViewItem3.UseItemStyleForSubItems = false;
            listViewItem4.UseItemStyleForSubItems = false;
            this.lstvDescripciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstvDescripciones.Location = new System.Drawing.Point(1024, 133);
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
            // dgvMetodosPago
            // 
            this.dgvMetodosPago.AllowUserToAddRows = false;
            this.dgvMetodosPago.AllowUserToDeleteRows = false;
            this.dgvMetodosPago.AllowUserToResizeColumns = false;
            this.dgvMetodosPago.AllowUserToResizeRows = false;
            this.dgvMetodosPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMetodosPago.BackgroundColor = System.Drawing.Color.White;
            this.dgvMetodosPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodosPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodosPago.ColumnHeadersHeight = 25;
            this.dgvMetodosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMetodosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveSociedad,
            this.ClaveSAT,
            this.Concepto,
            this.ExisteClave,
            this.Fallo});
            this.dgvMetodosPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMetodosPago.EnableHeadersVisualStyles = false;
            this.dgvMetodosPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvMetodosPago.Location = new System.Drawing.Point(12, 133);
            this.dgvMetodosPago.Name = "dgvMetodosPago";
            this.dgvMetodosPago.ReadOnly = true;
            this.dgvMetodosPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodosPago.RowHeadersVisible = false;
            this.dgvMetodosPago.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvMetodosPago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMetodosPago.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvMetodosPago.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvMetodosPago.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvMetodosPago.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodosPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetodosPago.ShowCellErrors = false;
            this.dgvMetodosPago.ShowCellToolTips = false;
            this.dgvMetodosPago.ShowEditingIcon = false;
            this.dgvMetodosPago.Size = new System.Drawing.Size(1006, 401);
            this.dgvMetodosPago.TabIndex = 32;
            // 
            // ClaveSociedad
            // 
            this.ClaveSociedad.HeaderText = "Clave Sociedad";
            this.ClaveSociedad.MinimumWidth = 150;
            this.ClaveSociedad.Name = "ClaveSociedad";
            this.ClaveSociedad.ReadOnly = true;
            this.ClaveSociedad.Width = 150;
            // 
            // ClaveSAT
            // 
            this.ClaveSAT.HeaderText = "Clave SAT";
            this.ClaveSAT.MinimumWidth = 100;
            this.ClaveSAT.Name = "ClaveSAT";
            this.ClaveSAT.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 250;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 250;
            // 
            // ExisteClave
            // 
            this.ExisteClave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExisteClave.DividerWidth = 1;
            this.ExisteClave.HeaderText = "Existe Clave";
            this.ExisteClave.MinimumWidth = 70;
            this.ExisteClave.Name = "ExisteClave";
            this.ExisteClave.ReadOnly = true;
            this.ExisteClave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExisteClave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExisteClave.Visible = false;
            this.ExisteClave.Width = 70;
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
            // frmMapeoMetodosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 559);
            this.Controls.Add(this.lstvDescripciones);
            this.Controls.Add(this.chkPrimerFilaNombresColumnas);
            this.Controls.Add(this.txtPathArchivoCatalogoCuentas);
            this.Controls.Add(this.cmdImportar);
            this.Controls.Add(this.dgvMetodosPago);
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
            this.Name = "frmMapeoMetodosPago";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Carga Mapeo Cuentas";
            this.Load += new System.EventHandler(this.frmMapeoMetodosPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPrimerFilaNombresColumnas;
        private System.Windows.Forms.TextBox txtPathArchivoCatalogoCuentas;
        private System.Windows.Forms.Button cmdImportar;
        private SATecDataGridView dgvMetodosPago;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExisteClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fallo;
    }
}