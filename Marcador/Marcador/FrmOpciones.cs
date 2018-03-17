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
        private bool funcion;
        public FrmOpciones()
        {
            InitializeComponent();
        }
        public FrmOpciones(Boolean fun, string pin)
        {
            InitializeComponent();
            funcion = fun;
            p = pin;
            ValidarFuncion();
        }

        private void ValidarFuncion()
        {
            if (!funcion)
            {
                rbPrimero.Text = "Consulta";
                rbSegundo.Text = "Reunión";
                rbTercero.Text = "Otro";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio(p, descripcion);
            frm.Show(this);
            Hide();
        }
    }
}
