
namespace AsignaciondeCursos
{
    partial class Validacion
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
            this.Lbl_validacion = new System.Windows.Forms.Label();
            this.Lbl_carnet = new System.Windows.Forms.Label();
            this.Txt_carnetCer1 = new System.Windows.Forms.TextBox();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Dgv_validacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_validacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_validacion
            // 
            this.Lbl_validacion.AutoSize = true;
            this.Lbl_validacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_validacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_validacion.Location = new System.Drawing.Point(339, 11);
            this.Lbl_validacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(139, 28);
            this.Lbl_validacion.TabIndex = 0;
            this.Lbl_validacion.Text = "Validación";
            // 
            // Lbl_carnet
            // 
            this.Lbl_carnet.AutoSize = true;
            this.Lbl_carnet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_carnet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_carnet.Location = new System.Drawing.Point(131, 53);
            this.Lbl_carnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_carnet.Name = "Lbl_carnet";
            this.Lbl_carnet.Size = new System.Drawing.Size(126, 19);
            this.Lbl_carnet.TabIndex = 1;
            this.Lbl_carnet.Text = "No. de Boleta:";
            // 
            // Txt_carnetCer1
            // 
            this.Txt_carnetCer1.Location = new System.Drawing.Point(135, 76);
            this.Txt_carnetCer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_carnetCer1.Name = "Txt_carnetCer1";
            this.Txt_carnetCer1.Size = new System.Drawing.Size(288, 22);
            this.Txt_carnetCer1.TabIndex = 5;
            this.Txt_carnetCer1.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(275, 503);
            this.Btn_Validar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(231, 43);
            this.Btn_Validar.TabIndex = 14;
            this.Btn_Validar.Text = "Validar/Asignación";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(13, 503);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(116, 43);
            this.Btn_regresar.TabIndex = 15;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Dgv_validacion
            // 
            this.Dgv_validacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_validacion.Location = new System.Drawing.Point(13, 127);
            this.Dgv_validacion.Name = "Dgv_validacion";
            this.Dgv_validacion.RowHeadersWidth = 51;
            this.Dgv_validacion.RowTemplate.Height = 24;
            this.Dgv_validacion.Size = new System.Drawing.Size(838, 360);
            this.Dgv_validacion.TabIndex = 16;
            // 
            // Validacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(863, 582);
            this.Controls.Add(this.Dgv_validacion);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Txt_carnetCer1);
            this.Controls.Add(this.Lbl_carnet);
            this.Controls.Add(this.Lbl_validacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Validacion";
            this.Text = "Validacion";
            this.Load += new System.EventHandler(this.Validacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_validacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_validacion;
        private System.Windows.Forms.Label Lbl_carnet;
        private System.Windows.Forms.TextBox Txt_carnetCer1;
        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.DataGridView Dgv_validacion;
    }
}