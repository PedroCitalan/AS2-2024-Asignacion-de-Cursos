using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AsignaciondeCursos
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtnombre.Text;
            string password = txtpassword.Text;
            string email = txtemail.Text;
            string address = txtaddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnombre.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtaddress.Clear();
        }
        private bool RegisterUser(string name, string password, string email, string address)
        {

            return true;


        }
    }
}

