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
    public partial class FrmCursoHorario : Form
    {
        private CursoBOL cursoBOL;
        private HorarioBOL horarioBOL;
        private Curso curso;
        private Horario horario;
        private CursoHorario cursoHorario;
        private string rutaCurso;
        private string rutaHorario;
        private string rutaCurHor;
        private CursoHorarioBOL cursoHorarioBOL;
        public FrmCursoHorario()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmCursoHorario_Load(object sender, EventArgs e)
        {
            cursoBOL = new CursoBOL();
            horarioBOL = new HorarioBOL();
            cursoHorarioBOL = new CursoHorarioBOL();
            curso = new Curso();
            horario = new Horario();
            cursoHorario = new CursoHorario();
            rutaCurso = "Cursos.xml";
            rutaHorario = "Horarios.xml";
            rutaCurHor = "CursosHorarios.xml";
            cursoHorarioBOL.CrearArchivo(rutaCurHor, "CursosHorarios");
            CargarTablas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                cursoHorario.Activo = true;
                cursoHorarioBOL.VerificarDocCur(cursoHorario, rutaCurHor, true);
                lblError.Text = "Asignación realizada.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        /// <summary>
        /// Carga las tablas cursos y horarios
        /// </summary>
        private void CargarTablas()
        {
            foreach (Curso c in cursoBOL.CargarTodo(rutaCurso))
            {
                if (c.Activo)
                {
                    dgvCursos.Rows.Add(c.Codigo, c.Nombre, c.Aula, c.FechaIni, c.FechaFin);
                }
            }
            foreach (Horario h in horarioBOL.CargarTodo(rutaHorario))
            {
                if (h.Activo)
                {
                    dgvHorarios.Rows.Add(h.Codigo, h.Dia, h.HoraIni, h.HoraFin);
                }
            }
        }

        private void FrmCursoHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cursoHorario.CodCurso = dgvCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblCurCod.Text = cursoHorario.CodCurso;
        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cursoHorario.CodHorario = dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblHorCod.Text = cursoHorario.CodHorario;
        }
    }
}
