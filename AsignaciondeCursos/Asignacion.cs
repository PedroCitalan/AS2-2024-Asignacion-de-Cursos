using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Asignacion : Form
    {
        private readonly ConexionMySQL ConexionaMySQL;

        public Asignacion()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
        }

        private void Asignacion_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            string query = "SELECT * FROM TBL_CURSOS"; // Selecciona todas las columnas

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar los datos a los ComboBox
                comboBox1.DataSource = dataTable.Copy();
                comboBox1.DisplayMember = "NOMBRE_C";

                comboBox2.DataSource = dataTable.Copy();
                comboBox2.DisplayMember = "NOMBRE_C";

                comboBox3.DataSource = dataTable.Copy();
                comboBox3.DisplayMember = "NOMBRE_C";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
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
            string numeroBoleta = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(numeroBoleta))
            {
                MessageBox.Show("Por favor, ingrese un número de boleta.");
                return;
            }

            MySqlConnection connection = null;
            try
            {
                connection = ConexionaMySQL.GetConnection();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // Consulta para verificar si la boleta existe
                string query = "SELECT COUNT(*) FROM TBL_BOLETA WHERE ID_BOLETA = @boleta";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@boleta", numeroBoleta);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Lógica para asignar cursos si la boleta existe
                    MessageBox.Show("Boleta encontrada. Procediendo con la asignación de cursos.");
                }
                else
                {
                    MessageBox.Show("Boleta no encontrada. Por favor verifique el número de boleta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
