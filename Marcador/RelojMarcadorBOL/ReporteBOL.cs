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
        public bool VerificarRegistro(int pin)
        {
            if (pin < 0)
            {
                throw new Exception("Docente requerido.");
            }
            return dal.VerificarRegistro(pin);
        }
    }
}
