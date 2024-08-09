
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
            this.Data_bitacora = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_bitacora
            // 
            this.Data_bitacora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_bitacora.Location = new System.Drawing.Point(1, 82);
            this.Data_bitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_bitacora.Name = "Data_bitacora";
            this.Data_bitacora.RowHeadersWidth = 51;
            this.Data_bitacora.RowTemplate.Height = 24;
            this.Data_bitacora.Size = new System.Drawing.Size(598, 283);
            this.Data_bitacora.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(245, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitacora";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(501, 51);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(90, 25);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(9, 51);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(90, 26);
            this.btn_regresar.TabIndex = 3;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_bitacora);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.Data_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_bitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_regresar;
    }
}