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
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public RegistroAdmin()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mAdmin = new Admin_catedratico();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Txt_nombre.Text;
                string password = Txt_contra.Text;
                string passwordconfirm = Txt_confirmarcontra.Text;
                string email = Txt_correo.Text;
                string address = Txt_address.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
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
                    obtenerDatosAdmin();
                    if (mAdminCRUD.agregarUsuario(mAdmin))
                    {
                        MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_nombre.Clear();
                        Txt_contra.Clear();
                        Txt_confirmarcontra.Clear();
                        Txt_correo.Clear();
                        Txt_address.Clear();
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
            mAdmin.Nombre = Txt_nombre.Text.Trim();
            mAdmin.Contra = Txt_contra.Text.Trim();
            mAdmin.Correo = Txt_correo.Text.Trim();
            mAdmin.Direccion = Txt_address.Text.Trim();
            string confirmarcontra = Txt_confirmarcontra.Text.Trim();
            if (mAdmin.Contra != confirmarcontra)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin LoginAdmin = new LoginAdmin();
            LoginAdmin.ShowDialog();
            this.Close();
        }
    }
}
