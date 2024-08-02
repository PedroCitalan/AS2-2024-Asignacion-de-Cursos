using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaciondeCursos
{
    class Admin_catedratico
    {
        public int ID_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo_electronico { get; set; }
        public string Tipo_usuario { get; set; }
        public DateTime Fecha_creacion { get; set; }
    }
}
