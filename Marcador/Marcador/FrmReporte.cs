using RelojMarcadorBOL;
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
        private ReporteBOL reporteBOL;
        private List<Reporte> lista;
        public FrmReporte()
        {
            InitializeComponent();
            CenterToScreen();
            comboBox1.SelectedIndex = 0;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            docenteBOL = new DocenteBOL();
            reporteBOL = new ReporteBOL();
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
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
