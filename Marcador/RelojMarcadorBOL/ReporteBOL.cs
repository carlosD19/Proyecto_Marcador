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
        /// <summary>
        /// Verificar el pin
        /// </summary>
        /// <param name="pin">pin del docente</param>
        /// <returns>el objeto reporte</returns>
        public Reporte VerificarPIN(int pin)
        {
            if (pin < 0)
            {
                throw new Exception("Docente requerido.");
            }
            return dal.VerificarPin(pin);
        }
        /// <summary>
        /// Carga lista de reportes
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de reportes</returns>
        public List<Reporte> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }
        /// <summary>
        /// Guarda el reporte
        /// </summary>
        /// <param name="reporte">reporte que se desea guardar</param>
        /// <param name="desc">descripcion del reporte</param>
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
