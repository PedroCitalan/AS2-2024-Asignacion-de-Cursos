
namespace AsignaciondeCursos
{
    partial class InicioSesión
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
            this.Lbl_iniciosesion = new System.Windows.Forms.Label();
            this.Lbl_iniciosesion3 = new System.Windows.Forms.Label();
            this.Btn_sesion2 = new System.Windows.Forms.Button();
            this.Lbl_iniciosesion2 = new System.Windows.Forms.Label();
            this.Btn_sesion1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_iniciosesion
            // 
            this.Lbl_iniciosesion.AutoSize = true;
            this.Lbl_iniciosesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_iniciosesion.Location = new System.Drawing.Point(225, 9);
            this.Lbl_iniciosesion.Name = "Lbl_iniciosesion";
            this.Lbl_iniciosesion.Size = new System.Drawing.Size(141, 24);
            this.Lbl_iniciosesion.TabIndex = 1;
            this.Lbl_iniciosesion.Text = "Inicio de sesión";
            // 
            // Lbl_iniciosesion3
            // 
            this.Lbl_iniciosesion3.AutoSize = true;
            this.Lbl_iniciosesion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_iniciosesion3.Location = new System.Drawing.Point(284, 58);
            this.Lbl_iniciosesion3.Name = "Lbl_iniciosesion3";
            this.Lbl_iniciosesion3.Size = new System.Drawing.Size(317, 16);
            this.Lbl_iniciosesion3.TabIndex = 20;
            this.Lbl_iniciosesion3.Text = "Menú de inicio de sesión de personal administrativo";
            // 
            // Btn_sesion2
            // 
            this.Btn_sesion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sesion2.Location = new System.Drawing.Point(315, 86);
            this.Btn_sesion2.Name = "Btn_sesion2";
            this.Btn_sesion2.Size = new System.Drawing.Size(249, 31);
            this.Btn_sesion2.TabIndex = 19;
            this.Btn_sesion2.Text = "Login administrador/catedrático";
            this.Btn_sesion2.UseVisualStyleBackColor = true;
            this.Btn_sesion2.Click += new System.EventHandler(this.Btn_sesion2_Click);
            // 
            // Lbl_iniciosesion2
            // 
            this.Lbl_iniciosesion2.AutoSize = true;
            this.Lbl_iniciosesion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_iniciosesion2.Location = new System.Drawing.Point(12, 58);
            this.Lbl_iniciosesion2.Name = "Lbl_iniciosesion2";
            this.Lbl_iniciosesion2.Size = new System.Drawing.Size(247, 16);
            this.Lbl_iniciosesion2.TabIndex = 18;
            this.Lbl_iniciosesion2.Text = "Menú de inicio de sesión de estudiantes";
            // 
            // Btn_sesion1
            // 
            this.Btn_sesion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sesion1.Location = new System.Drawing.Point(64, 86);
            this.Btn_sesion1.Name = "Btn_sesion1";
            this.Btn_sesion1.Size = new System.Drawing.Size(152, 31);
            this.Btn_sesion1.TabIndex = 17;
            this.Btn_sesion1.Text = "Login Estudiantes";
            this.Btn_sesion1.UseVisualStyleBackColor = true;
            this.Btn_sesion1.Click += new System.EventHandler(this.Btn_sesion1_Click);
            // 
            // InicioSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 154);
            this.Controls.Add(this.Lbl_iniciosesion3);
            this.Controls.Add(this.Btn_sesion2);
            this.Controls.Add(this.Lbl_iniciosesion2);
            this.Controls.Add(this.Btn_sesion1);
            this.Controls.Add(this.Lbl_iniciosesion);
            this.Name = "InicioSesión";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_iniciosesion;
        private System.Windows.Forms.Label Lbl_iniciosesion3;
        private System.Windows.Forms.Button Btn_sesion2;
        private System.Windows.Forms.Label Lbl_iniciosesion2;
        private System.Windows.Forms.Button Btn_sesion1;
    }
}