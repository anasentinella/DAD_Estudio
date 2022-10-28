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
    public partial class frmExcluirAluno : Form
    {
        public frmExcluirAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if(e.KeyChar==13)
            {
                if(aluno.consultarAluno())
                {
                    if(aluno.ExcluirAluno())
                    {
                        MessageBox.Show("Aluno Excluído");
                    }
                }
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
