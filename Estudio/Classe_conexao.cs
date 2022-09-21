using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Classe_conexao
    {
        private static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user ,String senha)
        {
            Boolean retorno = false;

            try
            {
                con = new MySqlConnection("server=" + local + "; User ID=" + user + ";" + "database=" + banco +"; password=" + senha + "; SslMode = none ");

                con.Open();
                retorno = true;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                con.Close();//ajustar
            }

            finally
            {
                con.Close();
            }

            return retorno;
        }
    }

   
}
