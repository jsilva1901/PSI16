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
    public partial class Filme : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Conn);
        SqlDataAdapter SqlDAdapter;
        DataSet dgv;
        public Filme()
        {
            InitializeComponent();
        }

        private void Filme_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Filme", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvFilme.VirtualMode = false;
                dgvFilme.Columns.Clear();
                dgvFilme.AutoGenerateColumns = true;
                dgvFilme.DataSource = ds.Tables[0];
                dgvFilme.Refresh();
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
            dgvFilme.ReadOnly = false;
            dgvFilme.AllowUserToAddRows = true;
            dgvFilme.AllowUserToDeleteRows = true;

            SqlDAdapter = new SqlDataAdapter("Select * from Filme", con);

            dgv = new DataSet();

            SqlDAdapter.Fill(dgv, "Filme");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdBd = new SqlCommandBuilder(SqlDAdapter);

            SqlDAdapter.Update(dgv, "Filme");

            MessageBox.Show("Informação atualizada", "DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Novo_filme NFilme = new Novo_filme();
            NFilme.Show();

        }
    }
}
