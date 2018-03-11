using System;

namespace RelojMarcadorENL
{
    public class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Aula { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
    }
}
