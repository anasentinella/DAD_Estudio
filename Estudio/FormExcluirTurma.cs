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
    public partial class FormExcluirTurma : Form
    {
        public static int id;
        public FormExcluirTurma()
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
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(cbxModalidade.Text);
            Turma t = new Turma(m.buscaporId(), cbxDiaSemana.Text, cbxHora.Text);
            if (t.ExcluirTurma())
            {
                MessageBox.Show("Exclusão realizada com sucesso");
                cbxModalidade.Items.Clear();
                cbxModalidade.Text = String.Empty;
                cbxDiaSemana.Items.Clear();
                cbxDiaSemana.Text = String.Empty;
                cbxHora.Items.Clear();
                cbxHora.Text = String.Empty;
                carregaComboBox();
            }
            else
                MessageBox.Show("Erro de exclusão!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxHora.Items.Clear();
            cbxHora.Text = String.Empty;
            Modalidade m = new Modalidade(cbxModalidade.Text);
            Turma t = new Turma(m.buscaporId(), cbxDiaSemana.Text);
            MySqlDataReader re = t.buscaTurmaGeral();
            while (re.Read())
            {
                cbxHora.Items.Add(re["Hora"]);
            }
            DAO_Conexao.con.Close();
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDiaSemana.Items.Clear();
            cbxHora.Items.Clear();
            cbxHora.Text = String.Empty;
            cbxDiaSemana.Text = String.Empty;
            Modalidade m = new Modalidade(cbxModalidade.Text);
            Turma t = new Turma(m.buscaporId());
            MySqlDataReader re = t.buscaTurma1();
        }
    }      
}
