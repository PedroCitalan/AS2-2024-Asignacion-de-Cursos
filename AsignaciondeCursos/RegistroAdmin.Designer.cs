
namespace AsignaciondeCursos
{
    partial class RegistroAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_registroadmin = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Txt_confirmarcontra = new System.Windows.Forms.TextBox();
            this.Lbl_confirmarcontra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_contra
            // 
            this.Txt_contra.Location = new System.Drawing.Point(180, 100);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.Size = new System.Drawing.Size(310, 20);
            this.Txt_contra.TabIndex = 9;
            this.Txt_contra.UseSystemPasswordChar = true;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_contraseña.Location = new System.Drawing.Point(90, 101);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(87, 16);
            this.Lbl_contraseña.TabIndex = 8;
            this.Lbl_contraseña.Text = "Contraseña:";
            // 
            // Txt_username
            // 
            this.Txt_username.Location = new System.Drawing.Point(180, 64);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(310, 20);
            this.Txt_username.TabIndex = 7;
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_username.Location = new System.Drawing.Point(37, 65);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(137, 16);
            this.Lbl_username.TabIndex = 6;
            this.Lbl_username.Text = "Nombre de usuario:";
            // 
            // Lbl_registroadmin
            // 
            this.Lbl_registroadmin.AutoSize = true;
            this.Lbl_registroadmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_registroadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_registroadmin.Location = new System.Drawing.Point(133, 18);
            this.Lbl_registroadmin.Name = "Lbl_registroadmin";
            this.Lbl_registroadmin.Size = new System.Drawing.Size(335, 23);
            this.Lbl_registroadmin.TabIndex = 5;
            this.Lbl_registroadmin.Text = "Registro de personal administrativo";
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(180, 180);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 11;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_correo.Location = new System.Drawing.Point(41, 181);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(133, 16);
            this.Lbl_correo.TabIndex = 10;
            this.Lbl_correo.Text = "Correo electrónico:";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.Location = new System.Drawing.Point(265, 227);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(82, 31);
            this.Btn_registrar.TabIndex = 14;
            this.Btn_registrar.Text = "Registrar";
            this.Btn_registrar.UseVisualStyleBackColor = true;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(12, 227);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(84, 31);
            this.Btn_regresar.TabIndex = 15;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Txt_confirmarcontra
            // 
            this.Txt_confirmarcontra.Location = new System.Drawing.Point(180, 140);
            this.Txt_confirmarcontra.Name = "Txt_confirmarcontra";
            this.Txt_confirmarcontra.Size = new System.Drawing.Size(310, 20);
            this.Txt_confirmarcontra.TabIndex = 10;
            this.Txt_confirmarcontra.UseSystemPasswordChar = true;
            // 
            // Lbl_confirmarcontra
            // 
            this.Lbl_confirmarcontra.AutoSize = true;
            this.Lbl_confirmarcontra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_confirmarcontra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_confirmarcontra.Location = new System.Drawing.Point(20, 141);
            this.Lbl_confirmarcontra.Name = "Lbl_confirmarcontra";
            this.Lbl_confirmarcontra.Size = new System.Drawing.Size(154, 16);
            this.Lbl_confirmarcontra.TabIndex = 16;
            this.Lbl_confirmarcontra.Text = "Confirmar contraseña:";
            // 
            // RegistroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(594, 286);
            this.Controls.Add(this.Txt_confirmarcontra);
            this.Controls.Add(this.Lbl_confirmarcontra);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.Lbl_registroadmin);
            this.Name = "RegistroAdmin";
            this.Text = "Registro de personal administrativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_registroadmin;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.TextBox Txt_confirmarcontra;
        private System.Windows.Forms.Label Lbl_confirmarcontra;
    }
}