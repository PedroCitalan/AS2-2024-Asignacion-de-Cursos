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
    public partial class LoginAdmin : Form
    {
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public LoginAdmin()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mAdmin = new Admin_catedratico();
        }

        private void Btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                string password = Txt_contra.Text;
                string email = Txt_correo.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!matchEspeciales.Success)
                {
                    MessageBox.Show("El correo requiere una @ para ingresar.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    obtenerDatosAdmin();
                    if (mAdminCRUD.buscarUsuarioAdmin(mAdmin))
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Sesión Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AyudaAdmin AyudaAdmin = new AyudaAdmin();
                        AyudaAdmin.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerDatosAdmin()
        {
            mAdmin.Contra = Txt_contra.Text.Trim();
            mAdmin.Correo = Txt_correo.Text.Trim();
        }

        private void Btn_cambiocontra_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioContraAdmin CambioContraAdmin = new CambioContraAdmin();
            CambioContraAdmin.ShowDialog();
            this.Close();
        }

        private void Btn_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroAdmin RegistroAdmin = new RegistroAdmin();
            RegistroAdmin.ShowDialog();
            this.Close();
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
