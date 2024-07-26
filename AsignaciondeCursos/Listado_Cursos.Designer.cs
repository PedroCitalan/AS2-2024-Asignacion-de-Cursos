
namespace AsignaciondeCursos
{
    partial class Listado_Cursos
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
            this.Dgv_curso = new System.Windows.Forms.DataGridView();
            this.Lbl_listCurso = new System.Windows.Forms.Label();
            this.Lbl_codCar = new System.Windows.Forms.Label();
            this.Txt_codCarrera = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_curso
            // 
            this.Dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_curso.Location = new System.Drawing.Point(12, 286);
            this.Dgv_curso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_curso.Name = "Dgv_curso";
            this.Dgv_curso.RowHeadersWidth = 51;
            this.Dgv_curso.RowTemplate.Height = 24;
            this.Dgv_curso.Size = new System.Drawing.Size(1041, 401);
            this.Dgv_curso.TabIndex = 2;
            // 
            // Lbl_listCurso
            // 
            this.Lbl_listCurso.AutoSize = true;
            this.Lbl_listCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listCurso.Location = new System.Drawing.Point(392, 9);
            this.Lbl_listCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listCurso.Name = "Lbl_listCurso";
            this.Lbl_listCurso.Size = new System.Drawing.Size(207, 29);
            this.Lbl_listCurso.TabIndex = 3;
            this.Lbl_listCurso.Text = "Listado de Cursos";
            // 
            // Lbl_codCar
            // 
            this.Lbl_codCar.AutoSize = true;
            this.Lbl_codCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codCar.Location = new System.Drawing.Point(55, 85);
            this.Lbl_codCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codCar.Name = "Lbl_codCar";
            this.Lbl_codCar.Size = new System.Drawing.Size(148, 20);
            this.Lbl_codCar.TabIndex = 4;
            this.Lbl_codCar.Text = "Código de carrera:";
            // 
            // Txt_codCarrera
            // 
            this.Txt_codCarrera.Location = new System.Drawing.Point(221, 84);
            this.Txt_codCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_codCarrera.Name = "Txt_codCarrera";
            this.Txt_codCarrera.Size = new System.Drawing.Size(169, 22);
            this.Txt_codCarrera.TabIndex = 5;
            this.Txt_codCarrera.TextChanged += new System.EventHandler(this.Txt_codCarrera_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(735, 84);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(107, 37);
            this.Btn_buscar.TabIndex = 10;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(735, 143);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(107, 38);
            this.Btn_limpiar.TabIndex = 11;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Location = new System.Drawing.Point(735, 202);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(107, 38);
            this.Btn_salir.TabIndex = 12;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Listado_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 690);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_codCarrera);
            this.Controls.Add(this.Lbl_codCar);
            this.Controls.Add(this.Lbl_listCurso);
            this.Controls.Add(this.Dgv_curso);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Listado_Cursos";
            this.Text = "Listado_Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_curso;
        private System.Windows.Forms.Label Lbl_listCurso;
        private System.Windows.Forms.Label Lbl_codCar;
        private System.Windows.Forms.TextBox Txt_codCarrera;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_salir;
    }
}