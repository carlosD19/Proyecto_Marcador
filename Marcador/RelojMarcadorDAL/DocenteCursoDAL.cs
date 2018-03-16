using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RelojMarcadorENL;

namespace RelojMarcadorDAL
{
    public class DocenteCursoDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public DocenteCursoDAL()
        {
            doc = new XmlDocument();
        }

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

        public void ModificarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("DocentesCursos/docenteCurso");
                XmlNode docen = CrearDocenteCurso(docenteCurso);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.FirstChild.InnerText == docenteCurso.CedDocente)
                    {
                        if (item.LastChild.InnerText.Equals("True"))
                        {
                            XmlNode nodoOld = item;
                            docentes.ReplaceChild(docen, nodoOld);
                        }
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar asignación.");
            }
        }

        public void AsignarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            try
            {
                if (!VerificarAsignacion(docenteCurso, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode docCur = CrearDocenteCurso(docenteCurso);

                    XmlNode nodoRaiz = doc.DocumentElement;

                    nodoRaiz.InsertAfter(docCur, nodoRaiz.LastChild);

                    doc.Save(rutaXML);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool VerificarAsignacion(DocenteCurso docenteCurso, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode docCurso = doc.DocumentElement;

                XmlNodeList listaDocCur = doc.SelectNodes("DocentesCursos/docenteCurso");

                foreach (XmlNode docente in listaDocCur)
                {
                    if (docente.SelectSingleNode("cedDocente").InnerText.Equals(docenteCurso.CedDocente))
                    {
                        if (docente.SelectSingleNode("codCurso").InnerText.Equals(docenteCurso.CodCurso))
                        {
                            if (docente.SelectSingleNode("codHorario").InnerText.Equals(docenteCurso.CodHorario))
                            {
                                throw new Exception("La asignacion ya existe.");
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private XmlNode CrearDocenteCurso(DocenteCurso docenteCurso)
        {
            try
            {
                XmlNode docenteCur = doc.CreateElement("docenteCurso");

                XmlElement xCed = doc.CreateElement("cedDocente");
                xCed.InnerText = docenteCurso.CedDocente;
                docenteCur.AppendChild(xCed);

                XmlElement xCodCur = doc.CreateElement("codCurso");
                xCodCur.InnerText = docenteCurso.CodCurso;
                docenteCur.AppendChild(xCodCur);

                XmlElement xCodHor = doc.CreateElement("codHorario");
                xCodHor.InnerText = docenteCurso.CodHorario;
                docenteCur.AppendChild(xCodHor);

                XmlElement xActivo = doc.CreateElement("activo");
                xActivo.InnerText = docenteCurso.Activo.ToString();
                docenteCur.AppendChild(xActivo);

                return docenteCur;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear asignación docente-curso.");
            }
        }

        public void EliminarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("DocentesCursos/docenteCurso");
                XmlNode docCurso = CrearDocenteCurso(docenteCurso);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.SelectSingleNode("cedDocente").InnerText.Equals(docenteCurso.CedDocente))
                    {
                        if (item.SelectSingleNode("codCurso").InnerText.Equals(docenteCurso.CodCurso))
                        {
                            if (item.SelectSingleNode("codHorario").InnerText.Equals(docenteCurso.CodHorario))
                            {
                                XmlNode nodoOld = item;
                                docentes.ReplaceChild(docCurso, nodoOld);
                            }
                        }
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar asignación.");
            }
        }
    }
}
