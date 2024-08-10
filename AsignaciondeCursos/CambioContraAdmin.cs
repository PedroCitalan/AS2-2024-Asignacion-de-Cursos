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
    public partial class CambioContraAdmin : Form
    {
        public string correo { get; set; }
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public CambioContraAdmin()
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
                    MessageBox.Show("Debe ingresar un correo para poder cambiar la contraseña.", "Correo no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (mAdminCRUD.buscarCorreoAdmin(mAdmin))
                    {
                        MessageBox.Show("Correo encontrado con éxito, puede proceder a cambiar la contraseña.", "Correo Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lbl_contra.Visible = true;
                        Lbl_confirmarcontra.Visible = true;
                        Txt_contra.Visible = true;
                        Txt_confirmarcontra.Visible = true;
                        Btn_cambiocontra.Visible = true;
                        Txt_correo.ReadOnly = true;
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

        private void Btn_cambiocontra_Click(object sender, EventArgs e)
        {
            try
            {
                string password = Txt_contra.Text;
                string passwordconfirm = Txt_confirmarcontra.Text;

                if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm))
                {
                    MessageBox.Show("Todos los campos de contraseña son obligatorios.", "Error de cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    obtenerDatosContra();
                    if (mAdmin.Contraseña != passwordconfirm)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (mAdminCRUD.actualizarContraAdmin(mAdmin))
                    {
                        MessageBox.Show("Cambio de contraseña realizado con éxito.", "Cambio Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginAdmin LoginAdmin = new LoginAdmin();
                        LoginAdmin.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void obtenerDatosContra()
        {
            mAdmin.Correo_electronico = Txt_correo.Text.Trim();
            mAdmin.Contraseña = Txt_contra.Text.Trim();
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
