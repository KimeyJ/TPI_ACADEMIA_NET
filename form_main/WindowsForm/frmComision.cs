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
    public partial class frmComision : Form
    {
        public frmComision()
        {
            InitializeComponent();
        }
        public Comision comision = new Comision();
        public bool editMode = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            ComisionesApiClient client = new ComisionesApiClient();
            comision.Descripcion = textBox1.Text;

            if (editMode)
            {
                await ComisionesApiClient.UpdateAsync(comision);
            }
            else
            {
                await ComisionesApiClient.AddAsync(comision);
            }

            this.Dispose();
        }

        private void frmComision_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                textBox1.Text = comision.Descripcion;
                button1.Text = "Modificar";
            }
        }
    }
}
