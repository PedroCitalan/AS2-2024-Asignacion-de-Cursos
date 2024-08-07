using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public partial class aprobacion_cursos : Form
    {
        private ConexionMySQL ConexionaMySQL;

        public string Correo { get; set; }

        private Form ayudaForm;
        public aprobacion_cursos(Form ayudaForm)
        {
            InitializeComponent();
            this.ayudaForm = ayudaForm;
            this.FormClosed += aprobacion_cursos_FormClosed;
        }

        private void aprobacion_cursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ayudaForm.Show(); // Mostrar el formulario Ayuda
        }

        public aprobacion_cursos()
        {
            InitializeComponent();
            ConexionaMySQL = new ConexionMySQL();
            CargarCursos();

            // Asociar eventos
            Btn_cargarNotas.Click += Btn_cargarNotas_Click;
            Btn_buscarcarnet.Click += BtnBuscar_carnet_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            btn_mod.Click += Btn_mod_Click;
        }

        private void CargarCursos()
        {
            // Lógica para cargar cursos en el ComboBox
            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = "SELECT ID_CURSOS, NOMBRE_C FROM TBL_CURSOS";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Cbo_cursos.DataSource = dataTable;
                        Cbo_cursos.DisplayMember = "NOMBRE_C";
                        Cbo_cursos.ValueMember = "ID_CURSOS";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los cursos: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_cargarNotas_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(Txt_carnet.Text) || Cbo_cursos.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Txt_nota.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string carnet = Txt_carnet.Text;
            int cursoId = (int)Cbo_cursos.SelectedValue;
            string nota = Txt_nota.Text;

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();

                // Verificar si ya existe una nota para el curso
                string checkQuery = @"
                    SELECT COUNT(*) FROM TBL_NOTAS 
                    WHERE ID_ESTUDIANTE = (SELECT ID_ESTUDIANTE FROM TBL_ESTUDIANTE WHERE CARNE = @Carnet) 
                    AND ID_CURSOS = @CursoId";

                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Carnet", carnet);
                    checkCommand.Parameters.AddWithValue("@CursoId", cursoId);

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe una nota registrada para este curso.");
                        return;
                    }
                }

                // Insertar la nota
                string query = @"
                    INSERT INTO TBL_NOTAS (ID_ESTUDIANTE, ID_CURSOS, NOTA, FECHA_REGISTRO)
                    VALUES ((SELECT ID_ESTUDIANTE FROM TBL_ESTUDIANTE WHERE CARNE = @Carnet), @CursoId, @Nota, NOW())";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@CursoId", cursoId);
                    command.Parameters.AddWithValue("@Nota", nota);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Nota cargada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la nota: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void BtnBuscar_carnet_Click(object sender, EventArgs e)
        {
            string carnet = Txt_carnet.Text;

            if (string.IsNullOrWhiteSpace(carnet))
            {
                MessageBox.Show("Por favor, ingrese el carnet del estudiante.");
                return;
            }

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();
                string query = @"
                    SELECT E.NOMBRE, E.APELLIDO, C.NOMBRE_C, C.SALON, C.SECCION, N.NOTA
                    FROM TBL_ESTUDIANTE E
                    JOIN TBL_NOTAS N ON E.ID_ESTUDIANTE = N.ID_ESTUDIANTE
                    JOIN TBL_CURSOS C ON N.ID_CURSOS = C.ID_CURSOS
                    WHERE E.CARNE = @Carnet";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Carnet", carnet);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Dgv_notas.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            Txt_carnet.Clear();
            Txt_nota.Clear();
            Cbo_cursos.SelectedIndex = -1;
            Dgv_notas.DataSource = null;
        }

        private void Btn_mod_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(Txt_carnet.Text) || Cbo_cursos.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Txt_nota.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string carnet = Txt_carnet.Text;
            int cursoId = (int)Cbo_cursos.SelectedValue;
            string nuevaNota = Txt_nota.Text;

            MySqlConnection connection = null;

            try
            {
                connection = ConexionaMySQL.GetConnection();

                // Verificar si ya existe una nota para el curso
                string checkQuery = @"
            SELECT COUNT(*) FROM TBL_NOTAS 
            WHERE ID_ESTUDIANTE = (SELECT ID_ESTUDIANTE FROM TBL_ESTUDIANTE WHERE CARNE = @Carnet) 
            AND ID_CURSOS = @CursoId";

                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Carnet", carnet);
                    checkCommand.Parameters.AddWithValue("@CursoId", cursoId);

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("No hay nota registrada para este curso.");
                        return;
                    }
                }

                // Actualizar la nota
                string updateQuery = @"
            UPDATE TBL_NOTAS
            SET NOTA = @Nota
            WHERE ID_ESTUDIANTE = (SELECT ID_ESTUDIANTE FROM TBL_ESTUDIANTE WHERE CARNE = @Carnet) 
            AND ID_CURSOS = @CursoId";

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Carnet", carnet);
                    updateCommand.Parameters.AddWithValue("@CursoId", cursoId);
                    updateCommand.Parameters.AddWithValue("@Nota", nuevaNota);

                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Nota modificada exitosamente.");

                    // Actualizar el DataGridView llamando al método BtnBuscar_carnet_Click
                    BtnBuscar_carnet_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la nota: " + ex.Message);
            }
            finally
            {
                ConexionaMySQL.CloseConnection(connection);
            }
        }


    }
}


