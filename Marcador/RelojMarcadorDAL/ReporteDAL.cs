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
        //private string rutaDoc;
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
            //rutaDoc = "Docentes.xml";
            rutaAsig = "DocentesCursos.xml";
            rutaXML = "Reportes.xml";
            CrearArchivo(rutaXML, "Reportes");
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

        public void VerificarRegistro(Reporte rep)
        {
            if (rep.Numero == 0 || rep.Numero == 1 || rep.Numero == 4)
            {
                Registrar(rep);
            }
            else
            {
                Modificar(rep);
            }
        }

        private void Modificar(Reporte rep)
        {
            try
            {
                doc.Load(rutaXML);
                XmlElement docentes = doc.DocumentElement;

                XmlNodeList listaReportes = doc.SelectNodes("Reportes/reporte");


                foreach (XmlNode item in listaReportes)
                {
                    if (item.FirstChild.InnerText == rep.CedDocente)
                    {
                        DateTime horaSalida = Convert.ToDateTime(item.SelectSingleNode("horaSalida").InnerText);
                        if (horaSalida.Hour == 0)
                        {
                            rep.DescripcionE = item.SelectSingleNode("descripcionEntrada").InnerText;
                            rep.Ausencia = Int32.Parse(item.SelectSingleNode("ausencia").InnerText);
                            rep.HoraEntrada = Convert.ToDateTime(item.SelectSingleNode("horaEntrada").InnerText);
                            rep.Tardia = Int32.Parse(item.SelectSingleNode("tardia").InnerText);
                            XmlNode report = CrearReporte(rep);
                            XmlNode nodoOld = item;
                            docentes.ReplaceChild(report, nodoOld);
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

        public void Registrar(Reporte rep)
        {
            try
            {
                doc.Load(rutaXML);
                XmlNode reporte = CrearReporte(rep);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(reporte, nodoRaiz.LastChild);

                doc.Save(rutaXML);
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
                    DocenteCurso dc = new DocenteCurso();
                    dc.CedDocente = item.SelectSingleNode("cedDocente").InnerText;
                    dc.CodCurso = item.SelectSingleNode("codCurso").InnerText;
                    dc.CodHorario = item.SelectSingleNode("codHorario").InnerText;
                    if (dc.CedDocente.Equals(docente.Cedula))
                    {
                        foreach (Horario h in horarioDAL.CargarTodo("Horarios.xml"))
                        {
                            if (dc.CodHorario.Equals(h.Codigo))
                            {
                                string d = DateTime.Now.Date.ToString("dddd");
                                string d2 = h.Dia.ToString("dddd");
                                if (d2.Equals(d))
                                {
                                    horario = h;
                                    foreach (Curso c in cursoDAL.CargarTodo("Cursos.xml"))
                                    {
                                        if (dc.CodCurso.Equals(c.Codigo))
                                        {
                                            int num = DateTime.Now.Date.CompareTo(c.FechaIni);
                                            int num2 = DateTime.Now.Date.CompareTo(c.FechaFin);
                                            if (num == 1 || num == 0 && num2 == -1 || num2 == 0)
                                            {
                                                return true;
                                            }
                                        }
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

        public Reporte VerificarPin(int pin)
        {
            reporte = new Reporte();
            try
            {
                foreach (Docente item in docenteDAL.CargarTodo("Docentes.xml"))
                {
                    if (item.Activo)
                    {
                        if (item.Pin == pin)
                        {
                            docente = item;
                            reporte.CedDocente = item.Cedula;
                            if (VerificarAsig())
                            {
                                return VerificarHora();
                            }
                            else
                            {
                                reporte.Numero = 4;
                                return reporte;
                            }
                        }
                    }
                }
                throw new Exception("Problemas al verificar pin.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Reporte VerificarHora()
        {

            float inicio = horario.HoraIni.Hour + float.Parse("," + horario.HoraIni.Minute);
            float final = horario.HoraFin.Hour + float.Parse("," + horario.HoraFin.Minute);
            float actual = DateTime.Now.Hour + float.Parse("," + DateTime.Now.Minute);
            float resta = inicio - actual;
            float resta2 = actual - final;
            if (!docente.Estado)
            {
                DateTime entrada = Convert.ToDateTime(DateTime.Now.ToString("t"));
                reporte.HoraEntrada = entrada;
                docente.Estado = true;
                if (resta > 1 && resta2 < 0)
                {
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    reporte.Numero = 0;
                }
                else if (inicio < actual)
                {
                    reporte.Tardia = 1;
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    reporte.Numero = 1;
                }
                else if (resta < 1 && resta2 < 0)
                {
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    reporte.Numero = 1;
                }
            }
            else
            {
                docente.Estado = false;
                DateTime salida = Convert.ToDateTime(DateTime.Now.ToString("t"));
                reporte.HoraSalida = salida;
                if (final > actual)
                {
                    reporte.SalidaAnticipada = 1;
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    reporte.Numero = 2;
                }
                else if (resta2 > 1)
                {
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    reporte.Numero = 3;
                }
            }
            return reporte;
        }

        private XmlNode CrearReporte(Reporte r)
        {
            reporte = r;
            try
            {
                XmlNode report = this.doc.CreateElement("reporte");

                XmlElement xCed = this.doc.CreateElement("cedDocente");
                xCed.InnerText = reporte.CedDocente;
                report.AppendChild(xCed);

                XmlElement xAusencia = this.doc.CreateElement("ausencia");
                xAusencia.InnerText = reporte.Ausencia.ToString();
                report.AppendChild(xAusencia);

                XmlElement xTardia = this.doc.CreateElement("tardia");
                xTardia.InnerText = reporte.Tardia.ToString();
                report.AppendChild(xTardia);

                XmlElement xSal = this.doc.CreateElement("salidaAnticipada");
                xSal.InnerText = reporte.SalidaAnticipada.ToString();
                report.AppendChild(xSal);

                XmlElement xEntrada = this.doc.CreateElement("horaEntrada");
                xEntrada.InnerText = reporte.HoraEntrada.ToString();
                report.AppendChild(xEntrada);

                XmlElement xSalida = this.doc.CreateElement("horaSalida");
                xSalida.InnerText = reporte.HoraSalida.ToString();
                report.AppendChild(xSalida);

                XmlElement xDesc = this.doc.CreateElement("descripcionEntrada");
                xDesc.InnerText = reporte.DescripcionE;
                report.AppendChild(xDesc);

                XmlElement xDesc1 = this.doc.CreateElement("descripcionSalida");
                xDesc1.InnerText = reporte.DescripcionS;
                report.AppendChild(xDesc1);

                return report;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear docente.");
            }
        }
    }
}
