
namespace AsignaciondeCursos
{
    partial class Certificacion
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Dgv_cert = new System.Windows.Forms.DataGridView();
            this.Lbl_certificacion = new System.Windows.Forms.Label();
            this.Lbl_carnet = new System.Windows.Forms.Label();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cert)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_cert
            // 
            this.Dgv_cert.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cert.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dgv_cert.Location = new System.Drawing.Point(9, 229);
            this.Dgv_cert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_cert.Name = "Dgv_cert";
            this.Dgv_cert.RowHeadersWidth = 51;
            this.Dgv_cert.RowTemplate.Height = 24;
            this.Dgv_cert.Size = new System.Drawing.Size(901, 326);
            this.Dgv_cert.TabIndex = 3;
            // 
            // Lbl_certificacion
            // 
            this.Lbl_certificacion.AutoSize = true;
            this.Lbl_certificacion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_certificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_certificacion.Location = new System.Drawing.Point(326, 6);
            this.Lbl_certificacion.Name = "Lbl_certificacion";
            this.Lbl_certificacion.Size = new System.Drawing.Size(319, 32);
            this.Lbl_certificacion.TabIndex = 4;
            this.Lbl_certificacion.Text = "Certificacion de Cursos";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_carnet.Location = new System.Drawing.Point(83, 66);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(144, 23);
            this.Lbl_carnet.TabIndex = 5;
            this.Lbl_carnet.Text = "No. de Carnet:";
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(236, 73);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(129, 20);
            this.Txt_carnetCer1.TabIndex = 6;
            this.Txt_carnetCer1.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(404, 55);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(88, 43);
            this.Btn_buscar.TabIndex = 11;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(404, 103);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(88, 41);
            this.Btn_limpiar.TabIndex = 12;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(404, 148);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(88, 44);
            this.Btn_regresar.TabIndex = 13;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Certificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(922, 565);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Lbl_carnet);
            this.Controls.Add(this.Lbl_certificacion);
            this.Controls.Add(this.Dgv_cert);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Certificacion";
            this.Text = "Certificacion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_cert;
        private System.Windows.Forms.Label Lbl_certificacion;
        private System.Windows.Forms.Label Lbl_carnet;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}
