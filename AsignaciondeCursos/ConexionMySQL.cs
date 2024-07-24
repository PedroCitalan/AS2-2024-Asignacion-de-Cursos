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

            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return conexion;
        }
    }
}
