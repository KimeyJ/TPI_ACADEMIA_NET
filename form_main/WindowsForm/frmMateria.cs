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
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }

        public bool editMode = false;
        public Materia materia = new Materia();
        private async void button1_Click(object sender, EventArgs e)
        {
            MateriasApiClient client = new MateriasApiClient();
            materia.Descripcion = textBox1.Text;
            materia.HsSemanales = Convert.ToInt32(textBox2.Text);
            materia.HsTotales = Convert.ToInt32(textBox3.Text);

            if (editMode)
            {
                await MateriasApiClient.UpdateAsync(materia);
            }
            else
            {
                await MateriasApiClient.AddAsync(materia);
            }
            this.Dispose();
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            if(editMode)
            {
                textBox1.Text = materia.Descripcion;
                textBox2.Text = materia.HsSemanales.ToString();
                textBox3.Text = materia.HsTotales.ToString();
            }
        }
    }
}
