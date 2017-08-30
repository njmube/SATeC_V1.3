namespace SATeC.Balanza {
	partial class frmConsultarBalanzasImportadas {
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
            this.dgvBalanzasImportadas = new SATeC.SATecDataGridView();
            this.ID_Balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioImportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConversionXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioConversionXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.XML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarXLS = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportarPDF = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportarXLSSAT = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanzasImportadas)).BeginInit();
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
            this.lblModulo.Size = new System.Drawing.Size(306, 25);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Validar Balanzas Importadas con ";
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
            this.cmdCerrar.Location = new System.Drawing.Point(966, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(126, 40);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // dgvBalanzasImportadas
            // 
            this.dgvBalanzasImportadas.AllowUserToAddRows = false;
            this.dgvBalanzasImportadas.AllowUserToDeleteRows = false;
            this.dgvBalanzasImportadas.AllowUserToResizeColumns = false;
            this.dgvBalanzasImportadas.AllowUserToResizeRows = false;
            this.dgvBalanzasImportadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBalanzasImportadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvBalanzasImportadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalanzasImportadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBalanzasImportadas.ColumnHeadersHeight = 25;
            this.dgvBalanzasImportadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBalanzasImportadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Balanza,
            this.Ejercicio,
            this.Periodo,
            this.FechaImportacion,
            this.UsuarioImportacion,
            this.FechaConversionXML,
            this.UsuarioConversionXML,
            this.Borrar,
            this.XML,
            this.ExportarXLS,
            this.ExportarPDF,
            this.ExportarXLSSAT});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalanzasImportadas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBalanzasImportadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBalanzasImportadas.EnableHeadersVisualStyles = false;
            this.dgvBalanzasImportadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanzasImportadas.Location = new System.Drawing.Point(0, 46);
            this.dgvBalanzasImportadas.Name = "dgvBalanzasImportadas";
            this.dgvBalanzasImportadas.ReadOnly = true;
            this.dgvBalanzasImportadas.RowHeadersVisible = false;
            this.dgvBalanzasImportadas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBalanzasImportadas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanzasImportadas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.dgvBalanzasImportadas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBalanzasImportadas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalanzasImportadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalanzasImportadas.ShowCellErrors = false;
            this.dgvBalanzasImportadas.ShowCellToolTips = false;
            this.dgvBalanzasImportadas.ShowEditingIcon = false;
            this.dgvBalanzasImportadas.Size = new System.Drawing.Size(1082, 454);
            this.dgvBalanzasImportadas.TabIndex = 20;
            this.dgvBalanzasImportadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalanzasImportadas_CellClick);
            this.dgvBalanzasImportadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBalanzasImportadas_CellDoubleClick);
            // 
            // ID_Balanza
            // 
            this.ID_Balanza.DividerWidth = 1;
            this.ID_Balanza.HeaderText = "ID_Balanza";
            this.ID_Balanza.Name = "ID_Balanza";
            this.ID_Balanza.ReadOnly = true;
            this.ID_Balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Balanza.Visible = false;
            // 
            // Ejercicio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Ejercicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ejercicio.DividerWidth = 1;
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.MinimumWidth = 100;
            this.Ejercicio.Name = "Ejercicio";
            this.Ejercicio.ReadOnly = true;
            this.Ejercicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ejercicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.UsuarioImportacion.MinimumWidth = 100;
            this.UsuarioImportacion.Name = "UsuarioImportacion";
            this.UsuarioImportacion.ReadOnly = true;
            this.UsuarioImportacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioImportacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaConversionXML
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaConversionXML.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaConversionXML.DividerWidth = 1;
            this.FechaConversionXML.HeaderText = "Fecha de Conversión";
            this.FechaConversionXML.MinimumWidth = 300;
            this.FechaConversionXML.Name = "FechaConversionXML";
            this.FechaConversionXML.ReadOnly = true;
            this.FechaConversionXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaConversionXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaConversionXML.Width = 300;
            // 
            // UsuarioConversionXML
            // 
            this.UsuarioConversionXML.DividerWidth = 1;
            this.UsuarioConversionXML.HeaderText = "Usuario Conversión XML";
            this.UsuarioConversionXML.MinimumWidth = 200;
            this.UsuarioConversionXML.Name = "UsuarioConversionXML";
            this.UsuarioConversionXML.ReadOnly = true;
            this.UsuarioConversionXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioConversionXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UsuarioConversionXML.Width = 200;
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
            this.ExportarXLS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ExportarPDF
            // 
            this.ExportarPDF.HeaderText = "Exportar PDF";
            this.ExportarPDF.Image = global::SATeC.Properties.Resources.pdf22x22;
            this.ExportarPDF.MinimumWidth = 100;
            this.ExportarPDF.Name = "ExportarPDF";
            this.ExportarPDF.ReadOnly = true;
            // 
            // ExportarXLSSAT
            // 
            this.ExportarXLSSAT.HeaderText = "Exportar XLS SAT";
            this.ExportarXLSSAT.Image = global::SATeC.Properties.Resources.excel;
            this.ExportarXLSSAT.Name = "ExportarXLSSAT";
            this.ExportarXLSSAT.ReadOnly = true;
            this.ExportarXLSSAT.Width = 300;
            // 
            // frmConsultarBalanzasImportadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 500);
            this.Controls.Add(this.dgvBalanzasImportadas);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarBalanzasImportadas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Balanzas Importadas No Convertidas a XML";
            this.Load += new System.EventHandler(this.frmConsultarBalanzasImportadasNoConvertidasXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanzasImportadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Label lblModulo;
        private SATecDataGridView dgvBalanzasImportadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioImportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConversionXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioConversionXML;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn XML;
        private System.Windows.Forms.DataGridViewImageColumn ExportarXLS;
        private System.Windows.Forms.DataGridViewImageColumn ExportarPDF;
        private System.Windows.Forms.DataGridViewImageColumn ExportarXLSSAT;
	}
}