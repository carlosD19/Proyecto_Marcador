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
        /// <summary>
        /// Crea el archivo
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="nodoRaiz">nodo raiz del archivo</param>
        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            if (String.IsNullOrEmpty(ruta)
                || String.IsNullOrEmpty(nodoRaiz))
            {
                throw new Exception("Datos requeridos para crear archivo.");
            }
            dal.CrearArchivo(ruta, nodoRaiz);
        }
        /// <summary>
        /// Verifica los datos de la asignacion
        /// </summary>
        /// <param name="cursoHorario">Objeto asignacion</param>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="funcion">funcion del metodo</param>
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
        /// <summary>
        /// Desactiva la asignacion
        /// </summary>
        /// <param name="cursoHorario">Objeto asignacion</param>
        /// <param name="ruta">ruta del archivo</param>
        public void EliminarCurHor(CursoHorario cursoHorario, string ruta)
        {
            dal.EliminarCurHor(cursoHorario, ruta);
        }
        /// <summary>
        /// Carga la lista de asignaciones
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de asignaciones</returns>
        public List<CursoHorario> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }
    }
}
