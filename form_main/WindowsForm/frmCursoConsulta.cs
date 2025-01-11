using Domain.Model;
using form_main.APIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_main.WindowsForm
{
    public partial class frmCursoConsulta : Form
    {
        public frmCursoConsulta()
        {
            InitializeComponent();
        }

        public IEnumerable<Docente_Curso> docentesCursos;
        public IEnumerable<Inscripcion> inscripciones;
        public List<Curso> cursos;
        public List<Persona> alumnos;
        public Persona docente = new Persona();

        private async void frmCursoConsulta_Load(object sender, EventArgs e)
        {
            docentesCursos = await DocentesCursosApiClient.GetAllAsync(docente.Legajo, false);
            
            foreach (Docente_Curso docente_Curso in docentesCursos)
            {
                cursos.Add(await CursosApiClient.GetAsync(docente_Curso.IdDocente));
            }
            cursoDataGridView.DataSource = cursos;
        }

        private async void alumnoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inscripciones = await InscripcionesApiClient.GetAllAsync(((Curso)cursoDataGridView.SelectedRows[0].DataBoundItem).CursoId, false);
            foreach (Inscripcion alumno in inscripciones)
            {
                alumnos.Add(await PersonasApiClient.GetAsync(alumno.IdAlumno));
            }
            alumnoDataGridView.DataSource = null;
            alumnoDataGridView.DataSource = alumnos;
        }
    }
}
