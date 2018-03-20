using RelojMarcadorBOL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador
{
    public partial class FrmReporte : Form
    {
        private DocenteBOL docenteBOL;
        private string cedula;
        private int funcion;
        private Docente docente;
        private HistorialBOL historialBOL;
        private ReporteBOL reporteBOL;
        private List<Reporte> listaReporte;
        private List<Historial> listaHistorial;
        public FrmReporte()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            docenteBOL = new DocenteBOL();
            reporteBOL = new ReporteBOL();
            historialBOL = new HistorialBOL();
            docente = new Docente();
            cedula = "";
            listaHistorial = new List<Historial>();
            listaReporte = new List<Reporte>();
            listaReporte = reporteBOL.CargarTodo("Reportes.xml");
            listaHistorial = historialBOL.CargarTodo();
            cargarTablaDocente();
        }
        /// <summary>
        /// Carga la tabla de docentes
        /// </summary>
        private void cargarTablaDocente()
        {
            foreach (Docente d in docenteBOL.CargarTodo("Docentes.xml"))
            {
                string sexo = "";
                if (d.Sexo)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                if (d.Activo)
                {
                    dgvDocentes.Rows.Add(d.Cedula, d.Nombre, d.ApellidoUno, d.ApellidoDos, sexo, d.Telefono, d.Email);
                }
            }
        }

        private void FrmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
        /// <summary>
        /// Carga las respectiva tabla
        /// </summary>
        private void cargarTabla()
        {
            if (funcion == 0)
            {
                cargarTablaUNO();
            }
            else if (funcion == 1)
            {
                cargarTablaDOS();
            }
            else if (funcion == 2)
            {
                cargarTablaTRES();
            }

        }
        /// <summary>
        /// Carga la marcas de los docentes
        /// </summary>
        private void cargarTablaTRES()
        {
            dgvMarcas.DataSource = null;
            List<Reporte> reportes = new List<Reporte>();
            if (!cedula.Equals(""))
            {
                foreach (Reporte r in listaReporte)
                {
                    if (r.CedDocente.Equals(cedula))
                    {
                        reportes.Add(r);
                    }
                }
                dgvMarcas.DataSource = reportes;
            }
            else
            {
                dgvMarcas.DataSource = listaReporte;
            }
        }
        /// <summary>
        /// Carga a los destacados
        /// </summary>
        private void cargarTablaDOS()
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns[1].HeaderText = "Destacado";
            string mas = "";
            string menos = "";
            int num1 = 0;
            int num2 = 0;
            bool bus = true;
            foreach (Historial h in listaHistorial)
            {
                if (bus)
                {
                    num1 = AusenciasD(h);
                    num2 = AusenciasD(h);
                    mas = h.CedDocente;
                    menos = h.CedDocente;
                    bus = false;
                }
                else
                {
                    int aus = AusenciasD(h);
                    if (num1 > aus)
                    {
                        num1 = aus;
                        mas = h.CedDocente;
                    }
                    if (num2 < aus)
                    {
                        num2 = aus;
                        menos = h.CedDocente;
                    }
                }
            }
            dgvReportes.Rows.Add(mas, "Mas Destacado", num1);
            dgvReportes.Rows.Add(menos, "Menos Destacado", num2);
        }
        /// <summary>
        /// Carga las tardias y ausencias
        /// </summary>
        private void cargarTablaUNO()
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns[1].HeaderText = "Tardía";
            int tardia = 0;
            int ausencia = 0;
            int anticipada = 0;
            int temp = 0;
            int temp2 = 0;
            if (!cedula.Equals(""))
            {
                foreach (Historial r in listaHistorial)
                {
                    if (r.CedDocente.Equals(cedula))
                    {
                        tardia = r.Tardia;
                        anticipada = r.Anticipada;
                        ausencia = r.Ausencia;
                        temp = tardia;
                        temp2 = anticipada;
                        while (temp > 1)
                        {
                            temp -= 2;
                            ausencia++;
                        } while (temp2 > 5)
                        {
                            temp -= 5;
                            ausencia++;
                        }
                    }
                }
                dgvReportes.Rows.Add(cedula, tardia, ausencia);
            }
            else
            {
                foreach (Historial r in listaHistorial)
                {
                    tardia = r.Tardia;
                    anticipada = r.Anticipada;
                    ausencia = r.Ausencia;
                    temp = tardia;
                    temp2 = anticipada;
                    while (temp > 1)
                    {
                        temp -= 2;
                        ausencia++;
                    } while (temp2 > 5)
                    {
                        temp -= 5;
                        ausencia++;
                    }
                    dgvReportes.Rows.Add(r.CedDocente, tardia, ausencia);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                funcion = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                funcion = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                funcion = 2;
            }
            cargarTabla();
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                cedula = dgvDocentes.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(cedula);
            }
        }
        /// <summary>
        /// Valida las ausencias
        /// </summary>
        /// <param name="h">Objeto historial</param>
        /// <returns>las ausencias totales</returns>
        private int AusenciasD(Historial h)
        {
            int tardia = h.Tardia;
            int anticipada = h.Anticipada;
            int ausencia = h.Ausencia;
            int temp = tardia;
            int temp2 = anticipada;
            while (temp > 1)
            {
                temp -= 2;
                ausencia++;
            } while (temp2 > 5)
            {
                temp -= 5;
                ausencia++;
            }
            return ausencia;
        }
    }
}
