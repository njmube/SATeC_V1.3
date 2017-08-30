namespace SATeC.Administracion {
    partial class frmCatalogosDeCuentas {
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
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.dgvCatalogosDeCuentas = new SATeC.SATecDataGridView();
            this.IDCatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosDeCuentas)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(261, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogos de Cuentas";
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
            this.cmdNuevo.Location = new System.Drawing.Point(268, 1);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(120, 40);
            this.cmdNuevo.TabIndex = 18;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            this.cmdCerrar.Location = new System.Drawing.Point(852, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(126, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // dgvCatalogosDeCuentas
            // 
            this.dgvCatalogosDeCuentas.AllowUserToAddRows = false;
            this.dgvCatalogosDeCuentas.AllowUserToDeleteRows = false;
            this.dgvCatalogosDeCuentas.AllowUserToResizeColumns = false;
            this.dgvCatalogosDeCuentas.AllowUserToResizeRows = false;
            this.dgvCatalogosDeCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogosDeCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogosDeCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogosDeCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogosDeCuentas.ColumnHeadersHeight = 25;
            this.dgvCatalogosDeCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogosDeCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCatalogoCuentas,
            this.NumeroCatalogoCuentas,
            this.NombreCatalogoCuentas,
            this.FechaAlta,
            this.Borrar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosDeCuentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogosDeCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogosDeCuentas.EnableHeadersVisualStyles = false;
            this.dgvCatalogosDeCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentas.Location = new System.Drawing.Point(0, 46);
            this.dgvCatalogosDeCuentas.Name = "dgvCatalogosDeCuentas";
            this.dgvCatalogosDeCuentas.ReadOnly = true;
            this.dgvCatalogosDeCuentas.RowHeadersVisible = false;
            this.dgvCatalogosDeCuentas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogosDeCuentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosDeCuentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCatalogosDeCuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosDeCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogosDeCuentas.ShowCellErrors = false;
            this.dgvCatalogosDeCuentas.ShowCellToolTips = false;
            this.dgvCatalogosDeCuentas.ShowEditingIcon = false;
            this.dgvCatalogosDeCuentas.Size = new System.Drawing.Size(980, 454);
            this.dgvCatalogosDeCuentas.TabIndex = 20;
            this.dgvCatalogosDeCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosDeCuentas_CellClick);
            this.dgvCatalogosDeCuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosDeCuentas_CellDoubleClick);
            // 
            // IDCatalogoCuentas
            // 
            this.IDCatalogoCuentas.HeaderText = "IDCatalogoCuentas";
            this.IDCatalogoCuentas.Name = "IDCatalogoCuentas";
            this.IDCatalogoCuentas.ReadOnly = true;
            this.IDCatalogoCuentas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDCatalogoCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDCatalogoCuentas.Visible = false;
            // 
            // NumeroCatalogoCuentas
            // 
            this.NumeroCatalogoCuentas.DividerWidth = 1;
            this.NumeroCatalogoCuentas.HeaderText = "No. Catálogo";
            this.NumeroCatalogoCuentas.MinimumWidth = 100;
            this.NumeroCatalogoCuentas.Name = "NumeroCatalogoCuentas";
            this.NumeroCatalogoCuentas.ReadOnly = true;
            this.NumeroCatalogoCuentas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroCatalogoCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreCatalogoCuentas
            // 
            this.NombreCatalogoCuentas.DividerWidth = 1;
            this.NombreCatalogoCuentas.HeaderText = "Nombre del Catálogo";
            this.NombreCatalogoCuentas.MinimumWidth = 400;
            this.NombreCatalogoCuentas.Name = "NombreCatalogoCuentas";
            this.NombreCatalogoCuentas.ReadOnly = true;
            this.NombreCatalogoCuentas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCatalogoCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCatalogoCuentas.Width = 400;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DividerWidth = 1;
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.MinimumWidth = 250;
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            this.FechaAlta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaAlta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaAlta.Width = 250;
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
            // frmCatalogosDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.dgvCatalogosDeCuentas);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogosDeCuentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas";
            this.Load += new System.EventHandler(this.frmCatalogosDeCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosDeCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvCatalogosDeCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCatalogoCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCatalogoCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCatalogoCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}