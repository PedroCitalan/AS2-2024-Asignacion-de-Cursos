using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    class EstudianteCRUD
    {
        private ConexionMySQL ConexionMySQL;

        public EstudianteCRUD()
        {
            ConexionMySQL = new ConexionMySQL();
        }

        internal bool agregarEstudiante(Estudiantes mEstudiantes)
        {
            string INSERT = "INSERT INTO TBL_ESTUDIANTE (NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS, ID_CARRERA, ID_CURSOS, SECCION)" + " VALUES (@Nombre, @Apellido, @Fecha_nac, @Carne, @Creditos_acumulados, @ID_Carrera, @ID_Cursos, @Seccion);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mEstudiantes.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@Apellido", mEstudiantes.Apellido));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_nac", mEstudiantes.Fecha_nacimiento));
            mCommand.Parameters.Add(new MySqlParameter("@Carne", mEstudiantes.Carne));
            mCommand.Parameters.Add(new MySqlParameter("@Creditos_acumulados", mEstudiantes.Creditos_acumulados));
            mCommand.Parameters.Add(new MySqlParameter("@ID_Carrera", mEstudiantes.ID_Carrera));
            mCommand.Parameters.Add(new MySqlParameter("@ID_Cursos", mEstudiantes.ID_Cursos));
            mCommand.Parameters.Add(new MySqlParameter("@Seccion", mEstudiantes.Seccion));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool agregarUsuarioEstudiante(Estudiantes mEstudiantes)
        {
            string INSERT = "INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO)" + " VALUES (@Nombre_usuario, @Contraseña, @Correo_electronico, @Tipo_usuario);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre_usuario", mEstudiantes.Nombre_usuario));
            mCommand.Parameters.Add(new MySqlParameter("@Contraseña", mEstudiantes.Contraseña));
            mCommand.Parameters.Add(new MySqlParameter("@Correo_electronico", mEstudiantes.Correo_electronico));
            mCommand.Parameters.Add(new MySqlParameter("@Tipo_usuario", mEstudiantes.tipo_usuario));

            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}

