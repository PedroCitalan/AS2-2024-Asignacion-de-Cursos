using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignaciondeCursos
{
    class AdminCRUD
    {
        private ConexionMySQL ConexionMySQL;

        public AdminCRUD()
        {
            ConexionMySQL = new ConexionMySQL();
        }

        internal bool agregarUsuario(Admin_catedratico mAdmin)
        {
            string INSERT = "INSERT INTO Admin_catedratico (Nombre, Contra, Correo, Direccion)" +
                "values (@Nombre, @Contra, @Correo, @Direccion);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mAdmin.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@Contra", mAdmin.Contra));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo));
            mCommand.Parameters.Add(new MySqlParameter("@Direccion", mAdmin.Direccion));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool buscarUsuario(Admin_catedratico mAdmin)
        {
            string BUSCAR = "SELECT * FROM Admin_catedratico WHERE Correo = @Correo AND Contra = @Contra;";

            MySqlDataReader mReader;
            MySqlCommand mCommand = new MySqlCommand(BUSCAR, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Contra", mAdmin.Contra));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo));

            mReader = mCommand.ExecuteReader();

            int rows = 0;
            if (mReader.HasRows)
            {
                while (mReader.Read())
                    rows++;
            }
            if (rows == 0)
            {
                MessageBox.Show("Datos de usuario no encontrados. Si es un nuevo usuario, debe registrarse en la aplicación. Si olvidó su contraseña, debe hacer un cambio de contraseña.");
            }
            mReader.Close();

            return rows > 0;
        }
    }
}
