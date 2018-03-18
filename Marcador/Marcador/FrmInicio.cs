using RelojMarcadorBOL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Marcador
{
    public partial class FrmInicio : Form
    {
        private String pin;
        private FrmDocente frmDocente;
        private FrmCurso frmCurso;
        private FrmHorario frmHorario;
        private ReporteBOL reporteBOL;
        private string desc;
        public FrmInicio()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public FrmInicio(string pin, string desc)
        {
            InitializeComponent();
            CenterToScreen();
            this.pin = pin;
            this.desc = desc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //docenteBOL = new DocenteBOL();
            reporteBOL = new ReporteBOL();
            //rutaDoc = "Docentes.xml";
            timerHora.Start();
            ChangeControlStyles(btnEliminar, ControlStyles.Selectable, false);
            //docentes = docenteBOL.CargarTodo(rutaDoc);
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
                pin = pin.Remove(pin.Length - 1);
            }
            else if (!txtTres.Text.Equals(""))
            {
                txtTres.Text = "";
                pin = pin.Remove(pin.Length - 1);
            }
            else if (!txtDos.Text.Equals(""))
            {
                txtDos.Text = "";
                pin = pin.Remove(pin.Length - 1);
            }
            else if (!txtUno.Text.Equals(""))
            {
                txtUno.Text = "";
                pin = pin.Remove(pin.Length - 1);
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUno.Text.Equals(""))
                {
                    txtUno.Text = ((Button)sender).Text;
                    pin += ((Button)sender).Text;
                }
                else if (txtDos.Text.Equals(""))
                {
                    txtDos.Text = ((Button)sender).Text;
                    pin += ((Button)sender).Text;
                }
                else if (txtTres.Text.Equals(""))
                {
                    txtTres.Text = ((Button)sender).Text;
                    pin += ((Button)sender).Text;
                }
                else if (txtCuatro.Text.Equals(""))
                {
                    txtCuatro.Text = ((Button)sender).Text;
                    pin += ((Button)sender).Text;
                }
                if (!txtCuatro.Text.Equals(""))
                {
                    if (VerificarPin())
                    {
                        LimpiarTexto();
                    }
                }
            }
            catch (Exception ex)
            {
                LimpiarTexto();
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTexto()
        {
            txtUno.Text = "";
            txtDos.Text = "";
            txtTres.Text = "";
            txtCuatro.Text = "";
            pin = "";
        }


        private bool VerificarPin()
        {
            int num = reporteBOL.VerificarPIN(Int32.Parse(pin));
            if (num == 0)
            {
                FrmOpciones frm = new FrmOpciones(true, pin);
                frm.Show(this);
                Hide();
                return true;
            }
            else if (num == 4)
            {
                FrmOpciones frm = new FrmOpciones(false, pin);
                frm.Show(this);
                Hide();
                return true;
            }
            else if (num == 1)
            {
                throw new Exception("Entrada Registrada.");
            }
            else if(num == 2)
            {
                throw new Exception("Salida Registrada.");
            }
            else
            {
                return false;
            }
        }

        private void agregarDocente_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmDocente(1);
            frmDocente.Show(this);
            Hide();
        }

        private void modificarDocente_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmDocente(2);
            frmDocente.Show(this);
            Hide();
        }

        private void eliminarDocente_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmDocente(3);
            frmDocente.Show(this);
            Hide();
        }

        private void agregarCurso_Click(object sender, EventArgs e)
        {
            frmCurso = new FrmCurso(1);
            frmCurso.Show(this);
            Hide();
        }

        private void modificarCurso_Click(object sender, EventArgs e)
        {
            frmCurso = new FrmCurso(2);
            frmCurso.Show(this);
            Hide();
        }

        private void eliminarCurso_Click(object sender, EventArgs e)
        {
            frmCurso = new FrmCurso(3);
            frmCurso.Show(this);
            Hide();
        }

        private void agregarHorario_Click(object sender, EventArgs e)
        {
            frmHorario = new FrmHorario(1);
            frmHorario.Show(this);
            Hide();
        }

        private void modificarHorario_Click(object sender, EventArgs e)
        {
            frmHorario = new FrmHorario(2);
            frmHorario.Show(this);
            Hide();
        }

        private void eliminarHorario_Click(object sender, EventArgs e)
        {
            frmHorario = new FrmHorario(3);
            frmHorario.Show(this);
            Hide();
        }

        private void docenteCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocenteCurso frm = new FrmDocenteCurso();
            frm.Show(this);
            Hide();
        }

        private void cursoHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursoHorario frm = new FrmCursoHorario();
            frm.Show(this);
            Hide();
        }
    }
}
