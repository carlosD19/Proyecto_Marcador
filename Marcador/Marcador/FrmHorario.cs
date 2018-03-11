using RelojMarcadorBOL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Marcador
{
    public partial class FrmHorario : Form
    {
        private HorarioBOL horarioBOL;
        private Horario horario;
        private int funcion;
        private string cod;
        private string ruta;

        public FrmHorario()
        {
            InitializeComponent();
            CenterToScreen();
            funcion = 1;
            CambiarTexto();
        }
        public FrmHorario(int fun)
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
        private void FrmHorario_Load(object sender, EventArgs e)
        {
            horarioBOL = new HorarioBOL();
            horario = new Horario();
            ruta = "Horarios.xml";
            horarioBOL.CrearArchivo(ruta, "Horarios");
            CargarTabla();
        }
        private void CargarTabla()
        {
            dgvHorarios.DataSource = horarioBOL.CargarTodo(ruta);
        }

        private void txtCod_Changed(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void dgvHorarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (funcion == 2 || funcion == 3)
                {
                    int row = e.RowIndex;

                    if (row >= 0)
                    {
                        horario = dgvHorarios.CurrentRow.DataBoundItem as Horario;
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
            txtCodigo.Text = horario.Codigo;
            dtDia.Value = horario.Dia;
            dtInicio.Value = horario.HoraIni;
            dtFin.Value = horario.HoraFin;
            cod = horario.Codigo;
        }
        private void Guardar()
        {
            try
            {
                horario.Activo = true;
                horario.Codigo = txtCodigo.Text;
                horario.Dia = Convert.ToDateTime(dtDia.Value.Date);
                horario.HoraIni = Convert.ToDateTime(dtInicio.Value);
                horario.HoraFin = Convert.ToDateTime(dtFin.Value);
                horarioBOL.VerificarHorario(horario, true, ruta, cod);
                CargarTabla();
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
                    horario.Activo = true;
                    horario.Codigo = txtCodigo.Text.Trim();
                    horario.Dia = Convert.ToDateTime(dtDia.Value.Date);
                    horario.HoraIni = Convert.ToDateTime(dtInicio.Value);
                    horario.HoraFin = Convert.ToDateTime(dtFin.Value);
                    horarioBOL.VerificarHorario(horario, false, ruta, cod);
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void Eliminar()
        {
            try
            {
                if (!cod.Equals(""))
                {
                    horario.Activo = false;
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
