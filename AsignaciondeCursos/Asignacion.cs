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
            // Lógica para asignar cursos
        }
    }
}
