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
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("CursosHorarios/cursoHorario");
                XmlNode docen = CrearCursoHorario(cursoHorario);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.FirstChild.InnerText == cursoHorario.CodCurso)
                    {
                        if (item.SelectSingleNode("codHorario").InnerText.Equals(cursoHorario.CodHorario))
                        {
                            if (item.LastChild.InnerText.Equals("True"))
                            {
                                XmlNode nodoOld = item;
                                docentes.ReplaceChild(docen, nodoOld);
                            }
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

        public void AsignarCurHor(CursoHorario cursoHorario, string ruta)
        {
            try
            {
                if (!VerificarAsignacion(cursoHorario, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode docCur = CrearCursoHorario(cursoHorario);

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

        private XmlNode CrearCursoHorario(CursoHorario cursoHorario)
        {
            try
            {
                XmlNode docenteCur = doc.CreateElement("cursoHorario");

                XmlElement xCodCur = doc.CreateElement("codCurso");
                xCodCur.InnerText = cursoHorario.CodCurso;
                docenteCur.AppendChild(xCodCur);

                XmlElement xCodHor = doc.CreateElement("codHorario");
                xCodHor.InnerText = cursoHorario.CodHorario;
                docenteCur.AppendChild(xCodHor);

                XmlElement xActivo = doc.CreateElement("activo");
                xActivo.InnerText = cursoHorario.Activo.ToString();
                docenteCur.AppendChild(xActivo);

                return docenteCur;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear asignación curso-horario.");
            }
        }

        private bool VerificarAsignacion(CursoHorario cursoHorario, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode curHorario = doc.DocumentElement;

                XmlNodeList listaDocCur = doc.SelectNodes("CursosHorarios/cursoHorario");

                foreach (XmlNode cH in listaDocCur)
                {
                    if (cH.SelectSingleNode("codCurso").InnerText.Equals(cursoHorario.CodCurso))
                    {
                        if (cH.SelectSingleNode("codHorario").InnerText.Equals(cursoHorario.CodHorario))
                        {
                            throw new Exception("La asignacion ya existe.");
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

        public void EliminarCurHor(CursoHorario cursoHorario, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("CursosHorarios/cursoHorario");
                XmlNode docCurso = CrearCursoHorario(cursoHorario);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.SelectSingleNode("codCurso").InnerText.Equals(cursoHorario.CodCurso))
                    {
                        if (item.SelectSingleNode("codHorario").InnerText.Equals(cursoHorario.CodHorario))
                        {
                            XmlNode nodoOld = item;
                            docentes.ReplaceChild(docCurso, nodoOld);
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
        public List<CursoHorario> CargarTodo(string ruta)
        {
            try
            {
                List<CursoHorario> cursoHorario = new List<CursoHorario>();
                CursoHorario curHor;
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNodeList listaCurHor = doc.SelectNodes("CursosHorarios/cursoHorario");

                XmlNode unCurHor;

                for (int i = 0; i < listaCurHor.Count; i++)
                {
                    curHor = new CursoHorario();
                    unCurHor = listaCurHor.Item(i);
                    curHor.CodHorario = unCurHor.SelectSingleNode("codHorario").InnerText;
                    curHor.CodCurso = unCurHor.SelectSingleNode("codCurso").InnerText;
                    curHor.Activo = Boolean.Parse(unCurHor.SelectSingleNode("activo").InnerText);
                    cursoHorario.Add(curHor);
                }
                return cursoHorario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar curso-horario.");
            }
        }
    }
}
