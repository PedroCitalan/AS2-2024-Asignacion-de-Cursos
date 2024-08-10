using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Asignacion : Form
    {
        public string user { get; set; }
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
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "NOMBRE_C";
                comboBox1.ValueMember = "ID_CURSOS"; // Cambia a la columna adecuada

                comboBox2.DataSource = dataTable.Copy();
                comboBox2.DisplayMember = "NOMBRE_C";
                comboBox2.ValueMember = "ID_CURSOS"; // Cambia a la columna adecuada

                comboBox3.DataSource = dataTable.Copy();
                comboBox3.DisplayMember = "NOMBRE_C";
                comboBox3.ValueMember = "ID_CURSOS"; // Cambia a la columna adecuada
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
            string numeroBoleta = Txt_idboleta.Text.Trim();

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

                    // Inserción en la tabla TBL_ASIGNACION_CURSOS
                    string insertQuery = "INSERT INTO TBL_ASIGNACION_CURSOS (ID_BOLETA, ID_CURSO) VALUES (@idBoleta, @idCurso)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@idBoleta", numeroBoleta);

                        // Asignar los cursos seleccionados en los ComboBox
                        insertCmd.Parameters.AddWithValue("@idCurso", Convert.ToInt32(comboBox1.SelectedValue));
                        insertCmd.ExecuteNonQuery();

                        insertCmd.Parameters["@idCurso"].Value = Convert.ToInt32(comboBox2.SelectedValue);
                        insertCmd.ExecuteNonQuery();

                        insertCmd.Parameters["@idCurso"].Value = Convert.ToInt32(comboBox3.SelectedValue);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Cursos asignados exitosamente.");
                    }
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
