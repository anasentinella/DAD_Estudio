using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estudio
{
    public partial class FrmBuscarModalidade : Form
    {
       

        public FrmBuscarModalidade()
        {
            InitializeComponent();
            this.Text = "Atualizar Modalidade";
        }

        public FrmBuscarModalidade(int ac)
        {
            InitializeComponent();
            txtAlunos.Enabled = false;
            txtAulas.Enabled = false;
            txtPreco.Enabled = false;
            btnAtualizar.Visible = false;
            this.Text = "Consultar Modalidade";

        }
        private void FrmBuscarModalidade_Load_1(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT  descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas from Estudio_Modalidade where ativa =0 ";
            MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader datared = adiciona.ExecuteReader();
            while (datared.Read())
            {
                cbxDESC.Items.Add(datared["descricaoModalidade"].ToString());
                cbxDESC.DisplayMember = (datared["descricaoModalidade"].ToString());
                cbxDESC.ValueMember = (datared["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }



            private void FrmBuscarModalidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAO_Conexao.con.Close();
        }

        private void cbxDESC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                    DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();
                MySqlCommand selectModalidades = new MySqlCommand("Select * from Estudio_Modalidade where descricaoModalidade like'" + cbxDESC.Text + "'", DAO_Conexao.con);
                MySqlDataReader resModalidade = selectModalidades.ExecuteReader();
                resModalidade.Read();
                txtPreco.Text = resModalidade["precoModalidade"].ToString();
                txtAulas.Text = resModalidade["qtdeAulas"].ToString();
                txtAlunos.Text = resModalidade["qtdeAlunos"].ToString();

                resModalidade.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally{
                DAO_Conexao.con.Close();
            }
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxDESC.Text, float.Parse(txtPreco.Text), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
            if (mod.AtualizarModalidade())
                MessageBox.Show("Modalidade atualizada com sucesso");
            else
                MessageBox.Show("Erro ao atualizar");   

            
        }
    }   
}

