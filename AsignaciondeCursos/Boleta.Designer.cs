
namespace AsignaciondeCursos
{
    partial class Boleta
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
            this.Lbl_generarb = new System.Windows.Forms.Label();
            this.Lbl_semestre = new System.Windows.Forms.Label();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Cbo_semestre = new System.Windows.Forms.ComboBox();
            this.txtNombrePago = new System.Windows.Forms.TextBox();
            this.LblNombrePago = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.LblCarne = new System.Windows.Forms.Label();
            this.LblNombreEstudiante = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.LblApellidoEstudiante = new System.Windows.Forms.Label();
            this.Lbl_ID_boleta = new System.Windows.Forms.Label();
            this.LblNoBoleta = new System.Windows.Forms.Label();
            this.LblCodigoCarrera = new System.Windows.Forms.Label();
            this.txtCodigoCarrera = new System.Windows.Forms.TextBox();
            this.LblIDFacultad = new System.Windows.Forms.Label();
            this.txtIDFacultad = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Cbo_anio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Lbl_generarb
            // 
            this.Lbl_generarb.AutoSize = true;
            this.Lbl_generarb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_generarb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_generarb.Location = new System.Drawing.Point(75, 9);
            this.Lbl_generarb.Name = "Lbl_generarb";
            this.Lbl_generarb.Size = new System.Drawing.Size(497, 32);
            this.Lbl_generarb.TabIndex = 0;
            this.Lbl_generarb.Text = "Generación de boleta de inscripción";
            // 
            // Lbl_semestre
            // 
            this.Lbl_semestre.AutoSize = true;
            this.Lbl_semestre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_semestre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_semestre.Location = new System.Drawing.Point(88, 540);
            this.Lbl_semestre.Name = "Lbl_semestre";
            this.Lbl_semestre.Size = new System.Drawing.Size(79, 18);
            this.Lbl_semestre.TabIndex = 5;
            this.Lbl_semestre.Text = "Semestre:";
            // 
            // Btn_generar
            // 
            this.Btn_generar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_generar.Location = new System.Drawing.Point(452, 164);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(90, 44);
            this.Btn_generar.TabIndex = 7;
            this.Btn_generar.Text = "Generar";
            this.Btn_generar.UseVisualStyleBackColor = true;
            this.Btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(452, 259);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(90, 44);
            this.Btn_regresar.TabIndex = 8;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Cbo_semestre
            // 
            this.Cbo_semestre.FormattingEnabled = true;
            this.Cbo_semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cbo_semestre.Location = new System.Drawing.Point(91, 577);
            this.Cbo_semestre.Name = "Cbo_semestre";
            this.Cbo_semestre.Size = new System.Drawing.Size(121, 21);
            this.Cbo_semestre.TabIndex = 9;
            // 
            // txtNombrePago
            // 
            this.txtNombrePago.Location = new System.Drawing.Point(91, 134);
            this.txtNombrePago.Name = "txtNombrePago";
            this.txtNombrePago.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePago.TabIndex = 11;
            // 
            // LblNombrePago
            // 
            this.LblNombrePago.AutoSize = true;
            this.LblNombrePago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombrePago.Location = new System.Drawing.Point(88, 98);
            this.LblNombrePago.Name = "LblNombrePago";
            this.LblNombrePago.Size = new System.Drawing.Size(136, 18);
            this.LblNombrePago.TabIndex = 12;
            this.LblNombrePago.Text = "Nombre de pago";
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMonto.Location = new System.Drawing.Point(89, 164);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(55, 18);
            this.LblMonto.TabIndex = 13;
            this.LblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(92, 188);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 14;
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(91, 259);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer1.TabIndex = 17;
            // 
            // LblCarne
            // 
            this.LblCarne.AutoSize = true;
            this.LblCarne.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCarne.Location = new System.Drawing.Point(88, 232);
            this.LblCarne.Name = "LblCarne";
            this.LblCarne.Size = new System.Drawing.Size(54, 18);
            this.LblCarne.TabIndex = 18;
            this.LblCarne.Text = "Carne";
            // 
            // LblNombreEstudiante
            // 
            this.LblNombreEstudiante.AutoSize = true;
            this.LblNombreEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombreEstudiante.Location = new System.Drawing.Point(88, 299);
            this.LblNombreEstudiante.Name = "LblNombreEstudiante";
            this.LblNombreEstudiante.Size = new System.Drawing.Size(146, 18);
            this.LblNombreEstudiante.TabIndex = 19;
            this.LblNombreEstudiante.Text = "Nombre Estudiante";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(91, 320);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(129, 20);
            this.txtNombreEstudiante.TabIndex = 20;
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(91, 383);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(129, 20);
            this.txtApellidoEstudiante.TabIndex = 21;
            // 
            // LblApellidoEstudiante
            // 
            this.LblApellidoEstudiante.AutoSize = true;
            this.LblApellidoEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblApellidoEstudiante.Location = new System.Drawing.Point(89, 353);
            this.LblApellidoEstudiante.Name = "LblApellidoEstudiante";
            this.LblApellidoEstudiante.Size = new System.Drawing.Size(149, 18);
            this.LblApellidoEstudiante.TabIndex = 22;
            this.LblApellidoEstudiante.Text = "Apellido Estudiante";
            // 
            // Lbl_ID_boleta
            // 
            this.Lbl_ID_boleta.AutoSize = true;
            this.Lbl_ID_boleta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_boleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_ID_boleta.Location = new System.Drawing.Point(88, 52);
            this.Lbl_ID_boleta.Name = "Lbl_ID_boleta";
            this.Lbl_ID_boleta.Size = new System.Drawing.Size(84, 18);
            this.Lbl_ID_boleta.TabIndex = 1;
            this.Lbl_ID_boleta.Text = "No. Boleta";
            // 
            // LblNoBoleta
            // 
            this.LblNoBoleta.AutoSize = true;
            this.LblNoBoleta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoBoleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNoBoleta.Location = new System.Drawing.Point(182, 52);
            this.LblNoBoleta.Name = "LblNoBoleta";
            this.LblNoBoleta.Size = new System.Drawing.Size(107, 18);
            this.LblNoBoleta.TabIndex = 23;
            this.LblNoBoleta.Text = "No generado";
            // 
            // LblCodigoCarrera
            // 
            this.LblCodigoCarrera.AutoSize = true;
            this.LblCodigoCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoCarrera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCodigoCarrera.Location = new System.Drawing.Point(89, 416);
            this.LblCodigoCarrera.Name = "LblCodigoCarrera";
            this.LblCodigoCarrera.Size = new System.Drawing.Size(125, 18);
            this.LblCodigoCarrera.TabIndex = 24;
            this.LblCodigoCarrera.Text = "Codigo Carrera";
            // 
            // txtCodigoCarrera
            // 
            this.txtCodigoCarrera.Location = new System.Drawing.Point(91, 437);
            this.txtCodigoCarrera.Name = "txtCodigoCarrera";
            this.txtCodigoCarrera.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoCarrera.TabIndex = 25;
            // 
            // LblIDFacultad
            // 
            this.LblIDFacultad.AutoSize = true;
            this.LblIDFacultad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDFacultad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblIDFacultad.Location = new System.Drawing.Point(89, 475);
            this.LblIDFacultad.Name = "LblIDFacultad";
            this.LblIDFacultad.Size = new System.Drawing.Size(92, 18);
            this.LblIDFacultad.TabIndex = 26;
            this.LblIDFacultad.Text = "ID_facultad";
            // 
            // txtIDFacultad
            // 
            this.txtIDFacultad.Location = new System.Drawing.Point(91, 496);
            this.txtIDFacultad.Name = "txtIDFacultad";
            this.txtIDFacultad.Size = new System.Drawing.Size(129, 20);
            this.txtIDFacultad.TabIndex = 27;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFecha.Location = new System.Drawing.Point(278, 540);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(54, 18);
            this.LblFecha.TabIndex = 28;
            this.LblFecha.Text = "Fecha";
            // 
            // Cbo_anio
            // 
            this.Cbo_anio.FormattingEnabled = true;
            this.Cbo_anio.Items.AddRange(new object[] {
            "2020-01-01",
            "2021-01-01",
            "2022-01-01",
            "2023-01-01",
            "2024-01-01"});
            this.Cbo_anio.Location = new System.Drawing.Point(281, 577);
            this.Cbo_anio.Name = "Cbo_anio";
            this.Cbo_anio.Size = new System.Drawing.Size(121, 21);
            this.Cbo_anio.TabIndex = 10;
            // 
            // Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(635, 616);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.txtIDFacultad);
            this.Controls.Add(this.LblIDFacultad);
            this.Controls.Add(this.txtCodigoCarrera);
            this.Controls.Add(this.LblCodigoCarrera);
            this.Controls.Add(this.LblNoBoleta);
            this.Controls.Add(this.LblApellidoEstudiante);
            this.Controls.Add(this.txtApellidoEstudiante);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.LblNombreEstudiante);
            this.Controls.Add(this.LblCarne);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.LblNombrePago);
            this.Controls.Add(this.txtNombrePago);
            this.Controls.Add(this.Cbo_anio);
            this.Controls.Add(this.Cbo_semestre);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_generar);
            this.Controls.Add(this.Lbl_semestre);
            this.Controls.Add(this.Lbl_ID_boleta);
            this.Controls.Add(this.Lbl_generarb);
            this.Name = "Boleta";
            this.Text = "Boleta de inscripción";
            this.Load += new System.EventHandler(this.Boleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_generarb;
        private System.Windows.Forms.Label Lbl_semestre;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.ComboBox Cbo_semestre;
        private System.Windows.Forms.TextBox txtNombrePago;
        private System.Windows.Forms.Label LblNombrePago;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.Label LblCarne;
        private System.Windows.Forms.Label LblNombreEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.Label LblApellidoEstudiante;
        private System.Windows.Forms.Label Lbl_ID_boleta;
        private System.Windows.Forms.Label LblNoBoleta;
        private System.Windows.Forms.Label LblCodigoCarrera;
        private System.Windows.Forms.TextBox txtCodigoCarrera;
        private System.Windows.Forms.Label LblIDFacultad;
        private System.Windows.Forms.TextBox txtIDFacultad;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ComboBox Cbo_anio;
    }
}

