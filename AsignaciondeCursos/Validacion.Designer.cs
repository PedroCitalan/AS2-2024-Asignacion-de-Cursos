﻿
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
            this.Lbl_idboleta = new System.Windows.Forms.Label();
            this.Txt_idboleta = new System.Windows.Forms.TextBox();
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
            this.Lbl_validacion.Location = new System.Drawing.Point(278, 9);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(112, 23);
            this.Lbl_validacion.TabIndex = 0;
            this.Lbl_validacion.Text = "Validación";
            // 
            // Lbl_idboleta
            // 
            this.Lbl_idboleta.AutoSize = true;
            this.Lbl_idboleta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idboleta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_idboleta.Location = new System.Drawing.Point(98, 43);
            this.Lbl_idboleta.Name = "Lbl_idboleta";
            this.Lbl_idboleta.Size = new System.Drawing.Size(100, 16);
            this.Lbl_idboleta.TabIndex = 1;
            this.Lbl_idboleta.Text = "No. de Boleta:";
            // 
            // Txt_idboleta
            // 
            this.Txt_idboleta.Location = new System.Drawing.Point(101, 62);
            this.Txt_idboleta.Name = "Txt_idboleta";
            this.Txt_idboleta.Size = new System.Drawing.Size(217, 20);
            this.Txt_idboleta.TabIndex = 5;
            this.Txt_idboleta.TextChanged += new System.EventHandler(this.Txt_carnetCer1_TextChanged);
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Validar.Location = new System.Drawing.Point(282, 409);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(94, 35);
            this.Btn_Validar.TabIndex = 14;
            this.Btn_Validar.Text = "Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(10, 409);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(87, 35);
            this.Btn_regresar.TabIndex = 15;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // Dgv_validacion
            // 
            this.Dgv_validacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_validacion.Location = new System.Drawing.Point(10, 103);
            this.Dgv_validacion.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_validacion.Name = "Dgv_validacion";
            this.Dgv_validacion.RowHeadersWidth = 51;
            this.Dgv_validacion.RowTemplate.Height = 24;
            this.Dgv_validacion.Size = new System.Drawing.Size(628, 292);
            this.Dgv_validacion.TabIndex = 16;
            // 
            // Validacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(647, 468);
            this.Controls.Add(this.Dgv_validacion);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Txt_idboleta);
            this.Controls.Add(this.Lbl_idboleta);
            this.Controls.Add(this.Lbl_validacion);
            this.Name = "Validacion";
            this.Text = "Validacion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_validacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_validacion;
        private System.Windows.Forms.Label Lbl_idboleta;
        private System.Windows.Forms.TextBox Txt_idboleta;
        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.DataGridView Dgv_validacion;
    }
}