using RelojMarcadorBOL;
using RelojMarcadorENL;
using System;
using System.Windows.Forms;

namespace Marcador
{
    public partial class FrmDocente : Form
    {
        private Docente docente;
        private DocenteBOL bol;
        private int funcion;
        private string ruta;
        private string ced;
        public FrmDocente()
        {
            InitializeComponent();
            CenterToScreen();
            funcion = 1;
            CambiarTexto();
            cbxSexo.SelectedIndex = 0;
        }

        public FrmDocente(int fun)
        {
            InitializeComponent();
            CenterToScreen();
            funcion = fun;
            CambiarTexto();
            cbxSexo.SelectedIndex = 0;
        }

        private void CambiarTexto()
        {
            switch (funcion)
            {
                case 1:
                    btnAceptar.Text = "Guardar";
                    break;
                case 2:
                    btnAceptar.Text = "Modificar";
                    break;
                case 3:
                    btnAceptar.Text = "Eliminar";
                    break;
                default:
                    break;
            }
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            docente = new Docente();
            bol = new DocenteBOL();
            ced = "";
            ruta = "Docentes.xml";
            bol.CrearArchivo(ruta, "Docentes");
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvDocentes.DataSource = bol.CargarTodo(ruta);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (funcion)
            {
                case 1:
                    Guardar();
                    break;
                case 2:
                    Modificar();
                    break;
                case 3:
                    Eliminar();
                    break;
                default:
                    break;
            }
        }

        private void Eliminar()
        {
            try
            {
                if (!ced.Equals(""))
                {
                    docente.Activo = false;
                    bol.EliminarDocente(docente, ced, ruta);
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void Modificar()
        {
            try
            {
                if (!ced.Equals(""))
                {
                    int rePin = Int32.Parse(txtRePin.Text.Trim());
                    docente.Cedula = txtCed.Text.Trim();
                    docente.ApellidoUno = txtApeUno.Text.Trim();
                    docente.ApellidoDos = txtApeDos.Text.Trim();
                    docente.Email = txtEmail.Text.Trim();
                    docente.Nombre = txtNombre.Text.Trim();
                    docente.Pin = Int32.Parse(txtPin.Text.Trim());
                    docente.Telefono = Int32.Parse(txtTel.Text.Trim());
                    docente.Activo = true;
                    if (cbxSexo.Text.Equals("Masculino"))
                    {
                        docente.Sexo = true;
                    }
                    else
                    {
                        docente.Sexo = false;
                    }
                    bol.VerificarDocente(docente, false, ruta, ced, rePin);
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void Guardar()
        {
            try
            {
                int rePin = Int32.Parse(txtRePin.Text.Trim());
                docente.Cedula = txtCed.Text.Trim();
                docente.ApellidoUno = txtApeUno.Text.Trim();
                docente.ApellidoDos = txtApeDos.Text.Trim();
                docente.Email = txtEmail.Text.Trim();
                docente.Nombre = txtNombre.Text.Trim();
                docente.Pin = Int32.Parse(txtPin.Text.Trim());
                docente.Telefono = Int32.Parse(txtTel.Text.Trim());
                docente.Activo = true;
                if (cbxSexo.Text.Equals("Masculino"))
                {
                    docente.Sexo = true;
                }
                else
                {
                    docente.Sexo = false;
                }
                bol.VerificarDocente(docente, true, ruta, ced, rePin);
                CargarTabla();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void FrmDocente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void dgvDocentes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (funcion == 2 || funcion == 3)
                {
                    int row = e.RowIndex;

                    if (row >= 0)
                    {
                        docente = dgvDocentes.CurrentRow.DataBoundItem as Docente;
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al seleccionar fila.";
            }
        }

        private void CargarDatos()
        {
            if (docente.Activo)
            {
                txtCed.Text = docente.Cedula;
                txtApeUno.Text = docente.ApellidoUno;
                txtApeDos.Text = docente.ApellidoDos;
                txtEmail.Text = docente.Email;
                txtNombre.Text = docente.Nombre;
                txtPin.Text = docente.Pin.ToString();
                txtTel.Text = docente.Telefono.ToString();
                ced = docente.Cedula;
                if (docente.Sexo)
                {
                    cbxSexo.SelectedIndex = 0;
                }
                else
                {
                    cbxSexo.SelectedIndex = 1;
                }
            }
        }
    }
}
