namespace SATeC.Administracion {
    partial class frmUsuario_Datos {
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
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.txtClaveUsuario = new System.Windows.Forms.TextBox();
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			this.lblClaveUsuario = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNivelUsuario = new System.Windows.Forms.Label();
			this.cmbNivelUsuario = new System.Windows.Forms.ComboBox();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreUsuario.ForeColor = System.Drawing.Color.White;
			this.txtNombreUsuario.Location = new System.Drawing.Point(153, 51);
			this.txtNombreUsuario.MaxLength = 100;
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(170, 25);
			this.txtNombreUsuario.TabIndex = 1;
			this.txtNombreUsuario.Text = "Victor Hugo Jiménez Cruz";
			// 
			// txtClaveUsuario
			// 
			this.txtClaveUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtClaveUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtClaveUsuario.ForeColor = System.Drawing.Color.White;
			this.txtClaveUsuario.Location = new System.Drawing.Point(153, 21);
			this.txtClaveUsuario.MaxLength = 10;
			this.txtClaveUsuario.Name = "txtClaveUsuario";
			this.txtClaveUsuario.Size = new System.Drawing.Size(100, 25);
			this.txtClaveUsuario.TabIndex = 0;
			this.txtClaveUsuario.Text = "VHJC";
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.AutoSize = true;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNombreUsuario.Location = new System.Drawing.Point(12, 50);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(135, 19);
			this.lblNombreUsuario.TabIndex = 9;
			this.lblNombreUsuario.Text = "Nombre del Usuario:";
			// 
			// lblClaveUsuario
			// 
			this.lblClaveUsuario.AutoSize = true;
			this.lblClaveUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClaveUsuario.ForeColor = System.Drawing.Color.White;
			this.lblClaveUsuario.Location = new System.Drawing.Point(32, 20);
			this.lblClaveUsuario.Name = "lblClaveUsuario";
			this.lblClaveUsuario.Size = new System.Drawing.Size(115, 19);
			this.lblClaveUsuario.TabIndex = 8;
			this.lblClaveUsuario.Text = "Clave de Usuario:";
			// 
			// txtContraseña
			// 
			this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.ForeColor = System.Drawing.Color.White;
			this.txtContraseña.Location = new System.Drawing.Point(153, 80);
			this.txtContraseña.MaxLength = 10;
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '●';
			this.txtContraseña.Size = new System.Drawing.Size(100, 25);
			this.txtContraseña.TabIndex = 2;
			this.txtContraseña.Text = "contraseña";
			this.txtContraseña.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(65, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = "Contraseña:";
			// 
			// lblNivelUsuario
			// 
			this.lblNivelUsuario.AutoSize = true;
			this.lblNivelUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivelUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNivelUsuario.Location = new System.Drawing.Point(105, 110);
			this.lblNivelUsuario.Name = "lblNivelUsuario";
			this.lblNivelUsuario.Size = new System.Drawing.Size(42, 19);
			this.lblNivelUsuario.TabIndex = 12;
			this.lblNivelUsuario.Text = "Nivel:";
			// 
			// cmbNivelUsuario
			// 
			this.cmbNivelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmbNivelUsuario.DisplayMember = "Texto";
			this.cmbNivelUsuario.DropDownHeight = 100;
			this.cmbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNivelUsuario.ForeColor = System.Drawing.Color.White;
			this.cmbNivelUsuario.FormattingEnabled = true;
			this.cmbNivelUsuario.IntegralHeight = false;
			this.cmbNivelUsuario.Location = new System.Drawing.Point(153, 107);
			this.cmbNivelUsuario.Name = "cmbNivelUsuario";
			this.cmbNivelUsuario.Size = new System.Drawing.Size(120, 25);
			this.cmbNivelUsuario.TabIndex = 3;
			this.cmbNivelUsuario.ValueMember = "Valor";
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
			this.cmdCancelar.Location = new System.Drawing.Point(164, 149);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(105, 40);
			this.cmdCancelar.TabIndex = 5;
			this.cmdCancelar.Text = "&Cancelar";
			this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.cmdGuardar.FlatAppearance.BorderSize = 0;
			this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
			this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.ForeColor = System.Drawing.Color.White;
			this.cmdGuardar.Image = global::SATeC.Properties.Resources.Guardar_32x32;
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.Location = new System.Drawing.Point(58, 149);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(100, 40);
			this.cmdGuardar.TabIndex = 4;
			this.cmdGuardar.Text = "&Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// frmUsuario_Datos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(153)))));
			this.CancelButton = this.cmdCancelar;
			this.ClientSize = new System.Drawing.Size(327, 201);
			this.Controls.Add(this.cmbNivelUsuario);
			this.Controls.Add(this.lblNivelUsuario);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombreUsuario);
			this.Controls.Add(this.txtClaveUsuario);
			this.Controls.Add(this.lblNombreUsuario);
			this.Controls.Add(this.lblClaveUsuario);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdGuardar);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUsuario_Datos";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuario";
			this.Load += new System.EventHandler(this.frmUsuario_Datos_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNivelUsuario;
        private System.Windows.Forms.ComboBox cmbNivelUsuario;
    }
}