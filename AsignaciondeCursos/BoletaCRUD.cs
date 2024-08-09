using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    class BoletaCRUD
    {
        private ConexionMySQL ConexionMySQL;
        public BoletaCRUD()
        {
            ConexionMySQL = new ConexionMySQL();
        }

        internal bool crearBoleta(Boleta_propiedades boleta_Propiedades)
        {
            string SELECT = "SELECT A.ID_ESTUDIANTE FROM TBL_ESTUDIANTE A JOIN TBL_USUARIOS B ON A.CARNE = B.CARNE WHERE B.NOMBRE_USUARIO = @user;";
            string INSERT = "INSERT INTO TBL_TESORERIA (NOMBRE_PAGO, MONTO, ID_ESTUDIANTE) VALUES (@Nombre_pago, @Monto, @Id_estudiante);";
            string SELECT_B = "SELECT MAX(ID_TESORERIA) FROM TBL_TESORERIA";
            string INSERT_B = "INSERT INTO TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) VALUES (@Calendario, @No_semestre);";
            string SELECT_C = "SELECT LAST_INSERT_ID();";
            string INSERT_C = "INSERT INTO TBL_BOLETA (ID_BOLETA, NOMBRE_PAGO, MONTO, CARNE, NOMBRE_ESTUDIANTE, APELLIDO_ESTUDIANTE, CODIGO_CARRERA, ID_FACULTAD, ID_TESORERIA, ID_SEMESTRE)"
                + "VALUES (@Id_boleta, @Nombre_pago, @Monto, @Carne, @Nombre_estudiante, @Apellido_estudiante, @Codigo_carrera, @Id_facultad, @Id_tesoreria, @Id_semestre);";

            MySqlCommand mmCommando = new MySqlCommand(SELECT, ConexionMySQL.GetConnection());
            mmCommando.Parameters.AddWithValue("@user", boleta_Propiedades.Nombre_usuario);
            object result = mmCommando.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                // Manejar el caso donde no se encuentra el estudiante
                throw new Exception("No se encontró el estudiante con el nombre de usuario proporcionado.");
            }

            int ID_estudiante = Convert.ToInt32(result);

            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());
            mCommand.Parameters.AddWithValue("@Nombre_pago", boleta_Propiedades.Nombre_pago);
            mCommand.Parameters.AddWithValue("@Monto", boleta_Propiedades.Monto);
            mCommand.Parameters.AddWithValue("@Id_estudiante", ID_estudiante);
            mCommand.ExecuteNonQuery();

            MySqlCommand sqlCommand = new MySqlCommand(SELECT_B, ConexionMySQL.GetConnection());
            result = sqlCommand.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                throw new Exception("No se pudo obtener el ID de tesorería.");
            }

            int ID_tesoreria = Convert.ToInt32(result);

            MySqlCommand mySqlC = new MySqlCommand(INSERT_B, ConexionMySQL.GetConnection());
            mySqlC.Parameters.AddWithValue("@Calendario", boleta_Propiedades.Calendario);
            mySqlC.Parameters.AddWithValue("@No_semestre", boleta_Propiedades.No_semestre);
            mySqlC.ExecuteNonQuery();

            MySqlCommand commandR = new MySqlCommand(SELECT_C, ConexionMySQL.GetConnection());
            result = commandR.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                throw new Exception("No se pudo obtener el ID del semestre.");
            }

            int Id_semestre = Convert.ToInt32(result);

            MySqlCommand mCommand_B = new MySqlCommand(INSERT_C, ConexionMySQL.GetConnection());
            mCommand_B.Parameters.AddWithValue("@Id_boleta", boleta_Propiedades.ID_boleta);
            mCommand_B.Parameters.AddWithValue("@Nombre_pago", boleta_Propiedades.Nombre_pago);
            mCommand_B.Parameters.AddWithValue("@Monto", boleta_Propiedades.Monto);
            mCommand_B.Parameters.AddWithValue("@Carne", boleta_Propiedades.carnet);
            mCommand_B.Parameters.AddWithValue("@Nombre_estudiante", boleta_Propiedades.Nombre_estudiante);
            mCommand_B.Parameters.AddWithValue("@Apellido_estudiante", boleta_Propiedades.Apellido_estudiante);
            mCommand_B.Parameters.AddWithValue("@Codigo_carrera", boleta_Propiedades.Codigo_Carrera);
            mCommand_B.Parameters.AddWithValue("@Id_facultad", boleta_Propiedades.ID_facultad);
            mCommand_B.Parameters.AddWithValue("@Id_tesoreria", ID_tesoreria);
            mCommand_B.Parameters.AddWithValue("@Id_semestre", Id_semestre);

            bool boletaInsertada = mCommand_B.ExecuteNonQuery() > 0;

            if (boletaInsertada)
            {
                // Insertar en TBL_BITACORA después de crear la boleta
                string query = @"
            INSERT INTO TBL_BITACORA (ACCION, CORREO_ELECTRONICO)
            VALUES (@Accion, @CorreoElectronico)";

                MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());

                // Acción con el correo del usuario
                command.Parameters.AddWithValue("@Accion", "Informacion de boleta");
                mCommand_B.Parameters.AddWithValue("@Nombre_estudiante", boleta_Propiedades.Nombre_estudiante);

                // Ejecutar la consulta de bitácora
                command.ExecuteNonQuery();
            }

            return boletaInsertada;

        }
    }
}

