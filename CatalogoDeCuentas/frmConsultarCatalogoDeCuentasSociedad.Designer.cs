namespace SATeC.CatalogoDeCuentas {
    partial class frmConsultarCatalogoDeCuentasSociedad {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCatalogoDeCuentasSociedad));
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.tgvCatalogoCuentasSociedad = new AdvancedDataGridView.TreeGridView();
            this.Cuenta = new AdvancedDataGridView.TreeGridColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naturaleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdExpandir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSociedad)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(422, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogo de Cuentas de la Sociedad";
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
            this.cmdCerrar.Location = new System.Drawing.Point(577, 5);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // tgvCatalogoCuentasSociedad
            // 
            this.tgvCatalogoCuentasSociedad.AllowUserToAddRows = false;
            this.tgvCatalogoCuentasSociedad.AllowUserToDeleteRows = false;
            this.tgvCatalogoCuentasSociedad.AllowUserToResizeColumns = false;
            this.tgvCatalogoCuentasSociedad.AllowUserToResizeRows = false;
            this.tgvCatalogoCuentasSociedad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgvCatalogoCuentasSociedad.BackgroundColor = System.Drawing.Color.White;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersHeight = 25;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tgvCatalogoCuentasSociedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.NombreCuenta,
            this.Naturaleza});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tgvCatalogoCuentasSociedad.DefaultCellStyle = dataGridViewCellStyle4;
            this.tgvCatalogoCuentasSociedad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvCatalogoCuentasSociedad.EnableHeadersVisualStyles = false;
            this.tgvCatalogoCuentasSociedad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.tgvCatalogoCuentasSociedad.ImageList = null;
            this.tgvCatalogoCuentasSociedad.Location = new System.Drawing.Point(0, 97);
            this.tgvCatalogoCuentasSociedad.Name = "tgvCatalogoCuentasSociedad";
            this.tgvCatalogoCuentasSociedad.ReadOnly = true;
            this.tgvCatalogoCuentasSociedad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tgvCatalogoCuentasSociedad.RowHeadersVisible = false;
            this.tgvCatalogoCuentasSociedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvCatalogoCuentasSociedad.ShowCellErrors = false;
            this.tgvCatalogoCuentasSociedad.ShowCellToolTips = false;
            this.tgvCatalogoCuentasSociedad.ShowEditingIcon = false;
            this.tgvCatalogoCuentasSociedad.Size = new System.Drawing.Size(687, 371);
            this.tgvCatalogoCuentasSociedad.TabIndex = 21;
            // 
            // Cuenta
            // 
            this.Cuenta.DefaultNodeImage = null;
            this.Cuenta.DividerWidth = 1;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 300;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cuenta.Width = 300;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.DividerWidth = 1;
            this.NombreCuenta.HeaderText = "Nombre de la Cuenta";
            this.NombreCuenta.MinimumWidth = 700;
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            this.NombreCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCuenta.Width = 700;
            // 
            // Naturaleza
            // 
            this.Naturaleza.DividerWidth = 1;
            this.Naturaleza.HeaderText = "Naturaleza";
            this.Naturaleza.MinimumWidth = 50;
            this.Naturaleza.Name = "Naturaleza";
            this.Naturaleza.ReadOnly = true;
            this.Naturaleza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Naturaleza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmdExpandir
            // 
            this.cmdExpandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdExpandir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdExpandir.FlatAppearance.BorderSize = 0;
            this.cmdExpandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdExpandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExpandir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExpandir.ForeColor = System.Drawing.Color.White;
            this.cmdExpandir.Image = ((System.Drawing.Image)(resources.GetObject("cmdExpandir.Image")));
            this.cmdExpandir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExpandir.Location = new System.Drawing.Point(8, 46);
            this.cmdExpandir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdExpandir.Name = "cmdExpandir";
            this.cmdExpandir.Size = new System.Drawing.Size(175, 43);
            this.cmdExpandir.TabIndex = 22;
            this.cmdExpandir.Text = "&Expandir Todo";
            this.cmdExpandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExpandir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExpandir.UseVisualStyleBackColor = false;
            this.cmdExpandir.Click += new System.EventHandler(this.cmdExpandir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::SATeC.Properties.Resources.Descargar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(503, 51);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(184, 40);
            this.btnExportar.TabIndex = 23;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmConsultarCatalogoDeCuentasSociedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 500);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cmdExpandir);
            this.Controls.Add(this.tgvCatalogoCuentasSociedad);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCatalogoDeCuentasSociedad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas";
            this.Load += new System.EventHandler(this.frmConsultarCatalogoDeCuentasSociedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSociedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblModulo;
        private AdvancedDataGridView.TreeGridView tgvCatalogoCuentasSociedad;
        private System.Windows.Forms.Button cmdExpandir;
        private AdvancedDataGridView.TreeGridColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naturaleza;
        private System.Windows.Forms.Button btnExportar;
    }
}