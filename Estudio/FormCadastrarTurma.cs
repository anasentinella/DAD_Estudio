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
        public FormCadastrarTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade com_mod = new Modalidade();
            MySqlDataReader r = com_mod.consultarModalidade();
            while (r.Read())
                dataGridView1.Rows.Add(r["DescricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }
        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {

        }
    }
}
