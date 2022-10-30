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
            Busca();
        }
        public void Busca()
        {
            
            DAO_Conexao.con.Open();
            string q = "Select descricaoModalidade from Estudio_Modalidade where descricaoModalidade LIKE '" + cbxDESC.Text.Trim().ToLower() + "' AND ativa = 0";
            MySqlCommand cmd = new MySqlCommand(q, DAO_Conexao.con);
            MySqlDataReader datread = cmd.ExecuteReader();
            while (datread.Read())
            {
                cbxDESC.Items.Add(datread["descricaoModalidade"].ToString());
                cbxDESC.DisplayMember = (datread["descricaoModalidade"].ToString());
                cbxDESC.ValueMember = (datread["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void cbxDESC_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select Estudio_Modalidade where descricaoModalidade='" + cbxDESC.SelectedIndex + "'";
            MySqlCommand cmd = new MySqlCommand(q,DAO_Conexao.con);
            MySqlDataReader datread = cmd.ExecuteReader();
            while (datread.Read())
            {
                adi = datread[0].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxDESC.Text);
            if (string.IsNullOrWhiteSpace(cbxDESC.Text.ToString()))
                mod.consultarTodasModalidade();
            else
            {
                mod.consultarModalidade();
            }
            if (cbxDESC.Items.Count > 0)
                cbxDESC.SelectedIndex = 0;
        }
    }
}
