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
    public partial class Boleta : Form
    {
        public string user { get; set; }
        private Boleta_propiedades boleta_Propiedades;
        private BoletaCRUD boletaCRUD;

        public Boleta()
        {
            InitializeComponent();
            boleta_Propiedades = new Boleta_propiedades();
            boletaCRUD = new BoletaCRUD();
            txtMonto.TextChanged += new EventHandler(txtMonto_TextChanged);
            
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtMonto.Text))
                {
                    long.Parse(txtMonto.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Solo puede ingresar numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txtMonto.Text = new string(txtMonto.Text.Where(char.IsDigit).ToArray());

                txtMonto.SelectionStart = txtMonto.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda Ayuda = new Ayuda();
            Ayuda.user = user;
            Ayuda.ShowDialog();
            this.Close();
        }

        private void Boleta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre_pago = txtNombrePago.Text;
                string monto = txtMonto.Text;
                string fecha_realizada = Cbo_anio.Text;
                string carne = Txt_carnetCer1.Text;
                string nombre_estudiante = txtNombreEstudiante.Text;
                string apellido_estudiante = txtApellidoEstudiante.Text;
                string codigo_carrera = txtCodigoCarrera.Text;
                string no_semestre = Cbo_semestre.Text;
                if (string.IsNullOrWhiteSpace(nombre_pago) || string.IsNullOrWhiteSpace(monto) || string.IsNullOrWhiteSpace(fecha_realizada) || string.IsNullOrWhiteSpace(carne) || string.IsNullOrWhiteSpace(nombre_estudiante) || string.IsNullOrWhiteSpace(apellido_estudiante) || string.IsNullOrWhiteSpace(codigo_carrera) || string.IsNullOrWhiteSpace(no_semestre))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                {
                    ObtenerDatosBoleta();
                    if(boletaCRUD.crearBoleta(boleta_Propiedades))
                    {
                        MessageBox.Show("Se creo la boleta de pago");
                        txtNombrePago.Clear();
                        txtMonto.Clear();
                        Txt_carnetCer1.Clear();
                        txtNombreEstudiante.Clear();
                        txtApellidoEstudiante.Clear();
                        txtCodigoCarrera.Clear();
                        LblNoBoleta.Text = boleta_Propiedades.ID_boleta.ToString();
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtenerDatosBoleta()
        {
            Random rnd = new Random();
            int idboleta = rnd.Next(10000, 100000);
            boleta_Propiedades.ID_boleta = idboleta;
            boleta_Propiedades.Nombre_pago = txtNombrePago.Text.Trim();
            boleta_Propiedades.Monto = Convert.ToDouble(txtMonto.Text.Trim());
            boleta_Propiedades.Calendario = Cbo_anio.Text.Trim();
            boleta_Propiedades.carnet = Txt_carnetCer1.Text.Trim();
            boleta_Propiedades.Nombre_estudiante = txtNombreEstudiante.Text.Trim();
            boleta_Propiedades.Apellido_estudiante = txtApellidoEstudiante.Text.Trim();
            boleta_Propiedades.Codigo_Carrera = txtCodigoCarrera.Text.Trim();
            boleta_Propiedades.No_semestre = Cbo_semestre.Text.Trim();
            boleta_Propiedades.ID_facultad = Convert.ToInt32(txtIDFacultad.Text.Trim());
            boleta_Propiedades.Nombre_usuario = user;
        }
    }
}
