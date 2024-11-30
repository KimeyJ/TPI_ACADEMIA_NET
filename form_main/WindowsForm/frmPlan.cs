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
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }
        public bool editMode = false;
        public Plan buffer = new Plan();

        private async void button1_Click(object sender, EventArgs e)
        {
            PlanesApiClient client = new PlanesApiClient();
            buffer.Descripcion = textBox2.Text;
            buffer.Año = Convert.ToInt32(textBox1.Text);

            if (editMode)
            {
                await PlanesApiClient.UpdateAsync(buffer);
            }
            else
            {
                await PlanesApiClient.AddAsync(buffer);
            }
            this.Dispose();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                textBox1.Text = buffer.Año.ToString();
                textBox2.Text = buffer.Descripcion.ToString();
                button1.Text = "Aplicar Cambios";
            }
        }
    }
}
