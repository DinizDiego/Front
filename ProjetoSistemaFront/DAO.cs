using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoSistemaFront
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=ti18nn;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\nAlgo deu errado!");
                conexao.Close();
                throw;
            }//fim do catch
        }//Fim da DAO

        public void inserir(int codigo, string nome, string telefone, string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into = pessoa(codigo, nome, telefone, cidade, estado) values " + dados;

            try
            { 
                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara o comando no banco
                MessageBox.Show("Um dado inserido!" + conn.ExecuteNonQuery() + "Dado inserido!");
            }catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);

            }//fim do try catch
        }//fim do método


    }//Fim da classe
}//Fim do projeto
