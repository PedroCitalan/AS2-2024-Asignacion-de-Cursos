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
        public string correo { get; set; }
        private Catedratico mCatedratico;
        private AdminCRUD mAdminCRUD;
        public RegistroCatedratico()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mCatedratico = new Catedratico();
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
                string email = Txt_correo.Text;
                string course = Txt_idcurso.Text;
                string career = Txt_idcarrera.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(carne) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(career))
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
                    obtenerDatosUsuarioCatedratico();
                    if (mCatedratico.Contraseña != passwordconfirm)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mAdminCRUD.agregarCatedratico(mCatedratico))
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
                        Txt_idcurso.Clear();
                        Txt_idcarrera.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error en el ingreso de datos, vuelva a intentarlo de nuevo.", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            mCatedratico.idCurso = Convert.ToInt32(Txt_idcurso.Text.Trim());
            mCatedratico.idCarrera = Convert.ToInt32(Txt_idcarrera.Text.Trim());
        }

        private void obtenerDatosUsuarioCatedratico()
        {
            mCatedratico.Nombre_usuario = Txt_username.Text.Trim();
            mCatedratico.Contraseña = Txt_contra.Text.Trim();
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
                MessageBox.Show("Por favor, ingrese solo números para el teléfono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.correo = correo;
            AyudaAdmin.ShowDialog();
            this.Close();
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
            public int idCurso { get; set; }
            public int idCarrera { get; set; }
            public string Nombre_usuario { get; set; }
            public string Contraseña { get; set; }
        }
    }
}
