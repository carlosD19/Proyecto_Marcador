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
    public class ReporteDAL
    {
        private XmlDocument doc;
        private string rutaXML;
        private string rutaDoc;
        private string rutaAsig;
        private Curso curso;
        private Horario horario;
        private Docente docente;
        private Reporte reporte;
        private CursoDAL cursoDAL;
        private HorarioDAL horarioDAL;
        private DocenteDAL docenteDAL;

        public ReporteDAL()
        {
            doc = new XmlDocument();
            docente = new Docente();
            reporte = new Reporte();
            horario = new Horario();
            curso = new Curso();
            cursoDAL = new CursoDAL();
            horarioDAL = new HorarioDAL();
            docenteDAL = new DocenteDAL();
            rutaDoc = "Docentes.xml";
            rutaAsig = "DocentesCursos.xml";
            CrearArchivo("Reportes.xml", "Reportes");
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

        public void AnnadirReporte(Docente docenteP, string ruta)
        {

        }


        public bool VerificarRegistro(int pin, string ruta)
        {
            try
            {
                if (VerificarPin(pin))
                {
                    rutaXML = ruta;
                    doc.Load(rutaXML);
                    if (VerificarAsig())
                    {
                        //XmlNode reporte = CrearReporte(pin);

                        //XmlNode nodoRaiz = doc.DocumentElement;

                        //nodoRaiz.InsertAfter(reporte, nodoRaiz.LastChild);

                        //doc.Save(rutaXML);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool VerificarAsig()
        {
            try
            {
                doc.Load(rutaAsig);
                XmlNode docentes = doc.DocumentElement;
                XmlNodeList listaDocCur = doc.SelectNodes("DocentesCursos/docenteCurso");
                foreach (XmlNode item in listaDocCur)
                {
                    if (item.SelectSingleNode("cedDocente").InnerText.Equals(docente.Cedula))
                    {
                        foreach (Curso c in cursoDAL.CargarTodo("Cursos.xml"))
                        {
                            if (item.SelectSingleNode("CodCurso").InnerText.Equals(c.Codigo))
                            {
                                curso.FechaIni = c.FechaIni;
                                curso.FechaFin = c.FechaFin;
                                foreach (Horario h in horarioDAL.CargarTodo("Horarios.xml"))
                                {
                                    if (item.SelectSingleNode("codHorario").InnerText.Equals(h.Codigo))
                                    {
                                        horario.Dia = h.Dia;
                                        horario.HoraIni = h.HoraIni;
                                        horario.HoraFin = h.HoraFin;
                                        return true;
                                    }
                                }
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

        private bool VerificarPin(int pin)
        {
            try
            {
                foreach (Docente item in docenteDAL.CargarTodo("Docentes.xml"))
                {
                    if (item.Activo)
                    {
                        if (item.Pin == pin)
                        {
                            docente.Cedula = item.Cedula;
                            docente.Estado = item.Estado;
                            return true;
                        }
                    }
                }
                throw new Exception("Pin Incorrecto.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private XmlNode CrearReporte(int pin)
        {
            try
            {
                XmlNode report = this.doc.CreateElement("reporte");

                XmlElement xCed = this.doc.CreateElement("cedDocente");
                xCed.InnerText = docente.Cedula;
                report.AppendChild(xCed);

                XmlElement xAusencia = this.doc.CreateElement("ausencia");
                xAusencia.InnerText = reporte.Ausencia.ToString();
                report.AppendChild(xAusencia);

                XmlElement xTardia = this.doc.CreateElement("tardia");
                xTardia.InnerText = reporte.Tardia.ToString();
                report.AppendChild(xTardia);

                XmlElement xEntrada = this.doc.CreateElement("horaEntrada");
                xEntrada.InnerText = reporte.HoraEntrada.ToString();
                report.AppendChild(xEntrada);

                XmlElement xSalida = this.doc.CreateElement("horaSalida");
                xSalida.InnerText = reporte.HoraSalida.ToString();
                report.AppendChild(xSalida);

                XmlElement xDesc = this.doc.CreateElement("descripcion");
                xDesc.InnerText = reporte.Descripcion;
                report.AppendChild(xDesc);

                return report;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear docente.");
            }
        }
    }
}
