using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    public partial class RegistroAdmin : Form
    {
        public RegistroAdmin()
        {
            InitializeComponent();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Txt_nombre.Text;
                string password = Txt_contra.Text;
                string email = Txt_correo.Text;
                string address = Txt_address.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!matchEspeciales.Success)
                {
                    MessageBox.Show("El correo requiere una @ para registrarse.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Txt_nombre.Clear();
                Txt_contra.Clear();
                Txt_correo.Clear();
                Txt_address.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegisterUser(string name, string password, string email, string address)
        {
            return true;
        }
    }
}
