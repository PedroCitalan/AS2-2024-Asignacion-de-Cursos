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
            // Crea una instancia del formulario Listado_alumnos
            Listado_alumnos listadoAlumnos = new Listado_alumnos();

            // Muestra el formulario Listado_alumnos
            listadoAlumnos.Show();
        }

        private void Btn_ayudaAdmin2_Click(object sender, EventArgs e)
        {
            // Puedes agregar el código para otros botones aquí
        }

        private void Btn_ayudaAdmin3_Click(object sender, EventArgs e)
        {
            // Puedes agregar el código para otros botones aquí
        }

        private void Btn_ayudaAdmin4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesión InicioSesion = new InicioSesión();
            InicioSesion.ShowDialog();
            this.Close();
        }

        private void AyudaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
