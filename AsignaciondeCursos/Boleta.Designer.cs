
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
            this.Txt_NombrePago = new System.Windows.Forms.TextBox();
            this.Lbl_NombrePago = new System.Windows.Forms.Label();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Lbl_Carne = new System.Windows.Forms.Label();
            this.Lbl_NombreEstudiante = new System.Windows.Forms.Label();
            this.Txt_NombreEstudiante = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.Lbl_ApellidoEstudiante = new System.Windows.Forms.Label();
            this.Lbl_idboleta = new System.Windows.Forms.Label();
            this.LblNoBoleta = new System.Windows.Forms.Label();
            this.Lbl_CodigoCarrera = new System.Windows.Forms.Label();
            this.Txt_CodigoCarrera = new System.Windows.Forms.TextBox();
            this.Lbl_idfacultad = new System.Windows.Forms.Label();
            this.Txt_IDFacultad = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
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
            this.Lbl_semestre.Location = new System.Drawing.Point(89, 531);
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
            this.Cbo_semestre.Location = new System.Drawing.Point(91, 562);
            this.Cbo_semestre.Name = "Cbo_semestre";
            this.Cbo_semestre.Size = new System.Drawing.Size(121, 21);
            this.Cbo_semestre.TabIndex = 9;
            // 
            // Txt_NombrePago
            // 
            this.Txt_NombrePago.Location = new System.Drawing.Point(92, 119);
            this.Txt_NombrePago.Name = "Txt_NombrePago";
            this.Txt_NombrePago.Size = new System.Drawing.Size(100, 20);
            this.Txt_NombrePago.TabIndex = 11;
            // 
            // Lbl_NombrePago
            // 
            this.Lbl_NombrePago.AutoSize = true;
            this.Lbl_NombrePago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombrePago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_NombrePago.Location = new System.Drawing.Point(89, 98);
            this.Lbl_NombrePago.Name = "Lbl_NombrePago";
            this.Lbl_NombrePago.Size = new System.Drawing.Size(136, 18);
            this.Lbl_NombrePago.TabIndex = 12;
            this.Lbl_NombrePago.Text = "Nombre de pago";
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Monto.Location = new System.Drawing.Point(89, 155);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(55, 18);
            this.Lbl_Monto.TabIndex = 13;
            this.Lbl_Monto.Text = "Monto";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(91, 176);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Monto.TabIndex = 14;
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(91, 242);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer1.TabIndex = 17;
            // 
            // Lbl_Carne
            // 
            this.Lbl_Carne.AutoSize = true;
            this.Lbl_Carne.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Carne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Carne.Location = new System.Drawing.Point(88, 221);
            this.Lbl_Carne.Name = "Lbl_Carne";
            this.Lbl_Carne.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Carne.TabIndex = 18;
            this.Lbl_Carne.Text = "Carne";
            // 
            // Lbl_NombreEstudiante
            // 
            this.Lbl_NombreEstudiante.AutoSize = true;
            this.Lbl_NombreEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_NombreEstudiante.Location = new System.Drawing.Point(88, 285);
            this.Lbl_NombreEstudiante.Name = "Lbl_NombreEstudiante";
            this.Lbl_NombreEstudiante.Size = new System.Drawing.Size(146, 18);
            this.Lbl_NombreEstudiante.TabIndex = 19;
            this.Lbl_NombreEstudiante.Text = "Nombre Estudiante";
            // 
            // Txt_NombreEstudiante
            // 
            this.Txt_NombreEstudiante.Location = new System.Drawing.Point(91, 306);
            this.Txt_NombreEstudiante.Name = "Txt_NombreEstudiante";
            this.Txt_NombreEstudiante.Size = new System.Drawing.Size(129, 20);
            this.Txt_NombreEstudiante.TabIndex = 20;
            // 
            // Txt_ApellidoEstudiante
            // 
            this.Txt_ApellidoEstudiante.Location = new System.Drawing.Point(91, 362);
            this.Txt_ApellidoEstudiante.Name = "Txt_ApellidoEstudiante";
            this.Txt_ApellidoEstudiante.Size = new System.Drawing.Size(129, 20);
            this.Txt_ApellidoEstudiante.TabIndex = 21;
            // 
            // Lbl_ApellidoEstudiante
            // 
            this.Lbl_ApellidoEstudiante.AutoSize = true;
            this.Lbl_ApellidoEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApellidoEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_ApellidoEstudiante.Location = new System.Drawing.Point(88, 341);
            this.Lbl_ApellidoEstudiante.Name = "Lbl_ApellidoEstudiante";
            this.Lbl_ApellidoEstudiante.Size = new System.Drawing.Size(149, 18);
            this.Lbl_ApellidoEstudiante.TabIndex = 22;
            this.Lbl_ApellidoEstudiante.Text = "Apellido Estudiante";
            // 
            // Lbl_idboleta
            // 
            this.Lbl_idboleta.AutoSize = true;
            this.Lbl_idboleta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idboleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_idboleta.Location = new System.Drawing.Point(88, 52);
            this.Lbl_idboleta.Name = "Lbl_idboleta";
            this.Lbl_idboleta.Size = new System.Drawing.Size(84, 18);
            this.Lbl_idboleta.TabIndex = 1;
            this.Lbl_idboleta.Text = "No. Boleta";
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
            // Lbl_CodigoCarrera
            // 
            this.Lbl_CodigoCarrera.AutoSize = true;
            this.Lbl_CodigoCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoCarrera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_CodigoCarrera.Location = new System.Drawing.Point(88, 404);
            this.Lbl_CodigoCarrera.Name = "Lbl_CodigoCarrera";
            this.Lbl_CodigoCarrera.Size = new System.Drawing.Size(125, 18);
            this.Lbl_CodigoCarrera.TabIndex = 24;
            this.Lbl_CodigoCarrera.Text = "Codigo Carrera";
            // 
            // Txt_CodigoCarrera
            // 
            this.Txt_CodigoCarrera.Location = new System.Drawing.Point(91, 425);
            this.Txt_CodigoCarrera.Name = "Txt_CodigoCarrera";
            this.Txt_CodigoCarrera.Size = new System.Drawing.Size(129, 20);
            this.Txt_CodigoCarrera.TabIndex = 25;
            // 
            // Lbl_idfacultad
            // 
            this.Lbl_idfacultad.AutoSize = true;
            this.Lbl_idfacultad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idfacultad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_idfacultad.Location = new System.Drawing.Point(89, 463);
            this.Lbl_idfacultad.Name = "Lbl_idfacultad";
            this.Lbl_idfacultad.Size = new System.Drawing.Size(92, 18);
            this.Lbl_idfacultad.TabIndex = 26;
            this.Lbl_idfacultad.Text = "ID_facultad";
            // 
            // Txt_IDFacultad
            // 
            this.Txt_IDFacultad.Location = new System.Drawing.Point(91, 484);
            this.Txt_IDFacultad.Name = "Txt_IDFacultad";
            this.Txt_IDFacultad.Size = new System.Drawing.Size(129, 20);
            this.Txt_IDFacultad.TabIndex = 27;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_fecha.Location = new System.Drawing.Point(278, 531);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(54, 18);
            this.Lbl_fecha.TabIndex = 28;
            this.Lbl_fecha.Text = "Fecha";
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
            this.Cbo_anio.Location = new System.Drawing.Point(281, 562);
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
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Txt_IDFacultad);
            this.Controls.Add(this.Lbl_idfacultad);
            this.Controls.Add(this.Txt_CodigoCarrera);
            this.Controls.Add(this.Lbl_CodigoCarrera);
            this.Controls.Add(this.LblNoBoleta);
            this.Controls.Add(this.Lbl_ApellidoEstudiante);
            this.Controls.Add(this.Txt_ApellidoEstudiante);
            this.Controls.Add(this.Txt_NombreEstudiante);
            this.Controls.Add(this.Lbl_NombreEstudiante);
            this.Controls.Add(this.Lbl_Carne);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.Lbl_NombrePago);
            this.Controls.Add(this.Txt_NombrePago);
            this.Controls.Add(this.Cbo_anio);
            this.Controls.Add(this.Cbo_semestre);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_generar);
            this.Controls.Add(this.Lbl_semestre);
            this.Controls.Add(this.Lbl_idboleta);
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
        private System.Windows.Forms.TextBox Txt_NombrePago;
        private System.Windows.Forms.Label Lbl_NombrePago;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.Label Lbl_Carne;
        private System.Windows.Forms.Label Lbl_NombreEstudiante;
        private System.Windows.Forms.TextBox Txt_NombreEstudiante;
        private System.Windows.Forms.TextBox Txt_ApellidoEstudiante;
        private System.Windows.Forms.Label Lbl_ApellidoEstudiante;
        private System.Windows.Forms.Label Lbl_idboleta;
        private System.Windows.Forms.Label LblNoBoleta;
        private System.Windows.Forms.Label Lbl_CodigoCarrera;
        private System.Windows.Forms.TextBox Txt_CodigoCarrera;
        private System.Windows.Forms.Label Lbl_idfacultad;
        private System.Windows.Forms.TextBox Txt_IDFacultad;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.ComboBox Cbo_anio;
    }
}

