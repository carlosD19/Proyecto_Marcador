using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace RelojMarcadorDAL
{
    public class HorarioDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public HorarioDAL()
        {
            doc = new XmlDocument();
        }
        /// <summary>
        /// Crea el archivo Horario
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="nodoRaiz">ruta del nodo raiz</param>
        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            try
            {
                this.rutaXML = ruta;
                if (!File.Exists(rutaXML))
                {
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlNode root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlNode element1 = doc.CreateElement(nodoRaiz);
                    doc.AppendChild(element1);
                    doc.Save(ruta);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el archivo xml.");
            }
        }
        /// <summary>
        /// Modifica el horario 
        /// </summary>
        /// <param name="horario">horario que se desea modificar</param>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="cod">codigo del horario que se desea modificar</param>
        public void ModificarHorario(Horario horario, string ruta, string cod)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement horarios = doc.DocumentElement;

                XmlNodeList listaHorarios = doc.SelectNodes("Horarios/horario");
                XmlNode horar = CrearHorario(horario);

                foreach (XmlNode item in listaHorarios)
                {
                    if (item.FirstChild.InnerText == cod)
                    {
                        if (item.LastChild.InnerText.Equals("True"))
                        {
                            XmlNode nodoOld = item;
                            horarios.ReplaceChild(horar, nodoOld);
                        }
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar horario.");
            }
        }
        /// <summary>
        /// Agrega un Horario al archivo
        /// </summary>
        /// <param name="horarioP">horario que se desea agregar</param>
        /// <param name="ruta">ruta del archivo</param>
        public void AñadirHorario(Horario horarioP, string ruta)
        {
            try
            {
                if (!VerificarExistencia(horarioP.Codigo, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode horario = CrearHorario(horarioP);

                    XmlNode nodoRaiz = doc.DocumentElement;

                    nodoRaiz.InsertAfter(horario, nodoRaiz.LastChild);

                    doc.Save(rutaXML);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Crea el nodo horario para archivarlo
        /// </summary>
        /// <param name="horarioP">horario que se desea convertir en nodo</param>
        /// <returns>el nodo horario</returns>
        private XmlNode CrearHorario(Horario horarioP)
        {
            try
            {
                XmlNode horario = doc.CreateElement("horario");

                XmlElement xCod = doc.CreateElement("codigo");
                xCod.InnerText = horarioP.Codigo;
                horario.AppendChild(xCod);

                XmlElement xDia = doc.CreateElement("dia");
                xDia.InnerText = horarioP.Dia.ToString();
                horario.AppendChild(xDia);

                XmlElement xInicio = doc.CreateElement("horaInicio");
                xInicio.InnerText = horarioP.HoraIni.ToString();
                horario.AppendChild(xInicio);

                XmlElement xFinal = doc.CreateElement("horaFinal");
                xFinal.InnerText = horarioP.HoraFin.ToString();
                horario.AppendChild(xFinal);

                XmlElement xActivo = doc.CreateElement("activo");
                xActivo.InnerText = horarioP.Activo.ToString();
                horario.AppendChild(xActivo);

                return horario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear horario.");
            }
        }
        /// <summary>
        /// Carga todos los horarios que estan archivados.
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <returns>lista de horarios</returns>
        public List<Horario> CargarTodo(string ruta)
        {
            try
            {
                List<Horario> horarios = new List<Horario>();
                Horario horario;
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNodeList listaHorarios = doc.SelectNodes("Horarios/horario");

                XmlNode unHorario;

                for (int i = 0; i < listaHorarios.Count; i++)
                {
                    horario = new Horario();
                    unHorario = listaHorarios.Item(i);
                    horario.Dia = Convert.ToDateTime(unHorario.SelectSingleNode("dia").InnerText);
                    horario.Codigo = unHorario.SelectSingleNode("codigo").InnerText;
                    horario.HoraFin = Convert.ToDateTime(unHorario.SelectSingleNode("horaFinal").InnerText);
                    horario.HoraIni = Convert.ToDateTime(unHorario.SelectSingleNode("horaInicio").InnerText);
                    horario.Activo = Boolean.Parse(unHorario.SelectSingleNode("activo").InnerText);
                    horarios.Add(horario);
                }
                return horarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar horarios.");
            }
        }
        /// <summary>
        /// Desactiva el horario
        /// </summary>
        /// <param name="horario">horario que se desea desactivar</param>
        /// <param name="codigo">codigo del horario</param>
        /// <param name="ruta">ruta del horario</param>
        public void EliminarHorario(Horario horario, string codigo, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement horarios = doc.DocumentElement;

                XmlNodeList listaHorarios = doc.SelectNodes("Horarios/horario");
                XmlNode horar = CrearHorario(horario);

                foreach (XmlNode item in listaHorarios)
                {
                    if (item.FirstChild.InnerText == codigo)
                    {
                        XmlNode nodoOld = item;
                        horarios.ReplaceChild(horar, nodoOld);
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar horario.");
            }
        }
        ///<summary>
        ///Verifica la existencia del horario 
        /// </summary>
        /// <param name="codigo">codigo del horario</param>
        /// <param name="ruta">ruta del horario</param>
        /// <returns>false si no existe y una exception si si</returns>
        private bool VerificarExistencia(string codigo, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode horarios = doc.DocumentElement;

                XmlNodeList listaHorarios = doc.SelectNodes("Horarios/horario");

                foreach (XmlNode item in listaHorarios)
                {

                    if (item.SelectSingleNode("codigo").InnerText.Equals(codigo))
                    {
                        throw new Exception("El código del horario ya existe.");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
