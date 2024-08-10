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
            Txt_Monto.TextChanged += new EventHandler(txtMonto_TextChanged);
            
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_Monto.Text))
                {
                    long.Parse(Txt_Monto.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Solo puede ingresar numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_Monto.Text = new string(Txt_Monto.Text.Where(char.IsDigit).ToArray());

                Txt_Monto.SelectionStart = Txt_Monto.Text.Length;
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
                string nombre_pago = Txt_NombrePago.Text;
                string monto = Txt_Monto.Text;
                string fecha_realizada = Cbo_anio.Text;
                string carne = Txt_carnetCer1.Text;
                string nombre_estudiante = Txt_NombreEstudiante.Text;
                string apellido_estudiante = Txt_ApellidoEstudiante.Text;
                string codigo_carrera = Txt_CodigoCarrera.Text;
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
                        Txt_NombrePago.Clear();
                        Txt_Monto.Clear();
                        Txt_carnetCer1.Clear();
                        Txt_NombreEstudiante.Clear();
                        Txt_ApellidoEstudiante.Clear();
                        Txt_CodigoCarrera.Clear();
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
            boleta_Propiedades.Nombre_pago = Txt_NombrePago.Text.Trim();
            boleta_Propiedades.Monto = Convert.ToDouble(Txt_Monto.Text.Trim());
            boleta_Propiedades.Calendario = Cbo_anio.Text.Trim();
            boleta_Propiedades.carnet = Txt_carnetCer1.Text.Trim();
            boleta_Propiedades.Nombre_estudiante = Txt_NombreEstudiante.Text.Trim();
            boleta_Propiedades.Apellido_estudiante = Txt_ApellidoEstudiante.Text.Trim();
            boleta_Propiedades.Codigo_Carrera = Txt_CodigoCarrera.Text.Trim();
            boleta_Propiedades.No_semestre = Cbo_semestre.Text.Trim();
            boleta_Propiedades.ID_facultad = Convert.ToInt32(Txt_IDFacultad.Text.Trim());
            boleta_Propiedades.Nombre_usuario = user;
        }
    }
}
