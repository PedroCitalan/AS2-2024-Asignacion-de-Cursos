
namespace AsignaciondeCursos
{
    partial class CambioContraEstudiante
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
            this.Lbl_cambiocontraest = new System.Windows.Forms.Label();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Txt_contra = new System.Windows.Forms.TextBox();
            this.Txt_confirmarcontra = new System.Windows.Forms.TextBox();
            this.Lbl_contra = new System.Windows.Forms.Label();
            this.Lbl_confirmarcontra = new System.Windows.Forms.Label();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Btn_cambiocontra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_cambiocontraest
            // 
            this.Lbl_cambiocontraest.AutoSize = true;
            this.Lbl_cambiocontraest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cambiocontraest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_cambiocontraest.Location = new System.Drawing.Point(144, 9);
            this.Lbl_cambiocontraest.Name = "Lbl_cambiocontraest";
            this.Lbl_cambiocontraest.Size = new System.Drawing.Size(357, 23);
            this.Lbl_cambiocontraest.TabIndex = 25;
            this.Lbl_cambiocontraest.Text = "Cambio de contraseña de estudiante";
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(174, 48);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 27;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(514, 40);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(85, 31);
            this.Btn_buscar.TabIndex = 34;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_correo.Location = new System.Drawing.Point(110, 49);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(56, 16);
            this.Lbl_correo.TabIndex = 35;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Txt_contra
            // 
            this.Txt_contra.Location = new System.Drawing.Point(174, 85);
            this.Txt_contra.Name = "Txt_contra";
            this.Txt_contra.PasswordChar = '*';
            this.Txt_contra.Size = new System.Drawing.Size(310, 20);
            this.Txt_contra.TabIndex = 36;
            this.Txt_contra.UseSystemPasswordChar = true;
            this.Txt_contra.Visible = false;
            // 
            // Txt_confirmarcontra
            // 
            this.Txt_confirmarcontra.Location = new System.Drawing.Point(174, 124);
            this.Txt_confirmarcontra.Name = "Txt_confirmarcontra";
            this.Txt_confirmarcontra.Size = new System.Drawing.Size(310, 20);
            this.Txt_confirmarcontra.TabIndex = 37;
            this.Txt_confirmarcontra.UseSystemPasswordChar = true;
            this.Txt_confirmarcontra.Visible = false;
            // 
            // Lbl_contra
            // 
            this.Lbl_contra.AutoSize = true;
            this.Lbl_contra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_contra.Location = new System.Drawing.Point(81, 86);
            this.Lbl_contra.Name = "Lbl_contra";
            this.Lbl_contra.Size = new System.Drawing.Size(87, 16);
            this.Lbl_contra.TabIndex = 38;
            this.Lbl_contra.Text = "Contraseña:";
            this.Lbl_contra.Visible = false;
            // 
            // Lbl_confirmarcontra
            // 
            this.Lbl_confirmarcontra.AutoSize = true;
            this.Lbl_confirmarcontra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_confirmarcontra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_confirmarcontra.Location = new System.Drawing.Point(14, 125);
            this.Lbl_confirmarcontra.Name = "Lbl_confirmarcontra";
            this.Lbl_confirmarcontra.Size = new System.Drawing.Size(154, 16);
            this.Lbl_confirmarcontra.TabIndex = 39;
            this.Lbl_confirmarcontra.Text = "Confirmar contraseña:";
            this.Lbl_confirmarcontra.Visible = false;
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(15, 201);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(85, 31);
            this.Btn_regresar.TabIndex = 40;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Btn_cambiocontra
            // 
            this.Btn_cambiocontra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cambiocontra.Location = new System.Drawing.Point(271, 182);
            this.Btn_cambiocontra.Name = "Btn_cambiocontra";
            this.Btn_cambiocontra.Size = new System.Drawing.Size(108, 50);
            this.Btn_cambiocontra.TabIndex = 41;
            this.Btn_cambiocontra.Text = "Cambiar contraseña";
            this.Btn_cambiocontra.UseVisualStyleBackColor = true;
            this.Btn_cambiocontra.Visible = false;
            this.Btn_cambiocontra.Click += new System.EventHandler(this.Btn_cambiocontra_Click);
            // 
            // CambioContraEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(624, 267);
            this.Controls.Add(this.Btn_cambiocontra);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Lbl_confirmarcontra);
            this.Controls.Add(this.Lbl_contra);
            this.Controls.Add(this.Txt_confirmarcontra);
            this.Controls.Add(this.Txt_contra);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_cambiocontraest);
            this.Name = "CambioContraEstudiante";
            this.Text = "Cambio de contraseña de estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cambiocontraest;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.TextBox Txt_contra;
        private System.Windows.Forms.TextBox Txt_confirmarcontra;
        private System.Windows.Forms.Label Lbl_contra;
        private System.Windows.Forms.Label Lbl_confirmarcontra;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.Button Btn_cambiocontra;
    }
}