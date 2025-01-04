using Domain.Model;
using form_main.APIs;
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
        public Usuario usuario = new Usuario();
        public bool editMode = false;
        public bool validationResult;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblPersona.Text = "Persona: " + buffer.Nombre + " " + buffer.Apellido + ", Legajo: " + buffer.Legajo;
            txtUsername.Text = buffer.Apellido.ToLower() + buffer.Nombre.ToLower() + buffer.Legajo;
            if(editMode )
            {
                txtUsername.Text = usuario.Username;
                txtPass1.Text = usuario.Password;
                button1.Text = "Modificar usuario";
            }
        }

        public async void ValidationCheck()
        {
            validationResult = true;
            if(txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                validationResult = false;
            }
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Complete el campo Nombre de Usuario");
                validationResult = false;
            }
            if(editMode == true && usuario.Username != txtUsername.Text)
            {
                UsuariosApiClient client = new UsuariosApiClient();
                if (await UsuariosApiClient.CheckDuplicateAsync(txtUsername.Text, usuario.UsuarioId))
                {
                    validationResult = true;
                }
                else
                {
                    MessageBox.Show("Nombre de usuario en uso, por favor ingrese otro");
                    validationResult = false;
                }
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            ValidationCheck();
            if (validationResult)
            {
                usuario.Username = txtUsername.Text;
                usuario.Password = txtPass1.Text;
                usuario.IdPersona = buffer.Legajo;

                UsuariosApiClient client = new UsuariosApiClient();
  
                if (editMode)
                {
                    
                    await UsuariosApiClient.UpdateAsync(usuario);
                    MessageBox.Show("Cambios realizados correctamente");
                    this.Dispose();
                }
                else
                {
                    await UsuariosApiClient.AddAsync(usuario);
                    MessageBox.Show("Usuario creado exitosamente");
                    this.Dispose();
                }
                
            }

        }
    }
}
