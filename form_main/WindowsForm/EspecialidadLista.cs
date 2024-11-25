using Domain.Model;
using WindowsForm;

namespace WindowsForms
{
    public partial class EspecialidadLista : Form
    {
        public EspecialidadLista()
        {
            InitializeComponent();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();

            Especialidad especialidadNuevo = new Especialidad();

            especialidadDetalle.Especialidad = especialidadNuevo;

            especialidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();

            int id;

            id = this.SelectedItem().Id;

            Especialidad especialidad = await EspecialidadesApiClient.GetAsync(id);

            especialidadDetalle.EditMode = true;
            especialidadDetalle.Especialidad = especialidad;

            especialidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await EspecialidadesApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            EspecialidadesApiClient client = new EspecialidadesApiClient();

            this.clientesDataGridView.DataSource = null;
            this.clientesDataGridView.DataSource = await EspecialidadesApiClient.GetAllAsync();

            if (this.clientesDataGridView.Rows.Count > 0)
            {
                this.clientesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Especialidad SelectedItem()
        {
            Especialidad especialidad;

            especialidad = (Especialidad)clientesDataGridView.SelectedRows[0].DataBoundItem;

            return especialidad;
        }

        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}