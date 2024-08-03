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
    public partial class Certificacion : Form
    {
        public Certificacion()
        {
            InitializeComponent();
            Txt_carnetCer1.TextChanged += new EventHandler(Txt_carnetCer1_TextChanged);
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

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_carnetCer1.Clear();
            Dgv_cert.Rows.Clear();

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda ayuda = new Ayuda();
            ayuda.ShowDialog();
            this.Close();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
