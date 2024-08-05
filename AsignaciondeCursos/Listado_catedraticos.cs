using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Listado_catedraticos : Form
    {
        private readonly ConexionMySQL ConexionaMySQL;

        public Listado_catedraticos()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
            Txt_codCarrera.TextChanged += Txt_codCarrera_TextChanged;
            Btn_buscar.Click += Btn_buscar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_regresar.Click += Btn_regresar_Click;
            this.Load += Listado_catedraticos_Load; // Añadir el evento Load
        }

        private void Listado_catedraticos_Load(object sender, EventArgs e)
        {
            CargarCatedraticos();
        }

        private void CargarCatedraticos()
        {
            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = "SELECT * FROM TBL_CATEDRATICO";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Dgv_catedratico.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de los catedráticos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string codigoCarrera = Txt_codCarrera.Text.Trim();

            string query = "SELECT * FROM TBL_CATEDRATICO WHERE 1=1";
            if (!string.IsNullOrEmpty(codigoCarrera))
            {
                query += " AND ID_CARRERA = @CodigoCarrera";
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

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Dgv_catedratico.DataSource = dataTable;
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
            CargarCatedraticos();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda Ayuda = new Ayuda();
            Ayuda.ShowDialog();
            this.Close();
        }

        private void Txt_codCarrera_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_codCarrera);
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
    }

    public class Catedratico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Carnet { get; set; }
        public string Departamento { get; set; }
    }
}

