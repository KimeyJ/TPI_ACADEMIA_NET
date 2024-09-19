namespace form_main
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Shown(object sender, EventArgs e)
        {
            form_login appLogin = new form_login();
            appLogin.Show();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void form_main_Load(object sender, EventArgs e)
        {

        }

        private void materiasDelPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
