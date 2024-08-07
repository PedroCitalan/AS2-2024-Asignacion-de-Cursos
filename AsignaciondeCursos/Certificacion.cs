using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Certificacion : Form
    {
        public string correo { get; set; }
        private readonly ConexionMySQL ConexionaMySQL;

        public Certificacion()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
            Btn_buscar.Click += Btn_buscar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_regresar.Click += Btn_regresar_Click;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string carnet = Txt_carnetCer1.Text.Trim();

            if (string.IsNullOrEmpty(carnet))
            {
                MessageBox.Show("Por favor, ingrese el número de carnet.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        SELECT 
            c.NOMBRE_C, 
            c.HORARIO, 
            c.REQUISITOS, 
            c.CREDITOS, 
            c.SALON, 
            c.SECCION, 
            c.LABORATORIO, 
            n.NOTA
        FROM 
            TBL_CURSOS c
        INNER JOIN 
            TBL_NOTAS n ON c.ID_CURSOS = n.ID_CURSOS
        INNER JOIN 
            TBL_ESTUDIANTE e ON n.ID_ESTUDIANTE = e.ID_ESTUDIANTE
        WHERE 
            e.CARNE = @Carnet
            AND n.NOTA >= 61";  // Filtra solo las notas aprobadas

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Carnet", carnet);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Dgv_cert.DataSource = dataTable;
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
            Txt_carnetCer1.Text = string.Empty;
            Dgv_cert.DataSource = null;
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda ayuda = new Ayuda(); // Cambia AyudaAdmin por Ayuda
            ayuda.correo = correo;
            ayuda.ShowDialog();
            this.Close();
        }


        private void Txt_carnetCer1_TextChanged(object sender, EventArgs e)
        {
            HandleTextChanged(Txt_carnetCer1);
        }

        private void HandleTextChanged(TextBox textBox)
        {
            // Aquí puedes agregar lógica para validar el formato del carnet si es necesario.
        }
    }
}
