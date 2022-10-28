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
            cmbdisp();
        }
        public void cmbdisp()
        {
            con.Open();
            string q = "Select Estudio_Modalidade where descricaoModalidade from Estudio_Modalidade";
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader datread = cmd.ExecuteReader();
            while (datread.Read())
            {
                cbxDESC.Items.Add(datread["descricaoModalidade"].ToString());
                cbxDESC.DisplayMember = (datread["descricaoModalidade"].ToString());
                cbxDESC.ValueMember = (datread["descricaoModalidade"].ToString());
            }
            con.Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void cbxDESC_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select Estudio_Modalidade where descricaoModalidade='" + cbxDESC.SelectedIndex + "'";
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader datread = cmd.ExecuteReader();
            while (datread.Read())
            {
                adi = datread[0].ToString();
            }
            con.Close();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            float alunos = float.Parse(txtAlunos.Text);
            int aulas = int.Parse(txtAulas.Text);
            int preco = int.Parse(txtPreco.Text);
            con.Open();
            string q = "insert into descricaoModalidade(qtdeAlunos,qtdeAulas,precoModalidade) values(" + alunos + "," + aulas + "," + preco + "," +adi+")";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
