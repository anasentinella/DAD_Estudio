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
            this.Text = "Excluir Modalidade";
        }

       

       

        private void FrmExcluirModalidade_Load(object sender, EventArgs e)
        {
            populatecbxDESC();
        }
        public void populatecbxDESC()
        {
            try
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }
        

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxDESC.Text);
            if (mod.excluirModalidade())
            {
                
                MessageBox.Show("Modalidade inativa!");
                cbxDESC.Items.Clear();
                populatecbxDESC();
            }
            else
            {
                MessageBox.Show("impossivel excluir modalidade...");
            
            }
         
        }
    }
}

