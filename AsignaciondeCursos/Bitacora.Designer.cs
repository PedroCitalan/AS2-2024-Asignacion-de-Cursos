
namespace AsignaciondeCursos
{
    partial class Bitacora
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
            this.Dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Lbl_bitacora = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_bitacora
            // 
            this.Dgv_bitacora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_bitacora.Location = new System.Drawing.Point(1, 82);
            this.Dgv_bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_bitacora.Name = "Dgv_bitacora";
            this.Dgv_bitacora.RowHeadersWidth = 51;
            this.Dgv_bitacora.RowTemplate.Height = 24;
            this.Dgv_bitacora.Size = new System.Drawing.Size(598, 283);
            this.Dgv_bitacora.TabIndex = 0;
            // 
            // Lbl_bitacora
            // 
            this.Lbl_bitacora.AutoSize = true;
            this.Lbl_bitacora.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bitacora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_bitacora.Location = new System.Drawing.Point(245, 7);
            this.Lbl_bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_bitacora.Name = "Lbl_bitacora";
            this.Lbl_bitacora.Size = new System.Drawing.Size(102, 26);
            this.Lbl_bitacora.TabIndex = 1;
            this.Lbl_bitacora.Text = "Bitacora";
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(501, 51);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(90, 25);
            this.Btn_actualizar.TabIndex = 2;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(9, 51);
            this.Btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(90, 26);
            this.Btn_regresar.TabIndex = 3;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Lbl_bitacora);
            this.Controls.Add(this.Dgv_bitacora);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_bitacora;
        private System.Windows.Forms.Label Lbl_bitacora;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}