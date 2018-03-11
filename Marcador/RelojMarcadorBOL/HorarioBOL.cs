using System;
using RelojMarcadorDAL;
using RelojMarcadorENL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorBOL
{
    public class HorarioBOL
    {
        private HorarioDAL dal;

        public HorarioBOL()
        {
            dal = new HorarioDAL();
        }

        public void VerificarHorario(Horario horario, bool funcion, string ruta, string cod)
        {
            if (String.IsNullOrEmpty(horario.Dia.ToString()))
            {
                throw new Exception("Día requerido.");
            }
            if (String.IsNullOrEmpty(horario.Codigo))
            {
                throw new Exception("Código requerido.");
            }
            if (String.IsNullOrEmpty(horario.HoraIni.ToString())
                || String.IsNullOrEmpty(horario.HoraIni.ToString()))
            {
                throw new Exception("Hora de inicio y fin requeridas.");
            }
            if (!funcion)
            {
                dal.ModificarHorario(horario, ruta, cod);
            }
            else if (funcion)
            {
                dal.AñadirHorario(horario, ruta);
            }
        }

        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            if (String.IsNullOrEmpty(ruta)
                || String.IsNullOrEmpty(nodoRaiz))
            {
                throw new Exception("Datos requeridos para crear archivo.");
            }
            dal.CrearArchivo(ruta, nodoRaiz);
        }

        public List<Horario> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }

        public void EliminarHorario(Horario horario, string cod, string ruta)
        {
            dal.Eliminar(horario, cod, ruta);
        }
    }
}
