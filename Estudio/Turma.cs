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
        private string professor, dia_semana;
        string hora;
        private int modalidade;

        public Turma(string professor, string dia_semana, string hora)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
           
          
        }
        public Turma(int idmodalidade,string diaSemana, string hora)
        {
            this.modalidade = idmodalidade;
         
            this.dia_semana = diaSemana;
            this.hora = hora;
        }
        public Turma(int idmodalidade, string Professor, string diaSemana, string hora)
        {
            this.modalidade = idmodalidade;
            this.professor = Professor;
            this.dia_semana = diaSemana;
            this.hora = hora;
        }
        public Turma(int idmodalidade, string diaSemana)
        {
            this.modalidade = idmodalidade;
            this.dia_semana = diaSemana;
        }
        public Turma(int idmodalidade)
        {
            this.modalidade = idmodalidade;
        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int V { get; }
        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }

        public bool CadastrarTurma()
        {
        bool cadi = false;
        try
        {
            DAO_Conexao.con.Open();
            Console.WriteLine("insert into Estudio_Turma(idModalidade,Professor,DiaSemana,Hora) values ("+modalidade +",'" + Professor + "','" + dia_semana + "','" + Hora + "')", DAO_Conexao.con);
            MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma(idModalidade,Professor,DiaSemana,Hora) values (" + modalidade + ",'" + Professor + "','" + dia_semana + "','" + Hora + "')", DAO_Conexao.con);
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
                MySqlCommand exclui = new MySqlCommand("Delete FROM Estudio_Turma where idModalidade=" + Modalidade + " AND DiaSemana like '"+ dia_semana+ "' And Hora like '"+ hora +"'", DAO_Conexao.con);
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

        public MySqlDataReader buscaTurma()
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
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade=" + modalidade + " AND DiaSemana like '" + dia_semana + "'", DAO_Conexao.con);
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
