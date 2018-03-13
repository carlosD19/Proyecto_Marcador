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
    public class CursoHorarioDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public CursoHorarioDAL()
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

        public void ModificarCurHor(CursoHorario cursoHorario, string ruta)
        {
            throw new NotImplementedException();
        }

        public void AsignarCurHor(CursoHorario cursoHorario, string ruta)
        {
            throw new NotImplementedException();
        }

        public void EliminarCurHor(CursoHorario cursoHorario, string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
