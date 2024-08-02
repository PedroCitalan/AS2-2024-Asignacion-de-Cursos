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
    public partial class RegistroCatedratico : Form
    {
        private Catedratico mCatedratico;
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public RegistroCatedratico()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mCatedratico = new Catedratico();
            mAdmin = new Admin_catedratico();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Txt_nombre.Text;
                string lastname = Txt_apellido.Text;
                string carne = Txt_carne.Text;
                string phone = Txt_telefono.Text;
                string username = Txt_username.Text;
                string password = Txt_contra.Text;
                string passwordconfirm = Txt_confirmarcontra.Text;
                string email = Lbl_correo.Text;

                Match matchEspeciales = Regex.Match(Lbl_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(carne) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm) || string.IsNullOrWhiteSpace(email))
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
                    obtenerDatosCatedratico();
                    obtenerDatosAdmin();
                    if (mAdmin.Contraseña != passwordconfirm)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mAdminCRUD.agregarCatedratico(mCatedratico) && mAdminCRUD.agregarUsuarioCatedratico(mAdmin))
                    {
                        MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_nombre.Clear();
                        Txt_apellido.Clear();
                        Txt_carne.Clear();
                        Txt_correo.Clear();
                        Txt_telefono.Clear();
                        Txt_username.Clear();
                        Txt_contra.Clear();
                        Txt_confirmarcontra.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerDatosCatedratico()
        {
            string selectDateAsString = picker_fechanac.Value.ToString("yyyy-MM-dd");

            mCatedratico.Nombre = Txt_nombre.Text.Trim();
            mCatedratico.Apellido = Txt_apellido.Text.Trim();
            mCatedratico.Fecha_nacimiento = selectDateAsString;
            mCatedratico.Carne = Convert.ToInt32(Txt_carne.Text.Trim());
            mCatedratico.Correo_electronico = Txt_correo.Text.Trim();
            mCatedratico.Telefono = Convert.ToInt32(Txt_telefono.Text.Trim());
        }

        private void obtenerDatosAdmin()
        {
            mAdmin.Nombre_usuario = Txt_username.Text.Trim();
            mAdmin.Contraseña = Txt_contra.Text.Trim();
            mAdmin.Correo_electronico = Txt_correo.Text.Trim();
        }

        private void Txt_telefono_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_telefono);
        }

        private void HandleTextChanged(TextBox textBox)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    long.Parse(textBox.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.ShowDialog();
        }

        public class Catedratico
        {
            public int ID_catedratico { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Fecha_nacimiento { get; set; }
            public int Carne { get; set; }
            public string Correo_electronico { get; set; }
            public int Telefono { get; set; }
        }
    }
}
