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
            Usuario usuario = new Usuario();
            UsuariosApiClient client = new UsuariosApiClient();
            usuario.Username= txtUsuario.Text;
            usuario.Password= txtPassword.Text;

            if (await UsuariosApiClient.AuthenticateAsync(usuario.Username, usuario.Password))
            {
                MessageBox.Show("Logueo exitoso");
                form_main frmMain = new form_main();
                frmMain.usuarioActual = usuario;
                this.Hide();
                frmMain.ShowDialog();
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
                per.firstTimeBoot = true;
                per.ShowDialog();
            }
        }
    }
}
