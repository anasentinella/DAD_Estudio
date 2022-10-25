using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private string Descricao1;
        private float preco;
        private int qtdeAlunos,qtdeAulas;

        public string Descricao { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco1; set => Preco1 = value; }
        public int QtdeAlunos { get => QtdeAlunos; set => QtdeAlunos = value; }
        public int QtdeAulas { get => qtdeAulas; set => qtdeAulas = value; }

       public Modalidade(string Descricao1, float preco, int qtde_alunos,int qtde_aulas){
            DAO_Conexao.getConexao("143.106.241.3", "cl201281", "cl201281", "cl*15022006");
            setDescricao(Descricao1);
            setPreco1(preco);
            setQtdeAlunos(qtde_alunos);
            setQtdeAulas(qtde_aulas);
        }
        public Modalidade(string Descric)
        {
            setDescricao(Descric);
        }



        public Modalidade()
        {

        }

        public int getQtdeAulas()
        {
            return qtdeAulas;
        }

        private void setQtdeAulas(int qtde_aulas)
        {
            this.qtdeAulas= qtde_aulas;
        }
        public int getQtdeAlunos()
        {
            return qtdeAlunos;
        }
        private void setQtdeAlunos(int qtde_alunos)
        {
            this.qtdeAlunos = qtde_alunos;
        }
        public float getPreco()
        {
            return preco;
        }
        private void setPreco1(float preco)
        {
            this.preco = preco;
        }

        public String getDescricao()
        {
            return Descricao;
        }
        private void setDescricao(string descric)
        {
            this.Descricao = descric;
        }

        public bool cadastrarModalidade()
        {

        }
         
        public MySqlDataReader consultarModalidade()
        {

        }
        
        public MySqlDataReader consultarTodasModalidade()
        {

        }

        public bool atualizarModalidade()
        {

        }

        public bool excluirModalidade()
        {

        }














    }

}
