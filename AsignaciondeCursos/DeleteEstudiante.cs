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
    public partial class DeleteEstudiante : Form
    {
        public string correo { get; set; }
        private EstudianteDelete mEstudiante;
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public DeleteEstudiante()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mAdmin = new Admin_catedratico();
            mEstudiante = new EstudianteDelete();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Txt_correo.Text;
                string carne = Txt_carne.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(carne))
                {
                    MessageBox.Show("Debe ingresar todos los campos para poder eliminar el usuario.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!matchEspeciales.Success)
                {
                    MessageBox.Show("El correo requiere una @ para poder hacer la búsqueda.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    obtenerDatosEstudiante();
                    obtenerDatosCorreo();
                    if (mAdminCRUD.deleteEstudiante(mEstudiante) && mAdminCRUD.deleteUsuarioEstudiante(mAdmin))
                    {
                        MessageBox.Show("Usuario eliminado con éxito.", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerDatosEstudiante()
        {
            mEstudiante.Carne = Convert.ToInt32(Txt_carne.Text.Trim());
        }
        private void obtenerDatosCorreo()
        {
            mAdmin.Correo_electronico = Txt_correo.Text.Trim();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.correo = correo;
            AyudaAdmin.ShowDialog();
            this.Close();
        }

        public class EstudianteDelete
        {
            public int Carne { get; set; }
        }
    }
}
