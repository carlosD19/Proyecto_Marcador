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
            throw new NotImplementedException();
        }

        public void AsignarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            try
            {
                if (!VerificarExistencia(docenteCurso, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode docCur = CrearDocente(docenteCurso);

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

        private bool VerificarExistencia(DocenteCurso docenteCurso, string ruta)
        {
            
        }

        private XmlNode CrearDocente(DocenteCurso docenteCurso)
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
                throw new Exception("Error al crear docente.");
            }
        }

        public void EliminarDocCur(DocenteCurso docenteCurso, string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
