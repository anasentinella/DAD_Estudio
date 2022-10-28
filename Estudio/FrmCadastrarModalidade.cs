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
    public partial class FrmCadastrarModalidade : Form
    {
        public FrmCadastrarModalidade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            float alunos = float.Parse(txtAlunos.Text);
            int aulas = int.Parse(txtAulas.Text);
            int preco = int.Parse(txtPreco.Text);
            Modalidade mod = new Modalidade(txtDescricao.Text, alunos, aulas, preco);
            if (mod.cadastrarModalidade())
            {
                MessageBox.Show("Modalidade cadastrada");
            }
            else
            {
                MessageBox.Show("Erro no Cadastro");
            }
        }
    }
}
