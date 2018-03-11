using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador
{
    public partial class FrmInicio : Form
    {
        private String Pin;
        public FrmInicio()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHora.Start();
            ChangeControlStyles(btnEliminar, ControlStyles.Selectable, false);
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToString("dddd")
                + "  " + DateTime.Now.ToShortDateString();
        }

        private void txtUno_TextChanged(object sender, EventArgs e)
        {
            if (!txtUno.Text.Equals(""))
            {
                btnEliminar.Visible = true;
            }
            else
            {
                btnEliminar.Visible = false;
            }
        }
        private void ChangeControlStyles(Control ctrl, ControlStyles flag, bool value)
        {
            MethodInfo method = ctrl.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            if (method != null)
                method.Invoke(ctrl, new object[] { flag, value });
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtCuatro.Text.Equals(""))
            {
                txtCuatro.Text = "";
                Pin = Pin.Remove(Pin.Length - 1);
            }
            else if (!txtTres.Text.Equals(""))
            {
                txtTres.Text = "";
                Pin = Pin.Remove(Pin.Length - 1);
            }
            else if (!txtDos.Text.Equals(""))
            {
                txtDos.Text = "";
                Pin = Pin.Remove(Pin.Length - 1);
            }
            else if (!txtUno.Text.Equals(""))
            {
                txtUno.Text = "";
                Pin = Pin.Remove(Pin.Length - 1);
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtUno.Text.Equals(""))
            {
                txtUno.Text = ((Button)sender).Text;
                Pin += ((Button)sender).Text;
            }
            else if (txtDos.Text.Equals(""))
            {
                txtDos.Text = ((Button)sender).Text;
                Pin += ((Button)sender).Text;
            }
            else if (txtTres.Text.Equals(""))
            {
                txtTres.Text = ((Button)sender).Text;
                Pin += ((Button)sender).Text;
            }
            else if (txtCuatro.Text.Equals(""))
            {
                txtCuatro.Text = ((Button)sender).Text;
                Pin += ((Button)sender).Text;
            }
            if (!txtCuatro.Text.Equals(""))
            {
                MessageBox.Show("Listo");
            }
        }
    }
}
