namespace SATeC {
    partial class frmSociedades {
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
			this.dgvSociedades = new SATeC.SATecDataGridView();
			this.IDSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RFCSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrimerFechaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UltimaFechaSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSociedades)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSociedades
			// 
			this.dgvSociedades.AllowUserToAddRows = false;
			this.dgvSociedades.AllowUserToDeleteRows = false;
			this.dgvSociedades.AllowUserToResizeColumns = false;
			this.dgvSociedades.AllowUserToResizeRows = false;
			this.dgvSociedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSociedades.BackgroundColor = System.Drawing.Color.White;
			this.dgvSociedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSociedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSociedades.ColumnHeadersHeight = 45;
			this.dgvSociedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvSociedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSociedad,
            this.NumeroSociedad,
            this.NombreSociedad,
            this.RFCSociedad,
            this.CatalogoCuentas,
            this.PrimerFechaSAT,
            this.UltimaFechaSAT});
			this.dgvSociedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvSociedades.EnableHeadersVisualStyles = false;
			this.dgvSociedades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvSociedades.Location = new System.Drawing.Point(0, 0);
			this.dgvSociedades.Name = "dgvSociedades";
			this.dgvSociedades.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSociedades.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSociedades.RowHeadersVisible = false;
			this.dgvSociedades.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSociedades.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvSociedades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.dgvSociedades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvSociedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSociedades.ShowCellErrors = false;
			this.dgvSociedades.ShowCellToolTips = false;
			this.dgvSociedades.ShowEditingIcon = false;
			this.dgvSociedades.ShowRowErrors = false;
			this.dgvSociedades.Size = new System.Drawing.Size(980, 500);
			this.dgvSociedades.TabIndex = 0;
			this.dgvSociedades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociedades_CellDoubleClick);
			// 
			// IDSociedad
			// 
			this.IDSociedad.HeaderText = "IDSociedad";
			this.IDSociedad.Name = "IDSociedad";
			this.IDSociedad.ReadOnly = true;
			this.IDSociedad.Visible = false;
			// 
			// NumeroSociedad
			// 
			this.NumeroSociedad.DividerWidth = 1;
			this.NumeroSociedad.HeaderText = "No. Sociedad";
			this.NumeroSociedad.MinimumWidth = 70;
			this.NumeroSociedad.Name = "NumeroSociedad";
			this.NumeroSociedad.ReadOnly = true;
			this.NumeroSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NumeroSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.NumeroSociedad.Width = 70;
			// 
			// NombreSociedad
			// 
			this.NombreSociedad.DividerWidth = 1;
			this.NombreSociedad.HeaderText = "Nombre de la Sociedad";
			this.NombreSociedad.MinimumWidth = 400;
			this.NombreSociedad.Name = "NombreSociedad";
			this.NombreSociedad.ReadOnly = true;
			this.NombreSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.NombreSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.NombreSociedad.Width = 400;
			// 
			// RFCSociedad
			// 
			this.RFCSociedad.DividerWidth = 1;
			this.RFCSociedad.HeaderText = "RFCSociedad";
			this.RFCSociedad.MinimumWidth = 100;
			this.RFCSociedad.Name = "RFCSociedad";
			this.RFCSociedad.ReadOnly = true;
			this.RFCSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.RFCSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.RFCSociedad.Visible = false;
			// 
			// CatalogoCuentas
			// 
			this.CatalogoCuentas.DividerWidth = 1;
			this.CatalogoCuentas.HeaderText = "Catálogo de Cuentas";
			this.CatalogoCuentas.MinimumWidth = 210;
			this.CatalogoCuentas.Name = "CatalogoCuentas";
			this.CatalogoCuentas.ReadOnly = true;
			this.CatalogoCuentas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.CatalogoCuentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.CatalogoCuentas.Width = 210;
			// 
			// PrimerFechaSAT
			// 
			this.PrimerFechaSAT.DividerWidth = 1;
			this.PrimerFechaSAT.HeaderText = "Primer fecha presentación al SAT";
			this.PrimerFechaSAT.MinimumWidth = 140;
			this.PrimerFechaSAT.Name = "PrimerFechaSAT";
			this.PrimerFechaSAT.ReadOnly = true;
			this.PrimerFechaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.PrimerFechaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.PrimerFechaSAT.Width = 140;
			// 
			// UltimaFechaSAT
			// 
			this.UltimaFechaSAT.DividerWidth = 1;
			this.UltimaFechaSAT.HeaderText = "Ultima fecha presentación al SAT";
			this.UltimaFechaSAT.MinimumWidth = 140;
			this.UltimaFechaSAT.Name = "UltimaFechaSAT";
			this.UltimaFechaSAT.ReadOnly = true;
			this.UltimaFechaSAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UltimaFechaSAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.UltimaFechaSAT.Width = 140;
			// 
			// frmSociedades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(980, 500);
			this.Controls.Add(this.dgvSociedades);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSociedades";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Selección de Sociedad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSociedades_FormClosing);
			this.Load += new System.EventHandler(this.frmSociedades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSociedades)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private SATeC.SATecDataGridView dgvSociedades;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDSociedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSociedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreSociedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn RFCSociedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn CatalogoCuentas;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrimerFechaSAT;
		private System.Windows.Forms.DataGridViewTextBoxColumn UltimaFechaSAT;
    }
}