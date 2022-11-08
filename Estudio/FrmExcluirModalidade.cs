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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(txtDescricao.Text);
            if (mod.consultarModalidade())
            {
                if (mod.excluirModalidade())
                {
                    MessageBox.Show("Modalidade inativa");
                }
            }
            else
            {
                MessageBox.Show("modalidade não encontrada");
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modalidade mod = new Modalidade(txtDescricao.Text);
            if (e.KeyChar == 13)
            {
                if (mod.consultarModalidade())
                {
                    if (mod.excluirModalidade())
                    {
                        MessageBox.Show("Modalidade inativa");
                    }
                }
                else
                {
                    MessageBox.Show("modalidade não encontrada");
                }
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
