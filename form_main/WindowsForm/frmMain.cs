using Domain.Model;
using form_main.APIs;
using form_main.WindowsForm;
using WindowsForms;

namespace form_main
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        public Persona personaActual;
        public Usuario usuarioActual;

        private void form_main_Shown(object sender, EventArgs e)
        {


        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private async void form_main_Load(object sender, EventArgs e)
        {
            PersonasApiClient client = new PersonasApiClient();
            personaActual = await PersonasApiClient.GetAsync(usuarioActual.IdPersona);
            switch (personaActual.Tipo_persona)
            {
            }
        }

        private void materiasDelPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMateria nuevaConsulta = new frmConsultaMateria();
            nuevaConsulta.MdiParent = this;
            nuevaConsulta.Show();
        }

        private void moficarDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona modificaPersona = new frmPersona();
            modificaPersona.MdiParent = this;
            modificaPersona.persona = personaActual;
            modificaPersona.editMode = true;
            modificaPersona.Show();
        }

        private void modifcarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios modificaUsuario = new frmUsuarios();
            modificaUsuario.MdiParent = this;
            modificaUsuario.buffer = personaActual;
            modificaUsuario.usuario = usuarioActual;
            modificaUsuario.editMode = true;
            modificaUsuario.Show();
        }

        private void agregarUnProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona nuevoProfesor = new frmPersona();
            nuevoProfesor.MdiParent = this;
            nuevoProfesor.persona.Tipo_persona = 2;
            nuevoProfesor.Show();
        }

        private void agregarUnAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona nuevoAlumno = new frmPersona();
            nuevoAlumno.MdiParent = this;
            nuevoAlumno.persona.Tipo_persona = 1;
            nuevoAlumno.Show();
        }

        private void consultaAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPersona nuevaConsulta = new frmConsultaPersona();
            nuevaConsulta.MdiParent = this;
            nuevaConsulta.tipoPersona = 1;
            nuevaConsulta.Show();

        }

        private void consultaProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPersona nuevaConsulta = new frmConsultaPersona();
            nuevaConsulta.MdiParent = this;
            nuevaConsulta.tipoPersona = 2;
            nuevaConsulta.Show();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            EspecialidadLista nuevaConsulta = new EspecialidadLista();
            nuevaConsulta.MdiParent = this;
            nuevaConsulta.Show();
        }

        private void tsddPlan_Click(object sender, EventArgs e)
        {
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanConsulta nuevaConsulta = new frmPlanConsulta();
            nuevaConsulta.MdiParent = this;
            nuevaConsulta.Show();
        }

        private void inscripcionACursadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcion nuevaInscripcion = new frmInscripcion();
            nuevaInscripcion.persona = personaActual;
            nuevaInscripcion.MdiParent = this;
            nuevaInscripcion.Show();
        }

        private void notasExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursoConsulta nuevaConsulta = new frmCursoConsulta();
            nuevaConsulta.docente = personaActual;
            nuevaConsulta.MdiParent= this;
            nuevaConsulta.Show();
        }
    }
}
