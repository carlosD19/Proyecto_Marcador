using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojMarcadorBOL
{
    public class DocenteCursoBOL
    {
        private DocenteCursoDAL dal;
        public DocenteCursoBOL()
        {
            dal = new DocenteCursoDAL();
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
        /// Verifica los datos del archivo
        /// </summary>
        /// <param name="docenteCurso">asignacion</param>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="funcion">funcion del metodo</param>
        public void VerificarDocCur(DocenteCurso docenteCurso, string ruta, Boolean funcion)
        {
            if (String.IsNullOrEmpty(docenteCurso.CedDocente))
            {
                throw new Exception("Docente requerido.");
            }
            if (String.IsNullOrEmpty(docenteCurso.CodCurso))
            {
                throw new Exception("Curso requerido.");
            }
            if (String.IsNullOrEmpty(docenteCurso.CodHorario))
            {
                throw new Exception("Horario requerido.");
            }
            if (!funcion)
            {
                dal.ModificarDocCur(docenteCurso, ruta);
            }
            else
            {
                dal.AsignarDocCur(docenteCurso, ruta);
            }
        }
        /// <summary>
        /// Eliminar asignacion
        /// </summary>
        /// <param name="docenteCurso">asignacion</param>
        /// <param name="ruta">ruta del archivo</param>
        public void EliminarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            dal.EliminarDocCur(docenteCurso, ruta);
        }
    }
}
