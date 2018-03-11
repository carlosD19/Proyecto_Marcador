using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorENL
{
    public class Curso
    {
        public string Nombre { get; set; }
        public int Aula { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
    }
}
