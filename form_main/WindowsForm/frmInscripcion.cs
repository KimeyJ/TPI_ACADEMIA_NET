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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        public List<Curso> cursos;
        public Persona persona;


        private async void frmInscripcion_Load(object sender, EventArgs e)
        {
            this.cursosDataGridView.DataSource = null;
            cursos = (List<Curso>)await CursosApiClient.GetAllByPlanAsync(persona.IdPlan);
            this.cursosDataGridView.DataSource = from c in cursos where c.Cupo > 0 select c;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            Curso curso = (Curso)cursosDataGridView.SelectedRows[0].DataBoundItem;
            inscripcion.IdAlumno = persona.Legajo;
            inscripcion.IdCurso = curso.CursoId;
            int ins_id = await InscripcionesApiClient.AddAsync(inscripcion);
            Inscripcion buffer = await InscripcionesApiClient.GetAsync(ins_id);
            persona.CursosAlumno.Add(buffer);
            curso.Alumnos.Add(buffer);
            PersonasApiClient.UpdateAsync(persona);
            CursosApiClient.UpdateAsync(curso);

        }
    }
}
