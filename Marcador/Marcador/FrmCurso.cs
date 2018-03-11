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
    public partial class FrmCurso : Form
    {
        private int funcion;
        public FrmCurso()
        {
            InitializeComponent();
            CenterToScreen();
            funcion = 1;
        }

        public FrmCurso(int fun)
        {
            InitializeComponent();
            CenterToScreen();
            funcion = fun;
        }

        private void FrmCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
