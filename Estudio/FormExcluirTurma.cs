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

        }
    }
}
