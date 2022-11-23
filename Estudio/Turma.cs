using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;
        private string text;

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }
        public Turma(int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
          
        }

       

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
   

        public bool CadastrarTurma()
        {
        bool cadi = false;
        try
        {
            DAO_Conexao.con.Open();
            Console.WriteLine("insert into Estudio_Turma(Professor,DiaSemanaHora,Hora) values ('" + Professor + "','" + dia_semana + "','" + Hora + "')", DAO_Conexao.con);
            MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma(Professor,DiaSemanaHora,Hora) values ('" + Professor + "','" + dia_semana + "','" + Hora + "')", DAO_Conexao.con);
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

   
        public bool ExcluirTurma()
        {
         bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("Delete Estudio_Turma  1 where idModalidade like '" + Modalidade + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao excluir turma: " + Modalidade + "\n" + ex.ToString());

            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }


        public bool ConsultarTurma()
        {
            bool existe = false;
            try
            {
                Console.WriteLine("Select * From Estudio_Turma" + " WHERE idModalidade='" + modalidade + "'", DAO_Conexao.con);
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * From Estudio_Turma" + " WHERE idModalidade='" + modalidade + "'", DAO_Conexao.con);
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

        public MySqlDataReader buscaTurma1()
        {
            MySqlDataReader res = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade=" + modalidade + "", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }
        public MySqlDataReader buscaTurmaGeral()
        {
            MySqlDataReader res = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE id_modalidade=" + modalidade + " AND Dia_semana like '" + dia_semana + "'", DAO_Conexao.con);
                res = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DAO_Conexao.con.Close();
            }
            return res;
        }
    }
}
