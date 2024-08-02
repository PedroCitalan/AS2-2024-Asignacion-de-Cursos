using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Listado_alumnos : Form
    {
        private readonly ConexionMySQL ConexionaMySQL;

        public Listado_alumnos()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
            Txt_codCarrera.TextChanged += Txt_codCarrera_TextChanged;
            Txt_codCur.TextChanged += Txt_codCur_TextChanged;
            Btn_buscar.Click += Btn_buscar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_regresar.Click += Btn_regresar_Click;
            this.Load += Listado_alumnos_Load;
        }

        private void Listado_alumnos_Load(object sender, EventArgs e)
        {
            try
            {
                List<Estudiante> estudiantes = ObtenerEstudiantes();
                Dgv_alumno.DataSource = estudiantes;
                CargarSecciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = "SELECT ID_ESTUDIANTE, NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS FROM TBL_ESTUDIANTE";
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
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }

            return estudiantes;
        }

        private void CargarSecciones()
        {
            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = "SELECT DISTINCT SECCION FROM TBL_ESTUDIANTE";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        Cbo_secc.Items.Clear();
                        while (reader.Read())
                        {
                            Cbo_secc.Items.Add(reader.GetString("SECCION"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las secciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string codigoCarrera = Txt_codCarrera.Text.Trim();
            string codigoCurso = Txt_codCur.Text.Trim();
            string seccion = Cbo_secc.SelectedItem?.ToString();

            string query = "SELECT * FROM TBL_ESTUDIANTE WHERE 1=1";
            if (!string.IsNullOrEmpty(codigoCarrera))
            {
                query += " AND ID_CARRERA = @CodigoCarrera";
            }
            if (!string.IsNullOrEmpty(codigoCurso))
            {
                query += " AND ID_CURSOS = @CodigoCurso";
            }
            if (!string.IsNullOrEmpty(seccion))
            {
                query += " AND SECCION = @Seccion";
            }

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(codigoCarrera))
                    {
                        command.Parameters.AddWithValue("@CodigoCarrera", codigoCarrera);
                    }
                    if (!string.IsNullOrEmpty(codigoCurso))
                    {
                        command.Parameters.AddWithValue("@CodigoCurso", codigoCurso);
                    }
                    if (!string.IsNullOrEmpty(seccion))
                    {
                        command.Parameters.AddWithValue("@Seccion", seccion);
                    }

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Dgv_alumno.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_codCarrera.Text = string.Empty;
            Txt_codCur.Text = string.Empty;
            Cbo_secc.SelectedIndex = -1;
            Dgv_alumno.DataSource = null;
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_codCarrera_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_codCarrera);
        }

        private void Txt_codCur_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_codCur);
        }

        private void HandleTextChanged(TextBox textBox)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    long.Parse(textBox.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                textBox.SelectionStart = textBox.Text.Length;
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
