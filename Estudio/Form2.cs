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
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCpf.Text, txtNome.Text, txtEndereco.Text, txtBairro.Text, txtComplemento.Text, txtCep.Text, txtCidade.Text, txtEstado.Text, txtTelefone.Text, txtEmail.Text);
                if (aluno.cadastrarAluno())
                MessageBox.Show("Cadastrado com Sucesso");
                else
                MessageBox.Show("Erro no Cadastro");
        }
    }
}
