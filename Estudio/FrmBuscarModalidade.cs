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
        private MySqlConnection con;
        string adi;

        public FrmBuscarModalidade()
        {
            InitializeComponent();
        }
        private void FrmBuscarModalidade_Load_1(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select descricaoModalidade from Estudio_Modalidade where ativa=1", DAO_Conexao.con);
            MySqlDataReader rest = selectDesc.ExecuteReader();

            cbxDESC.Items.Clear();
            while (rest.Read())
            {
                cbxDESC.Items.Add(rest.GetString("descricaoModalidade"));
                cbxDESC.Text = rest[0].ToString();
            }

            rest.Close();
            DAO_Conexao.con.Close();
        }
        

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {

            DAO_Conexao.con.Open();
            MySqlCommand selectModalidade = new MySqlCommand("Select * from Estudio_Modalidade where descricaoModalidade='" + cbxDESC.Text + "'", DAO_Conexao.con);
            MySqlDataReader resModalidade = selectModalidade.ExecuteReader();
            resModalidade.Read();

            txtPreco.Text = resModalidade.GetString("precoModalidade").ToString();
            txtAlunos.Text = resModalidade.GetString("qtdAlunos").ToString();
            txtAulas.Text = resModalidade.GetString("qtdAulas").ToString();

            resModalidade.Close();
            DAO_Conexao.con.Close();
        }

        private void FrmBuscarModalidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAO_Conexao.con.Close();
        }
    }
}
