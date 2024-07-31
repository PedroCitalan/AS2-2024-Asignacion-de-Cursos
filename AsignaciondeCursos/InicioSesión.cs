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
    public partial class InicioSesión : Form
    {
        public InicioSesión()
        {
            InitializeComponent();
        }

        private void Btn_sesion1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEstudiante LoginEstudiante = new LoginEstudiante();
            LoginEstudiante.ShowDialog();
            this.Close();
        }

        private void Btn_sesion2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin LoginAdmin = new LoginAdmin();
            LoginAdmin.ShowDialog();
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
