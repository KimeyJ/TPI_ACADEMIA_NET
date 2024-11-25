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

            this.personasDataGridView.DataSource = null;
            this.personasDataGridView.DataSource = await PersonasApiClient.GetAllAsync(tipoPersona);

            if (this.personasDataGridView.Rows.Count == 0)
            {
                this.btnEliminar.Enabled = false;
                this.btnModifcar.Enabled = false;
            }
            else
            {
                this.personasDataGridView.Rows[0].Selected = true;
            }
        }

        private void frmConsultaPersona_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }
    }
}
