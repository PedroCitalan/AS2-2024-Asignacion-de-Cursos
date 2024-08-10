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
    public partial class Validacion : Form
    {
        public string user { get; set; }
        public Validacion()
        {
            InitializeComponent();
            Txt_idboleta.TextChanged += new EventHandler(Txt_carnetCer1_TextChanged);
        }

        private void Txt_carnetCer1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Txt_idboleta.Text))
                {
                    long.Parse(Txt_idboleta.Text);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Entrada inválida, solo se permite ingresar números.", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Txt_idboleta.Text = new string(Txt_idboleta.Text.Where(char.IsDigit).ToArray());

                Txt_idboleta.SelectionStart = Txt_idboleta.Text.Length;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda Ayuda = new Ayuda();
            Ayuda.ShowDialog();
            this.Close();
        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            Validar(Convert.ToInt32(Txt_idboleta.Text.Trim()));
        }
        ConexionMySQL con = new ConexionMySQL();
        private void Validar(int idboleta)
        {
            try
            {
                string sql = "select * from TBL_BOLETA where ID_BOLETA =" + idboleta + "";
                MySqlDataAdapter datatable = new MySqlDataAdapter(sql, con.GetConnection());

                DataTable table = new DataTable();
                datatable.Fill(table);
                Dgv_validacion.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en llenado de tabla:" + e);
            }
        }
    }
}
