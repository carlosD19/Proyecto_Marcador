using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorENL
{
    public class Horario
    {
        public String Codigo { get; set; }
        public DateTime Dia { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }
        public Boolean Activo { get; set; }
    }
}
