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
    public partial class Novo_filme : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Conn);
        public Novo_filme()
        {
            InitializeComponent();
        }

        private void Novo_filme_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Filme values(titulo,duracao,elenco,realizador,nome_trailer,produtores,duracao_trailer,publicidade)", con);
                #region Adicionar
                if (txtTituloFilme.Text != "")
                {
                    cmd.Parameters.AddWithValue("titulo", "'"+txtTituloFilme.Text+"'");
                }
                else
                {
                    throw new Exception("O titulo do filme não pode estar vazio!");
                }
                if (txtPrincipal.Text!= "")
                {
                    cmd.Parameters.AddWithValue("elenco", "'" + txtPrincipal.Text + "'");
                }
                else
                {
                    throw new Exception("O nome do ator/atriz principal não pode estar vazio!");
                }
                if (txtProdutor.Text != "")
                {
                    cmd.Parameters.AddWithValue("produtor", "'" + txtProdutor.Text + "'");
                }
                else
                {
                    throw new Exception("O nome do produtor não pode estar vazio!");
                }
                if (txtRealizador.Text != "")
                {
                    cmd.Parameters.AddWithValue("realizador", "'" + txtRealizador.Text + "'");
                }
                else
                {
                    throw new Exception("O titulo do filme não pode estar vazio!");
                }

                if (txtNomeTrailer.Text!="")
                {
                    cmd.Parameters.AddWithValue("nome_tralier", "'" + txtNomeTrailer.Text + "'");
                }
                else
                {
                    throw new Exception("O nome do trailer não pode estar vazio !!");

                }
                if (Convert.ToInt32(txtPub.Text)==1 || Convert.ToInt32(txtPub.Text)==2)
                {
                    cmd.Parameters.AddWithValue("publicidade", Convert.ToInt32(txtPub.Text));
                }
                else
                {
                    throw new Exception("A publicidade não pode estar vazia!");
                }

                if (nudDuF.Value>0 && nudDuF.Value<nudDuT.Value)
                {// se o numero indicado pelo user estiver entre os valores compreendidos o numero de lugares vai ser esse
                    cmd.Parameters.AddWithValue("duracao", Convert.ToInt32(nudDuF.Value));
                }
                else
                {
                    throw new Exception("Valor de duração do filme inválido!!");

                }
                if (nudDuT.Value > 0 && nudDuT.Value<10)
                {// se o numero indicado pelo user estiver entre os valores compreendidos o numero de lugares vai ser esse
                    cmd.Parameters.AddWithValue("duracao_tralier", Convert.ToInt32(nudDuT.Value));
                }
                else
                {
                    throw new Exception("Valor de duração do trailer inválido!!");

                }
                #endregion
                SqlDataAdapter SqlDAdapter = new SqlDataAdapter("Select * from Filme", con);

                DataSet dgv = new DataSet();

                SqlDAdapter.Fill(dgv, "Filme");
                SqlCommandBuilder cmdBd = new SqlCommandBuilder(SqlDAdapter);

                SqlDAdapter.Update(dgv, "Filme");

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
    }
}
