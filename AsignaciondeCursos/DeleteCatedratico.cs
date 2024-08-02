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
    public partial class DeleteCatedratico : Form
    {
        public string correo { get; set; }
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public DeleteCatedratico()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mAdmin = new Admin_catedratico();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Txt_correo.Text;

                Match matchEspeciales = Regex.Match(Txt_correo.Text, @"[@]");

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Debe ingresar un correo para poder eliminar el usuario.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!matchEspeciales.Success)
                {
                    MessageBox.Show("El correo requiere una @ para poder hacer la búsqueda.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    obtenerDatosCorreo();
                    if (mAdminCRUD.deleteUsuarioCatedratico(mAdmin))
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
    }
}
