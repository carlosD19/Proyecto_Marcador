using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorBOL
{


    public class CursoHorarioBOL
    {
        private CursoHorarioDAL dal;

        public CursoHorarioBOL()
        {
            dal = new CursoHorarioDAL();
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

        public void VerificarDocCur(CursoHorario cursoHorario, string ruta, Boolean funcion)
        {
            if (String.IsNullOrEmpty(cursoHorario.CodCurso))
            {
                throw new Exception("Curso requerido.");
            }
            if (String.IsNullOrEmpty(cursoHorario.CodHorario))
            {
                throw new Exception("Horario requerido.");
            }
            if (!funcion)
            {
                dal.ModificarCurHor(cursoHorario, ruta);
            }
            else
            {
                dal.AsignarCurHor(cursoHorario, ruta);
            }
        }

        public void EliminarCurHor(CursoHorario cursoHorario, string ruta)
        {
            dal.EliminarCurHor(cursoHorario, ruta);
        }

        public List<CursoHorario> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }
    }
}
