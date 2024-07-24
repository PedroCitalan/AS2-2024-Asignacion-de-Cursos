
namespace AsignaciondeCursos
{
    partial class Validacion
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
            this.Lbl_validacion = new System.Windows.Forms.Label();
            this.Lbl_carnet = new System.Windows.Forms.Label();
            this.Txt_carnetCer3 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer2 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Cbo_anio = new System.Windows.Forms.ComboBox();
            this.Cbo_semestre = new System.Windows.Forms.ComboBox();
            this.Lbl_semestre = new System.Windows.Forms.Label();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_validacion
            // 
            this.Lbl_validacion.AutoSize = true;
            this.Lbl_validacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_validacion.Location = new System.Drawing.Point(254, 9);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(98, 24);
            this.Lbl_validacion.TabIndex = 0;
            this.Lbl_validacion.Text = "Validación";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.Location = new System.Drawing.Point(98, 43);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(93, 16);
            this.Lbl_carnet.TabIndex = 1;
            this.Lbl_carnet.Text = "No. de Carnet:";
            // 
            // Txt_carnetCer3
            // 
            this.Txt_carnetCer3.Location = new System.Drawing.Point(393, 62);
            this.Txt_carnetCer3.Name = "Txt_carnetCer3";
            this.Txt_carnetCer3.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer3.TabIndex = 7;
            // 
            // Txt_carnetCer2
            // 
            this.Txt_carnetCer2.Location = new System.Drawing.Point(247, 62);
            this.Txt_carnetCer2.Name = "Txt_carnetCer2";
            this.Txt_carnetCer2.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer2.TabIndex = 6;
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(101, 62);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer1.TabIndex = 5;
            // 
            // Cbo_anio
            // 
            this.Cbo_anio.FormattingEnabled = true;
            this.Cbo_anio.Location = new System.Drawing.Point(261, 123);
            this.Cbo_anio.Name = "Cbo_anio";
            this.Cbo_anio.Size = new System.Drawing.Size(121, 21);
            this.Cbo_anio.TabIndex = 13;
            // 
            // Cbo_semestre
            // 
            this.Cbo_semestre.FormattingEnabled = true;
            this.Cbo_semestre.Location = new System.Drawing.Point(101, 123);
            this.Cbo_semestre.Name = "Cbo_semestre";
            this.Cbo_semestre.Size = new System.Drawing.Size(121, 21);
            this.Cbo_semestre.TabIndex = 12;
            // 
            // Lbl_semestre
            // 
            this.Lbl_semestre.AutoSize = true;
            this.Lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_semestre.Location = new System.Drawing.Point(98, 104);
            this.Lbl_semestre.Name = "Lbl_semestre";
            this.Lbl_semestre.Size = new System.Drawing.Size(69, 16);
            this.Lbl_semestre.TabIndex = 11;
            this.Lbl_semestre.Text = "Semestre:";
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(218, 171);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(153, 35);
            this.Btn_Validar.TabIndex = 14;
            this.Btn_Validar.Text = "Validar/Asignación";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            // 
            // Validacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 218);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Cbo_anio);
            this.Controls.Add(this.Cbo_semestre);
            this.Controls.Add(this.Lbl_semestre);
            this.Controls.Add(this.Txt_carnetCer3);
            this.Controls.Add(this.Txt_carnetCer2);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Lbl_carnet);
            this.Controls.Add(this.Lbl_validacion);
            this.Name = "Validacion";
            this.Text = "Validacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_validacion;
        private System.Windows.Forms.Label Lbl_carnet;
        private System.Windows.Forms.TextBox Txt_carnetCer3;
        private System.Windows.Forms.TextBox Txt_carnetCer2;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.ComboBox Cbo_anio;
        private System.Windows.Forms.ComboBox Cbo_semestre;
        private System.Windows.Forms.Label Lbl_semestre;
        private System.Windows.Forms.Button Btn_Validar;
    }
}