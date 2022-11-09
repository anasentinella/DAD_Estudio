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
        private MySqlConnection con;

        private String Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;
        

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int QtdeAlunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int QtdeAulas { get => qtde_aulas; set => qtde_aulas = value; }
        public int Id { get => Id; set => Id = value; }

        public Modalidade(string Descricao1, float preco, int qtde_alunos,int qtde_aulas){
            DAO_Conexao.getConexao("143.106.241.3", "cl201281", "cl201281", "cl*15022006");
            setDescricao(Descricao1);
            setPreco1(preco);
            setQtdeAlunos(qtde_alunos);
            setQtdeAulas(qtde_aulas);
        }

        

        public Modalidade(string Descricao1)
        {
            setDescricao(Descricao1);
        }



        public Modalidade()
        {

        }

        public int getId()
        {
            return Id;
        }
        private void setId(int id)
        {
            this.Id = id;
        }
        public int getQtdeAulas()
        {
            return QtdeAulas;
        }

        private void setQtdeAulas(int qtde_aulas)
        {
            this.QtdeAulas = qtde_aulas;
        }
        public int getQtdeAlunos()
        {
            return QtdeAlunos;
        }
        private void setQtdeAlunos(int qtde_alunos)
        {
            this.QtdeAlunos = qtde_alunos;
        }
        public float getPreco()
        {
            return Preco1;
        }
        private void setPreco1(float preco)
        {
            this.Preco1 = preco;
        }

        public string getDescricao()
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
                Console.WriteLine("insert into Estudio_Modalidade(descricaoModalidade,precoModalidade,qtdeAlunos,qtdeAulas) values ('" + Descricao + "', '" + Preco + "', " + qtde_alunos + ", " + qtde_aulas + ")");
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade(descricaoModalidade,precoModalidade,qtdeAlunos,qtdeAulas) values ('" + Descricao + "', '" + Preco + "', " + qtde_alunos + ", " + qtde_aulas + ")", DAO_Conexao.con);
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
                Console.WriteLine("Select * From Estudio_Modalidade" + " WHERE descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * From Estudio_Modalidade" + " WHERE descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
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
        

        public bool AtualizarModalidade()
        {
            bool checkUpdate = false;

            try
            {
   
                DAO_Conexao.con.Open();
                MySqlCommand atua = new MySqlCommand("UPDATE Estudio_Modalidade SET precoModalidade =" + Preco + ", qtdeAlunos =" + qtde_alunos + ", qtdeAulas = " + qtde_aulas + " WHERE descricaoModalidade like '" + Descricao + "'", DAO_Conexao.con);
                atua.ExecuteNonQuery();
                checkUpdate = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return checkUpdate;
        }

        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativa" + "= 1 where descricaoModalidade like '" + Descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao excluir modalidade: " + Descricao + "\n" + ex.ToString());

            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

    }

}
