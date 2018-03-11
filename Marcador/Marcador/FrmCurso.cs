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
    public partial class FrmCurso : Form
    {
        private int funcion;
        private string ruta;
        private string cod;
        private CursoBOL bol;
        private Curso curso;

        public FrmCurso()
        {
            InitializeComponent();
            CenterToScreen();
            funcion = 1;
            CambiarTexto();
        }

        public FrmCurso(int fun)
        {
            InitializeComponent();
            CenterToScreen();
            funcion = fun;
            CambiarTexto();
        }

        private void FrmCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (funcion)
            {
                case 1:
                    Guardar();
                    LimpiarTexto();
                    break;
                case 2:
                    Modificar();
                    LimpiarTexto();
                    break;
                case 3:
                    Eliminar();
                    LimpiarTexto();
                    break;
                default:
                    break;
            }
        }

        private void Eliminar()
        {
            try
            {
                if (!cod.Equals(""))
                {
                    curso.Activo = false;
                    bol.EliminarCurso(curso, cod, ruta);
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
                if (!cod.Equals(""))
                {
                    curso.Activo = true;
                    curso.Aula = Int32.Parse(txtAula.Text.Trim());
                    curso.Codigo = txtCod.Text.Trim();
                    curso.Nombre = txtNombre.Text;
                    curso.FechaIni = Convert.ToDateTime(dtInicio.Value);
                    curso.FechaFin = Convert.ToDateTime(dtFinal.Value);
                    bol.ValidarCurso(curso, false, cod, ruta);
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
                curso.Activo = true;
                curso.Aula = Int32.Parse(txtAula.Text.Trim());
                curso.Codigo = txtCod.Text.Trim();
                curso.Nombre = txtNombre.Text;
                curso.FechaIni = Convert.ToDateTime(dtInicio.Value);
                curso.FechaFin = Convert.ToDateTime(dtFinal.Value);
                bol.ValidarCurso(curso, true, cod, ruta);
                CargarTabla();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
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

        private void CargarTabla()
        {
            try
            {
                dgvCursos.DataSource = bol.CargarTodo(ruta);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            ruta = "Cursos.xml";
            bol = new CursoBOL();
            curso = new Curso();
            cod = "";
            bol.CrearArchivo(ruta, "Cursos");
            CargarTabla();
        }

        private void dgvCursos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (funcion == 2 || funcion == 3)
                {
                    int row = e.RowIndex;

                    if (row >= 0)
                    {
                        curso = dgvCursos.CurrentRow.DataBoundItem as Curso;
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
            if (curso.Activo)
            {
                txtAula.Text = curso.Aula.ToString();
                txtCod.Text = curso.Codigo;
                txtNombre.Text = curso.Nombre;
                dtInicio.Value = curso.FechaIni;
                dtFinal.Value = curso.FechaFin;
                cod = curso.Codigo;
            }
        }
        private void LimpiarTexto()
        {
            txtAula.Text = "";
            txtCod.Text = "";
            txtNombre.Text = "";
        }
    }
}
