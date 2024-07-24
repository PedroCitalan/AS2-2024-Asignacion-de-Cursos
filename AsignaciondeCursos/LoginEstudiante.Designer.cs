
namespace AsignaciondeCursos
{
    partial class LoginEstudiante
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
            this.Lbl_loginestudiante = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Btn_ingreso = new System.Windows.Forms.Button();
            this.Btn_cambiocontra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_loginestudiante
            // 
            this.Lbl_loginestudiante.AutoSize = true;
            this.Lbl_loginestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginestudiante.Location = new System.Drawing.Point(135, 9);
            this.Lbl_loginestudiante.Name = "Lbl_loginestudiante";
            this.Lbl_loginestudiante.Size = new System.Drawing.Size(241, 24);
            this.Lbl_loginestudiante.TabIndex = 0;
            this.Lbl_loginestudiante.Text = "Inicio de sesión estudiantes";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(46, 57);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(126, 16);
            this.Lbl_usuario.TabIndex = 1;
            this.Lbl_usuario.Text = "Nombre de usuario:";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(178, 56);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(213, 20);
            this.Txt_usuario.TabIndex = 2;
            // 
            // Txt_contra
            // 
            this.Txt_contra.Location = new System.Drawing.Point(178, 92);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.Size = new System.Drawing.Size(213, 20);
            this.Txt_contra.TabIndex = 4;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(92, 93);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(80, 16);
            this.Lbl_contraseña.TabIndex = 3;
            this.Lbl_contraseña.Text = "Contraseña:";
            // 
            // Btn_ingreso
            // 
            this.Btn_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingreso.Location = new System.Drawing.Point(126, 143);
            this.Btn_ingreso.Name = "Btn_ingreso";
            this.Btn_ingreso.Size = new System.Drawing.Size(143, 33);
            this.Btn_ingreso.TabIndex = 5;
            this.Btn_ingreso.Text = "Ingreso/Registro";
            this.Btn_ingreso.UseVisualStyleBackColor = true;
            // 
            // Btn_cambiocontra
            // 
            this.Btn_cambiocontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cambiocontra.Location = new System.Drawing.Point(295, 143);
            this.Btn_cambiocontra.Name = "Btn_cambiocontra";
            this.Btn_cambiocontra.Size = new System.Drawing.Size(108, 50);
            this.Btn_cambiocontra.TabIndex = 6;
            this.Btn_cambiocontra.Text = "Cambio de contraseña";
            this.Btn_cambiocontra.UseVisualStyleBackColor = true;
            // 
            // LoginEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 216);
            this.Controls.Add(this.Btn_cambiocontra);
            this.Controls.Add(this.Btn_ingreso);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_loginestudiante);
            this.Name = "LoginEstudiante";
            this.Text = "Inicio de sesión de estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_loginestudiante;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.Button Btn_ingreso;
        private System.Windows.Forms.Button Btn_cambiocontra;
    }
}