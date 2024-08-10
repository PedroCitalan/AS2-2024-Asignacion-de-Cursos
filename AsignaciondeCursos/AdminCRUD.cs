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

        internal bool agregarUsuarioAdmin(Admin_catedratico mAdmin)
        {
            string INSERT = "INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO)" +
                "values (@Nombre, @Contra, @Correo, 'ADMINISTRADOR');";

            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mAdmin.Nombre_usuario));
            mCommand.Parameters.Add(new MySqlParameter("@Contra", Hash.HashString(mAdmin.Contraseña)));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, NOMBRE_USUARIO, CORREO_ELECTRONICO)
                    VALUES (@Accion, @NombreUsuario, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Usuario de administrador agregado");
            command.Parameters.AddWithValue("@NombreUsuario", mAdmin.Nombre_usuario);
            command.Parameters.AddWithValue("@CorreoElectronico", mAdmin.Correo_electronico);

            return mCommand.ExecuteNonQuery() > 0 && command.ExecuteNonQuery() > 0;
        }

        internal bool buscarUsuarioAdmin(Admin_catedratico mAdmin)
        {
            string BUSCAR = "SELECT * FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND CONTRASEÑA = @Contra;";

            MySqlDataReader mReader;
            MySqlCommand mCommand = new MySqlCommand(BUSCAR, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Contra", Hash.HashString(mAdmin.Contraseña)));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

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

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, CORREO_ELECTRONICO)
                    VALUES (@Accion, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Inicio de sesion de usuario administrador/catedrático");
            command.Parameters.AddWithValue("@CorreoElectronico", mAdmin.Correo_electronico);

            return rows > 0 && command.ExecuteNonQuery() > 0;
        }

        internal bool deleteUsuarioEstudiante(Admin_catedratico mAdmin)
        {
            string DELETE = "DELETE FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'ESTUDIANTE';";

            MySqlCommand mCommand = new MySqlCommand(DELETE, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, CORREO_ELECTRONICO)
                    VALUES (@Accion, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Usuario de estudiante eliminado");
            command.Parameters.AddWithValue("@CorreoElectronico", mAdmin.Correo_electronico);

            return mCommand.ExecuteNonQuery() > 0 && command.ExecuteNonQuery() > 0;
        }

        internal bool deleteEstudiante(DeleteEstudiante.EstudianteDelete mEstudiante)
        {
            string DELETE = "DELETE FROM TBL_ESTUDIANTE WHERE CARNE = @Carne;";

            MySqlCommand mCommand = new MySqlCommand(DELETE, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Carne", mEstudiante.Carne));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool deleteUsuarioCatedratico(Admin_catedratico mAdmin)
        {
            string DELETE = "DELETE FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'CATEDRATICO';";
            string DELETE2 = "DELETE FROM TBL_CATEDRATICO WHERE CORREO_ELECTRONICO = @Correo;";

            MySqlCommand mCommand = new MySqlCommand(DELETE, ConexionMySQL.GetConnection());
            MySqlCommand mCommand2 = new MySqlCommand(DELETE2, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));
            mCommand2.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, CORREO_ELECTRONICO)
                    VALUES (@Accion, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Usuario de catedrático eliminado");
            command.Parameters.AddWithValue("@CorreoElectronico", mAdmin.Correo_electronico);

            return mCommand.ExecuteNonQuery() > 0 && mCommand2.ExecuteNonQuery() > 0;
        }

        internal bool buscarCorreoCatedratico(Admin_catedratico mAdmin)
        {
            string BUSCARCORREO = "SELECT * FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'CATEDRATICO';";

            MySqlDataReader mReader;
            MySqlCommand mCommand = new MySqlCommand(BUSCARCORREO, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            mReader = mCommand.ExecuteReader();

            int rows = 0;
            if (mReader.HasRows)
            {
                while (mReader.Read())
                    rows++;
            }
            if (rows == 0)
            {
                MessageBox.Show("Correo no encontrado o no es un correo de catedrático.");
            }
            mReader.Close();

            return rows > 0;
        }

        internal bool agregarCatedratico(RegistroCatedratico.Catedratico mCatedratico)
        {
            string INSERT = "INSERT INTO TBL_CATEDRATICO (NOMBRE, APELLIDO, FECHA_NAC, CARNE, CORREO_ELECTRONICO, TELEFONO, ID_CURSOS, ID_CARRERA)" +
                "values (@Nombre, @Apellido, @Fecha_nac, @Carne, @Correo, @Telefono, @IDCurso, @IDCarrera);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mCatedratico.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@Apellido", mCatedratico.Apellido));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_nac", mCatedratico.Fecha_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Carne", mCatedratico.Carne));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mCatedratico.Correo_electronico));
            mCommand.Parameters.Add(new MySqlParameter("@Telefono", mCatedratico.Telefono));
            mCommand.Parameters.Add(new MySqlParameter("@IDCurso", mCatedratico.idCurso));
            mCommand.Parameters.Add(new MySqlParameter("@IDCarrera", mCatedratico.idCarrera));

            int execute1 = mCommand.ExecuteNonQuery();

            string SELECT = "SELECT MAX(ID_CATEDRATICO) FROM TBL_CATEDRATICO;";
            string INSERT_B = "INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO, ID_CATEDRATICO)" +
                "values (@Nombre, @Contra, @Correo, 'CATEDRATICO', @Idcatedratico);";

            MySqlCommand mCommand2 = new MySqlCommand(SELECT, ConexionMySQL.GetConnection());
            object resultado = mCommand2.ExecuteScalar();

            if (resultado == null || resultado == DBNull.Value)
            {
                throw new Exception("No se pudo obtener el ID de catedrático.");
            }

            int ID_catedratico = Convert.ToInt32(resultado);

            MySqlCommand mCommand3 = new MySqlCommand(INSERT_B, ConexionMySQL.GetConnection());

            mCommand3.Parameters.Add(new MySqlParameter("@Nombre", mCatedratico.Nombre_usuario));
            mCommand3.Parameters.Add(new MySqlParameter("@Contra", Hash.HashString(mCatedratico.Contraseña)));
            mCommand3.Parameters.Add(new MySqlParameter("@Correo", mCatedratico.Correo_electronico));
            mCommand3.Parameters.Add(new MySqlParameter("@Idcatedratico", ID_catedratico));

            int execute2 = mCommand3.ExecuteNonQuery();

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, NOMBRE_USUARIO, CORREO_ELECTRONICO)
                    VALUES (@Accion, @NombreUsuario, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Usuario de catedrático agregado");
            command.Parameters.AddWithValue("@NombreUsuario", mCatedratico.Nombre_usuario);
            command.Parameters.AddWithValue("@CorreoElectronico", mCatedratico.Correo_electronico);

            return execute1 > 0 && execute2 > 0 && command.ExecuteNonQuery() > 0;
        }

        internal bool buscarCorreoAdmin(Admin_catedratico mAdmin)
        {
            string BUSCARCORREO = "SELECT * FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'ADMINISTRADOR';";

            MySqlDataReader mReader;
            MySqlCommand mCommand = new MySqlCommand(BUSCARCORREO, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            mReader = mCommand.ExecuteReader();

            int rows = 0;
            if (mReader.HasRows)
            {
                while (mReader.Read())
                    rows++;
            }
            if (rows == 0)
            {
                MessageBox.Show("Correo no encontrado o no es un correo de administrador.");
            }
            mReader.Close();

            return rows > 0;
        }

        internal bool actualizarContraAdmin(Admin_catedratico mAdmin)
        {
            string UPDATE = "UPDATE TBL_USUARIOS SET CONTRASEÑA = @Contra WHERE CORREO_ELECTRONICO = @Correo;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Contra", Hash.HashString(mAdmin.Contraseña)));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            string query = @"
                    INSERT INTO TBL_BITACORA (ACCION, CORREO_ELECTRONICO)
                    VALUES (@Accion, @CorreoElectronico)";

            MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
            command.Parameters.AddWithValue("@Accion", "Contraseña de usuario administrador/catedrático actualizado");
            command.Parameters.AddWithValue("@CorreoElectronico", mAdmin.Correo_electronico);

            return mCommand.ExecuteNonQuery() > 0 && command.ExecuteNonQuery() > 0;
        }

        internal bool verificarUsuarioAdmin(Admin_catedratico mAdmin)
        {
            string BUSCARCORREO = "SELECT * FROM TBL_USUARIOS WHERE CORREO_ELECTRONICO = @Correo AND TIPO_USUARIO = 'ADMINISTRADOR';";

            MySqlDataReader mReader;
            MySqlCommand mCommand = new MySqlCommand(BUSCARCORREO, ConexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.Correo_electronico));

            mReader = mCommand.ExecuteReader();

            int rows = 0;
            if (mReader.HasRows)
            {
                while (mReader.Read())
                    rows++;
            }
            if (rows == 0)
            {
                MessageBox.Show("Solo usuarios administradores pueden ingresar a este menú.");
            }
            mReader.Close();

            return rows > 0;
        }
    }
}
