namespace SATeC.Polizas {
	partial class frmConsultarPolizas {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.dgvPolizasImportadas = new SATeC.SATecDataGridView();
            this.ID_Poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConversionXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioConversionXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportarXLS = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportarPDF = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReporteCuentas = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizasImportadas)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(180, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Validar Pólizas";
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
            this.cmdCerrar.Location = new System.Drawing.Point(919, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(120, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // dgvPolizasImportadas
            // 
            this.dgvPolizasImportadas.AllowUserToAddRows = false;
            this.dgvPolizasImportadas.AllowUserToDeleteRows = false;
            this.dgvPolizasImportadas.AllowUserToResizeColumns = false;
            this.dgvPolizasImportadas.AllowUserToResizeRows = false;
            this.dgvPolizasImportadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPolizasImportadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPolizasImportadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPolizasImportadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizasImportadas.ColumnHeadersHeight = 25;
            this.dgvPolizasImportadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPolizasImportadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Poliza,
            this.Ejercicio,
            this.Periodo,
            this.FechaImportacion,
            this.UsuarioImportacion,
            this.FechaConversionXML,
            this.UsuarioConversionXML,
            this.Borrar,
            this.ExportarXLS,
            this.ExportarPDF,
            this.ReporteCuentas});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPolizasImportadas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPolizasImportadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPolizasImportadas.EnableHeadersVisualStyles = false;
            this.dgvPolizasImportadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvPolizasImportadas.Location = new System.Drawing.Point(0, 46);
            this.dgvPolizasImportadas.Name = "dgvPolizasImportadas";
            this.dgvPolizasImportadas.ReadOnly = true;
            this.dgvPolizasImportadas.RowHeadersVisible = false;
            this.dgvPolizasImportadas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizasImportadas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvPolizasImportadas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvPolizasImportadas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPolizasImportadas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPolizasImportadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizasImportadas.ShowCellErrors = false;
            this.dgvPolizasImportadas.ShowCellToolTips = false;
            this.dgvPolizasImportadas.ShowEditingIcon = false;
            this.dgvPolizasImportadas.Size = new System.Drawing.Size(1049, 454);
            this.dgvPolizasImportadas.TabIndex = 20;
            this.dgvPolizasImportadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizasImportadas_CellClick);
            this.dgvPolizasImportadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizasImportadas_CellDoubleClick);
            // 
            // ID_Poliza
            // 
            this.ID_Poliza.DividerWidth = 1;
            this.ID_Poliza.HeaderText = "ID_Poliza";
            this.ID_Poliza.Name = "ID_Poliza";
            this.ID_Poliza.ReadOnly = true;
            this.ID_Poliza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Poliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Poliza.Visible = false;
            // 
            // Ejercicio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaImportacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaImportacion.DividerWidth = 1;
            this.FechaImportacion.HeaderText = "Fecha de Importación";
            this.FechaImportacion.MinimumWidth = 300;
            this.FechaImportacion.Name = "FechaImportacion";
            this.FechaImportacion.ReadOnly = true;
            this.FechaImportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaImportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaImportacion.Width = 300;
            // 
            // UsuarioImportacion
            // 
            this.UsuarioImportacion.HeaderText = "Usuario Importación";
            this.UsuarioImportacion.MinimumWidth = 500;
            this.UsuarioImportacion.Name = "UsuarioImportacion";
            this.UsuarioImportacion.ReadOnly = true;
            this.UsuarioImportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioImportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UsuarioImportacion.Width = 500;
            // 
            // FechaConversionXML
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaConversionXML.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaConversionXML.DividerWidth = 1;
            this.FechaConversionXML.HeaderText = "Fecha de Conversión";
            this.FechaConversionXML.MinimumWidth = 180;
            this.FechaConversionXML.Name = "FechaConversionXML";
            this.FechaConversionXML.ReadOnly = true;
            this.FechaConversionXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaConversionXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaConversionXML.Width = 180;
            // 
            // UsuarioConversionXML
            // 
            this.UsuarioConversionXML.DividerWidth = 1;
            this.UsuarioConversionXML.HeaderText = "Usuario Conversión XML";
            this.UsuarioConversionXML.MinimumWidth = 100;
            this.UsuarioConversionXML.Name = "UsuarioConversionXML";
            this.UsuarioConversionXML.ReadOnly = true;
            this.UsuarioConversionXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioConversionXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.ExportarPDF.HeaderText = "Exportar PDF";
            this.ExportarPDF.Image = global::SATeC.Properties.Resources.pdf22x22;
            this.ExportarPDF.MinimumWidth = 100;
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.ReadOnly = true;
            // 
            // ReporteCuentas
            // 
            this.ReporteCuentas.HeaderText = "Reporte Cuentas";
            this.ReporteCuentas.Image = global::SATeC.Properties.Resources.excel22x22;
            this.ReporteCuentas.MinimumWidth = 200;
            this.ReporteCuentas.Name = "ReporteCuentas";
            this.ReporteCuentas.ReadOnly = true;
            this.ReporteCuentas.Width = 200;
            // 
            // frmConsultarPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 500);
            this.Controls.Add(this.dgvPolizasImportadas);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarPolizas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Balanzas Importadas No Convertidas a XML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultarPolizas_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultarPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizasImportadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvPolizasImportadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConversionXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioConversionXML;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewImageColumn ExportarXLS;
        private System.Windows.Forms.DataGridViewImageColumn ExportarPDF;
        private System.Windows.Forms.DataGridViewImageColumn ReporteCuentas;
	}
}