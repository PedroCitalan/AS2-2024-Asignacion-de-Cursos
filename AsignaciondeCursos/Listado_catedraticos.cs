using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    public partial class Listado_catedraticos : Form
    {
        public Listado_catedraticos()
        {
            InitializeComponent();
            Txt_codCarrera.TextChanged += new EventHandler(Txt_codCarrera_TextChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_codCarrera_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_codCarrera.Text))
                {
                    long.Parse(Txt_codCarrera.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_codCarrera.Text = new string(Txt_codCarrera.Text.Where(char.IsDigit).ToArray());

                Txt_codCarrera.SelectionStart = Txt_codCarrera.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.ShowDialog();
            this.Close();
        }
    }
}
