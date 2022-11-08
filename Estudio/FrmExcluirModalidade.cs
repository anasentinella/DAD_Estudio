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
    public partial class FrmExcluirModalidade : Form
    {
        public FrmExcluirModalidade()
        {
            InitializeComponent();
        }

       

       

        private void FrmExcluirModalidade_Load(object sender, EventArgs e)
        {
            populatecbxDESC();
        }
        public void populatecbxDESC()
        {
            DAO_Conexao.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select descricaoModalidade from Estudio_Modalidade where ativa=1", DAO_Conexao.con);
            MySqlDataReader res = selectDesc.ExecuteReader();
            cbxDESC.Items.Clear();
            while (res.Read())
            {
                cbxDESC.Items.Add(res.GetString("descricaoModalidade"));
                cbxDESC.Text = res[0].ToString();
            }
            DAO_Conexao.con.Close();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxDESC.SelectedItem.ToString());
            if (mod.excluirModalidade())
            {
                MessageBox.Show("Modalidade inativa!");
            }
            else
            {
                MessageBox.Show("impossivel excluir modalidade...");
            }
            populatecbxDESC();
        }

       
    }
}
