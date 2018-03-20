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
    public partial class FrmOpciones : Form
    {
        private string descripcion;
        private string p;
        private Reporte r;
        private int funcion;
        private ReporteBOL reporteBOL;
        public FrmOpciones()
        {
            InitializeComponent();
            CenterToParent();
        }
        public FrmOpciones(int fun, string pin, Reporte reporte)
        {
            InitializeComponent();
            CenterToParent();
            funcion = fun;
            p = pin;
            r = reporte;
            ValidarFuncion();
        }
        /// <summary>
        /// Cambia el texto a los radio buttons
        /// </summary>
        private void ValidarFuncion()
        {
            if (funcion == 2)
            {
                rbPrimero.Text = "Consulta";
                rbSegundo.Text = "Reunión";
                rbTercero.Text = "Otro";
            }
            else if (funcion == 3)
            {
                rbPrimero.Text = "Curso y Consulta";
                rbSegundo.Text = "Curso y Reunión";
                rbTercero.Text = "Otro";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbPrimero.Checked)
            {
                descripcion = rbPrimero.Text;
            }
            else if (rbSegundo.Checked)
            {
                descripcion = rbSegundo.Text;
            }
            else
            {
                descripcion = rbTercero.Text;
            }
            if (Owner != null)
            {
                Owner.Hide();
            }
            reporteBOL.Guardar(r, descripcion);
            FrmInicio frm = new FrmInicio();
            frm.Show(this);
            Hide();
        }

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            reporteBOL = new ReporteBOL();
        }
    }
}
