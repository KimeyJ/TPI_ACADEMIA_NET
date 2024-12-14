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
    public partial class frmPlanConsulta : Form
    {
        public frmPlanConsulta()
        {
            InitializeComponent();
        }

        public List<Especialidad> especialidades;
        public int current_esp_id = 0;
        public int current_pl_id = 0;
        public int current_mat_id = 0;
        public int current_com_id = 0;

        private async void frmPlanConsulta_Load(object sender, EventArgs e)
        {
            this.planesDataGridView.DataSource = null;
            EspecialidadesApiClient client = new EspecialidadesApiClient();
            especialidades = (List<Especialidad>)await EspecialidadesApiClient.GetAllAsync().ConfigureAwait(false);

            foreach (var item in especialidades)
            {
                cmbEspecialidad.Items.Add(item.descripcion);
            }

        }

        private async void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var esp = (from es in especialidades where es.descripcion == cmbEspecialidad.SelectedItem.ToString() select es.Id).First();
            this.planesDataGridView.DataSource = null;
            this.planesDataGridView.DataSource = await PlanesApiClient.GetAllAsync(esp);
            current_esp_id = esp;

        }


        private void crearUnPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current_esp_id == 0)
            {
                MessageBox.Show("Escoja una especialidad primero");
            }
            else
            {
                frmPlan nuevoPlan = new frmPlan();
                nuevoPlan.MdiParent = this.MdiParent;
                nuevoPlan.buffer.IdEsp = current_esp_id;
                nuevoPlan.Show();
                if (nuevoPlan.IsDisposed)
                {
                    loadDataGrids(true);
                }
            }
        }

        private void modificarUnPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlan modPlan = new frmPlan();
            modPlan.MdiParent = this.MdiParent;
            modPlan.editMode = true;
            modPlan.buffer = (Plan)planesDataGridView.SelectedRows[0].DataBoundItem;
            modPlan.Show();
            if (modPlan.IsDisposed)
            {
                loadDataGrids(true);
            }
        }

        private async void eliminarPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanesApiClient client = new PlanesApiClient();
            await PlanesApiClient.DeleteAsync(current_pl_id);
            loadDataGrids(true);
        }

        private void crearUnaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria nuevaMateria = new frmMateria();
            nuevaMateria.MdiParent = this.MdiParent;
            nuevaMateria.materia.IdPlan = current_pl_id;
            nuevaMateria.Show();
            if (nuevaMateria.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private void modifcarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria modMateria = new frmMateria();
            modMateria.MdiParent = this.MdiParent;
            modMateria.editMode = true;
            modMateria.materia = (Materia)materiasDataGridView.SelectedRows[0].DataBoundItem;
            modMateria.Show();
            if (modMateria.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private async void eliminarMateriaSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriasApiClient client = new MateriasApiClient();
            await MateriasApiClient.DeleteAsync(((Materia)materiasDataGridView.SelectedRows[0].DataBoundItem).Id, ((Materia)materiasDataGridView.SelectedRows[0].DataBoundItem).IdPlan);
            loadDataGrids(false);
        }

        private void crearComisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComision nuevaComision = new frmComision();
            nuevaComision.MdiParent = this.MdiParent;
            nuevaComision.comision.PlanId = current_pl_id;
            nuevaComision.Show();
            if (nuevaComision.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private void modificarComisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComision modComision = new frmComision();
            modComision.MdiParent = this.MdiParent;
            modComision.editMode = true;
            modComision.comision = (Comision)comisionesDataGridView.SelectedRows[0].DataBoundItem;
            modComision.Show();
            if (modComision.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private async void eliminarComisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComisionesApiClient client = new ComisionesApiClient();
            await ComisionesApiClient.DeleteAsync(((Comision)comisionesDataGridView.SelectedRows[0].DataBoundItem).Id);
            loadDataGrids(false);
        }

        private async void planesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_pl_id = ((Plan)planesDataGridView.SelectedRows[0].DataBoundItem).Id;
            loadDataGrids(false);
            menuStrip1.Items[1].Enabled = true;
            menuStrip1.Items[2].Enabled = true;
            menuStrip1.Items[3].Enabled = true;
        }

        public async void loadDataGrids(bool id)
        {

            if (id)
            {
                this.planesDataGridView.DataSource = null;
                this.planesDataGridView.DataSource = await PlanesApiClient.GetAllAsync(current_esp_id);
            }
            else
            {
                this.materiasDataGridView.DataSource = null;
                this.comisionesDataGridView.DataSource = null;

                this.materiasDataGridView.DataSource = await MateriasApiClient.GetAllAsync(current_pl_id);
                this.comisionesDataGridView.DataSource = await ComisionesApiClient.GetAllAsync(current_pl_id);
                if(comisionesDataGridView.SelectedRows.Count > 0 && materiasDataGridView.SelectedRows.Count > 0)
                {
                    current_com_id = ((Comision)comisionesDataGridView.SelectedRows[0].DataBoundItem).Id;
                    current_mat_id = ((Materia)materiasDataGridView.SelectedRows[0].DataBoundItem).Id;
                    this.cursosDataGridView.DataSource = null;
                    this.cursosDataGridView.DataSource = await CursosApiClient.GetAllAsync(current_mat_id, current_com_id);
                }
                else
                {
                    this.cursosDataGridView.DataSource = null;
                }
            }
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso nuevoCurso = new frmCurso();
            nuevoCurso.MdiParent = this.MdiParent;
            nuevoCurso.curso.ComisionId = current_com_id;
            nuevoCurso.curso.MateriaId = current_mat_id;
            nuevoCurso.Show();
            if (nuevoCurso.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private void modificarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso modCurso = new frmCurso();
            modCurso.MdiParent = this.MdiParent;
            modCurso.editMode = true;
            modCurso.curso = (Curso)cursosDataGridView.SelectedRows[0].DataBoundItem;
            modCurso.Show();
            if (modCurso.IsDisposed)
            {
                loadDataGrids(false);
            }
        }

        private async void eliminarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursosApiClient client = new CursosApiClient();
            await CursosApiClient.DeleteAsync(((Curso)cursosDataGridView.SelectedRows[0].DataBoundItem).Id);
            loadDataGrids(false);
        }

        private async void comisionesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_com_id = ((Comision)comisionesDataGridView.SelectedRows[0].DataBoundItem).Id;
            this.cursosDataGridView.DataSource = await CursosApiClient.GetAllAsync(current_mat_id, current_com_id);
        }

        private async void materiasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_mat_id = ((Materia)materiasDataGridView.SelectedRows[0].DataBoundItem).Id;
            this.cursosDataGridView.DataSource = await CursosApiClient.GetAllAsync(current_mat_id, current_com_id);
        }
    }
}
