using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelojMarcadorENL;
using System.Xml;
using System.IO;

namespace RelojMarcadorDAL
{
    public class HistorialDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public HistorialDAL()
        {
            doc = new XmlDocument();
            rutaXML = "Historial.xml";
            CrearArchivo(rutaXML, "Historial");
        }
        /// <summary>
        /// Crea el archivo historial
        /// </summary>
        /// <param name="ruta">ruta del archivo</param>
        /// <param name="nodoRaiz">ruta del nodo raiz</param>
        private void CrearArchivo(string ruta, string nodoRaiz)
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
        /// Verifica si ya existe un docente en el historial
        /// </summary>
        /// <param name="reporte">reporte que se desea verificar</param>
        /// <returns>true si existe y false si no</returns>
        public bool VerificarHistorial(Reporte reporte)
        {
            doc.Load(rutaXML);

            XmlNode docentes = doc.DocumentElement;

            XmlNodeList listaHistorial = doc.SelectNodes("Historial/historial");

            foreach (XmlNode item in listaHistorial)
            {
                if (item.SelectSingleNode("cedDocente").InnerText.Equals(reporte.CedDocente))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Guardar o modifica el archivo
        /// </summary>
        /// <param name="r">datos del reporte que se desea archivar</param>
        public void Guardar(Reporte r)
        {
            if (!VerificarHistorial(r))
            {
                doc.Load(rutaXML);

                XmlNode horario = CrearHistorial(r);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(horario, nodoRaiz.LastChild);

                doc.Save(rutaXML);
            }
            else
            {
                ModificarHistorial(r);
            }
        }
        /// <summary>
        /// Modifica el historial de un docente
        /// </summary>
        /// <param name="r">datos del reporte que se desean modificar</param>
        private void ModificarHistorial(Reporte r)
        {
            doc.Load(rutaXML);
            XmlElement docentes = doc.DocumentElement;

            XmlNodeList listaDocentes = doc.SelectNodes("Historial/historial");


            foreach (XmlNode item in listaDocentes)
            {
                if (item.FirstChild.InnerText == r.CedDocente)
                {
                    r.Ausencia += Int32.Parse(item.SelectSingleNode("ausencia").InnerText);
                    r.Tardia += Int32.Parse(item.SelectSingleNode("tardia").InnerText);
                    r.Ausencia += Int32.Parse(item.SelectSingleNode("anticipada").InnerText);
                    XmlNode reporte = CrearHistorial(r);
                    XmlNode nodoOld = item;
                    docentes.ReplaceChild(reporte, nodoOld);
                }
            }
            doc.Save(rutaXML);
        }
        /// <summary>
        /// Crea el nodo Historial
        /// </summary>
        /// <param name="r">datos del reporte que se desean crear</param>
        /// <returns>un nodo historial</returns>
        private XmlNode CrearHistorial(Reporte r)
        {
            XmlNode historial = doc.CreateElement("historial");

            XmlElement xCed = doc.CreateElement("cedDocente");
            xCed.InnerText = r.CedDocente;
            historial.AppendChild(xCed);

            XmlElement xTardia = doc.CreateElement("tardia");
            xTardia.InnerText = r.Tardia.ToString();
            historial.AppendChild(xTardia);

            XmlElement xAus = doc.CreateElement("ausencia");
            xAus.InnerText = r.Ausencia.ToString();
            historial.AppendChild(xAus);

            XmlElement xAnt = doc.CreateElement("anticipada");
            xAnt.InnerText = r.SalidaAnticipada.ToString();
            historial.AppendChild(xAnt);

            return historial;
        }
        /// <summary>
        /// Carga la lista de historiales
        /// </summary>
        /// <returns>la lista de historiales</returns>
        public List<Historial> CargarTodo()
        {
            try
            {
                List<Historial> historiales = new List<Historial>();
                Historial hist;
                doc.Load(rutaXML);

                XmlNodeList listaHistoriales = doc.SelectNodes("Historial/historial");

                XmlNode unHistorial;

                for (int i = 0; i < listaHistoriales.Count; i++)
                {
                    hist = new Historial();
                    unHistorial = listaHistoriales.Item(i);
                    hist.CedDocente = unHistorial.SelectSingleNode("cedDocente").InnerText;
                    hist.Ausencia = Int32.Parse(unHistorial.SelectSingleNode("ausencia").InnerText);
                    hist.Tardia = Int32.Parse(unHistorial.SelectSingleNode("tardia").InnerText);
                    hist.Anticipada = Int32.Parse(unHistorial.SelectSingleNode("anticipada").InnerText);

                    historiales.Add(hist);
                }
                return historiales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar historiales.");
            }
        }
    }
}
