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
            this.Hide();
            // Crea una instancia del formulario Asignacion
            Asignacion asignacion = new Asignacion();

            // Muestra el formulario Asignacion
            asignacion.ShowDialog();
            this.Close();
        }

        private void Btn_ayuda2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del formulario Boleta
            Boleta boleta = new Boleta();

            // Muestra el formulario Boleta
            boleta.ShowDialog();
            this.Close();
        }

        private void Btn_ayuda3_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del formulario Certificacion
            Certificacion certificacion = new Certificacion();

            // Muestra el formulario Certificacion
            certificacion.ShowDialog();
        }

        private void Btn_ayuda4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del formulario Validacion
            Validacion validacion = new Validacion();

            // Muestra el formulario Validacion
            validacion.Show();
            this.Close();
        }

        private void Btn_ayuda5_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesión InicioSesion = new InicioSesión();
            InicioSesion.ShowDialog();
            this.Close();
        }

        private void AyudaEst1_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para la asignación de seccion por curso
            MessageBox.Show("Para la asignación de secciones por curso, ingrese los datos correspondientes. Al momento de presionar el botón, ya no se podrá modificar la sección asignada.");
        }

        private void AyudaEst2_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para generar la boleta de inscripción
            MessageBox.Show("Para generar una boleta de inscripción, ingrese el número de carnet y el semestre al que se está asignando.");
        }

        private void AyudaEst3_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para la búsqueda de certificación
            MessageBox.Show("Para realizar una búsqueda de certificación, ingrese el número de carnet del estudiante.");
        }

        private void AyudaEst4_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para validar la asignación
            MessageBox.Show("Para validar la asignación de cursos, ingrese el número de carnet del estudiante y el semestre.");
        }
    }
}

