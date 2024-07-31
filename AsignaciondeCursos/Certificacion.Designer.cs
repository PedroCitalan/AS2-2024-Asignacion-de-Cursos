
namespace AsignaciondeCursos
{
    partial class Certificacion
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
            this.Dgv_cert = new System.Windows.Forms.DataGridView();
            this.Lbl_certificacion = new System.Windows.Forms.Label();
            this.Lbl_carnet = new System.Windows.Forms.Label();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer2 = new System.Windows.Forms.TextBox();
            this.Txt_carnetCer3 = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cert)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_cert
            // 
            this.Dgv_cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cert.Location = new System.Drawing.Point(9, 229);
            this.Dgv_cert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_cert.Name = "Dgv_cert";
            this.Dgv_cert.RowHeadersWidth = 51;
            this.Dgv_cert.RowTemplate.Height = 24;
            this.Dgv_cert.Size = new System.Drawing.Size(781, 326);
            this.Dgv_cert.TabIndex = 3;
            // 
            // Lbl_certificacion
            // 
            this.Lbl_certificacion.AutoSize = true;
            this.Lbl_certificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_certificacion.Location = new System.Drawing.Point(305, 7);
            this.Lbl_certificacion.Name = "Lbl_certificacion";
            this.Lbl_certificacion.Size = new System.Drawing.Size(203, 24);
            this.Lbl_certificacion.TabIndex = 4;
            this.Lbl_certificacion.Text = "Certificacion de Cursos";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.Location = new System.Drawing.Point(36, 71);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(93, 16);
            this.Lbl_carnet.TabIndex = 5;
            this.Lbl_carnet.Text = "No. de Carnet:";
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(135, 67);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer1.TabIndex = 6;
            this.Txt_carnetCer1.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Txt_carnetCer2
            // 
            this.Txt_carnetCer2.Location = new System.Drawing.Point(255, 67);
            this.Txt_carnetCer2.Name = "Txt_carnetCer2";
            this.Txt_carnetCer2.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer2.TabIndex = 7;
            this.Txt_carnetCer2.TextChanged += new System.EventHandler(this.Txt_carnetCer2_TextChanged);
            // 
            // Txt_carnetCer3
            // 
            this.Txt_carnetCer3.Location = new System.Drawing.Point(372, 67);
            this.Txt_carnetCer3.Name = "Txt_carnetCer3";
            this.Txt_carnetCer3.Size = new System.Drawing.Size(100, 20);
            this.Txt_carnetCer3.TabIndex = 8;
            this.Txt_carnetCer3.TextChanged += new System.EventHandler(this.Txt_carnetCer3_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(585, 69);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(88, 28);
            this.Btn_buscar.TabIndex = 11;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(585, 115);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(88, 31);
            this.Btn_limpiar.TabIndex = 12;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(585, 162);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(88, 32);
            this.Btn_regresar.TabIndex = 13;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            // 
            // Certificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_carnetCer3);
            this.Controls.Add(this.Txt_carnetCer2);
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
        private System.Windows.Forms.TextBox Txt_carnetCer2;
        private System.Windows.Forms.TextBox Txt_carnetCer3;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}