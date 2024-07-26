
namespace AsignaciondeCursos
{
    partial class Listado_alumnos
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
            this.Dgv_alumno = new System.Windows.Forms.DataGridView();
            this.Lbl_listadoA = new System.Windows.Forms.Label();
            this.Lbl_codCar = new System.Windows.Forms.Label();
            this.Txt_codCarrera = new System.Windows.Forms.TextBox();
            this.Lbl_listCurso = new System.Windows.Forms.Label();
            this.Txt_codCur = new System.Windows.Forms.TextBox();
            this.Lbl_listSecc = new System.Windows.Forms.Label();
            this.Cbo_secc = new System.Windows.Forms.ComboBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_alumno
            // 
            this.Dgv_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_alumno.Location = new System.Drawing.Point(12, 281);
            this.Dgv_alumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_alumno.Name = "Dgv_alumno";
            this.Dgv_alumno.RowHeadersWidth = 51;
            this.Dgv_alumno.RowTemplate.Height = 24;
            this.Dgv_alumno.Size = new System.Drawing.Size(1041, 401);
            this.Dgv_alumno.TabIndex = 0;
            // 
            // Lbl_listadoA
            // 
            this.Lbl_listadoA.AutoSize = true;
            this.Lbl_listadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listadoA.Location = new System.Drawing.Point(421, 9);
            this.Lbl_listadoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listadoA.Name = "Lbl_listadoA";
            this.Lbl_listadoA.Size = new System.Drawing.Size(222, 29);
            this.Lbl_listadoA.TabIndex = 1;
            this.Lbl_listadoA.Text = "Listado de alumnos";
            this.Lbl_listadoA.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_codCar
            // 
            this.Lbl_codCar.AutoSize = true;
            this.Lbl_codCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codCar.Location = new System.Drawing.Point(24, 90);
            this.Lbl_codCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codCar.Name = "Lbl_codCar";
            this.Lbl_codCar.Size = new System.Drawing.Size(148, 20);
            this.Lbl_codCar.TabIndex = 2;
            this.Lbl_codCar.Text = "Codigo de carrera:";
            this.Lbl_codCar.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_codCarrera
            // 
            this.Txt_codCarrera.Location = new System.Drawing.Point(191, 89);
            this.Txt_codCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_codCarrera.Name = "Txt_codCarrera";
            this.Txt_codCarrera.Size = new System.Drawing.Size(169, 22);
            this.Txt_codCarrera.TabIndex = 3;
            this.Txt_codCarrera.TextChanged += new System.EventHandler(this.Txt_codCarrera_TextChanged);
            // 
            // Lbl_listCurso
            // 
            this.Lbl_listCurso.AutoSize = true;
            this.Lbl_listCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listCurso.Location = new System.Drawing.Point(403, 90);
            this.Lbl_listCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listCurso.Name = "Lbl_listCurso";
            this.Lbl_listCurso.Size = new System.Drawing.Size(140, 20);
            this.Lbl_listCurso.TabIndex = 4;
            this.Lbl_listCurso.Text = "Código del curso:";
            this.Lbl_listCurso.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_codCur
            // 
            this.Txt_codCur.Location = new System.Drawing.Point(560, 87);
            this.Txt_codCur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_codCur.Name = "Txt_codCur";
            this.Txt_codCur.Size = new System.Drawing.Size(169, 22);
            this.Txt_codCur.TabIndex = 5;
            this.Txt_codCur.TextChanged += new System.EventHandler(this.Txt_codCur_TextChanged);
            // 
            // Lbl_listSecc
            // 
            this.Lbl_listSecc.AutoSize = true;
            this.Lbl_listSecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listSecc.Location = new System.Drawing.Point(768, 90);
            this.Lbl_listSecc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listSecc.Name = "Lbl_listSecc";
            this.Lbl_listSecc.Size = new System.Drawing.Size(74, 20);
            this.Lbl_listSecc.TabIndex = 6;
            this.Lbl_listSecc.Text = "Sección:";
            this.Lbl_listSecc.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cbo_secc
            // 
            this.Cbo_secc.FormattingEnabled = true;
            this.Cbo_secc.Location = new System.Drawing.Point(855, 89);
            this.Cbo_secc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_secc.Name = "Cbo_secc";
            this.Cbo_secc.Size = new System.Drawing.Size(121, 24);
            this.Cbo_secc.TabIndex = 7;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(223, 208);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(101, 43);
            this.Btn_buscar.TabIndex = 8;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(459, 208);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(95, 43);
            this.Btn_limpiar.TabIndex = 9;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Location = new System.Drawing.Point(691, 208);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(88, 43);
            this.Btn_salir.TabIndex = 10;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Listado_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 694);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Cbo_secc);
            this.Controls.Add(this.Lbl_listSecc);
            this.Controls.Add(this.Txt_codCur);
            this.Controls.Add(this.Lbl_listCurso);
            this.Controls.Add(this.Txt_codCarrera);
            this.Controls.Add(this.Lbl_codCar);
            this.Controls.Add(this.Lbl_listadoA);
            this.Controls.Add(this.Dgv_alumno);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Listado_alumnos";
            this.Text = "Listado_alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_alumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_alumno;
        private System.Windows.Forms.Label Lbl_listadoA;
        private System.Windows.Forms.Label Lbl_codCar;
        private System.Windows.Forms.TextBox Txt_codCarrera;
        private System.Windows.Forms.Label Lbl_listCurso;
        private System.Windows.Forms.TextBox Txt_codCur;
        private System.Windows.Forms.Label Lbl_listSecc;
        private System.Windows.Forms.ComboBox Cbo_secc;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_salir;
    }
}