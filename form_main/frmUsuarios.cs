using Domain.Model;
using form_main.WindowsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_main
{
    public partial class frmUsuarios : Form
    {
        public Persona buffer;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblPersona.Text = "Persona: " + buffer.Nombre + " " + buffer.Apellido + ", Legajo: " + buffer.Legajo;
            txtUsername.Text = buffer.Apellido.ToLower() + buffer.Nombre.ToLower() + buffer.Legajo;
        }

        public bool ValidationCheck()
        {
            if(txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Complete el campo Nombre de Usuario");
                return false;
            }
            return true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (ValidationCheck())
            {
                usuario.Username = txtUsername.Text;
                usuario.Password = txtPass1.Text;
                usuario.IdPersona = buffer.Legajo;

                UsuariosApiClient client = new UsuariosApiClient();
                await UsuariosApiClient.AddAsync(usuario);
                MessageBox.Show("Usuario creado exitosamente");
                this.Dispose();
            }

        }
    }
}
