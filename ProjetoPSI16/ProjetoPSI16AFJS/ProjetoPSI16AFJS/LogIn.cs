using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPSI16AFJS
{

    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Conn);

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select nome,login,pass from [User]", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (txtUser.Text == sdr.GetValue(1).ToString() && txtPass.Text == sdr.GetValue(2).ToString())
                    {
                        ((MainFRM)this.MdiParent).MainMenuStrip.Enabled = true;

                        this.Hide();
                        MessageBox.Show("Bem vindo " + sdr.GetValue(0).ToString(), "Wellcome");
                       
                    }
                    else
                    {
                        throw new Exception();
                    }



                }
                txtUser.Text = "";
                txtPass.Text = "";


            }
            catch (Exception)
            {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}

