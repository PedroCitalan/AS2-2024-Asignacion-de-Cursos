using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    class ConexionMySQL : Conexion
    {
        private MySqlConnection conexion;
        private string cadenaConexion;

        public ConexionMySQL()
        {
            cadenaConexion = "Database=" + database +
            "; DataSource=" + server +
            "; User Id=" + user +
            "; Password=" + password;
        }

        public MySqlConnection GetConnection()
        {
            conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return conexion;
        }

        public void CloseConnection(MySqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}