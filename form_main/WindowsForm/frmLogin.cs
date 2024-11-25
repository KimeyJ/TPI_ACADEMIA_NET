using form_main.WindowsForm;
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
using WindowsForms;

namespace form_main
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario buffer = new Usuario();
            Usuario rta = new Usuario();
            UsuariosApiClient client = new UsuariosApiClient();
            buffer.Username= txtUsuario.Text;
            buffer.Password= txtPassword.Text;
            rta = await UsuariosApiClient.AuthenticateAsync(buffer);

            if ( rta != null)
            {
                MessageBox.Show("Logueo exitoso");
                form_main frmMain = new form_main();
                frmMain.usuarioActual = rta;
                this.Hide();
                frmMain.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void form_login_Load(object sender, EventArgs e)
        {
            int countUser = await UsuariosApiClient.GetCountAsync();
            if (countUser == 0)
            {
                MessageBox.Show("No hay un Usuario Maestro cargado en la base de datos, ahora sera redirigido para crear un nuevo usuario","Usuario Maestro Faltante",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmPersona per = new frmPersona();
                per.tipoPersona = 3;
                per.ShowDialog();
            }
        }
    }
}
