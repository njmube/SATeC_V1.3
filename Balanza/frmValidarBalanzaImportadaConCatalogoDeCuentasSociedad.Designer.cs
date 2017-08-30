namespace SATeC.Balanza {
	partial class frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad {
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
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.cmdValidar = new System.Windows.Forms.Button();
			this.lblEjercicioPeriodo = new System.Windows.Forms.Label();
			this.lblEjercicioPeriodoSeleccionado = new System.Windows.Forms.Label();
			this.tgvBalanza = new AdvancedDataGridView.TreeGridView();
			this.Cuenta = new AdvancedDataGridView.TreeGridColumn();
			this.DescripcionCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tgvBalanza)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
			this.cmdCancelar.Location = new System.Drawing.Point(867, 0);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(105, 40);
			this.cmdCancelar.TabIndex = 5;
			this.cmdCancelar.Text = "&Cancelar";
			this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
			// 
			// cmdValidar
			// 
			this.cmdValidar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdValidar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdValidar.FlatAppearance.BorderSize = 0;
			this.cmdValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdValidar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValidar.ForeColor = System.Drawing.Color.White;
			this.cmdValidar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
			this.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdValidar.Location = new System.Drawing.Point(872, 430);
			this.cmdValidar.Name = "cmdValidar";
			this.cmdValidar.Size = new System.Drawing.Size(100, 40);
			this.cmdValidar.TabIndex = 4;
			this.cmdValidar.Text = "&Validar";
			this.cmdValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdValidar.UseVisualStyleBackColor = true;
			this.cmdValidar.Click += new System.EventHandler(this.cmdValidar_Click);
			// 
			// lblEjercicioPeriodo
			// 
			this.lblEjercicioPeriodo.AutoSize = true;
			this.lblEjercicioPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEjercicioPeriodo.ForeColor = System.Drawing.Color.White;
			this.lblEjercicioPeriodo.Location = new System.Drawing.Point(12, 15);
			this.lblEjercicioPeriodo.Name = "lblEjercicioPeriodo";
			this.lblEjercicioPeriodo.Size = new System.Drawing.Size(120, 19);
			this.lblEjercicioPeriodo.TabIndex = 6;
			this.lblEjercicioPeriodo.Text = "Ejercicio / Periodo:";
			// 
			// lblEjercicioPeriodoSeleccionado
			// 
			this.lblEjercicioPeriodoSeleccionado.AutoSize = true;
			this.lblEjercicioPeriodoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEjercicioPeriodoSeleccionado.ForeColor = System.Drawing.Color.White;
			this.lblEjercicioPeriodoSeleccionado.Location = new System.Drawing.Point(138, 15);
			this.lblEjercicioPeriodoSeleccionado.Name = "lblEjercicioPeriodoSeleccionado";
			this.lblEjercicioPeriodoSeleccionado.Size = new System.Drawing.Size(119, 19);
			this.lblEjercicioPeriodoSeleccionado.TabIndex = 7;
			this.lblEjercicioPeriodoSeleccionado.Text = "2014 - 08 Agosto";
			// 
			// tgvBalanza
			// 
			this.tgvBalanza.AllowUserToAddRows = false;
			this.tgvBalanza.AllowUserToDeleteRows = false;
			this.tgvBalanza.AllowUserToResizeColumns = false;
			this.tgvBalanza.AllowUserToResizeRows = false;
			this.tgvBalanza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tgvBalanza.BackgroundColor = System.Drawing.Color.White;
			this.tgvBalanza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tgvBalanza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.tgvBalanza.ColumnHeadersHeight = 25;
			this.tgvBalanza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.tgvBalanza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.DescripcionCuenta,
            this.SaldoInicial,
            this.Cargos,
            this.Abonos,
            this.SaldoFinal});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tgvBalanza.DefaultCellStyle = dataGridViewCellStyle6;
			this.tgvBalanza.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.tgvBalanza.EnableHeadersVisualStyles = false;
			this.tgvBalanza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.tgvBalanza.ImageList = null;
			this.tgvBalanza.Location = new System.Drawing.Point(12, 43);
			this.tgvBalanza.Name = "tgvBalanza";
			this.tgvBalanza.ReadOnly = true;
			this.tgvBalanza.RowHeadersVisible = false;
			this.tgvBalanza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tgvBalanza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.tgvBalanza.ShowCellErrors = false;
			this.tgvBalanza.ShowCellToolTips = false;
			this.tgvBalanza.ShowEditingIcon = false;
			this.tgvBalanza.Size = new System.Drawing.Size(965, 381);
			this.tgvBalanza.TabIndex = 3;
			// 
			// Cuenta
			// 
			this.Cuenta.DefaultNodeImage = null;
			this.Cuenta.DividerWidth = 1;
			this.Cuenta.HeaderText = "Cuenta";
			this.Cuenta.MinimumWidth = 130;
			this.Cuenta.Name = "Cuenta";
			this.Cuenta.ReadOnly = true;
			this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Cuenta.Width = 130;
			// 
			// DescripcionCuenta
			// 
			this.DescripcionCuenta.DividerWidth = 1;
			this.DescripcionCuenta.HeaderText = "Descripción de la Cuenta";
			this.DescripcionCuenta.MinimumWidth = 340;
			this.DescripcionCuenta.Name = "DescripcionCuenta";
			this.DescripcionCuenta.ReadOnly = true;
			this.DescripcionCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DescripcionCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DescripcionCuenta.Width = 340;
			// 
			// SaldoInicial
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "#,##0.00;(#,##0.00)";
			this.SaldoInicial.DefaultCellStyle = dataGridViewCellStyle2;
			this.SaldoInicial.DividerWidth = 1;
			this.SaldoInicial.HeaderText = "Saldo Inicial";
			this.SaldoInicial.MinimumWidth = 115;
			this.SaldoInicial.Name = "SaldoInicial";
			this.SaldoInicial.ReadOnly = true;
			this.SaldoInicial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.SaldoInicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.SaldoInicial.Width = 115;
			// 
			// Cargos
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "#,##0.00;(#,##0.00)";
			this.Cargos.DefaultCellStyle = dataGridViewCellStyle3;
			this.Cargos.DividerWidth = 1;
			this.Cargos.HeaderText = "Cargos del Mes";
			this.Cargos.MinimumWidth = 120;
			this.Cargos.Name = "Cargos";
			this.Cargos.ReadOnly = true;
			this.Cargos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Cargos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Cargos.Width = 120;
			// 
			// Abonos
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "#,##0.00;(#,##0.00)";
			this.Abonos.DefaultCellStyle = dataGridViewCellStyle4;
			this.Abonos.DividerWidth = 1;
			this.Abonos.HeaderText = "Abonos del Mes";
			this.Abonos.MinimumWidth = 120;
			this.Abonos.Name = "Abonos";
			this.Abonos.ReadOnly = true;
			this.Abonos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Abonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Abonos.Width = 120;
			// 
			// SaldoFinal
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "#,##0.00;(#,##0.00)";
			this.SaldoFinal.DefaultCellStyle = dataGridViewCellStyle5;
			this.SaldoFinal.DividerWidth = 1;
			this.SaldoFinal.HeaderText = "Saldo Final";
			this.SaldoFinal.MinimumWidth = 115;
			this.SaldoFinal.Name = "SaldoFinal";
			this.SaldoFinal.ReadOnly = true;
			this.SaldoFinal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.SaldoFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.SaldoFinal.Width = 115;
			// 
			// frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.CancelButton = this.cmdCancelar;
			this.ClientSize = new System.Drawing.Size(984, 471);
			this.Controls.Add(this.lblEjercicioPeriodoSeleccionado);
			this.Controls.Add(this.lblEjercicioPeriodo);
			this.Controls.Add(this.tgvBalanza);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdValidar);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmValidarBalanzaImportadaConCatalogoDeCuentasSociedad";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Validar Balanza Importada con Catálogo de Cuentas de la Sociedad";
			this.Load += new System.EventHandler(this.frmRelacionBalanzaCatalogoDeCuentasSociedad_Load);
			((System.ComponentModel.ISupportInitialize)(this.tgvBalanza)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Label lblEjercicioPeriodo;
		private System.Windows.Forms.Label lblEjercicioPeriodoSeleccionado;
		private AdvancedDataGridView.TreeGridView tgvBalanza;
		private AdvancedDataGridView.TreeGridColumn Cuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCuenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaldoInicial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cargos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Abonos;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
	}
}