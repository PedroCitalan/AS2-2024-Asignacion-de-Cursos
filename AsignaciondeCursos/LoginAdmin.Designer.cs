
namespace AsignaciondeCursos
{
    partial class LoginAdmin
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
            this.Lbl_loginadmin = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Btn_ingreso = new System.Windows.Forms.Button();
            this.Btn_cambiocontra = new System.Windows.Forms.Button();
            this.Btn_registro = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_loginadmin
            // 
            this.Lbl_loginadmin.AutoSize = true;
            this.Lbl_loginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginadmin.Location = new System.Drawing.Point(84, 9);
            this.Lbl_loginadmin.Name = "Lbl_loginadmin";
            this.Lbl_loginadmin.Size = new System.Drawing.Size(433, 24);
            this.Lbl_loginadmin.TabIndex = 0;
            this.Lbl_loginadmin.Text = "Inicio de sesión personal administrativo/catedrático";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(98, 55);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(52, 16);
            this.Lbl_correo.TabIndex = 1;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(156, 54);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 2;
            // 
            // Txt_contra
            // 
            this.Txt_contra.Location = new System.Drawing.Point(156, 90);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.Size = new System.Drawing.Size(310, 20);
            this.Txt_contra.TabIndex = 4;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(73, 91);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(80, 16);
            this.Lbl_contraseña.TabIndex = 3;
            this.Lbl_contraseña.Text = "Contraseña:";
            // 
            // Btn_ingreso
            // 
            this.Btn_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingreso.Location = new System.Drawing.Point(131, 136);
            this.Btn_ingreso.Name = "Btn_ingreso";
            this.Btn_ingreso.Size = new System.Drawing.Size(82, 31);
            this.Btn_ingreso.TabIndex = 9;
            this.Btn_ingreso.Text = "Ingreso";
            this.Btn_ingreso.UseVisualStyleBackColor = true;
            this.Btn_ingreso.Click += new System.EventHandler(this.Btn_ingreso_Click);
            // 
            // Btn_cambiocontra
            // 
            this.Btn_cambiocontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cambiocontra.Location = new System.Drawing.Point(250, 136);
            this.Btn_cambiocontra.Name = "Btn_cambiocontra";
            this.Btn_cambiocontra.Size = new System.Drawing.Size(108, 50);
            this.Btn_cambiocontra.TabIndex = 10;
            this.Btn_cambiocontra.Text = "Cambio de contraseña";
            this.Btn_cambiocontra.UseVisualStyleBackColor = true;
            this.Btn_cambiocontra.Click += new System.EventHandler(this.Btn_cambiocontra_Click);
            // 
            // Btn_registro
            // 
            this.Btn_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registro.Location = new System.Drawing.Point(395, 136);
            this.Btn_registro.Name = "Btn_registro";
            this.Btn_registro.Size = new System.Drawing.Size(82, 31);
            this.Btn_registro.TabIndex = 11;
            this.Btn_registro.Text = "Registro";
            this.Btn_registro.UseVisualStyleBackColor = true;
            this.Btn_registro.Click += new System.EventHandler(this.Btn_registro_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(12, 136);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(85, 31);
            this.Btn_regresar.TabIndex = 12;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 198);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_registro);
            this.Controls.Add(this.Btn_cambiocontra);
            this.Controls.Add(this.Btn_ingreso);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_loginadmin);
            this.Name = "LoginAdmin";
            this.Text = "Inicio de sesión administradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_loginadmin;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.Button Btn_ingreso;
        private System.Windows.Forms.Button Btn_cambiocontra;
        private System.Windows.Forms.Button Btn_registro;
        private System.Windows.Forms.Button Btn_regresar;
    }
}