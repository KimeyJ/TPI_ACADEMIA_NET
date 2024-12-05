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
    public partial class frmConsultaComision : Form
    {
        public frmConsultaComision()
        {
            InitializeComponent();
        }
        public int idPlan;
        private async void frmConsultaComision_Load(object sender, EventArgs e)
        {
            ComisionesApiClient client = new ComisionesApiClient();
            dataGridView1.DataSource = await ComisionesApiClient.GetAllAsync(idPlan);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            frmComision nuevaComision = new frmComision();
            nuevaComision.MdiParent = this.MdiParent;
            nuevaComision.comision.PlanId = idPlan;
            nuevaComision.Show();
            this.dataGridView1.DataSource = await ComisionesApiClient.GetAllAsync(idPlan);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            frmComision modComision = new frmComision();
            modComision.MdiParent = this.MdiParent;
            modComision.editMode = true;
            modComision.comision = (Comision)dataGridView1.SelectedRows[0].DataBoundItem;
            modComision.Show();
            this.dataGridView1.DataSource = await ComisionesApiClient.GetAllAsync(idPlan);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ComisionesApiClient client = new ComisionesApiClient();
            await ComisionesApiClient.DeleteAsync(((Comision)dataGridView1.SelectedRows[0].DataBoundItem).Id);
            this.dataGridView1.DataSource = await ComisionesApiClient.GetAllAsync(idPlan);
        }
    }
}
