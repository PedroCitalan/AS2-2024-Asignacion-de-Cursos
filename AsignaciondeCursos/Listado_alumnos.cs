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
    public partial class Listado_alumnos : Form
    {
        public Listado_alumnos()
        {
            InitializeComponent();
            Txt_codCarrera.TextChanged += new EventHandler(Txt_codCarrera_TextChanged);
            Txt_codCur.TextChanged += new EventHandler(Txt_codCur_TextChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void Txt_codCur_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_codCur.Text))
                {
                    long.Parse(Txt_codCur.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_codCur.Text = new string(Txt_codCur.Text.Where(char.IsDigit).ToArray());

                Txt_codCur.SelectionStart = Txt_codCur.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
