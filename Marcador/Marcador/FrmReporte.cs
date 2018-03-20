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
            dgDocentes.DataSource = docenteBOL.CargarTodo("Docentes.xml");
        }

        private void dgDocentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (Convert.ToBoolean(dgDocentes.Rows[e.RowIndex].Cells["Sexo1"].Value) == true)
                {
                    dgDocentes.Rows[e.RowIndex].Cells["Sexo"].Value = "Masculino";
                }
                else
                {
                    dgDocentes.Rows[e.RowIndex].Cells["Sexo"].Value = "Femenino";
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

        private void dgDocentes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                docente = dgDocentes.CurrentRow.DataBoundItem as Docente;
                cedula = docente.Cedula;
            }
        }

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

        private void cargarTablaDOS()
        {
            dgvReportes.Rows.Clear();
            dgvReportes.Columns[1].HeaderText = "Destacado";
            string mas = "";
            string menos = "";
            int num1 = 0;
            int num2 = 0;
            bool bus = true;
            foreach (Historial r in listaHistorial)
            {
                if (bus)
                {
                    num1 = r.Ausencia;
                    num2 = r.Ausencia;
                    mas = r.CedDocente;
                    menos = r.CedDocente;
                    bus = false;
                }
                else
                {
                    if (num1 > r.Ausencia)
                    {
                        num1 = r.Ausencia;
                        mas = r.CedDocente;
                    }
                    if (num2 < r.Ausencia)
                    {
                        num2 = r.Ausencia;
                        menos = r.CedDocente;
                    }
                }
            }
            dgvReportes.Rows.Add(mas, "Mas Destacado", num1);
            dgvReportes.Rows.Add(menos, "Menos Destacado", num2);
        }

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
                        while (temp != 0 && temp != 1)
                        {
                            temp -= 2;
                            ausencia++;
                        } while (temp2 != 0 && temp2 != 1)
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
                    while (temp != 0 && temp != 1)
                    {
                        temp -= 2;
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
    }
}
