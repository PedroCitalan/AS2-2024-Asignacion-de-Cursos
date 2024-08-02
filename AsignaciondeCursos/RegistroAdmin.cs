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
                string username = Txt_username.Text;
                string password = Txt_contra.Text;
                string passwordconfirm = Txt_confirmarcontra.Text;
                string email = Txt_correo.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm) || string.IsNullOrWhiteSpace(email))
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
                    if (mAdmin.Contraseña != passwordconfirm)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mAdminCRUD.agregarUsuarioAdmin(mAdmin))
                    {
                        MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_username.Clear();
                        Txt_contra.Clear();
                        Txt_confirmarcontra.Clear();
                        Txt_correo.Clear();
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
            mAdmin.Nombre_usuario = Txt_username.Text.Trim();
            mAdmin.Contraseña = Txt_contra.Text.Trim();
            mAdmin.Correo_electronico = Txt_correo.Text.Trim();
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
