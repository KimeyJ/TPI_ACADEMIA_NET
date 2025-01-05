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
        public bool editMode = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            curso.Cupo = Convert.ToInt32(textBox2.Text);
            curso.Nombre = textBox1.Text;
            curso.AñoCalendario = DateTime.Now.Year;
            curso.Descripcion = richTextBox1.Text;

            if (editMode)
            {
                AsignarDocente(curso.CursoId, ((Persona)profDataGridView.SelectedRows[0].DataBoundItem).Legajo, 1);
                AsignarDocente(curso.CursoId, ((Persona)profDataGridView1.SelectedRows[0].DataBoundItem).Legajo, 2);
                await CursosApiClient.UpdateAsync(curso);
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
                //profDataGridView.SelectedRows.Equals(curso.Profesores[0]);
                //profDataGridView1.SelectedRows.Equals(curso.Profesores[1]);
            }

        }

        private async void AsignarDocente(int idCurso, int idDocente, int cargo)
        {
            Docente_Curso docente_Curso = new Docente_Curso();
            
            docente_Curso.IdDocente = idDocente;
            docente_Curso.IdCurso = idCurso;
            docente_Curso.Cargo = cargo;
            int id1 = await DocentesCursosApiClient.AddAsync(docente_Curso);

            curso.Profesores.Append(await DocentesCursosApiClient.GetAsync(id1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Persona)profDataGridView1.SelectedRows[0].DataBoundItem).Legajo.ToString());
        }
    }
}
