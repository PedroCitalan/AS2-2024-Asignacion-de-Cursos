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
    public partial class AyudaAdmin : Form
    {
        public AyudaAdmin()
        {
            InitializeComponent();
        }

        private void Btn_ayudaAdmin1_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_alumnos
            Listado_alumnos listadoAlumnosForm = new Listado_alumnos();
            listadoAlumnosForm.Show();
        }

        private void Btn_ayudaAdmin2_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_catedraticos
            Listado_catedraticos listadoCatedraticosForm = new Listado_catedraticos();
            listadoCatedraticosForm.Show();
        }

        private void Btn_ayudaAdmin3_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_cursos
            Listado_Cursos listadoCursosForm = new Listado_Cursos();
            listadoCursosForm.Show();
        }

        private void Btn_ayudaAdmin4_Click(object sender, EventArgs e)
        {
            // Cierra la sesión y vuelve a la pantalla de inicio de sesión
            this.Hide();
            InicioSesión inicioSesionForm = new InicioSesión();
            inicioSesionForm.ShowDialog();
            this.Close();
        }

        private void AyudaAdm1_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para la búsqueda de estudiantes
            MessageBox.Show("Para buscar estudiantes, ingrese el código de carrera, el código de curso y la sección. Luego, haga clic en 'Buscar' para ver los resultados. Puede limpiar los campos con el botón 'Limpiar' y regresar con el botón 'Regresar'.");
        }

        private void AyudaAdm2_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para generar la lista de catedráticos
            MessageBox.Show("Para generar la lista de catedráticos, ingrese el código de carrera. Puede limpiar los campos con el botón 'Limpiar' y crear un nuevo registro con el botón 'Nuevo'.");
        }

        private void AyudaAdm3_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de ayuda para generar la lista de cursos
            MessageBox.Show("Para generar la lista de cursos, ingrese el código de carrera. Luego, haga clic en 'Buscar' para ver los resultados.");
        }
    }
}

