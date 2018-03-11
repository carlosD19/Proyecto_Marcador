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
            funcion = 1;
            CambiarTexto();
        }

        public FrmDocente(int fun)
        {
            InitializeComponent();
            CenterToScreen();
            funcion = fun;
            CambiarTexto();
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
            throw new NotImplementedException();
        }

        private void Modificar()
        {
            throw new NotImplementedException();
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
    }
}
