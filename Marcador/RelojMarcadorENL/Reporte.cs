using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorENL
{
    public class Reporte
    {
        public string CedDocente { get; set; }
        public int Ausencia { get; set; }
        public int Tardia { get; set; }
        public int SalidaAnticipada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public String DescripcionE { get; set; }
        public String DescripcionS { get; set; }
        public int Numero { get; set; }
    }
}
