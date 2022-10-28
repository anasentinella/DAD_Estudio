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
        private MySqlConnection con;

        public string Descricao2 { get => Descricao2; set => Descricao2 = value; }
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
            return Descricao1;
        }
        private void setDescricao(string descric)
        {
            this.Descricao1 = descric;
        }

        public bool cadastrarModalidade()
        {
            bool cadi = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade(descricaoModalidade,precoModalidade,qtdeAlunos,qtdeAulas,ativa"+
                "values=( '" + Descricao2 + "', " + preco + ", " + qtdeAlunos + ", '" + qtdeAulas + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cadi = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cadi;
        }
         
        public bool consultarModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * From Estudio_Modalidade" + " WHERE descricaoModalidade='" + Descricao1 + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }
        
       
        public bool consultarTodasModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * From Estudio_Modalidade", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        

        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade se ativo" + "= 1 where descricaoModalidade ='" + Descricao1 + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }














    }

}
