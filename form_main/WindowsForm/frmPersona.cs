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

namespace form_main.WindowsForm
{
    public partial class frmPersona : Form
    {
        public bool firstTimeBoot = false;
        public bool editMode = false;
        public frmPersona()
        {
            InitializeComponent();
        }

        public bool ValidationCheck(Persona buffer)
        {
            if(buffer.Nombre.Length == 0)
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
            if(buffer.Fecha_nac == DateTime.Today)
            {
                MessageBox.Show("Seleccione una fecha valida");
                return false;
            }
            if(buffer.Email.Contains('@') == false)
            {
                MessageBox.Show("Ingrese un correo valido");
                return false;
            }

            return true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Email = txtMail.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Fecha_nac = mcNac.SelectionRange.Start;
            if(rbAdm.Checked)
            {
                persona.Tipo_persona = 1;
            }else if (rbProf.Checked)
            {
                persona.Tipo_persona= 2;
            }else if (rbAl.Checked)
            {
                persona.Tipo_persona = 3;
            }

            if(ValidationCheck(persona))
            {
                PersonasApiClient client = new PersonasApiClient();
                persona.Legajo = await PersonasApiClient.AddAsync(persona);
                MessageBox.Show("Persona registrada exitosamente, se procedera a la creacion del usuario correspondiente");
                frmUsuarios nuevoUsuario = new frmUsuarios();
                nuevoUsuario.buffer = persona;
                nuevoUsuario.ShowDialog();
                this.Dispose();
            }
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            if(firstTimeBoot)
            {
                rbAdm.Checked = true;
                rbAdm.Enabled = false;
                rbAl.Enabled = false;
                rbProf.Enabled = false;
            }
            mcNac.MaxDate = DateTime.Now;
        }
    }
}
