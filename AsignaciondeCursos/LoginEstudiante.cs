using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AsignaciondeCursos
{
    public partial class LoginEstudiante : Form
    {
        private ConexionMySQL conexionSQL;
        public LoginEstudiante()
        {
            InitializeComponent();
            conexionSQL = new ConexionMySQL();
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
                    if(ValidarUsuario(user, password))
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Sesión Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Ayuda Ayuda = new Ayuda();
                        Ayuda.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario/Contraseña Incorrecto");
                    }
                }

                Txt_contra.Clear();
                Txt_usuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarUsuario (string user, string password)
        {
            string query = "SELECT COUNT(*) FROM TBL_USUARIOS WHERE NOMBRE_USUARIO = @usuario AND CONTRASEÑA = @contraseña";
            MySqlDataReader mReader;
            MySqlCommand cmd = new MySqlCommand(query, conexionSQL.GetConnection());
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@contraseña", Hash.HashString(password));

            mReader = cmd.ExecuteReader();
            mReader.Close();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        private void Btn_cambiocontra_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioContraEstudiante cambioContraEstudiante = new CambioContraEstudiante();
            cambioContraEstudiante.ShowDialog();
            this.Close();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesión InicioSesion = new InicioSesión();
            InicioSesion.ShowDialog();
            this.Close();
        }

        private void Btn_registroEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroEstudiante registroEstudiante = new RegistroEstudiante();
            registroEstudiante.ShowDialog();
            this.Close();
        }
    }
}
