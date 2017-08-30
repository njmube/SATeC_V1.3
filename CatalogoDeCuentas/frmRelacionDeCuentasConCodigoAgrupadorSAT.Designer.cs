namespace SATeC.CatalogoDeCuentas {
	partial class frmRelacionDeCuentasConCodigoAgrupadorSAT {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelacionDeCuentasConCodigoAgrupadorSAT));
            this.lblModulo = new System.Windows.Forms.Label();
            this.tgvCatalogoCuentasSociedad = new AdvancedDataGridView.TreeGridView();
            this.CuentaSociedad = new AdvancedDataGridView.TreeGridColumn();
            this.DescripcionCuentaSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturalezaCuentaSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaSATRelacionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAgrupador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaAuxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCuentaSociedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuCuentasSociedad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCuentasSociedad_RelacionarCuentaSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdConvertirXML = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdExpandir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSociedad)).BeginInit();
            this.mnuCuentasSociedad.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lblModulo.Size = new System.Drawing.Size(778, 32);
            this.lblModulo.TabIndex = 17;
            this.lblModulo.Text = "Relación de Cuentas de la Sociedad con Código Agrupador del SAT";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersHeight = 25;
            this.tgvCatalogoCuentasSociedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tgvCatalogoCuentasSociedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuentaSociedad,
            this.DescripcionCuentaSociedad,
            this.NaturalezaCuentaSociedad,
            this.CuentaSATRelacionada,
            this.CodigoAgrupador,
            this.CuentaPadre,
            this.CuentaAuxiliar,
            this.NivelCuentaSociedad});
            this.tgvCatalogoCuentasSociedad.ContextMenuStrip = this.mnuCuentasSociedad;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tgvCatalogoCuentasSociedad.DefaultCellStyle = dataGridViewCellStyle2;
            this.tgvCatalogoCuentasSociedad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvCatalogoCuentasSociedad.EnableHeadersVisualStyles = false;
            this.tgvCatalogoCuentasSociedad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.tgvCatalogoCuentasSociedad.ImageList = null;
            this.tgvCatalogoCuentasSociedad.Location = new System.Drawing.Point(0, 96);
            this.tgvCatalogoCuentasSociedad.Name = "tgvCatalogoCuentasSociedad";
            this.tgvCatalogoCuentasSociedad.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tgvCatalogoCuentasSociedad.RowHeadersVisible = false;
            this.tgvCatalogoCuentasSociedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvCatalogoCuentasSociedad.ShowCellErrors = false;
            this.tgvCatalogoCuentasSociedad.ShowCellToolTips = false;
            this.tgvCatalogoCuentasSociedad.ShowEditingIcon = false;
            this.tgvCatalogoCuentasSociedad.ShowRowErrors = false;
            this.tgvCatalogoCuentasSociedad.Size = new System.Drawing.Size(979, 353);
            this.tgvCatalogoCuentasSociedad.TabIndex = 22;
            this.tgvCatalogoCuentasSociedad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tgvCatalogoCuentasSociedad_CellDoubleClick);
            // 
            // CuentaSociedad
            // 
            this.CuentaSociedad.DefaultNodeImage = null;
            this.CuentaSociedad.DividerWidth = 1;
            this.CuentaSociedad.HeaderText = "Cuenta";
            this.CuentaSociedad.MinimumWidth = 300;
            this.CuentaSociedad.Name = "CuentaSociedad";
            this.CuentaSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaSociedad.Width = 300;
            // 
            // DescripcionCuentaSociedad
            // 
            this.DescripcionCuentaSociedad.DividerWidth = 1;
            this.DescripcionCuentaSociedad.HeaderText = "Descripción de la Cuenta";
            this.DescripcionCuentaSociedad.MinimumWidth = 700;
            this.DescripcionCuentaSociedad.Name = "DescripcionCuentaSociedad";
            this.DescripcionCuentaSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionCuentaSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescripcionCuentaSociedad.Width = 700;
            // 
            // NaturalezaCuentaSociedad
            // 
            this.NaturalezaCuentaSociedad.DividerWidth = 1;
            this.NaturalezaCuentaSociedad.HeaderText = "Naturaleza";
            this.NaturalezaCuentaSociedad.MinimumWidth = 70;
            this.NaturalezaCuentaSociedad.Name = "NaturalezaCuentaSociedad";
            this.NaturalezaCuentaSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NaturalezaCuentaSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NaturalezaCuentaSociedad.Width = 70;
            // 
            // CuentaSATRelacionada
            // 
            this.CuentaSATRelacionada.DividerWidth = 1;
            this.CuentaSATRelacionada.HeaderText = "Cuenta SAT Relacionada";
            this.CuentaSATRelacionada.MinimumWidth = 700;
            this.CuentaSATRelacionada.Name = "CuentaSATRelacionada";
            this.CuentaSATRelacionada.ReadOnly = true;
            this.CuentaSATRelacionada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaSATRelacionada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaSATRelacionada.Width = 700;
            // 
            // CodigoAgrupador
            // 
            this.CodigoAgrupador.DividerWidth = 1;
            this.CodigoAgrupador.HeaderText = "Código Agrupador";
            this.CodigoAgrupador.MinimumWidth = 130;
            this.CodigoAgrupador.Name = "CodigoAgrupador";
            this.CodigoAgrupador.ReadOnly = true;
            this.CodigoAgrupador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoAgrupador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoAgrupador.Visible = false;
            this.CodigoAgrupador.Width = 130;
            // 
            // CuentaPadre
            // 
            this.CuentaPadre.HeaderText = "CuentaPadre";
            this.CuentaPadre.Name = "CuentaPadre";
            this.CuentaPadre.ReadOnly = true;
            this.CuentaPadre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaPadre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaPadre.Visible = false;
            // 
            // CuentaAuxiliar
            // 
            this.CuentaAuxiliar.HeaderText = "CuentaAuxiliar";
            this.CuentaAuxiliar.MinimumWidth = 200;
            this.CuentaAuxiliar.Name = "CuentaAuxiliar";
            this.CuentaAuxiliar.ReadOnly = true;
            this.CuentaAuxiliar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuentaAuxiliar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuentaAuxiliar.Visible = false;
            this.CuentaAuxiliar.Width = 200;
            // 
            // NivelCuentaSociedad
            // 
            this.NivelCuentaSociedad.HeaderText = "Nivel";
            this.NivelCuentaSociedad.Name = "NivelCuentaSociedad";
            this.NivelCuentaSociedad.ReadOnly = true;
            this.NivelCuentaSociedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NivelCuentaSociedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NivelCuentaSociedad.Visible = false;
            // 
            // mnuCuentasSociedad
            // 
            this.mnuCuentasSociedad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCuentasSociedad_RelacionarCuentaSAT,
            this.mnuSeparator,
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT});
            this.mnuCuentasSociedad.Name = "cmsMenuCuentasSociedad";
            this.mnuCuentasSociedad.Size = new System.Drawing.Size(270, 58);
            // 
            // mnuCuentasSociedad_RelacionarCuentaSAT
            // 
            this.mnuCuentasSociedad_RelacionarCuentaSAT.Name = "mnuCuentasSociedad_RelacionarCuentaSAT";
            this.mnuCuentasSociedad_RelacionarCuentaSAT.Size = new System.Drawing.Size(269, 24);
            this.mnuCuentasSociedad_RelacionarCuentaSAT.Text = "Relacionar Cuenta SAT";
            this.mnuCuentasSociedad_RelacionarCuentaSAT.Click += new System.EventHandler(this.mnuCuentasSociedad_RelacionarCuentaSAT_Click);
            // 
            // mnuSeparator
            // 
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(266, 6);
            // 
            // mnuCuentasSociedad_EliminarRelacionCuentasSAT
            // 
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT.Name = "mnuCuentasSociedad_EliminarRelacionCuentasSAT";
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT.Size = new System.Drawing.Size(269, 24);
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT.Text = "Eliminar relación Cuenta SAT";
            this.mnuCuentasSociedad_EliminarRelacionCuentasSAT.Click += new System.EventHandler(this.mnuCuentasSociedad_EliminarRelacionCuentasSAT_Click);
            // 
            // cmdConvertirXML
            // 
            this.cmdConvertirXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdConvertirXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdConvertirXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdConvertirXML.FlatAppearance.BorderSize = 0;
            this.cmdConvertirXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdConvertirXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdConvertirXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConvertirXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConvertirXML.ForeColor = System.Drawing.Color.White;
            this.cmdConvertirXML.Image = global::SATeC.Properties.Resources.Convertir;
            this.cmdConvertirXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConvertirXML.Location = new System.Drawing.Point(696, 455);
            this.cmdConvertirXML.Name = "cmdConvertirXML";
            this.cmdConvertirXML.Size = new System.Drawing.Size(272, 40);
            this.cmdConvertirXML.TabIndex = 25;
            this.cmdConvertirXML.Text = "Convertir Catálogo a XML";
            this.cmdConvertirXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdConvertirXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConvertirXML.UseVisualStyleBackColor = false;
            this.cmdConvertirXML.Click += new System.EventHandler(this.cmdConvertirXML_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdMostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdMostrar.FlatAppearance.BorderSize = 0;
            this.cmdMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMostrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar.ForeColor = System.Drawing.Color.White;
            this.cmdMostrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMostrar.Image")));
            this.cmdMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdMostrar.Location = new System.Drawing.Point(8, 455);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(281, 40);
            this.cmdMostrar.TabIndex = 24;
            this.cmdMostrar.Text = "Mostrar solo no relacionadas";
            this.cmdMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdMostrar.UseVisualStyleBackColor = false;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.cmdGuardar.Location = new System.Drawing.Point(236, 7);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(140, 43);
            this.cmdGuardar.TabIndex = 23;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            this.cmdCerrar.Location = new System.Drawing.Point(399, 7);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(115, 43);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
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
            this.cmdExpandir.Location = new System.Drawing.Point(14, 6);
            this.cmdExpandir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdExpandir.Name = "cmdExpandir";
            this.cmdExpandir.Size = new System.Drawing.Size(186, 43);
            this.cmdExpandir.TabIndex = 26;
            this.cmdExpandir.Text = "&Expandir Todo";
            this.cmdExpandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExpandir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExpandir.UseVisualStyleBackColor = false;
            this.cmdExpandir.Click += new System.EventHandler(this.cmdExpandir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.cmdExpandir);
            this.panel1.Controls.Add(this.cmdGuardar);
            this.panel1.Controls.Add(this.cmdCerrar);
            this.panel1.Location = new System.Drawing.Point(127, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 53);
            this.panel1.TabIndex = 27;
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
            this.btnExportar.Location = new System.Drawing.Point(532, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(182, 47);
            this.btnExportar.TabIndex = 27;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmRelacionDeCuentasConCodigoAgrupadorSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdConvertirXML);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.tgvCatalogoCuentasSociedad);
            this.Controls.Add(this.lblModulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelacionDeCuentasConCodigoAgrupadorSAT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Relacionar Cuentas";
            this.Load += new System.EventHandler(this.frmRelacionDeCuentasConCodigoAgrupadorSAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgvCatalogoCuentasSociedad)).EndInit();
            this.mnuCuentasSociedad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblModulo;
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.ContextMenuStrip mnuCuentasSociedad;
		private System.Windows.Forms.ToolStripMenuItem mnuCuentasSociedad_RelacionarCuentaSAT;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator;
		private System.Windows.Forms.ToolStripMenuItem mnuCuentasSociedad_EliminarRelacionCuentasSAT;
		private AdvancedDataGridView.TreeGridView tgvCatalogoCuentasSociedad;
		private System.Windows.Forms.Button cmdMostrar;
		private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdConvertirXML;
        private System.Windows.Forms.Button cmdExpandir;
        private System.Windows.Forms.Panel panel1;
        private AdvancedDataGridView.TreeGridColumn CuentaSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCuentaSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturalezaCuentaSociedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaSATRelacionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaAuxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCuentaSociedad;
        private System.Windows.Forms.Button btnExportar;
	}
}