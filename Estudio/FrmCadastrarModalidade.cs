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
            this.Text = "Cadastrar Modalidade";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Equals(""))
                {
                    MessageBox.Show("cadastro realizado com sucesso", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Modalidade mod = new Modalidade(txtDescricao.Text, int.Parse(txtAlunos.Text),int.Parse(txtAulas.Text), int.Parse(txtPreco.Text));
                if (mod.cadastrarModalidade())
                {
                    MessageBox.Show("Modalidade cadastrada");
                }
                else
                {
                    MessageBox.Show("Erro no Cadastro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
