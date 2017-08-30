namespace SATeC.CatalogoDeCuentas {
    partial class frmConsultarCatalogoCuentasSAT {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCatalogoCuentasSAT));
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.tgvCatalogoCuentasSAT = new AdvancedDataGridView.TreeGridView();
            this.CodigoAgrupador = new AdvancedDataGridView.TreeGridColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCuentaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdExpandir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSAT)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(341, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogo de Cuentas del SAT";
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
            this.cmdCerrar.Location = new System.Drawing.Point(494, 1);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(126, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // tgvCatalogoCuentasSAT
            // 
            this.tgvCatalogoCuentasSAT.AllowUserToAddRows = false;
            this.tgvCatalogoCuentasSAT.AllowUserToDeleteRows = false;
            this.tgvCatalogoCuentasSAT.AllowUserToResizeColumns = false;
            this.tgvCatalogoCuentasSAT.AllowUserToResizeRows = false;
            this.tgvCatalogoCuentasSAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgvCatalogoCuentasSAT.BackgroundColor = System.Drawing.Color.White;
            this.tgvCatalogoCuentasSAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tgvCatalogoCuentasSAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvCatalogoCuentasSAT.ColumnHeadersHeight = 25;
            this.tgvCatalogoCuentasSAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tgvCatalogoCuentasSAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAgrupador,
            this.NombreCuenta,
            this.IDCuentaSAT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tgvCatalogoCuentasSAT.DefaultCellStyle = dataGridViewCellStyle2;
            this.tgvCatalogoCuentasSAT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvCatalogoCuentasSAT.EnableHeadersVisualStyles = false;
            this.tgvCatalogoCuentasSAT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.tgvCatalogoCuentasSAT.ImageList = null;
            this.tgvCatalogoCuentasSAT.Location = new System.Drawing.Point(0, 97);
            this.tgvCatalogoCuentasSAT.Name = "tgvCatalogoCuentasSAT";
            this.tgvCatalogoCuentasSAT.ReadOnly = true;
            this.tgvCatalogoCuentasSAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvCatalogoCuentasSAT.RowHeadersVisible = false;
            this.tgvCatalogoCuentasSAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvCatalogoCuentasSAT.ShowCellErrors = false;
            this.tgvCatalogoCuentasSAT.ShowCellToolTips = false;
            this.tgvCatalogoCuentasSAT.ShowEditingIcon = false;
            this.tgvCatalogoCuentasSAT.Size = new System.Drawing.Size(687, 402);
            this.tgvCatalogoCuentasSAT.TabIndex = 21;
            // 
            // CodigoAgrupador
            // 
            this.CodigoAgrupador.DefaultNodeImage = null;
            this.CodigoAgrupador.DividerWidth = 1;
            this.CodigoAgrupador.HeaderText = "Código Agrupador";
            this.CodigoAgrupador.MinimumWidth = 300;
            this.CodigoAgrupador.Name = "CodigoAgrupador";
            this.CodigoAgrupador.ReadOnly = true;
            this.CodigoAgrupador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoAgrupador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoAgrupador.Width = 300;
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
            // IDCuentaSAT
            // 
            this.IDCuentaSAT.DividerWidth = 1;
            this.IDCuentaSAT.HeaderText = "IDCuentaSAT";
            this.IDCuentaSAT.Name = "IDCuentaSAT";
            this.IDCuentaSAT.ReadOnly = true;
            this.IDCuentaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDCuentaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.cmdExpandir.TabIndex = 23;
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
            this.btnExportar.Location = new System.Drawing.Point(494, 51);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(190, 43);
            this.btnExportar.TabIndex = 24;
            this.btnExportar.Text = "&Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmConsultarCatalogoCuentasSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 500);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cmdExpandir);
            this.Controls.Add(this.tgvCatalogoCuentasSAT);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCatalogoCuentasSAT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas";
            this.Load += new System.EventHandler(this.frmConsultarCatalogoCuentasSAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblModulo;
        private AdvancedDataGridView.TreeGridView tgvCatalogoCuentasSAT;
        private System.Windows.Forms.Button cmdExpandir;
        private AdvancedDataGridView.TreeGridColumn CodigoAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCuentaSAT;
        private System.Windows.Forms.Button btnExportar;

    }
}