
namespace AsignaciondeCursos
{
    partial class DeleteCatedratico
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
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_eliminarcat = new System.Windows.Forms.Label();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(223, 121);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(85, 31);
            this.Btn_buscar.TabIndex = 37;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(126, 66);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(310, 20);
            this.Txt_correo.TabIndex = 36;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_correo.Location = new System.Drawing.Point(65, 67);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(56, 16);
            this.Lbl_correo.TabIndex = 35;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_eliminarcat
            // 
            this.Lbl_eliminarcat.AutoSize = true;
            this.Lbl_eliminarcat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_eliminarcat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_eliminarcat.Location = new System.Drawing.Point(122, 19);
            this.Lbl_eliminarcat.Name = "Lbl_eliminarcat";
            this.Lbl_eliminarcat.Size = new System.Drawing.Size(299, 23);
            this.Lbl_eliminarcat.TabIndex = 34;
            this.Lbl_eliminarcat.Text = "Eliminar usuario de catedrático";
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(12, 121);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(85, 31);
            this.Btn_regresar.TabIndex = 38;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // DeleteCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(536, 191);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Lbl_correo);
            this.Controls.Add(this.Lbl_eliminarcat);
            this.Name = "DeleteCatedratico";
            this.Text = "Eliminar usuario de catedrático";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_eliminarcat;
        private System.Windows.Forms.Button Btn_regresar;
    }
}