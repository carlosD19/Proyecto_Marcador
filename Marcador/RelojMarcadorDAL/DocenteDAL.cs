using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RelojMarcadorDAL
{
    public class DocenteDAL
    {
        private string rutaXML;
        private XmlDocument doc;

        public DocenteDAL()
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

        public void AñadirDocente(Docente docenteP, string ruta)
        {
            try
            {
                if (!VerificarExistencia(docenteP.Cedula, ruta))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);

                    XmlNode horario = CrearDocente(docenteP);

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

        private XmlNode CrearDocente(Docente docenteP)
        {
            try
            {
                XmlNode docente = doc.CreateElement("docente");

                XmlElement xCed = doc.CreateElement("cedula");
                xCed.InnerText = docenteP.Cedula;
                docente.AppendChild(xCed);


                XmlElement xNom = doc.CreateElement("nombre");
                xNom.InnerText = docenteP.Nombre;
                docente.AppendChild(xNom);


                XmlElement xApeUno = doc.CreateElement("primerApellido");
                xApeUno.InnerText = docenteP.ApellidoUno;
                docente.AppendChild(xApeUno);


                XmlElement xApeDos = doc.CreateElement("segundoApellido");
                xApeDos.InnerText = docenteP.ApellidoDos;
                docente.AppendChild(xApeDos);

                XmlElement xSexo = doc.CreateElement("sexo");
                xSexo.InnerText = docenteP.Sexo.ToString();
                docente.AppendChild(xSexo);

                XmlElement xEmail = doc.CreateElement("email");
                xEmail.InnerText = docenteP.Email;
                docente.AppendChild(xEmail);

                XmlElement xTel = doc.CreateElement("telefono");
                xTel.InnerText = docenteP.Telefono.ToString();
                docente.AppendChild(xTel);

                XmlElement xPin = doc.CreateElement("pin");
                xPin.InnerText = docenteP.Telefono.ToString();
                docente.AppendChild(xPin);

                XmlElement xActivo = doc.CreateElement("activo");
                xActivo.InnerText = docenteP.Activo.ToString();
                docente.AppendChild(xActivo);


                return docente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear docente.");
            }
        }

        private bool VerificarExistencia(string cedula, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNode docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("Docentes/docente");

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.SelectSingleNode("cedula").InnerText.Equals(cedula))
                    {
                        throw new Exception("El docente ya existe.");
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarDocente(Docente docente, string cedula, string ruta)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("Docentes/docente");
                XmlNode docen = CrearDocente(docente);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.FirstChild.InnerText == cedula)
                    {
                        XmlNode nodoOld = item;
                        docentes.ReplaceChild(docen, nodoOld);
                    }
                }
                doc.Save(rutaXML);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar docente.");
            }
        }

        public List<Docente> CargarTodo(string ruta)
        {
            try
            {
                List<Docente> docentes = new List<Docente>();
                Docente docente;
                rutaXML = ruta;
                doc.Load(rutaXML);

                XmlNodeList listaDocentes = doc.SelectNodes("Docentes/docente");

                XmlNode unDocente;

                for (int i = 0; i < listaDocentes.Count; i++)
                {
                    docente = new Docente();
                    unDocente = listaDocentes.Item(i);
                    docente.Cedula = unDocente.SelectSingleNode("cedula").InnerText;
                    docente.Nombre = unDocente.SelectSingleNode("nombre").InnerText;
                    docente.ApellidoUno = unDocente.SelectSingleNode("primerApellido").InnerText;
                    docente.ApellidoDos = unDocente.SelectSingleNode("segundoApellido").InnerText;
                    docente.Email = unDocente.SelectSingleNode("email").InnerText;
                    docente.Telefono = Int32.Parse(unDocente.SelectSingleNode("telefono").InnerText);
                    docente.Sexo = Boolean.Parse(unDocente.SelectSingleNode("sexo").InnerText);
                    docente.Pin = Int32.Parse(unDocente.SelectSingleNode("pin").InnerText);
                    docente.Activo = Boolean.Parse(unDocente.SelectSingleNode("activo").InnerText);
                    docentes.Add(docente);
                }
                return docentes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar docentes.");
            }
        }

        public void ModificarDocente(Docente docente, string ruta, string ced)
        {
            try
            {
                rutaXML = ruta;
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaDocentes = doc.SelectNodes("Docentes/docente");
                XmlNode docen = CrearDocente(docente);

                foreach (XmlNode item in listaDocentes)
                {
                    if (item.FirstChild.InnerText == ced)
                    {
                        if (item.LastChild.InnerText == "true")
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
                throw new Exception("Error al modificar horario.");
            }
        }
    }
}
