
namespace AsignaciondeCursos
{
    partial class Listado_catedraticos
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
            this.Dgv_catedratico = new System.Windows.Forms.DataGridView();
            this.Lbl_listCat = new System.Windows.Forms.Label();
            this.Lbl_codCar = new System.Windows.Forms.Label();
            this.Txt_codCarrera = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_catedratico)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_catedratico
            // 
            this.Dgv_catedratico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_catedratico.Location = new System.Drawing.Point(9, 240);
            this.Dgv_catedratico.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_catedratico.Name = "Dgv_catedratico";
            this.Dgv_catedratico.RowHeadersWidth = 51;
            this.Dgv_catedratico.RowTemplate.Height = 24;
            this.Dgv_catedratico.Size = new System.Drawing.Size(781, 326);
            this.Dgv_catedratico.TabIndex = 1;
            // 
            // Lbl_listCat
            // 
            this.Lbl_listCat.AutoSize = true;
            this.Lbl_listCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listCat.Location = new System.Drawing.Point(298, 9);
            this.Lbl_listCat.Name = "Lbl_listCat";
            this.Lbl_listCat.Size = new System.Drawing.Size(201, 24);
            this.Lbl_listCat.TabIndex = 2;
            this.Lbl_listCat.Text = "Listado de catedráticos";
            this.Lbl_listCat.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_codCar
            // 
            this.Lbl_codCar.AutoSize = true;
            this.Lbl_codCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codCar.Location = new System.Drawing.Point(30, 67);
            this.Lbl_codCar.Name = "Lbl_codCar";
            this.Lbl_codCar.Size = new System.Drawing.Size(120, 16);
            this.Lbl_codCar.TabIndex = 3;
            this.Lbl_codCar.Text = "Código de carrera:";
            // 
            // Txt_codCarrera
            // 
            this.Txt_codCarrera.Location = new System.Drawing.Point(155, 66);
            this.Txt_codCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codCarrera.Name = "Txt_codCarrera";
            this.Txt_codCarrera.Size = new System.Drawing.Size(128, 20);
            this.Txt_codCarrera.TabIndex = 4;
            this.Txt_codCarrera.TextChanged += new System.EventHandler(this.Txt_codCarrera_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(587, 64);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(89, 32);
            this.Btn_buscar.TabIndex = 9;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(587, 115);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(89, 34);
            this.Btn_limpiar.TabIndex = 10;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(587, 167);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(89, 36);
            this.Btn_regresar.TabIndex = 11;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            // 
            // Listado_catedraticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 568);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_codCarrera);
            this.Controls.Add(this.Lbl_codCar);
            this.Controls.Add(this.Lbl_listCat);
            this.Controls.Add(this.Dgv_catedratico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Listado_catedraticos";
            this.Text = "Listado de catedráticos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_catedratico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_catedratico;
        private System.Windows.Forms.Label Lbl_listCat;
        private System.Windows.Forms.Label Lbl_codCar;
        private System.Windows.Forms.TextBox Txt_codCarrera;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}