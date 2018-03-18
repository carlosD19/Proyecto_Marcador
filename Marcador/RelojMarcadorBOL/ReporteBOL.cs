using RelojMarcadorDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorBOL
{
    public class ReporteBOL
    {
        private ReporteDAL dal;

        public ReporteBOL()
        {
            dal = new ReporteDAL();
        }
        public bool VerificarRegistro(int pin, string ruta)
        {
            if (pin < 0)
            {
                throw new Exception("Docente requerido.");
            }
            if (String.IsNullOrEmpty(ruta))
            {
                throw new Exception("Ruta requerida.");
            }
            //return dal.VerificarRegistro(pin, ruta);
            return true;
        }

        public int VerificarPIN(int pin)
        {
            return dal.VerificarPin(pin);
        }
    }
}
