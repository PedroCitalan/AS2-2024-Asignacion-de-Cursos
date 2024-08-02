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
        public string correo { get; set; }
        private Admin_catedratico mAdmin;
        private AdminCRUD mAdminCRUD;
        public AyudaAdmin()
        {
            InitializeComponent();
            mAdminCRUD = new AdminCRUD();
            mAdmin = new Admin_catedratico();
        }

        private void Btn_ayudaAdmin1_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_alumnos
            this.Hide();
            Listado_alumnos listadoAlumnosForm = new Listado_alumnos();
            listadoAlumnosForm.correo = correo;
            listadoAlumnosForm.ShowDialog();
            this.Close();
        }

        private void Btn_ayudaAdmin2_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_catedraticos
            this.Hide();
            Listado_catedraticos listadoCatedraticosForm = new Listado_catedraticos();
            listadoCatedraticosForm.ShowDialog();
            this.Close();
        }

        private void Btn_ayudaAdmin3_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Listado_cursos
            this.Hide();
            Listado_Cursos listadoCursosForm = new Listado_Cursos();
            listadoCursosForm.ShowDialog();
            this.Close();
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

        private void Btn_cambiocontra2_Click(object sender, EventArgs e)
        {
            // Abre el formulario de cambio de contraseña para catedráticos
            this.Hide();
            CambioContraCatedratico CambioContraCatedratico = new CambioContraCatedratico();
            CambioContraCatedratico.correo = correo;
            CambioContraCatedratico.ShowDialog();
            this.Close();
        }

        private void obtenerCorreo()
        {
            mAdmin.Correo_electronico = correo;
        }

        private void Btn_registrar1_Click(object sender, EventArgs e)
        {
            obtenerCorreo();
            if (mAdminCRUD.verificarUsuarioAdmin(mAdmin))
            {
                this.Hide();
                RegistroAdmin RegistroAdmin = new RegistroAdmin();
                RegistroAdmin.correo = correo;
                RegistroAdmin.ShowDialog();
                this.Close();
            }
        }

        private void Btn_registrar2_Click(object sender, EventArgs e)
        {
            obtenerCorreo();
            if (mAdminCRUD.verificarUsuarioAdmin(mAdmin))
            {
                this.Hide();
                RegistroCatedratico RegistroCatedratico = new RegistroCatedratico();
                RegistroCatedratico.correo = correo;
                RegistroCatedratico.ShowDialog();
                this.Close();
            }
        }

        private void Btn_cambiocontra1_Click(object sender, EventArgs e)
        {
            obtenerCorreo();
            if (mAdminCRUD.verificarUsuarioAdmin(mAdmin))
            {
                this.Hide();
                CambioContraAdmin CambioContraAdmin = new CambioContraAdmin();
                CambioContraAdmin.correo = correo;
                CambioContraAdmin.ShowDialog();
                this.Close();
            }
        }

        private void Btn_eliminar1_Click(object sender, EventArgs e)
        {
            obtenerCorreo();
            if (mAdminCRUD.verificarUsuarioAdmin(mAdmin))
            {
                this.Hide();
                DeleteCatedratico DeleteCatedratico = new DeleteCatedratico();
                DeleteCatedratico.correo = correo;
                DeleteCatedratico.ShowDialog();
                this.Close();
            }
        }

        private void Btn_eliminar2_Click(object sender, EventArgs e)
        {
            obtenerCorreo();
            if (mAdminCRUD.verificarUsuarioAdmin(mAdmin))
            {
                this.Hide();
                DeleteEstudiante DeleteEstudiante = new DeleteEstudiante();
                DeleteEstudiante.correo = correo;
                DeleteEstudiante.ShowDialog();
                this.Close();
            }
        }
    }
}

