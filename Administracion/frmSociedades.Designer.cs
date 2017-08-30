namespace SATeC.Administracion {
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
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.dgvSociedades = new SATeC.SATecDataGridView();
            this.NumeroSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogoCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociedades)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(142, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Sociedades";
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
            this.cmdCerrar.Location = new System.Drawing.Point(856, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(122, 40);
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
            this.cmdNuevo.Location = new System.Drawing.Point(729, 3);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(121, 40);
            this.cmdNuevo.TabIndex = 18;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNuevo.UseVisualStyleBackColor = false;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSociedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSociedades.ColumnHeadersHeight = 40;
            this.dgvSociedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSociedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroSociedad,
            this.RFCSociedad,
            this.NombreSociedad,
            this.CatalogoCuentas,
            this.ID_Sociedad,
            this.Borrar});
            this.dgvSociedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSociedades.EnableHeadersVisualStyles = false;
            this.dgvSociedades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvSociedades.Location = new System.Drawing.Point(0, 49);
            this.dgvSociedades.Name = "dgvSociedades";
            this.dgvSociedades.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.dgvSociedades.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSociedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSociedades.ShowCellErrors = false;
            this.dgvSociedades.ShowCellToolTips = false;
            this.dgvSociedades.ShowEditingIcon = false;
            this.dgvSociedades.Size = new System.Drawing.Size(980, 451);
            this.dgvSociedades.TabIndex = 20;
            this.dgvSociedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociedades_CellClick);
            this.dgvSociedades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociedades_CellDoubleClick);
            // 
            // NumeroSociedad
            // 
            this.NumeroSociedad.DividerWidth = 1;
            this.NumeroSociedad.HeaderText = "No. Sociedad";
            this.NumeroSociedad.MinimumWidth = 100;
            this.NumeroSociedad.Name = "NumeroSociedad";
            this.NumeroSociedad.ReadOnly = true;
            this.NumeroSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RFCSociedad
            // 
            this.RFCSociedad.DividerWidth = 1;
            this.RFCSociedad.HeaderText = "Registro de Contribuyente";
            this.RFCSociedad.MinimumWidth = 200;
            this.RFCSociedad.Name = "RFCSociedad";
            this.RFCSociedad.ReadOnly = true;
            this.RFCSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RFCSociedad.Width = 200;
            // 
            // NombreSociedad
            // 
            this.NombreSociedad.DividerWidth = 1;
            this.NombreSociedad.HeaderText = "Nombre de la Sociedad";
            this.NombreSociedad.MinimumWidth = 400;
            this.NombreSociedad.Name = "NombreSociedad";
            this.NombreSociedad.ReadOnly = true;
            this.NombreSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreSociedad.Width = 400;
            // 
            // CatalogoCuentas
            // 
            this.CatalogoCuentas.DividerWidth = 1;
            this.CatalogoCuentas.HeaderText = "Catalogo de Cuentas";
            this.CatalogoCuentas.MinimumWidth = 260;
            this.CatalogoCuentas.Name = "CatalogoCuentas";
            this.CatalogoCuentas.ReadOnly = true;
            this.CatalogoCuentas.Width = 260;
            // 
            // ID_Sociedad
            // 
            this.ID_Sociedad.HeaderText = "ID_Sociedad";
            this.ID_Sociedad.Name = "ID_Sociedad";
            this.ID_Sociedad.ReadOnly = true;
            this.ID_Sociedad.Visible = false;
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
            // frmSociedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.dgvSociedades);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSociedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sociedades";
            this.Load += new System.EventHandler(this.frmSociedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvSociedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogoCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sociedad;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}