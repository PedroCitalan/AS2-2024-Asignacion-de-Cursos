using System;
using MySql.Data.MySqlClient;

namespace AsignaciondeCursos
{
    public class BitacoraHelper
    {
        private static ConexionMySQL ConexionMySQL = new ConexionMySQL();

        public void RegistrarAccion(string accion, string nombreUsuario, string correoElectronico)
        {
            MySqlConnection connection = null;

            try
            {
                connection = ConexionMySQL.GetConnection();
               
                
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al registrar la acción: " + ex.Message);
            }
            finally
            {
                ConexionMySQL.CloseConnection(connection);
            }
        }
    }
}