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
    public partial class Asignacion : Form
    {
        public Asignacion()
        {
            InitializeComponent();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda Ayuda = new Ayuda();
            Ayuda.ShowDialog();
            this.Close();
        }

        private void Btn_asignar_Click(object sender, EventArgs e)
        {

        }

        private void Asignacion_Load(object sender, EventArgs e)
        {

        }
    }
}
