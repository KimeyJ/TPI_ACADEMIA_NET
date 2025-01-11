using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Model;
using form_main.APIs;

namespace form_main.WindowsForm
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }
        public Curso curso = new Curso();
        public IEnumerable<Docente_Curso> docentes;
        public bool editMode = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            curso.Cupo = Convert.ToInt32(textBox2.Text);
            curso.Nombre = textBox1.Text;
            curso.AñoCalendario = DateTime.Now.Year;
            curso.Descripcion = richTextBox1.Text;

            if (editMode)
            {
                await CursosApiClient.UpdateAsync(curso);
                if (docentes.First().IdDocente != ((Persona)profDataGridView.SelectedRows[0].DataBoundItem).Legajo)
                {
                    await DocentesCursosApiClient.DeleteAsync(docentes.First().IdDocente);
                    AsignarDocente(curso.CursoId, ((Persona)profDataGridView.SelectedRows[0].DataBoundItem).Legajo, 1);
                }
                if(docentes.Last().IdDocente != ((Persona)profDataGridView1.SelectedRows[0].DataBoundItem).Legajo)
                {
                    await DocentesCursosApiClient.DeleteAsync(docentes.Last().IdDocente);
                    AsignarDocente(curso.CursoId, ((Persona)profDataGridView1.SelectedRows[0].DataBoundItem).Legajo, 2);
                }
            }
            else
            {
                int idCurso = await CursosApiClient.AddAsync(curso);
                AsignarDocente(idCurso, ((Persona)profDataGridView.SelectedRows[0].DataBoundItem).Legajo, 1);
                AsignarDocente(idCurso, ((Persona)profDataGridView1.SelectedRows[0].DataBoundItem).Legajo, 2);
            }

            this.Dispose();

        }

        private async void frmCurso_Load(object sender, EventArgs e)
        {
            this.profDataGridView.DataSource = await PersonasApiClient.GetAllAsync(2);
            this.profDataGridView1.DataSource = await PersonasApiClient.GetAllAsync(2);

            if (editMode)
            {
                textBox2.Text = curso.Cupo.ToString();
                textBox1.Text = curso.Nombre;
                richTextBox1.Text = curso.Descripcion;
                docentes = await DocentesCursosApiClient.GetAllAsync(curso.CursoId, true);
                profDataGridView.SelectedRows.Equals(docentes.First());
                profDataGridView1.SelectedRows.Equals(docentes.Last());
            }

        }

        private async void AsignarDocente(int idCurso, int idDocente, int cargo)
        {
            Docente_Curso docente_Curso = new Docente_Curso();
            
            docente_Curso.IdDocente = idDocente;
            docente_Curso.IdCurso = idCurso;
            docente_Curso.Cargo = cargo;
            await DocentesCursosApiClient.AddAsync(docente_Curso);
        }
    }
}
