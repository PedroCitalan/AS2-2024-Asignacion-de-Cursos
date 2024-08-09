using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class Bitacora : Form
    {
        private ConexionMySQL ConexionaMySQL;
        public string correo { get; set; }

        public Bitacora()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
            CargarBitacora();

            // Asociar eventos
            btn_actualizar.Click += Btn_actualizar_Click;
        }

        private void CargarBitacora()
        {
            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = "SELECT * FROM TBL_BITACORA ORDER BY FECHA_ACCION DESC";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Data_bitacora.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la bitácora: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {

            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.correo = correo;
            AyudaAdmin.ShowDialog();
            this.Close();
        }
    }
}