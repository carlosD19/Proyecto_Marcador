using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;

namespace RelojMarcadorBOL
{
    public class CursoBOL
    {
        private CursoDAL dal;

        public CursoBOL()
        {
            dal = new CursoDAL();
        }
        /// <summary>
        /// Valida los datos del archivo
        /// </summary>
        /// <param name="curso">Objeto Curso</param>
        /// <param name="funcion">funcion del metodo</param>
        /// <param name="cod">codigo del curso</param>
        /// <param name="ruta">ruta del archivo</param>
        public void ValidarCurso(Curso curso, bool funcion, string cod, string ruta)
        {
            if (String.IsNullOrEmpty(curso.Codigo))
            {
                throw new Exception("Código requerido.");
            }
            if (String.IsNullOrEmpty(curso.Aula.ToString()))
            {
                throw new Exception("Número de aula requerido.");
            }
            if (String.IsNullOrEmpty(curso.Nombre))
            {
                throw new Exception("Nombre del curso requerido.");
            }
            if (String.IsNullOrEmpty(curso.FechaIni.ToString())
                || String.IsNullOrEmpty(curso.FechaFin.ToString()))
            {
                throw new Exception("Fecha de inicio y fecha final requeridas.");
            }
            if (!funcion)
            {
                dal.ModificarCurso(curso, ruta, cod);
            }
            else if(funcion)
            {
                dal.AñadirCurso(curso, ruta);
            }
        }
        /// <summary>
        /// Carga la lista de cursos
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de cursos</returns>
        public List<Curso> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
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
        /// Elimina el curso
        /// </summary>
        /// <param name="curso">Objeto Curso</param>
        /// <param name="cod">codigo del curso</param>
        /// <param name="ruta">ruta del archivo</param>
        public void EliminarCurso(Curso curso, string cod, string ruta)
        {
            dal.EliminarCurso(curso, cod, ruta);
        }
    }
}
