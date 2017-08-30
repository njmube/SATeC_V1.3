namespace SATeC.Comun {
	partial class frmMostrarArchivoXML {
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
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.lblArchivoXML = new System.Windows.Forms.Label();
            this.lblNombreArchivoXML = new System.Windows.Forms.Label();
            this.cmdDescargar = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSellar = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdAceptar.BackColor = System.Drawing.Color.Transparent;
            this.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdAceptar.FlatAppearance.BorderSize = 0;
            this.cmdAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.ForeColor = System.Drawing.Color.White;
            this.cmdAceptar.Image = global::SATeC.Properties.Resources.Validar;
            this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAceptar.Location = new System.Drawing.Point(862, 427);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(134, 40);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "&Aceptar";
            this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // lblArchivoXML
            // 
            this.lblArchivoXML.AutoSize = true;
            this.lblArchivoXML.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivoXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoXML.ForeColor = System.Drawing.Color.White;
            this.lblArchivoXML.Location = new System.Drawing.Point(12, 9);
            this.lblArchivoXML.Name = "lblArchivoXML";
            this.lblArchivoXML.Size = new System.Drawing.Size(116, 23);
            this.lblArchivoXML.TabIndex = 2;
            this.lblArchivoXML.Text = "Formato XML:";
            // 
            // lblNombreArchivoXML
            // 
            this.lblNombreArchivoXML.AutoSize = true;
            this.lblNombreArchivoXML.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreArchivoXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivoXML.ForeColor = System.Drawing.Color.White;
            this.lblNombreArchivoXML.Location = new System.Drawing.Point(105, 9);
            this.lblNombreArchivoXML.Name = "lblNombreArchivoXML";
            this.lblNombreArchivoXML.Size = new System.Drawing.Size(199, 23);
            this.lblNombreArchivoXML.TabIndex = 3;
            this.lblNombreArchivoXML.Text = "Nombre del archivo XML";
            // 
            // cmdDescargar
            // 
            this.cmdDescargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdDescargar.BackColor = System.Drawing.Color.Transparent;
            this.cmdDescargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.cmdDescargar.FlatAppearance.BorderSize = 0;
            this.cmdDescargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.cmdDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDescargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDescargar.ForeColor = System.Drawing.Color.White;
            this.cmdDescargar.Image = global::SATeC.Properties.Resources.Descargar;
            this.cmdDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDescargar.Location = new System.Drawing.Point(30, 427);
            this.cmdDescargar.Name = "cmdDescargar";
            this.cmdDescargar.Size = new System.Drawing.Size(155, 40);
            this.cmdDescargar.TabIndex = 5;
            this.cmdDescargar.Text = "&Descargar";
            this.cmdDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDescargar.UseVisualStyleBackColor = false;
            this.cmdDescargar.Click += new System.EventHandler(this.cmdDescargar_Click);
            // 
            // btnSellar
            // 
            this.btnSellar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSellar.BackColor = System.Drawing.Color.Transparent;
            this.btnSellar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.btnSellar.FlatAppearance.BorderSize = 0;
            this.btnSellar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnSellar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.btnSellar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellar.ForeColor = System.Drawing.Color.White;
            this.btnSellar.Image = global::SATeC.Properties.Resources.sellar;
            this.btnSellar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellar.Location = new System.Drawing.Point(484, 427);
            this.btnSellar.Name = "btnSellar";
            this.btnSellar.Size = new System.Drawing.Size(155, 40);
            this.btnSellar.TabIndex = 6;
            this.btnSellar.Text = "&Sellar";
            this.btnSellar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSellar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellar.UseVisualStyleBackColor = false;
            this.btnSellar.Click += new System.EventHandler(this.btnSellar_Click);
            // 
            // txtXML
            // 
            this.txtXML.ForeColor = System.Drawing.Color.Teal;
            this.txtXML.Location = new System.Drawing.Point(12, 31);
            this.txtXML.MaxLength = 0;
            this.txtXML.Name = "txtXML";
            this.txtXML.ReadOnly = true;
            this.txtXML.Size = new System.Drawing.Size(1107, 390);
            this.txtXML.TabIndex = 7;
            this.txtXML.Text = "";
            // 
            // frmMostrarArchivoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1131, 471);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.btnSellar);
            this.Controls.Add(this.cmdDescargar);
            this.Controls.Add(this.lblNombreArchivoXML);
            this.Controls.Add(this.lblArchivoXML);
            this.Controls.Add(this.cmdAceptar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarArchivoXML";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descarga de Archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMostrarArchivoXML_FormClosing);
            this.Load += new System.EventHandler(this.frmMostrarArchivoXML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.Label lblArchivoXML;
        private System.Windows.Forms.Label lblNombreArchivoXML;
		private System.Windows.Forms.Button cmdDescargar;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSellar;
        private System.Windows.Forms.RichTextBox txtXML;
	}
}