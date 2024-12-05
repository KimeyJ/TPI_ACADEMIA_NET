using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm;

namespace form_main.WindowsForm
{
    public partial class frmConsultaMateria : Form
    {
        public frmConsultaMateria()
        {
            InitializeComponent();
        }
        public int idPlan;

        private async void button2_Click(object sender, EventArgs e)
        {
            frmMateria modMateria = new frmMateria();
            modMateria.MdiParent = this.MdiParent;
            modMateria.editMode = true;
            modMateria.materia = (Materia)dataGridView1.SelectedRows[0].DataBoundItem;
            modMateria.Show();
            this.dataGridView1.DataSource = await MateriasApiClient.GetAllAsync(idPlan);
        }

        private async void frmConsultaMateria_Load(object sender, EventArgs e)
        {
            MateriasApiClient client = new MateriasApiClient();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await MateriasApiClient.GetAllAsync(idPlan);
            button1.Enabled = true;
            if(dataGridView1.Rows.Count > 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            frmMateria nuevaMateria = new frmMateria();
            nuevaMateria.MdiParent = this.MdiParent;
            nuevaMateria.materia.IdPlan = idPlan;
            nuevaMateria.Show();
            this.dataGridView1.DataSource = await MateriasApiClient.GetAllAsync(idPlan);

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            MateriasApiClient client = new MateriasApiClient();
            await MateriasApiClient.DeleteAsync(((Materia)dataGridView1.SelectedRows[0].DataBoundItem).Id, ((Materia)dataGridView1.SelectedRows[0].DataBoundItem).IdPlan);
            this.dataGridView1.DataSource = await MateriasApiClient.GetAllAsync(idPlan);
        }
    }
}
