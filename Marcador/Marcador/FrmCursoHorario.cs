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
        private string rutaCurso;
        private string rutaHorario;

        public FrmCursoHorario()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmCursoHorario_Load(object sender, EventArgs e)
        {
            cursoBOL = new CursoBOL();
            horarioBOL = new HorarioBOL();
            rutaCurso = "Cursos.xml";
            rutaHorario = "Horarios.xml";
            CargarTablas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

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
        }

        private void FrmCursoHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
