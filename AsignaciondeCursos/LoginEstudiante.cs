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
    public partial class LoginEstudiante : Form
    {
        public LoginEstudiante()
        {
            InitializeComponent();
        }

        private void Btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                string user = Txt_usuario.Text;
                string password = Txt_contra.Text;

                if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Sesión Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Txt_contra.Clear();
                Txt_usuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cambiocontra_Click(object sender, EventArgs e)
        {

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesión InicioSesion = new InicioSesión();
            InicioSesion.ShowDialog();
            this.Close();
        }
    }
}
