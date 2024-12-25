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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        public List<Especialidad> especialidades;

        private async void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var esp = (from es in especialidades where es.Descripcion == cmbEspecialidad.SelectedItem.ToString() select es.EspecialidadId).First();
            Plan plan = await PlanesApiClient.GetLastAsync(esp);
            MessageBox.Show(plan.PlanId.ToString());
            var cursos = await CursosApiClient.GetAllByPlanAsync(plan.PlanId);
            this.cursosDataGridView.DataSource = (from c in cursos where c.Cupo > 0 select c);
        }

        private async void frmInscripcion_Load(object sender, EventArgs e)
        {
            this.cursosDataGridView.DataSource = null;
            EspecialidadesApiClient client = new EspecialidadesApiClient();
            especialidades = (List<Especialidad>)await EspecialidadesApiClient.GetAllAsync().ConfigureAwait(false);

            foreach (var item in especialidades)
            {
                cmbEspecialidad.Items.Add(item.Descripcion);
            }
        }
    }
}
