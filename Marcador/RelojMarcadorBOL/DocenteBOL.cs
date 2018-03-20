using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;

namespace RelojMarcadorBOL
{
    public class DocenteBOL
    {
        private DocenteDAL dal;
        public DocenteBOL()
        {
            dal = new DocenteDAL();
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
        /// Verifica los datos del docente
        /// </summary>
        /// <param name="docente">objeto docente</param>
        /// <param name="funcion">funcion del metodo</param>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="ced">cedula del docente</param>
        /// <param name="rePin">re-pin del docente</param>
        public void VerificarDocente(Docente docente, bool funcion, string ruta, string ced, int rePin)
        {
            int digitos = (int)Math.Floor(Math.Log10(docente.Pin) + 1);

            if (String.IsNullOrEmpty(docente.Nombre)
                || String.IsNullOrEmpty(docente.ApellidoUno)
                || String.IsNullOrEmpty(docente.ApellidoDos)
                || String.IsNullOrEmpty(docente.Cedula)
                || String.IsNullOrEmpty(docente.Sexo.ToString()))
            {
                throw new Exception("Datos personales requeridos.");
            }
            if (String.IsNullOrEmpty(docente.Email)
                || String.IsNullOrEmpty(docente.Pin.ToString())
                || String.IsNullOrEmpty(docente.Telefono.ToString()))
            {
                throw new Exception("Datos de usuario requeridos.");
            }
            if (digitos < 4)
            {
                throw new Exception("El PIN debe ser de 4 digitos.");
            }
            if (docente.Pin != rePin)
            {
                throw new Exception("Los PIN no coinciden.");
            }
            if (!funcion)
            {
                dal.ModificarDocente(docente, ruta, ced);
            }
            else if (funcion)
            {
                dal.AnnadirDocente(docente, ruta);
            }
        }
        /// <summary>
        /// Carga todos los docentes
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de docentes</returns>
        public List<Docente> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }
        /// <summary>
        /// Elimina el docente
        /// </summary>
        /// <param name="docente">Objeto docente</param>
        /// <param name="ced">cedula del docente</param>
        /// <param name="ruta">ruta del archivo</param>
        public void EliminarDocente(Docente docente, string ced, string ruta)
        {
            dal.EliminarDocente(docente, ced, ruta);
        }
        /// <summary>
        /// Modifica el estado del docente
        /// </summary>
        /// <param name="docente">Objeto docente</param>
        /// <param name="ruta">ruta del archivo</param>
        public void ModificarEstado(Docente docente, string ruta)
        {
            dal.ModificarEstado(docente, ruta);
        }
    }
}
