
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
            this.Lbl_codfac = new System.Windows.Forms.Label();
            this.Txt_codFacultad = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_curso
            // 
            this.Dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_curso.Location = new System.Drawing.Point(9, 232);
            this.Dgv_curso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_curso.Name = "Dgv_curso";
            this.Dgv_curso.RowHeadersWidth = 51;
            this.Dgv_curso.RowTemplate.Height = 24;
            this.Dgv_curso.Size = new System.Drawing.Size(781, 326);
            this.Dgv_curso.TabIndex = 2;
            // 
            // Lbl_listCurso
            // 
            this.Lbl_listCurso.AutoSize = true;
            this.Lbl_listCurso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listCurso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_listCurso.Location = new System.Drawing.Point(309, 9);
            this.Lbl_listCurso.Name = "Lbl_listCurso";
            this.Lbl_listCurso.Size = new System.Drawing.Size(167, 23);
            this.Lbl_listCurso.TabIndex = 3;
            this.Lbl_listCurso.Text = "Listado de cursos";
            // 
            // Lbl_codfac
            // 
            this.Lbl_codfac.AutoSize = true;
            this.Lbl_codfac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codfac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_codfac.Location = new System.Drawing.Point(35, 69);
            this.Lbl_codfac.Name = "Lbl_codfac";
            this.Lbl_codfac.Size = new System.Drawing.Size(140, 16);
            this.Lbl_codfac.TabIndex = 4;
            this.Lbl_codfac.Text = "Código de facultad:";
            // 
            // Txt_codFacultad
            // 
            this.Txt_codFacultad.Location = new System.Drawing.Point(180, 68);
            this.Txt_codFacultad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_codFacultad.Name = "Txt_codFacultad";
            this.Txt_codFacultad.Size = new System.Drawing.Size(182, 20);
            this.Txt_codFacultad.TabIndex = 5;
            this.Txt_codFacultad.TextChanged += new System.EventHandler(this.Txt_codCarrera_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(551, 68);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(89, 30);
            this.Btn_buscar.TabIndex = 10;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(551, 116);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(89, 31);
            this.Btn_limpiar.TabIndex = 11;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(551, 164);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(89, 31);
            this.Btn_regresar.TabIndex = 12;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Listado_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(802, 561);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_codFacultad);
            this.Controls.Add(this.Lbl_codfac);
            this.Controls.Add(this.Lbl_listCurso);
            this.Controls.Add(this.Dgv_curso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Listado_Cursos";
            this.Text = "Listado de cursos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_curso;
        private System.Windows.Forms.Label Lbl_listCurso;
        private System.Windows.Forms.Label Lbl_codfac;
        private System.Windows.Forms.TextBox Txt_codFacultad;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}