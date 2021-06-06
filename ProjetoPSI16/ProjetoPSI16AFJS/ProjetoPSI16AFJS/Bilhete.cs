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
    public partial class Bilhete : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Conn);
        SqlDataAdapter SqlDAdapter;
        DataSet dgv;
        public Bilhete()
        {
            InitializeComponent();
        }

        private void Bilhete_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Bilhete", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvBilhete.VirtualMode = false;
                dgvBilhete.Columns.Clear();
                dgvBilhete.AutoGenerateColumns = true;
                dgvBilhete.DataSource = ds.Tables[0];
                dgvBilhete.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvBilhete.ReadOnly = false;
            dgvBilhete.AllowUserToAddRows = true;
            dgvBilhete.AllowUserToDeleteRows = true;

            SqlDAdapter = new SqlDataAdapter("Select * from bilhete", con);

            dgv = new DataSet();

            SqlDAdapter.Fill(dgv, "Bilhete");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder cmdBd = new SqlCommandBuilder(SqlDAdapter);

            SqlDAdapter.Update(dgv, "Bilhete");

            MessageBox.Show("Informação atualizada", "DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
