﻿using System;
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

            bool estudianteAgregado = mCommand.ExecuteNonQuery() > 0;

            if (estudianteAgregado)
            {
                // Insertar en TBL_BITACORA después de agregar al estudiante
                string query = @"
            INSERT INTO TBL_BITACORA (ACCION, NOMBRE_USUARIO, CORREO_ELECTRONICO)
            VALUES (@Accion, @CorreoElectronico)";

                MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
                string accion = $"Creación de estudiante por el usuario {mEstudiantes.Correo_electronico}";
                command.Parameters.AddWithValue("@Accion", "Agregar usuario");
                command.Parameters.AddWithValue("@Nombre", mEstudiantes.Nombre);
                command.Parameters.AddWithValue("@CorreoElectronico", mEstudiantes.Correo_electronico);

                command.ExecuteNonQuery();
            }

            return estudianteAgregado;


        }

        internal bool agregarUsuarioEstudiante(Estudiantes mEstudiantes)
        {
            string INSERT = "INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO, CARNE)" + " VALUES (@Nombre_usuario, @Contraseña, @Correo_electronico, 'ESTUDIANTE', @Carne);";
            MySqlCommand mCommand = new MySqlCommand(INSERT, ConexionMySQL.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre_usuario", mEstudiantes.Nombre_usuario));
            mCommand.Parameters.Add(new MySqlParameter("@Contraseña", Hash.HashString(mEstudiantes.Contraseña)));
            mCommand.Parameters.Add(new MySqlParameter("@Correo_electronico", mEstudiantes.Correo_electronico));
            mCommand.Parameters.Add(new MySqlParameter("@Carne", mEstudiantes.Carne));

            bool usuarioAgregado = mCommand.ExecuteNonQuery() > 0;

            if (usuarioAgregado)
            {
                // Insertar en TBL_BITACORA después de agregar al usuario estudiante
                string query = @"
            INSERT INTO TBL_BITACORA (ACCION, NOMBRE_USUARIO, CORREO_ELECTRONICO)
            VALUES (@Accion, @CorreoElectronico)";

                MySqlCommand command = new MySqlCommand(query, ConexionMySQL.GetConnection());
                string accion = $"Creación de usuario estudiante por el usuario {mEstudiantes.Correo_electronico}";
                command.Parameters.AddWithValue("@Accion", "Agregar usuario estudiantes");
                command.Parameters.AddWithValue("@Nombre_usuario", mEstudiantes.Nombre_usuario);
                command.Parameters.AddWithValue("@CorreoElectronico", mEstudiantes.Correo_electronico);

                command.ExecuteNonQuery();
            }

            return usuarioAgregado;



        }
    }
}

