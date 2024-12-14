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
        public bool editMode = false;
        public Persona persona = new Persona();
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

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Email = txtMail.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Fecha_nac = mcNac.SelectionRange.Start;
            persona.Tipo_persona = tipoPersona;


            if(ValidationCheck(persona))
            {
                PersonasApiClient client = new PersonasApiClient();
                if(editMode)
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

        private void frmPersona_Load(object sender, EventArgs e)
        {

            mcNac.MaxDate = DateTime.Now;
            if(editMode)
            {
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
                txtDireccion.Text = persona.Direccion;
                txtMail.Text = persona.Email;
                txtTelefono.Text = persona.Telefono;
                mcNac.SetDate(persona.Fecha_nac);

                button1.Text = "Guardar cambios";
            }
        }
    }
}
