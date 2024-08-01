using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Listado_alumnos : Form
    {
        private ConexionMySQL ConexionaMySQL;

        public Listado_alumnos()
        {
            InitializeComponent();
            Txt_codCarrera.TextChanged += new EventHandler(Txt_codCarrera_TextChanged);
            Txt_codCur.TextChanged += new EventHandler(Txt_codCur_TextChanged);
            ConexionaMySQL = new ConexionMySQL();
            this.Load += new EventHandler(Listado_alumnos_Load);
        }

        private void Listado_alumnos_Load(object sender, EventArgs e)
        {
            try
            {
                List<Estudiante> estudiantes = ObtenerEstudiantes();
                Dgv_alumno.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            using (MySqlConnection connection = ConexionaMySQL.GetConnection())
            {
                string query = "SELECT ID_ESTUDIANTE, NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS FROM ESTUDIANTE";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante
                            {
                                Id = reader.GetInt32("ID_ESTUDIANTE"),
                                Nombre = reader.GetString("NOMBRE"),
                                Apellido = reader.GetString("APELLIDO"),
                                FechaNac = reader.GetDateTime("FECHA_NAC"),
                                Carne = reader.GetInt32("CARNE"),
                                CreditosAcumulados = reader.GetInt32("CREDITOS_ACUMULADOS")
                            };
                            estudiantes.Add(estudiante);
                        }
                    }
                }
            }
            return estudiantes;
        }

        private void Txt_codCarrera_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_codCarrera, "codCarrera");
        }

        private void Txt_codCur_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_codCur, "codCur");
        }

        private void HandleTextChanged(TextBox textBox, string fieldName)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    long.Parse(textBox.Text);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado en {fieldName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Carne { get; set; }
        public int CreditosAcumulados { get; set; }
    }
}
