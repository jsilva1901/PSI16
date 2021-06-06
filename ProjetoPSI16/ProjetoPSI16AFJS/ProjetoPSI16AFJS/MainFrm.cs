using System;
using System.Threading;
using System.Windows.Forms;


namespace ProjetoPSI16AFJS
{
    public partial class MainFRM : Form
    {
        FrmSplash Splash = new FrmSplash();
        public MainFRM()
        {
            InitializeComponent();
            Splash.Show();
            Application.DoEvents();

        }

        private void MainFRM_Load(object sender, EventArgs e)
        {
            // Desactivar os controlos do form
            this.mnuMenu.Enabled = false;
            // Criar um novo form
            LogIn childForm = new LogIn();
            // Indicar qual é o "pai"
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFRM_Activated(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Splash.Close();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar um novo form
            Sala childForm = new Sala();
            // Indicar qual é o "pai"
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void bilhetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar um novo form
            Bilhete childForm = new Bilhete();
            // Indicar qual é o "pai"
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar um novo form
            Filme childForm = new Filme();
            // Indicar qual é o "pai"
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
