using System;
using RelojMarcadorDAL;
using RelojMarcadorENL;
using System.Collections.Generic;

namespace RelojMarcadorBOL
{
    public class HorarioBOL
    {
        private HorarioDAL dal;

        public HorarioBOL()
        {
            dal = new HorarioDAL();
        }
        /// <summary>
        /// Verifica los datos del horario
        /// </summary>
        /// <param name="horario">horario que se desea verificar</param>
        /// <param name="funcion">funcion del metodo</param>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="cod">codigo del horario</param>
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
            if (horario.HoraFin.CompareTo(horario.HoraIni) == -1)
            {
                throw new Exception("Hora de inicio debe ser menor a la hora fin.");
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
        /// Carga la lista de Horarios
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de horarios</returns>
        public List<Horario> CargarTodo(string ruta)
        {
            return dal.CargarTodo(ruta);
        }
        /// <summary>
        /// Desactiva el horario
        /// </summary>
        /// <param name="horario">objeto horario</param>
        /// <param name="cod">codigo de horario</param>
        /// <param name="ruta">ruta del archivo</param>
        public void EliminarHorario(Horario horario, string cod, string ruta)
        {
            dal.EliminarHorario(horario, cod, ruta);
        }
    }
}
