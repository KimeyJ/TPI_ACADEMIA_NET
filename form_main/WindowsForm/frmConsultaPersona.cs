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
    public partial class frmConsultaPersona : Form
    {
        public int tipoPersona;
        public frmConsultaPersona()
        {
            InitializeComponent();
        }

        private async void GetAllAndLoad()
        {
            PersonasApiClient client = new PersonasApiClient();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await PersonasApiClient.GetAllAsync(tipoPersona);

            if (this.dataGridView1.Rows.Count == 0)
            {
                this.btnEliminar.Enabled = false;
                this.btnModifcar.Enabled = false;
            }
            else
            {
                this.dataGridView1.Rows[0].Selected = true;
            }
        }

        private async void frmConsultaPersona_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private void personasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            frmPersona modPersona = new frmPersona();
            modPersona.MdiParent = form_main.ActiveForm;
            modPersona.editMode = true;
            modPersona.persona = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
            modPersona.Show();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonasApiClient client = new PersonasApiClient();
            await PersonasApiClient.DeleteAsync(((Persona)dataGridView1.SelectedRows[0].DataBoundItem).Legajo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersona nuevaPersona = new frmPersona();
            nuevaPersona.MdiParent = form_main.ActiveForm;
            nuevaPersona.persona.Tipo_persona = tipoPersona;
            nuevaPersona.Show();
        }
    }
}
