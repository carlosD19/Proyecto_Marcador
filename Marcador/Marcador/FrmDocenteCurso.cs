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
        private string rutaCurso;
        private string rutaHorario;
        private string rutaDocente;

        public FrmDocenteCurso()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmDocenteCurso_Load(object sender, EventArgs e)
        {
            cursoBOL = new CursoBOL();
            horarioBOL = new HorarioBOL();
            docenteBOL = new DocenteBOL();
            rutaCurso = "Cursos.xml";
            rutaHorario = "Horarios.xml";
            rutaDocente = "Docentes.xml";
            CargarTablas();
        }

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

        }

        private void FrmDocenteCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
