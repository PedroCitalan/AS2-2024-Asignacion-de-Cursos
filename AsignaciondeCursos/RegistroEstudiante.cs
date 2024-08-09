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

namespace AsignaciondeCursos
{
    public partial class RegistroEstudiante : Form
    {
        private Estudiantes mEstudiantes;
        private EstudianteCRUD MestudianteCRUD;

        public RegistroEstudiante()
        {
            InitializeComponent();
            mEstudiantes = new Estudiantes();
            MestudianteCRUD = new EstudianteCRUD();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre_estudiante = Txt_nombre.Text;
                string apellido_estudiante = Txt_apellido.Text;
                string fecha_nacimiento = picker_fechanac.Value.ToString("yyyy-MM-dd");
                string carne = Txt_carne.Text;
                string creditosacumulados = Txt_creditosacumulados.Text;
                string seccion = Txt_seccion.Text;
                string nombreusuario = Txt_nombreusuario.Text;
                string contraseña = Txt_contra.Text;
                string contraseñaconfirmar = Txt_confirmarcontra.Text;
                string correoelectronico = Txt_correoelectronico.Text;

                Match matchEspeciales = Regex.Match(Txt_correoelectronico.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(nombreusuario) || string.IsNullOrWhiteSpace(apellido_estudiante) || string.IsNullOrWhiteSpace(fecha_nacimiento) || string.IsNullOrWhiteSpace(carne) || string.IsNullOrWhiteSpace(creditosacumulados) || string.IsNullOrWhiteSpace(seccion) || string.IsNullOrWhiteSpace(nombreusuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(correoelectronico) || string.IsNullOrEmpty(contraseñaconfirmar))
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
                    ObtenerDatosEstudiante();
                    ObtenerDatosUsuario();
                    if (mEstudiantes.Contraseña != contraseñaconfirmar)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (MestudianteCRUD.agregarEstudiante(mEstudiantes) && MestudianteCRUD.agregarUsuarioEstudiante(mEstudiantes))
                    {
                        MessageBox.Show("Estudiante registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_nombre.Clear();
                        Txt_apellido.Clear();
                        Txt_carne.Clear();
                        Txt_creditosacumulados.Clear();
                        Txt_seccion.Clear();
                        Txt_nombreusuario.Clear();
                        Txt_contra.Clear();
                        Txt_confirmarcontra.Clear();
                        Txt_correoelectronico.Clear();
                        Txt_ID_carrera.Clear();
                        Txt_ID_curso.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ObtenerDatosEstudiante()
        {
            mEstudiantes.Nombre = Txt_nombre.Text.Trim();
            mEstudiantes.Apellido = Txt_apellido.Text.Trim();
            mEstudiantes.Fecha_nacimiento = picker_fechanac.Value.ToString("yyyy-MM-dd").Trim();
            mEstudiantes.Carne = Txt_carne.Text.Trim();
            mEstudiantes.Creditos_acumulados = Txt_creditosacumulados.Text.Trim();
            mEstudiantes.ID_Carrera = Txt_ID_carrera.Text.Trim();
            mEstudiantes.ID_Cursos = Txt_ID_curso.Text.Trim();
            mEstudiantes.Seccion = Txt_seccion.Text.Trim();
        }

        private void ObtenerDatosUsuario()
        {
            mEstudiantes.Nombre_usuario = Txt_nombreusuario.Text.Trim();
            mEstudiantes.Contraseña = Txt_contra.Text.Trim();
            mEstudiantes.Correo_electronico = Txt_correoelectronico.Text.Trim();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEstudiante LoginEstudiante = new LoginEstudiante();
            LoginEstudiante.ShowDialog();
            this.Close();
        }
    }
}
