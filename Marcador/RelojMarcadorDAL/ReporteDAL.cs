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


        //public bool VerificarRegistro(int pin, string ruta)
        //{
        //    try
        //    {
        //        if (VerificarPin(pin))
        //        {
        //            rutaXML = ruta;
        //            doc.Load(rutaXML);
        //            if (VerificarAsig())
        //            {
        //                //XmlNode reporte = CrearReporte(pin);

        //                //XmlNode nodoRaiz = doc.DocumentElement;

        //                //nodoRaiz.InsertAfter(reporte, nodoRaiz.LastChild);

        //                //doc.Save(rutaXML);
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

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

        public int VerificarPin(int pin)
        {
            try
            {
                foreach (Docente item in docenteDAL.CargarTodo("Docentes.xml"))
                {
                    if (item.Activo)
                    {
                        if (item.Pin == pin)
                        {
                            docente = item;
                            if (VerificarAsig())
                            {
                                return VerificarHora();
                            }
                            else
                            {
                                return 4;
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

        private int VerificarHora()
        {
            float inicio = horario.HoraIni.Hour + float.Parse("," + horario.HoraIni.Minute);
            float final = horario.HoraFin.Hour + float.Parse("," + horario.HoraFin.Minute);
            float actual = DateTime.Now.Hour + float.Parse("," + DateTime.Now.Minute);
            float resta = inicio - actual;
            float resta2 = actual - final;
            if (!docente.Estado)
            {
                docente.Estado = true;
                if (resta > 1 && resta2 < 0)
                {
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    return 0;
                }
                else if (resta < 1 && resta2 < 0)
                {
                    docenteDAL.ModificarEstado(docente, "Docentes.xml");
                    return 1;
                }
            }
            else
            {
                docente.Estado = false;
                if (final > actual)
                {

                }
                else if (resta2 > 1)
                {

                }
                docenteDAL.ModificarEstado(docente, "Docentes.xml");
                return 2;
            }
            return 10;
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

        private bool ValidarEstado()
        {
            return false;
        }
    }
}
