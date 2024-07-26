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
    public partial class Validacion : Form
    {
        public Validacion()
        {
            InitializeComponent();
            Txt_carnetCer1.TextChanged += new EventHandler(Txt_carnetCer1_TextChanged);
            Txt_carnetCer2.TextChanged += new EventHandler(Txt_carnetCer2_TextChanged);
            Txt_carnetCer3.TextChanged += new EventHandler(Txt_carnetCer3_TextChanged);
        }

        private void Txt_carnetCer1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_carnetCer1.Text))
                {
                    long.Parse(Txt_carnetCer1.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_carnetCer1.Text = new string(Txt_carnetCer1.Text.Where(char.IsDigit).ToArray());

                Txt_carnetCer1.SelectionStart = Txt_carnetCer1.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_carnetCer2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_carnetCer2.Text))
                {
                    long.Parse(Txt_carnetCer2.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_carnetCer2.Text = new string(Txt_carnetCer2.Text.Where(char.IsDigit).ToArray());

                Txt_carnetCer2.SelectionStart = Txt_carnetCer2.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_carnetCer3_TextChanged(object sender, EventArgs e)
        {
            try
            {

                    if (!string.IsNullOrEmpty(Txt_carnetCer3.Text))
                    {
                    long.Parse(Txt_carnetCer3.Text);
                    }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_carnetCer3.Text = new string(Txt_carnetCer3.Text.Where(char.IsDigit).ToArray());

                Txt_carnetCer3.SelectionStart = Txt_carnetCer3.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
