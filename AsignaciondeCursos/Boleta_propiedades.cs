using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaciondeCursos
{
    class Boleta_propiedades
    {
        public int ID_boleta { get; set; }
        public string Nombre_pago { get; set; }
        public double Monto { get; set; }
        public string Calendario { get; set; }
        public string carnet { get; set; }
        public string Nombre_estudiante { get; set; }
        public string Apellido_estudiante { get; set; }
        public string Codigo_Carrera { get; set; }
        public string No_semestre { get; set; }
        public int ID_facultad { get; set; }
        public int ID_tesoreria { get; set; }
        public string Nombre_usuario { get; set; }
    }
}
