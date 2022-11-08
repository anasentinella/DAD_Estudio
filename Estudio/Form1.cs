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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201281", "cl201281", "cl*15022006")) Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "felipe";
            txtSenha.Text = "1708";
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text, txtSenha.Text);
            if (tipo == 0)
                MessageBox.Show("Usuario/Senha inválidos");
            if(tipo==1)
            {
                MessageBox.Show("Usuário ADM :)");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                arquivoToolStripMenuItem.Enabled = true;
            }
            if(tipo==2)
            {
                MessageBox.Show("Usuário Restrito :(");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                frmCadastrarLogin.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                frmCadastrarAluno frmCadastrar_Aluno = new frmCadastrarAluno();
                frmCadastrar_Aluno.MdiParent = this;
                frmCadastrar_Aluno.Show();
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                frmCadastrarUsuario frmCadastrar_Usuario = new frmCadastrarUsuario();
                frmCadastrar_Usuario.MdiParent = this;
                frmCadastrar_Usuario.Show();
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalidademenu.Enabled = false;
           alunomenu.Enabled = false;
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                frmExcluirAluno frmExcluir_Aluno = new frmExcluirAluno();
                frmExcluir_Aluno.MdiParent = this;
                frmExcluir_Aluno.Show();
            }
        }


        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalidademenu.Enabled = false;
            alunomenu.Enabled = false;
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                FrmCadastrarModalidade frmCadastrar_modalidade = new FrmCadastrarModalidade();
                frmCadastrar_modalidade.MdiParent = this;
                frmCadastrar_modalidade.Show();
            }
        }


        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                FrmBuscarModalidade frmBuscar_modalidade = new FrmBuscarModalidade();
                frmBuscar_modalidade.MdiParent = this;
                frmBuscar_modalidade.Show();
            }
        }


        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarAluno>().Count() == 0)
            {
                alunomenu.Enabled = false;
                modalidademenu.Enabled = false;
                FrmExcluirModalidade frmExcluir_modalidade = new FrmExcluirModalidade();
                frmExcluir_modalidade.MdiParent = this;
                frmExcluir_modalidade.Show();
            }
        }

        private void alunomenu_Click(object sender, EventArgs e)
        {

        }
    }
}
