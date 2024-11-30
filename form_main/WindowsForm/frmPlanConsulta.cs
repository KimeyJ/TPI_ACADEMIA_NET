﻿using Domain.Model;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (current_esp_id == 0)
            {
                MessageBox.Show("Escoja una especialidad primero");
            }
            else
            {
                MessageBox.Show(current_esp_id.ToString());
                frmPlan nuevoPlan = new frmPlan();
                nuevoPlan.MdiParent = this.MdiParent;
                nuevoPlan.buffer.IdEsp = current_esp_id;
                nuevoPlan.Show();
            }

        }

        private async void frmPlanConsulta_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
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
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await PlanesApiClient.GetAllAsync(esp);
            current_esp_id = esp;
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(current_esp_id.ToString());
            frmPlan modPlan = new frmPlan();
            modPlan.MdiParent = this.MdiParent;
            modPlan.editMode = true;
            modPlan.buffer = (Plan)dataGridView1.SelectedRows[0].DataBoundItem;
            modPlan.Show();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            PlanesApiClient client = new PlanesApiClient();
            await PlanesApiClient.DeleteAsync(((Plan)dataGridView1.SelectedRows[0].DataBoundItem).Id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}