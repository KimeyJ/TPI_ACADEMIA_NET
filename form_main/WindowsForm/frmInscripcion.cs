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
            List<Curso> buffer = (List<Curso>)await CursosApiClient.GetAllAsync(0, 0);
            cursos = new List<Curso>();

            foreach (Curso curso in buffer)
            {
                Materia materia = await MateriasApiClient.GetAsync(curso.IdMateria);
                if (materia.IdPlan == persona.IdPlan && curso.Cupo > 0)
                {
                    cursos.Add(curso);
                }
            }
            this.cursosDataGridView.DataSource = cursos;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            Curso curso = (Curso)cursosDataGridView.SelectedRows[0].DataBoundItem;
            inscripcion.IdAlumno = persona.Legajo;
            inscripcion.IdCurso = curso.CursoId;
            MessageBox.Show(curso.CursoId.ToString());
            int ins_id = await InscripcionesApiClient.AddAsync(inscripcion);

            this.Dispose();
        }
    }
}
