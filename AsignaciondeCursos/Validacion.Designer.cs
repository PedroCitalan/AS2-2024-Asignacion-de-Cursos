
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
            this.Lbl_validacion.Location = new System.Drawing.Point(339, 11);
            this.Lbl_validacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(125, 29);
            this.Lbl_validacion.TabIndex = 0;
            this.Lbl_validacion.Text = "Validación";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.Location = new System.Drawing.Point(131, 53);
            this.Lbl_carnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(117, 20);
            this.Lbl_carnet.TabIndex = 1;
            this.Lbl_carnet.Text = "No. de Carnet:";
            // 
            // Txt_carnetCer3
            // 
            this.Txt_carnetCer3.Location = new System.Drawing.Point(524, 76);
            this.Txt_carnetCer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_carnetCer3.Name = "Txt_carnetCer3";
            this.Txt_carnetCer3.Size = new System.Drawing.Size(132, 22);
            this.Txt_carnetCer3.TabIndex = 7;
            this.Txt_carnetCer3.TextChanged += new System.EventHandler(this.Txt_carnetCer3_TextChanged);
            // 
            // Txt_carnetCer2
            // 
            this.Txt_carnetCer2.Location = new System.Drawing.Point(329, 76);
            this.Txt_carnetCer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_carnetCer2.Name = "Txt_carnetCer2";
            this.Txt_carnetCer2.Size = new System.Drawing.Size(132, 22);
            this.Txt_carnetCer2.TabIndex = 6;
            this.Txt_carnetCer2.TextChanged += new System.EventHandler(this.Txt_carnetCer2_TextChanged);
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(135, 76);
            this.Txt_carnetCer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(132, 22);
            this.Txt_carnetCer1.TabIndex = 5;
            this.Txt_carnetCer1.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Cbo_anio
            // 
            this.Cbo_anio.FormattingEnabled = true;
            this.Cbo_anio.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.Cbo_anio.Location = new System.Drawing.Point(348, 151);
            this.Cbo_anio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_anio.Name = "Cbo_anio";
            this.Cbo_anio.Size = new System.Drawing.Size(160, 24);
            this.Cbo_anio.TabIndex = 13;
            // 
            // Cbo_semestre
            // 
            this.Cbo_semestre.FormattingEnabled = true;
            this.Cbo_semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Cbo_semestre.Location = new System.Drawing.Point(135, 151);
            this.Cbo_semestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_semestre.Name = "Cbo_semestre";
            this.Cbo_semestre.Size = new System.Drawing.Size(160, 24);
            this.Cbo_semestre.TabIndex = 12;
            // 
            // Lbl_semestre
            // 
            this.Lbl_semestre.AutoSize = true;
            this.Lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_semestre.Location = new System.Drawing.Point(131, 128);
            this.Lbl_semestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_semestre.Name = "Lbl_semestre";
            this.Lbl_semestre.Size = new System.Drawing.Size(86, 20);
            this.Lbl_semestre.TabIndex = 11;
            this.Lbl_semestre.Text = "Semestre:";
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(291, 210);
            this.Btn_Validar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(204, 43);
            this.Btn_Validar.TabIndex = 14;
            this.Btn_Validar.Text = "Validar/Asignación";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            // 
            // Validacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 268);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Cbo_anio);
            this.Controls.Add(this.Cbo_semestre);
            this.Controls.Add(this.Lbl_semestre);
            this.Controls.Add(this.Txt_carnetCer3);
            this.Controls.Add(this.Txt_carnetCer2);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Lbl_carnet);
            this.Controls.Add(this.Lbl_validacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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