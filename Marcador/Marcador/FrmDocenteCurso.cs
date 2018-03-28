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
    public partial class FrmDocenteCurso : Form
    {
        private CursoBOL cursoBOL;
        private HorarioBOL horarioBOL;
        private DocenteBOL docenteBOL;
        private CursoHorarioBOL cursoHorarioBOL;
        private DocenteCursoBOL docenteCursoBOL;
        private DocenteCurso docenteCurso;
        private string rutaCurso;
        private string rutaHorario;
        private string rutaDocente;
        private string rutaCurHor;
        private string rutaDocCur;
        private List<Curso> cursos;
        private List<Horario> horarios;
        private List<CursoHorario> cursosH;

        public FrmDocenteCurso()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmDocenteCurso_Load(object sender, EventArgs e)
        {
            cursoBOL = new CursoBOL();
            docenteCursoBOL = new DocenteCursoBOL();
            horarioBOL = new HorarioBOL();
            docenteBOL = new DocenteBOL();
            cursoHorarioBOL = new CursoHorarioBOL();
            docenteCurso = new DocenteCurso();
            rutaDocCur = "DocentesCursos.xml";
            rutaCurso = "Cursos.xml";
            rutaHorario = "Horarios.xml";
            rutaDocente = "Docentes.xml";
            rutaCurHor = "CursosHorarios.xml";
            cursos = cursoBOL.CargarTodo(rutaCurso);
            horarios = horarioBOL.CargarTodo(rutaHorario);
            cursosH = cursoHorarioBOL.CargarTodo(rutaCurHor);
            docenteCursoBOL.CrearArchivo(rutaDocCur, "DocentesCursos");
            CargarTablas();
        }
        /// <summary>
        /// Carga las tablas
        /// </summary>
        private void CargarTablas()
        {
            string codTest = "";

            foreach (CursoHorario curHor in cursosH)
            {
                if (!codTest.Equals(curHor.CodCurso))
                {
                    codTest = curHor.CodCurso;
                    foreach (Curso c in cursos)
                    {
                        if (curHor.CodCurso.Equals(c.Codigo))
                        {
                            if (c.Activo)
                            {
                                dgvCursos.Rows.Add(c.Codigo, c.Nombre, c.Aula, c.FechaIni, c.FechaFin);
                            }
                        }
                    }
                }
            }
            foreach (Docente d in docenteBOL.CargarTodo(rutaDocente))
            {
                string sexo = "";
                if (d.Sexo)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                if (d.Activo)
                {
                    dgvDocentes.Rows.Add(d.Cedula, d.Nombre, d.ApellidoUno, d.ApellidoDos, sexo, d.Telefono, d.Email);
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                docenteCursoBOL.VerificarDocCur(docenteCurso, rutaDocCur, true);
                lblError.Text = "Asignacion realizada.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void FrmDocenteCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHorarios.Rows.Clear();
            string cod = dgvCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            foreach (CursoHorario item in cursosH)
            {
                if (cod.Equals(item.CodCurso))
                {
                    foreach (Horario h in horarios)
                    {
                        if (item.CodHorario.Equals(h.Codigo))
                        {
                            docenteCurso.CodCurso = dgvCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            lblC.Text = docenteCurso.CodCurso;
                            dgvHorarios.Rows.Add(h.Codigo, h.Dia, h.HoraIni, h.HoraFin);
                        }
                    }
                }
            }

        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            docenteCurso.CodHorario = dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblH.Text = docenteCurso.CodHorario;
            docenteCurso.Activo = true;
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            docenteCurso.CedDocente = dgvDocentes.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblD.Text = docenteCurso.CedDocente;
        }
    }
}
