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
                    MessageBox.Show("Modalidade Excluída");
                }
            } 
        }
    }
}
