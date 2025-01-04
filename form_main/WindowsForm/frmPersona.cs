using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Model;
using form_main.APIs;

namespace form_main.WindowsForm
{
    public partial class frmPersona : Form
    {
        public bool editMode = false;
        public Persona persona = new Persona();
        public List<Plan> planes = new List<Plan>();
        public List<Especialidad> especialidades = new List<Especialidad>();
        public frmPersona()
        {
            InitializeComponent();
        }

        public bool ValidationCheck(Persona buffer)
        {
            if (buffer.Nombre.Length == 0)
            {
                MessageBox.Show("El campo Nombre debe ser completado");
                return false;
            }
            if (buffer.Apellido.Length == 0)
            {
                MessageBox.Show("El campo Apellido debe ser completado");
                return false;
            }
            if (buffer.Email.Length == 0)
            {
                MessageBox.Show("El campo Email debe ser completado");
                return false;
            }
            if (buffer.Telefono.Length == 0)
            {
                MessageBox.Show("El campo Telefono debe ser completado");
                return false;
            }
            if (buffer.Fecha_nac == DateTime.Today)
            {
                MessageBox.Show("Seleccione una fecha valida");
                return false;
            }
            if (buffer.Email.Contains('@') == false)
            {
                MessageBox.Show("Ingrese un correo valido");
                return false;
            }

            return true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Email = txtMail.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Fecha_nac = mcNac.SelectionRange.Start;
            if (persona.Tipo_persona == 1)
            {
                var plan = (from pl in planes where pl.Descripcion == cmbPlan.SelectedItem.ToString() select pl.PlanId).First();
                persona.IdPlan = plan;
            }


            if (ValidationCheck(persona))
            {
                PersonasApiClient client = new PersonasApiClient();
                if (editMode)
                {
                    await PersonasApiClient.UpdateAsync(persona);
                    MessageBox.Show("Cambios realizados correctamente, debera reiniciar la aplicacion para que tome los nuevos datos");
                    this.Dispose();
                }
                else
                {
                    persona.Legajo = await PersonasApiClient.AddAsync(persona);
                    MessageBox.Show("Persona registrada exitosamente, se procedera a la creacion del usuario correspondiente");
                    frmUsuarios nuevoUsuario = new frmUsuarios();
                    nuevoUsuario.buffer = persona;
                    nuevoUsuario.ShowDialog();
                    this.Dispose();
                }

            }
        }

        private async void frmPersona_Load(object sender, EventArgs e)
        {

            mcNac.MaxDate = DateTime.Now;
            if (editMode)
            {
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
                txtDireccion.Text = persona.Direccion;
                txtMail.Text = persona.Email;
                txtTelefono.Text = persona.Telefono;
                mcNac.SetDate(persona.Fecha_nac);

                button1.Text = "Guardar cambios";
            }
            if (persona.Tipo_persona == 1)
            {
                label7.Visible = true;
                cmbPlan.Visible = true;
                label8.Visible = true;
                cmbEspecialidad.Visible = true;
                especialidades = (List<Especialidad>)await EspecialidadesApiClient.GetAllAsync();
                foreach (Especialidad especialidad in especialidades)
                {
                    cmbEspecialidad.Items.Add(especialidad.Descripcion);
                }
                cmbEspecialidad.SelectedItem = cmbEspecialidad.Items[0];
                loadPlanes();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }

        private async void loadPlanes()
        {
            cmbPlan.Items.Clear();
            var esp = (from es in especialidades where es.Descripcion == cmbEspecialidad.SelectedItem.ToString() select es.EspecialidadId).First();
            planes = (List<Plan>)await PlanesApiClient.GetAllAsync(esp);
            foreach (Plan plan in planes)
            {
                cmbPlan.Items.Add(plan.Descripcion);
            }
            cmbPlan.SelectedItem = cmbPlan.Items[0];
        }
    }
}
