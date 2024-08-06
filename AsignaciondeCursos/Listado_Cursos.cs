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
    public partial class Listado_Cursos : Form
    {
        public string correo { get; set; }

        public Listado_Cursos()
        {
            InitializeComponent();
            Txt_codFacultad.TextChanged += new EventHandler(Txt_codCarrera_TextChanged);
        }

        private void Txt_codCarrera_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_codFacultad.Text))
                {
                    long.Parse(Txt_codFacultad.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_codFacultad.Text = new string(Txt_codFacultad.Text.Where(char.IsDigit).ToArray());

                Txt_codFacultad.SelectionStart = Txt_codFacultad.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCursos(Convert.ToInt32(Txt_codFacultad.Text.Trim()));
        }
        ConexionMySQL con = new ConexionMySQL();
        private void BuscarCursos(int idfacultad)
        {
            try
            {
                string sql = "select * from TBL_CURSOS where id_facultad =" + idfacultad + "";
                MySqlDataAdapter datatable = new MySqlDataAdapter(sql, con.GetConnection());

                DataTable table = new DataTable();
                datatable.Fill(table);
                Dgv_curso.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en llenado de tabla:" + e);
            }

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_codFacultad.Clear();

            Dgv_curso.DataSource = null;
            Dgv_curso.Rows.Clear();
            Dgv_curso.Refresh();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AyudaAdmin AyudaAdmin = new AyudaAdmin();
            AyudaAdmin.correo = correo;
            AyudaAdmin.ShowDialog();
            this.Close();
        }


    }
}

