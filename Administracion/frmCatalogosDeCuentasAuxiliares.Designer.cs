namespace SATeC.Administracion {
    partial class frmCatalogosDeCuentasAuxiliares {
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
            this.lblModulo = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.dgvCatalogosDeCuentasAuxiliares = new SATeC.SATecDataGridView();
            this.IDCatalogoCuentasAuxiliares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCatalogoCuentasAuxiliares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCatalogoCuentasAuxiliares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosDeCuentasAuxiliares)).BeginInit();
            this.SuspendLayout();
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
            this.lblModulo.Size = new System.Drawing.Size(381, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogos de Cuentas Auxiliares";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            this.cmdCerrar.Location = new System.Drawing.Point(865, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(113, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdNuevo.FlatAppearance.BorderSize = 0;
            this.cmdNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.ForeColor = System.Drawing.Color.White;
            this.cmdNuevo.Image = global::SATeC.Properties.Resources.Agregar_32x32;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(388, 1);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(111, 40);
            this.cmdNuevo.TabIndex = 18;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // dgvCatalogosDeCuentasAuxiliares
            // 
            this.dgvCatalogosDeCuentasAuxiliares.AllowUserToAddRows = false;
            this.dgvCatalogosDeCuentasAuxiliares.AllowUserToDeleteRows = false;
            this.dgvCatalogosDeCuentasAuxiliares.AllowUserToResizeColumns = false;
            this.dgvCatalogosDeCuentasAuxiliares.AllowUserToResizeRows = false;
            this.dgvCatalogosDeCuentasAuxiliares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogosDeCuentasAuxiliares.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogosDeCuentasAuxiliares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogosDeCuentasAuxiliares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogosDeCuentasAuxiliares.ColumnHeadersHeight = 25;
            this.dgvCatalogosDeCuentasAuxiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogosDeCuentasAuxiliares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCatalogoCuentasAuxiliares,
            this.NumeroCatalogoCuentasAuxiliares,
            this.NombreCatalogoCuentasAuxiliares,
            this.NombreCatalogoCuentas,
            this.FechaAlta,
            this.ID_CatalogoCuentas,
            this.Borrar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosDeCuentasAuxiliares.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogosDeCuentasAuxiliares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogosDeCuentasAuxiliares.EnableHeadersVisualStyles = false;
            this.dgvCatalogosDeCuentasAuxiliares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentasAuxiliares.Location = new System.Drawing.Point(0, 46);
            this.dgvCatalogosDeCuentasAuxiliares.Name = "dgvCatalogosDeCuentasAuxiliares";
            this.dgvCatalogosDeCuentasAuxiliares.ReadOnly = true;
            this.dgvCatalogosDeCuentasAuxiliares.RowHeadersVisible = false;
            this.dgvCatalogosDeCuentasAuxiliares.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogosDeCuentasAuxiliares.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentasAuxiliares.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentasAuxiliares.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCatalogosDeCuentasAuxiliares.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosDeCuentasAuxiliares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogosDeCuentasAuxiliares.ShowCellErrors = false;
            this.dgvCatalogosDeCuentasAuxiliares.ShowCellToolTips = false;
            this.dgvCatalogosDeCuentasAuxiliares.ShowEditingIcon = false;
            this.dgvCatalogosDeCuentasAuxiliares.Size = new System.Drawing.Size(980, 454);
            this.dgvCatalogosDeCuentasAuxiliares.TabIndex = 20;
            this.dgvCatalogosDeCuentasAuxiliares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosDeCuentasAuxiliares_CellClick);
            this.dgvCatalogosDeCuentasAuxiliares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosDeCuentasAuxiliares_CellDoubleClick);
            // 
            // IDCatalogoCuentasAuxiliares
            // 
            this.IDCatalogoCuentasAuxiliares.HeaderText = "IDCatalogoCuentas";
            this.IDCatalogoCuentasAuxiliares.Name = "IDCatalogoCuentasAuxiliares";
            this.IDCatalogoCuentasAuxiliares.ReadOnly = true;
            this.IDCatalogoCuentasAuxiliares.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDCatalogoCuentasAuxiliares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDCatalogoCuentasAuxiliares.Visible = false;
            // 
            // NumeroCatalogoCuentasAuxiliares
            // 
            this.NumeroCatalogoCuentasAuxiliares.DividerWidth = 1;
            this.NumeroCatalogoCuentasAuxiliares.HeaderText = "No. Catálogo";
            this.NumeroCatalogoCuentasAuxiliares.MinimumWidth = 100;
            this.NumeroCatalogoCuentasAuxiliares.Name = "NumeroCatalogoCuentasAuxiliares";
            this.NumeroCatalogoCuentasAuxiliares.ReadOnly = true;
            this.NumeroCatalogoCuentasAuxiliares.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroCatalogoCuentasAuxiliares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreCatalogoCuentasAuxiliares
            // 
            this.NombreCatalogoCuentasAuxiliares.DividerWidth = 1;
            this.NombreCatalogoCuentasAuxiliares.HeaderText = "Nombre del Catálogo de Cuentas Auxiliares";
            this.NombreCatalogoCuentasAuxiliares.MinimumWidth = 340;
            this.NombreCatalogoCuentasAuxiliares.Name = "NombreCatalogoCuentasAuxiliares";
            this.NombreCatalogoCuentasAuxiliares.ReadOnly = true;
            this.NombreCatalogoCuentasAuxiliares.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCatalogoCuentasAuxiliares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCatalogoCuentasAuxiliares.Width = 340;
            // 
            // NombreCatalogoCuentas
            // 
            this.NombreCatalogoCuentas.DividerWidth = 1;
            this.NombreCatalogoCuentas.HeaderText = "Nombre del Catálogo de Cuentas";
            this.NombreCatalogoCuentas.MinimumWidth = 340;
            this.NombreCatalogoCuentas.Name = "NombreCatalogoCuentas";
            this.NombreCatalogoCuentas.ReadOnly = true;
            this.NombreCatalogoCuentas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCatalogoCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCatalogoCuentas.Width = 340;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DividerWidth = 1;
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.MinimumWidth = 130;
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            this.FechaAlta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaAlta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaAlta.Width = 130;
            // 
            // ID_CatalogoCuentas
            // 
            this.ID_CatalogoCuentas.HeaderText = "ID_CatalogoCuentas";
            this.ID_CatalogoCuentas.Name = "ID_CatalogoCuentas";
            this.ID_CatalogoCuentas.ReadOnly = true;
            this.ID_CatalogoCuentas.Visible = false;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::SATeC.Properties.Resources.Borrar_24x24;
            this.Borrar.MinimumWidth = 50;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Borrar.Width = 50;
            // 
            // frmCatalogosDeCuentasAuxiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.dgvCatalogosDeCuentasAuxiliares);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogosDeCuentasAuxiliares";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas Auxiliares";
            this.Load += new System.EventHandler(this.frmCatalogosDeCuentasAuxiliares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosDeCuentasAuxiliares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvCatalogosDeCuentasAuxiliares;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCatalogoCuentasAuxiliares;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCatalogoCuentasAuxiliares;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCatalogoCuentasAuxiliares;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCatalogoCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CatalogoCuentas;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}