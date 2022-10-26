using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string endereco;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;
        private string text;

        public Aluno()
        {

        }
        public Aluno(string text)
        {
            this.text = text;
        }

        public Aluno(string cpf, string nome, string endereco, string bairro, string complemento,
        string cep, string cidade, string estado, string telefone, string email, string numero)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201281", "cl201281", "cl*15022006");
            setCPF(cpf);
            setNome(nome);
            setEndereco(endereco);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setNumero(numero);

        }

        private void setNumero(string numero)
        {
            this.Numero = numero;
        }
        public String getNumero()
        {
            return this.Numero;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;

        }

        public string getEstado()
        {
            return this.Estado;
        }

        public void setCep(string cep)
        {
            this.CEP = cep;

        }

        public string getCep()
        {
            return this.CEP;
        }

        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;

        }

        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getEndereco()
        {
            return this.endereco;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }


       
        // public bool verificaCPF() //string CPF - sem parâmetro

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }
        
        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno,nomeAluno,ruaAluno, numeroAluno,bairroAluno,complementoAluno,CEPAluno,cidadeAluno,estadoAluno,telefoneAluno)" 
                    + "values(''" + CPF + "'," + Nome + "','" + endereco + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * From Estudio_Aluno" + " WHERE CPfAluno='" + CPF + "'", DAO_Conexao.con);
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
        public bool ExcluirAluno()
        {
            bool exc = false;
            try
            {
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno se ativo" + "= 1 where CPFAluno ='" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
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
