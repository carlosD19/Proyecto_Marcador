using RelojMarcadorDAL;
using RelojMarcadorENL;
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
        //public bool VerificarRegistro(int pin, string ruta)
        //{
            
        //    if (String.IsNullOrEmpty(ruta))
        //    {
        //        throw new Exception("Ruta requerida.");
        //    }
        //    //return dal.VerificarRegistro(pin, ruta);
        //    return true;
        //}
        public Reporte VerificarPIN(int pin)
        {
            if (pin < 0)
            {
                throw new Exception("Docente requerido.");
            }
            return dal.VerificarPin(pin);
        }

        public List<Reporte> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }

        public void Guardar(Reporte reporte, string desc)
        {
            if(reporte.Numero == 0 || reporte.Numero == 1 || reporte.Numero == 4)
            {
                reporte.DescripcionE = desc;
            }
            else
            {
                reporte.DescripcionS = desc;
            }
            dal.VerificarRegistro(reporte);
        }
    }
}
