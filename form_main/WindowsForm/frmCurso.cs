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
        private void button1_Click(object sender, EventArgs e)
        {
            curso.Cupo = Convert.ToInt32(textBox2.Text);
            curso.Nombre = textBox1.Text;
            curso.AñoCalendario = DateTime.Now.Year;
            curso.Descripcion = richTextBox1.Text;
            if (editMode)
            {
                CursosApiClient.UpdateAsync(curso);
            }
            else
            {
                CursosApiClient.AddAsync(curso);
            }

            this.Dispose();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                textBox2.Text = curso.Cupo.ToString();
                textBox1.Text = curso.Nombre;
                richTextBox1.Text = curso.Descripcion;
            }
        }
    }
}
