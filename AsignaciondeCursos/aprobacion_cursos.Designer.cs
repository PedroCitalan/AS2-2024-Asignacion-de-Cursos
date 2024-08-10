
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
            this.Lbl_aprobcurso = new System.Windows.Forms.Label();
            this.Dgv_notas = new System.Windows.Forms.DataGridView();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_mod = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_notas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_carnet
            // 
            this.Txt_carnet.Location = new System.Drawing.Point(145, 77);
            this.Txt_carnet.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_carnet.Name = "Txt_carnet";
            this.Txt_carnet.Size = new System.Drawing.Size(117, 20);
            this.Txt_carnet.TabIndex = 0;
            // 
            // Btn_cargarNotas
            // 
            this.Btn_cargarNotas.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cargarNotas.Location = new System.Drawing.Point(401, 117);
            this.Btn_cargarNotas.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cargarNotas.Name = "Btn_cargarNotas";
            this.Btn_cargarNotas.Size = new System.Drawing.Size(78, 34);
            this.Btn_cargarNotas.TabIndex = 6;
            this.Btn_cargarNotas.Text = "Subir Nota";
            this.Btn_cargarNotas.UseVisualStyleBackColor = true;
            // 
            // Txt_nota
            // 
            this.Txt_nota.Location = new System.Drawing.Point(266, 125);
            this.Txt_nota.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nota.Name = "Txt_nota";
            this.Txt_nota.Size = new System.Drawing.Size(117, 20);
            this.Txt_nota.TabIndex = 7;
            // 
            // Lbl_nota
            // 
            this.Lbl_nota.AutoSize = true;
            this.Lbl_nota.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_nota.Location = new System.Drawing.Point(173, 127);
            this.Lbl_nota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nota.Name = "Lbl_nota";
            this.Lbl_nota.Size = new System.Drawing.Size(89, 15);
            this.Lbl_nota.TabIndex = 8;
            this.Lbl_nota.Text = "Nota a Ingresar";
            // 
            // Cbo_cursos
            // 
            this.Cbo_cursos.FormattingEnabled = true;
            this.Cbo_cursos.Location = new System.Drawing.Point(74, 125);
            this.Cbo_cursos.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_cursos.Name = "Cbo_cursos";
            this.Cbo_cursos.Size = new System.Drawing.Size(82, 21);
            this.Cbo_cursos.TabIndex = 9;
            // 
            // ver_curso
            // 
            this.ver_curso.AutoSize = true;
            this.ver_curso.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_curso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ver_curso.Location = new System.Drawing.Point(32, 127);
            this.ver_curso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ver_curso.Name = "ver_curso";
            this.ver_curso.Size = new System.Drawing.Size(38, 15);
            this.ver_curso.TabIndex = 10;
            this.ver_curso.Text = "Curso";
            // 
            // Btn_buscarcarnet
            // 
            this.Btn_buscarcarnet.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscarcarnet.Location = new System.Drawing.Point(287, 68);
            this.Btn_buscarcarnet.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscarcarnet.Name = "Btn_buscarcarnet";
            this.Btn_buscarcarnet.Size = new System.Drawing.Size(60, 34);
            this.Btn_buscarcarnet.TabIndex = 14;
            this.Btn_buscarcarnet.Text = "Buscar";
            this.Btn_buscarcarnet.UseVisualStyleBackColor = true;
            // 
            // Nocarne
            // 
            this.Nocarne.AutoSize = true;
            this.Nocarne.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nocarne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nocarne.Location = new System.Drawing.Point(53, 79);
            this.Nocarne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nocarne.Name = "Nocarne";
            this.Nocarne.Size = new System.Drawing.Size(87, 15);
            this.Nocarne.TabIndex = 16;
            this.Nocarne.Text = "Carnet Alumno";
            // 
            // Lbl_aprobcurso
            // 
            this.Lbl_aprobcurso.AutoSize = true;
            this.Lbl_aprobcurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aprobcurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_aprobcurso.Location = new System.Drawing.Point(202, 19);
            this.Lbl_aprobcurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_aprobcurso.Name = "Lbl_aprobcurso";
            this.Lbl_aprobcurso.Size = new System.Drawing.Size(181, 19);
            this.Lbl_aprobcurso.TabIndex = 17;
            this.Lbl_aprobcurso.Text = "Aprobación de Cursos";
            // 
            // Dgv_notas
            // 
            this.Dgv_notas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_notas.Location = new System.Drawing.Point(35, 162);
            this.Dgv_notas.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_notas.Name = "Dgv_notas";
            this.Dgv_notas.RowHeadersWidth = 51;
            this.Dgv_notas.RowTemplate.Height = 29;
            this.Dgv_notas.Size = new System.Drawing.Size(505, 195);
            this.Dgv_notas.TabIndex = 18;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(369, 68);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(60, 34);
            this.Btn_limpiar.TabIndex = 19;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_mod
            // 
            this.Btn_mod.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mod.Location = new System.Drawing.Point(483, 117);
            this.Btn_mod.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_mod.Name = "Btn_mod";
            this.Btn_mod.Size = new System.Drawing.Size(97, 34);
            this.Btn_mod.TabIndex = 20;
            this.Btn_mod.Text = "Modificar Nota";
            this.Btn_mod.UseVisualStyleBackColor = true;
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(10, 376);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(70, 34);
            this.Btn_regresar.TabIndex = 21;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // aprobacion_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(591, 421);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_mod);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Dgv_notas);
            this.Controls.Add(this.Lbl_aprobcurso);
            this.Controls.Add(this.Nocarne);
            this.Controls.Add(this.Btn_buscarcarnet);
            this.Controls.Add(this.ver_curso);
            this.Controls.Add(this.Cbo_cursos);
            this.Controls.Add(this.Lbl_nota);
            this.Controls.Add(this.Txt_nota);
            this.Controls.Add(this.Btn_cargarNotas);
            this.Controls.Add(this.Txt_carnet);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label Lbl_aprobcurso;
        private System.Windows.Forms.DataGridView Dgv_notas;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_mod;
        private System.Windows.Forms.Button Btn_regresar;
    }
}

