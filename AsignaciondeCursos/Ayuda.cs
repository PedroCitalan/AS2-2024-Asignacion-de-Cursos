using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Btn_ayuda8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin LoginAdmin = new LoginAdmin();
            LoginAdmin.ShowDialog();
            this.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Asignacion
            Asignacion asignacion = new Asignacion();

            // Muestra el formulario Asignacion
            asignacion.Show();
        }

        private void Btn_ayuda2_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Boleta
            Boleta boleta = new Boleta();

            // Muestra el formulario Boleta
            boleta.Show();
        }

        private void Btn_ayuda3_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Certificacion
            Certificacion certificacion = new Certificacion();

            // Muestra el formulario Certificacion
            certificacion.Show();
        }

        private void Btn_ayuda4_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Validacion
            Validacion validacion = new Validacion();

            // Muestra el formulario Validacion
            validacion.Show();
        }

        private void Btn_ayuda5_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesión InicioSesion = new InicioSesión();
            InicioSesion.ShowDialog();
            this.Close();
        }
    }
}
