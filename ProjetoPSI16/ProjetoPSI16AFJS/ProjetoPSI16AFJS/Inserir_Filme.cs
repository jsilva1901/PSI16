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
    public partial class Inserir_Filme : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Conn);
        public Inserir_Filme()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Sala values(sessao,num_sala,capacidade,lugares)", con);
                #region Adicionar
                if (txtFilme.Text != "")
                {
                    cmd.Parameters.AddWithValue("sessao", txtFilme.Text);
                }
                else
                {
                    throw new Exception("O titulo do filme não pode estar vazio!");
                }


                if (Convert.ToInt32(txtSala.Text) > 0 && Convert.ToInt32(txtSala.Text) <= 10)
                {
                    cmd.Parameters.AddWithValue("num_sala", txtSala.Text);
                }
                else
                {
                    throw new Exception("O cinema só têm 10 salas!");

                }
                //Capacidade da sala =75 lugares
                cmd.Parameters.AddWithValue("capacidade", 75);
                if (Convert.ToInt32(txtLugaresDisponiveis.Text) >= 0 && Convert.ToInt32(txtLugaresDisponiveis.Text) <= 75)
                {// se o numero indicado pelo user estiver entre os valores compreendidos o numero de lugares vai ser esse
                    cmd.Parameters.AddWithValue("lugares", Convert.ToInt32(txtLugaresDisponiveis.Text));
                }
                else
                {
                    throw new Exception("A lotação Maxima da sala são 75 pessoas");

                }
                #endregion
                 SqlDataAdapter SqlDAdapter = new SqlDataAdapter("Select * from Sala", con);

                DataSet dgv = new DataSet();

                SqlDAdapter.Fill(dgv, "Sala");
                SqlCommandBuilder cmdBd = new SqlCommandBuilder(SqlDAdapter);

                SqlDAdapter.Update(dgv, "Sala");

                MessageBox.Show("Informação atualizada", "DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserting Data Successfully");
                this.Close();
 

            }
            catch (Exception exp)
            {
               MessageBox.Show(exp.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Inserir_Filme_Load(object sender, EventArgs e)
        {

        }
    }
}

