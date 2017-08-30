namespace SATeC.CatalogoDeCuentas {
	partial class frmConsultarCatalogosFormatoXML {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.dgvCatalogosImportados = new SATeC.SATecDataGridView();
            this.ID_CatalogoDeCuentasImportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.XML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarXLS = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportarPDF = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosImportados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BackColor = System.Drawing.Color.White;
            this.lblModulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.lblModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModulo.Location = new System.Drawing.Point(0, 3);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(455, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Catálogos Convertidos a Formato XML";
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
            this.cmdCerrar.Location = new System.Drawing.Point(929, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(130, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // dgvCatalogosImportados
            // 
            this.dgvCatalogosImportados.AllowUserToAddRows = false;
            this.dgvCatalogosImportados.AllowUserToDeleteRows = false;
            this.dgvCatalogosImportados.AllowUserToResizeColumns = false;
            this.dgvCatalogosImportados.AllowUserToResizeRows = false;
            this.dgvCatalogosImportados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogosImportados.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogosImportados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogosImportados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogosImportados.ColumnHeadersHeight = 25;
            this.dgvCatalogosImportados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogosImportados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CatalogoDeCuentasImportado,
            this.Ejercicio,
            this.Periodo,
            this.FechaImportacion,
            this.UsuarioImportacion,
            this.FechaConversion,
            this.UsuarioConversion,
            this.Actualizado,
            this.Borrar,
            this.XML,
            this.ExportarXLS,
            this.ExportarPDF});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosImportados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCatalogosImportados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogosImportados.EnableHeadersVisualStyles = false;
            this.dgvCatalogosImportados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosImportados.Location = new System.Drawing.Point(0, 46);
            this.dgvCatalogosImportados.Name = "dgvCatalogosImportados";
            this.dgvCatalogosImportados.ReadOnly = true;
            this.dgvCatalogosImportados.RowHeadersVisible = false;
            this.dgvCatalogosImportados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogosImportados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosImportados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvCatalogosImportados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCatalogosImportados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogosImportados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogosImportados.ShowCellErrors = false;
            this.dgvCatalogosImportados.ShowCellToolTips = false;
            this.dgvCatalogosImportados.ShowEditingIcon = false;
            this.dgvCatalogosImportados.Size = new System.Drawing.Size(1036, 454);
            this.dgvCatalogosImportados.TabIndex = 21;
            this.dgvCatalogosImportados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosImportados_CellClick);
            this.dgvCatalogosImportados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogosImportados_CellDoubleClick);
            // 
            // ID_CatalogoDeCuentasImportado
            // 
            this.ID_CatalogoDeCuentasImportado.DividerWidth = 1;
            this.ID_CatalogoDeCuentasImportado.HeaderText = "ID_CatalogoDeCuentasImportado";
            this.ID_CatalogoDeCuentasImportado.Name = "ID_CatalogoDeCuentasImportado";
            this.ID_CatalogoDeCuentasImportado.ReadOnly = true;
            this.ID_CatalogoDeCuentasImportado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_CatalogoDeCuentasImportado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_CatalogoDeCuentasImportado.Visible = false;
            // 
            // Ejercicio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ejercicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ejercicio.DividerWidth = 1;
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.MinimumWidth = 60;
            this.Ejercicio.Name = "Ejercicio";
            this.Ejercicio.ReadOnly = true;
            this.Ejercicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ejercicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ejercicio.Width = 60;
            // 
            // Periodo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Periodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Periodo.DividerWidth = 1;
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 100;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Periodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaImportacion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaImportacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaImportacion.DividerWidth = 1;
            this.FechaImportacion.HeaderText = "Fecha de Importación";
            this.FechaImportacion.MinimumWidth = 150;
            this.FechaImportacion.Name = "FechaImportacion";
            this.FechaImportacion.ReadOnly = true;
            this.FechaImportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaImportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaImportacion.Width = 150;
            // 
            // UsuarioImportacion
            // 
            this.UsuarioImportacion.HeaderText = "Usuario Importación";
            this.UsuarioImportacion.MinimumWidth = 100;
            this.UsuarioImportacion.Name = "UsuarioImportacion";
            this.UsuarioImportacion.ReadOnly = true;
            this.UsuarioImportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioImportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaConversion
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaConversion.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaConversion.DividerWidth = 1;
            this.FechaConversion.HeaderText = "Fecha de Conversión";
            this.FechaConversion.MinimumWidth = 150;
            this.FechaConversion.Name = "FechaConversion";
            this.FechaConversion.ReadOnly = true;
            this.FechaConversion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaConversion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaConversion.Width = 150;
            // 
            // UsuarioConversion
            // 
            this.UsuarioConversion.DividerWidth = 1;
            this.UsuarioConversion.HeaderText = "Usuario Conversión";
            this.UsuarioConversion.MinimumWidth = 200;
            this.UsuarioConversion.Name = "UsuarioConversion";
            this.UsuarioConversion.ReadOnly = true;
            this.UsuarioConversion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioConversion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UsuarioConversion.Width = 200;
            // 
            // Actualizado
            // 
            this.Actualizado.HeaderText = "Actualizado";
            this.Actualizado.MinimumWidth = 100;
            this.Actualizado.Name = "Actualizado";
            this.Actualizado.ReadOnly = true;
            this.Actualizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::SATeC.Properties.Resources.Borrar_24x24;
            this.Borrar.MinimumWidth = 50;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Borrar.Visible = false;
            this.Borrar.Width = 50;
            // 
            // XML
            // 
            this.XML.HeaderText = "XML";
            this.XML.MaxInputLength = 100000;
            this.XML.Name = "XML";
            this.XML.ReadOnly = true;
            this.XML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.XML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.XML.Visible = false;
            // 
            // ExportarXLS
            // 
            this.ExportarXLS.HeaderText = "Exportar XLS";
            this.ExportarXLS.Image = global::SATeC.Properties.Resources.excel22x22;
            this.ExportarXLS.MinimumWidth = 100;
            this.ExportarXLS.Name = "ExportarXLS";
            this.ExportarXLS.ReadOnly = true;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.HeaderText = "Export PDF";
            this.ExportarPDF.Image = global::SATeC.Properties.Resources.pdf22x22;
            this.ExportarPDF.MinimumWidth = 100;
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.ReadOnly = true;
            this.ExportarPDF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmConsultarCatalogosFormatoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 500);
            this.Controls.Add(this.dgvCatalogosImportados);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCatalogosFormatoXML";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catálogos de Cuentas";
            this.Load += new System.EventHandler(this.frmVerificarCatalogosFormatoXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogosImportados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvCatalogosImportados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CatalogoDeCuentasImportado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actualizado;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn XML;
        private System.Windows.Forms.DataGridViewImageColumn ExportarXLS;
        private System.Windows.Forms.DataGridViewImageColumn ExportarPDF;
	}
}