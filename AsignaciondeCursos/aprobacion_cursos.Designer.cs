
namespace AsignaciondeCursos
{
    partial class aprobacion_cursos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Txt_carnet = new System.Windows.Forms.TextBox();
            this.Btn_cargarNotas = new System.Windows.Forms.Button();
            this.Txt_nota = new System.Windows.Forms.TextBox();
            this.Lbl_nota = new System.Windows.Forms.Label();
            this.Cbo_cursos = new System.Windows.Forms.ComboBox();
            this.ver_curso = new System.Windows.Forms.Label();
            this.Btn_buscarcarnet = new System.Windows.Forms.Button();
            this.Nocarne = new System.Windows.Forms.Label();
            this.aprob_curso = new System.Windows.Forms.Label();
            this.Dgv_notas = new System.Windows.Forms.DataGridView();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_notas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_carnet
            // 
            this.Txt_carnet.Location = new System.Drawing.Point(218, 119);
            this.Txt_carnet.Name = "Txt_carnet";
            this.Txt_carnet.Size = new System.Drawing.Size(174, 26);
            this.Txt_carnet.TabIndex = 0;
            // 
            // Btn_cargarNotas
            // 
            this.Btn_cargarNotas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cargarNotas.Location = new System.Drawing.Point(601, 180);
            this.Btn_cargarNotas.Name = "Btn_cargarNotas";
            this.Btn_cargarNotas.Size = new System.Drawing.Size(90, 52);
            this.Btn_cargarNotas.TabIndex = 6;
            this.Btn_cargarNotas.Text = "Subir Nota";
            this.Btn_cargarNotas.UseVisualStyleBackColor = true;
            // 
            // Txt_nota
            // 
            this.Txt_nota.Location = new System.Drawing.Point(408, 194);
            this.Txt_nota.Name = "Txt_nota";
            this.Txt_nota.Size = new System.Drawing.Size(174, 26);
            this.Txt_nota.TabIndex = 7;
            // 
            // Lbl_nota
            // 
            this.Lbl_nota.AutoSize = true;
            this.Lbl_nota.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_nota.Location = new System.Drawing.Point(275, 194);
            this.Lbl_nota.Name = "Lbl_nota";
            this.Lbl_nota.Size = new System.Drawing.Size(127, 19);
            this.Lbl_nota.TabIndex = 8;
            this.Lbl_nota.Text = "Nota a Ingresar";
            // 
            // Cbo_cursos
            // 
            this.Cbo_cursos.FormattingEnabled = true;
            this.Cbo_cursos.Location = new System.Drawing.Point(137, 191);
            this.Cbo_cursos.Name = "Cbo_cursos";
            this.Cbo_cursos.Size = new System.Drawing.Size(121, 28);
            this.Cbo_cursos.TabIndex = 9;
            // 
            // ver_curso
            // 
            this.ver_curso.AutoSize = true;
            this.ver_curso.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_curso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ver_curso.Location = new System.Drawing.Point(67, 194);
            this.ver_curso.Name = "ver_curso";
            this.ver_curso.Size = new System.Drawing.Size(52, 19);
            this.ver_curso.TabIndex = 10;
            this.ver_curso.Text = "Curso";
            // 
            // Btn_buscarcarnet
            // 
            this.Btn_buscarcarnet.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscarcarnet.Location = new System.Drawing.Point(431, 105);
            this.Btn_buscarcarnet.Name = "Btn_buscarcarnet";
            this.Btn_buscarcarnet.Size = new System.Drawing.Size(90, 52);
            this.Btn_buscarcarnet.TabIndex = 14;
            this.Btn_buscarcarnet.Text = "Buscar";
            this.Btn_buscarcarnet.UseVisualStyleBackColor = true;
            // 
            // Nocarne
            // 
            this.Nocarne.AutoSize = true;
            this.Nocarne.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nocarne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nocarne.Location = new System.Drawing.Point(79, 122);
            this.Nocarne.Name = "Nocarne";
            this.Nocarne.Size = new System.Drawing.Size(127, 19);
            this.Nocarne.TabIndex = 16;
            this.Nocarne.Text = "Carnet Alumno";
            // 
            // aprob_curso
            // 
            this.aprob_curso.AutoSize = true;
            this.aprob_curso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprob_curso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aprob_curso.Location = new System.Drawing.Point(225, 49);
            this.aprob_curso.Name = "aprob_curso";
            this.aprob_curso.Size = new System.Drawing.Size(274, 28);
            this.aprob_curso.TabIndex = 17;
            this.aprob_curso.Text = "Aprobación de Cursos";
            // 
            // Dgv_notas
            // 
            this.Dgv_notas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_notas.Location = new System.Drawing.Point(52, 250);
            this.Dgv_notas.Name = "Dgv_notas";
            this.Dgv_notas.RowHeadersWidth = 51;
            this.Dgv_notas.RowTemplate.Height = 29;
            this.Dgv_notas.Size = new System.Drawing.Size(757, 300);
            this.Dgv_notas.TabIndex = 18;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(554, 105);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(90, 52);
            this.Btn_limpiar.TabIndex = 19;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_mod
            // 
            this.btn_mod.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(706, 180);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(90, 52);
            this.btn_mod.TabIndex = 20;
            this.btn_mod.Text = "Modificar Nota";
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // aprobacion_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(887, 598);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Dgv_notas);
            this.Controls.Add(this.aprob_curso);
            this.Controls.Add(this.Nocarne);
            this.Controls.Add(this.Btn_buscarcarnet);
            this.Controls.Add(this.ver_curso);
            this.Controls.Add(this.Cbo_cursos);
            this.Controls.Add(this.Lbl_nota);
            this.Controls.Add(this.Txt_nota);
            this.Controls.Add(this.Btn_cargarNotas);
            this.Controls.Add(this.Txt_carnet);
            this.Name = "aprobacion_cursos";
            this.Text = "Aprobación de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_notas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox Txt_carnet;
        private System.Windows.Forms.Button Btn_cargarNotas;
        private System.Windows.Forms.TextBox Txt_nota;
        private System.Windows.Forms.Label Lbl_nota;
        private System.Windows.Forms.ComboBox Cbo_cursos;
        private System.Windows.Forms.Label ver_curso;
        private System.Windows.Forms.Button Btn_buscarcarnet;
        private System.Windows.Forms.Label Nocarne;
        private System.Windows.Forms.Label aprob_curso;
        private System.Windows.Forms.DataGridView Dgv_notas;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button btn_mod;
    }
}

