using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class CambioContraEstudiante : Form
    {
        private ConexionMySQL ConexionMySQL;
        private Estudiantes mEstudiantes;
        public CambioContraEstudiante()
        {
            InitializeComponent();
            ConexionMySQL = new ConexionMySQL();
            mEstudiantes = new Estudiantes();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Txt_correo.Text;
                Match matchespeciales = Regex.Match(Txt_correo.Text, @"[@]");
                if(string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Debe ingresar un correo para poder cambiar su contraseña.", "Correo no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!matchespeciales.Success)
                {
                    MessageBox.Show("El correo requiere una @ para poder hacer la búsqueda.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    obtenerCorreo();
                    string BuscarCorreo = "SELECT * FROM TBL_USUARIOS where CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'ESTUDIANTE';";
                    MySqlDataReader mReader;
                    MySqlCommand mCommand = new MySqlCommand(BuscarCorreo, ConexionMySQL.GetConnection());
                    mCommand.Parameters.Add(new MySqlParameter("@Correo", mEstudiantes.Correo_electronico));

                    mReader = mCommand.ExecuteReader();

                    int rows = 0;
                    if (mReader.HasRows)
                    {
                        while (mReader.Read())
                            rows++;
                    }
                    if (rows == 0)
                    {
                        MessageBox.Show("Correo electronico no encontrado. Si es un nuevo usuario, debe registrarse en la aplicación. Si olvidó su contraseña, debe hacer un cambio de contraseña.");
                    }
                    else
                    {
                        MessageBox.Show("Correo electronico encontrado");
                        Lbl_contraseña.Visible = true;
                        Lbl_confirmarcontra.Visible = true;
                        Txt_contra.Visible = true;
                        Txt_confirmarcontra.Visible = true;
                        Btn_cambiocontra.Visible = true;

                        Txt_correo.ReadOnly = true;
                    }
                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void obtenerCorreo()
        {
            mEstudiantes.Correo_electronico = Txt_correo.Text.Trim();
        }
        private void actualizarContraseña()
        {
            mEstudiantes.Contraseña = Txt_contra.Text.Trim();
        }

        private void Btn_cambiocontra_Click(object sender, EventArgs e)
        {
            try
            {
                string password = Txt_contra.Text;
                string confirmpassword = Txt_confirmarcontra.Text;
                if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpassword))
                {
                    MessageBox.Show("Ambos campos deben estar llenos");
                    return;
                }
                else 
                {
                    actualizarContraseña();
                    if (mEstudiantes.Contraseña != confirmpassword)
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                        return;
                    }
                    else
                    {
                        string actualizarcontraseña = "UPDATE TBL_USUARIOS SET CONTRASEÑA = @Contraseña WHERE CORREO_ELECTRONICO = @Correo;";
                        MySqlCommand mCommand = new MySqlCommand(actualizarcontraseña, ConexionMySQL.GetConnection());
                        mCommand.Parameters.Add(new MySqlParameter("@Contraseña", mEstudiantes.Contraseña));
                        mCommand.Parameters.Add(new MySqlParameter("@Correo", mEstudiantes.Correo_electronico));

                        if (mCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Contraseña actualizada con exito");
                            this.Hide();
                            LoginEstudiante loginEstudiante = new LoginEstudiante();
                            loginEstudiante.ShowDialog();
                            this.Close();
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
