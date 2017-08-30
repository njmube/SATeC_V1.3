namespace SATeC.CatalogoDeCuentas {
	partial class frmSeleccionarCuentaSATRelacionCuentasSociedad {
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
            this.tgvCatalogoCuentasSAT = new AdvancedDataGridView.TreeGridView();
            this.CodigoAgrupador = new AdvancedDataGridView.TreeGridColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsParent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsChild = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSAT)).BeginInit();
            this.SuspendLayout();
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
            this.IsParent,
            this.IsChild});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tgvCatalogoCuentasSAT.DefaultCellStyle = dataGridViewCellStyle2;
            this.tgvCatalogoCuentasSAT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvCatalogoCuentasSAT.EnableHeadersVisualStyles = false;
            this.tgvCatalogoCuentasSAT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.tgvCatalogoCuentasSAT.ImageList = null;
            this.tgvCatalogoCuentasSAT.Location = new System.Drawing.Point(0, 0);
            this.tgvCatalogoCuentasSAT.MultiSelect = false;
            this.tgvCatalogoCuentasSAT.Name = "tgvCatalogoCuentasSAT";
            this.tgvCatalogoCuentasSAT.ReadOnly = true;
            this.tgvCatalogoCuentasSAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvCatalogoCuentasSAT.RowHeadersVisible = false;
            this.tgvCatalogoCuentasSAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvCatalogoCuentasSAT.ShowCellErrors = false;
            this.tgvCatalogoCuentasSAT.ShowCellToolTips = false;
            this.tgvCatalogoCuentasSAT.ShowEditingIcon = false;
            this.tgvCatalogoCuentasSAT.Size = new System.Drawing.Size(544, 420);
            this.tgvCatalogoCuentasSAT.TabIndex = 21;
            this.tgvCatalogoCuentasSAT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tgvCatalogoCuentasSAT_CellDoubleClick);
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
            // IsParent
            // 
            this.IsParent.DividerWidth = 1;
            this.IsParent.HeaderText = "IsParent";
            this.IsParent.MinimumWidth = 60;
            this.IsParent.Name = "IsParent";
            this.IsParent.ReadOnly = true;
            this.IsParent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsParent.Visible = false;
            this.IsParent.Width = 60;
            // 
            // IsChild
            // 
            this.IsChild.DividerWidth = 1;
            this.IsChild.HeaderText = "IsChild";
            this.IsChild.MinimumWidth = 50;
            this.IsChild.Name = "IsChild";
            this.IsChild.ReadOnly = true;
            this.IsChild.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsChild.Visible = false;
            this.IsChild.Width = 50;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
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
            this.cmdCancelar.Location = new System.Drawing.Point(273, 425);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(127, 40);
            this.cmdCancelar.TabIndex = 23;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.White;
            this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(147, 425);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(120, 40);
            this.cmdGuardar.TabIndex = 22;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmSeleccionarCuentaSATRelacionCuentasSociedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 471);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.tgvCatalogoCuentasSAT);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionarCuentaSATRelacionCuentasSociedad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Cuenta del SAT a Relacionar";
            this.Load += new System.EventHandler(this.frmSeleccionarCuentaSATRelacionCuentasSociedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSAT)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private AdvancedDataGridView.TreeGridView tgvCatalogoCuentasSAT;
		private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private AdvancedDataGridView.TreeGridColumn CodigoAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsParent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChild;
	}
}