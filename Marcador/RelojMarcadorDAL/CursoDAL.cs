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
    public class CursoDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public CursoDAL()
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

        public void AñadirCurso(Curso cursoP, string ruta)
        {
            try
            {
                if (!VerificarExistencia(cursoP.Codigo, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode curso = CrearCurso(cursoP);

                    XmlNode nodoRaiz = doc.DocumentElement;

                    nodoRaiz.InsertAfter(curso, nodoRaiz.LastChild);

                    doc.Save(rutaXML);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Curso> CargarTodo(string ruta)
        {
            try
            {
                List<Curso> cursos = new List<Curso>();
                Curso curso;
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNodeList listaCursos = doc.SelectNodes("Cursos/curso");

                XmlNode unCurso;

                for (int i = 0; i < listaCursos.Count; i++)
                {
                    curso = new Curso();
                    unCurso = listaCursos.Item(i);
                    curso.Codigo = unCurso.SelectSingleNode("codigo").InnerText;
                    curso.Nombre = unCurso.SelectSingleNode("nombre").InnerText;
                    curso.Aula= Int32.Parse(unCurso.SelectSingleNode("aula").InnerText);
                    curso.FechaIni = Convert.ToDateTime(unCurso.SelectSingleNode("fechaInicio").InnerText);
                    curso.FechaFin = Convert.ToDateTime(unCurso.SelectSingleNode("fechaFinal").InnerText);
                    curso.Activo = Boolean.Parse(unCurso.SelectSingleNode("activo").InnerText);
                    cursos.Add(curso);
                }
                return cursos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar cursos.");
            }
        }

        public void EliminarCurso(Curso curso, string cod, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement cursos = doc.DocumentElement;
                XmlNodeList listaCursos = doc.SelectNodes("Cursos/curso");
                XmlNode cur = CrearCurso(curso);

                foreach (XmlNode item in listaCursos)
                {
                    if (item.FirstChild.InnerText.Equals(cod))
                    {
                        XmlNode nodoOld = item;
                        cursos.ReplaceChild(cur, nodoOld);
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar curso.");
            }
        }

        private XmlNode CrearCurso(Curso cursoP)
        {
            try
            {
                XmlNode curso = doc.CreateElement("curso");

                XmlElement xCod = doc.CreateElement("codigo");
                xCod.InnerText = cursoP.Codigo;
                curso.AppendChild(xCod);

                XmlElement xNom = doc.CreateElement("nombre");
                xNom.InnerText = cursoP.Nombre;
                curso.AppendChild(xNom);

                XmlElement xAula = doc.CreateElement("aula");
                xAula.InnerText = cursoP.Aula.ToString();
                curso.AppendChild(xAula);

                XmlElement xFecIni = doc.CreateElement("fechaInicio");
                xFecIni.InnerText = cursoP.FechaIni.ToString();
                curso.AppendChild(xFecIni);

                XmlElement xFecFin = doc.CreateElement("fechaFinal");
                xFecFin.InnerText = cursoP.FechaFin.ToString();
                curso.AppendChild(xFecFin);

                XmlElement xActivo = doc.CreateElement("activo");
                xActivo.InnerText = cursoP.Activo.ToString();
                curso.AppendChild(xActivo);

                return curso;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear curso.");
            }
        }

        private bool VerificarExistencia(string cod, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode cursos = doc.DocumentElement;

                XmlNodeList listaCursos = doc.SelectNodes("Cursos/curso");

                foreach (XmlNode item in listaCursos)
                {
                    if (item.SelectSingleNode("codigo").InnerText.Equals(cod))
                    {
                        throw new Exception("El curso ya existe.");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarCurso(Curso curso, string ruta, string cod)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement cursos = doc.DocumentElement;

                XmlNodeList listaCursos = doc.SelectNodes("Cursos/curso");
                XmlNode cur = CrearCurso(curso);

                foreach (XmlNode item in listaCursos)
                {
                    if (item.FirstChild.InnerText == cod)
                    {
                        if (item.LastChild.InnerText.Equals("True"))
                        {
                            XmlNode nodoOld = item;
                            cursos.ReplaceChild(cur, nodoOld);
                        }
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar curso.");
            }
        }
    }
}
