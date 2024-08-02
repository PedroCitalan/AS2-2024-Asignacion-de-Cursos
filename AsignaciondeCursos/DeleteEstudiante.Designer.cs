
namespace AsignaciondeCursos
{
    partial class DeleteEstudiante
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
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_loginadmin = new System.Windows.Forms.Label();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_carne = new System.Windows.Forms.TextBox();
            this.Lbl_carne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(12, 154);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(85, 31);
            this.Btn_regresar.TabIndex = 43;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(237, 154);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(85, 31);
            this.Btn_buscar.TabIndex = 42;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Lbl_loginadmin
            // 
            this.Lbl_loginadmin.AutoSize = true;
            this.Lbl_loginadmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_loginadmin.Location = new System.Drawing.Point(142, 22);
            this.Lbl_loginadmin.Name = "Lbl_loginadmin";
            this.Lbl_loginadmin.Size = new System.Drawing.Size(286, 23);
            this.Lbl_loginadmin.TabIndex = 39;
            this.Lbl_loginadmin.Text = "Eliminar usuario de estudiante";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_correo.Location = new System.Drawing.Point(74, 70);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(56, 16);
            this.Lbl_correo.TabIndex = 40;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(135, 69);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 41;
            // 
            // Txt_carne
            // 
            this.Txt_carne.Location = new System.Drawing.Point(135, 106);
            this.Txt_carne.Name = "Txt_carne";
            this.Txt_carne.Size = new System.Drawing.Size(310, 20);
            this.Txt_carne.TabIndex = 45;
            // 
            // Lbl_carne
            // 
            this.Lbl_carne.AutoSize = true;
            this.Lbl_carne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_carne.Location = new System.Drawing.Point(78, 107);
            this.Lbl_carne.Name = "Lbl_carne";
            this.Lbl_carne.Size = new System.Drawing.Size(52, 16);
            this.Lbl_carne.TabIndex = 44;
            this.Lbl_carne.Text = "Carné:";
            // 
            // DeleteEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(545, 217);
            this.Controls.Add(this.Txt_carne);
            this.Controls.Add(this.Lbl_carne);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_loginadmin);
            this.Name = "DeleteEstudiante";
            this.Text = "Eliminar usuario de estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_loginadmin;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.TextBox Txt_carne;
        private System.Windows.Forms.Label Lbl_carne;
    }
}