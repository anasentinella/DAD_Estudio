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
    public partial class FormCadastrarTurma : Form
    {
        public static int id;
        
        public FormCadastrarTurma()
        {
            InitializeComponent();
            carregaComboBox();
            id = 0;
        }

        public void carregaComboBox()
        {
            Modalidade m = new Modalidade();
            MySqlDataReader re = m.consultarTodasModalidades();
            while (re.Read())
            {
                cbxModalidade.Items.Add(re["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }



        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(id == -1)
            {
                MessageBox.Show("Modalidade inválida");
            }
            else
            {
                Modalidade m = new Modalidade(cbxModalidade.Text);
                Turma tur = new Turma(m.buscaporId(),txtProfessor.Text, txtSemana.Text, maskedtxtHora.Text);
                if (tur.CadastrarTurma())
                {
                    MessageBox.Show("Cadastro feito com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro de cadastro!");
                }
            }
        }

        

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(cbxModalidade.Text);
            int a = m.buscaporId();
            if (a == -1)
            {
                MessageBox.Show("Erro interno,ID não encontrado");
            }
            else
            {
                id = a;
            }
        }
    }
}
