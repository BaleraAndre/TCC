using Folha_Pagamento.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_Pagamento.DataAcessObject
{
    public class OperacaoDAO
    {
        public static bool InserirOperacao(Operacao operacao)
        {

            SqlConnection connection = ConexaoBD.ConexaoBD.obterConexao();

            try
            {
                connection.Open();

                string sql = @"INSERT INTO operacoes (nome_operacao,condicao,tipo) 
                               VALUES (@nome_operacao, @condicao, @tipo)"
                ;

                SqlCommand command = new SqlCommand(sql, connection);

                // Adicionar os parâmetros com os valores do funcionário
                command.Parameters.AddWithValue("@nome_operacao", operacao.Nome_Operacao);
                command.Parameters.AddWithValue("@condicao", operacao.Condicao);
                command.Parameters.AddWithValue("@tipo", operacao.Tipo);



                int inseriu = command.ExecuteNonQuery();

                if (inseriu > 0)
                {
                    MessageBox.Show("Operação inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Erro ao inserir o registro.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static List<Operacao> ObterTodos()
        {
            List<Operacao> lista = new List<Operacao>();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = "select * from operacoes;";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet operacoes = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(operacoes);

                foreach (DataRow row in operacoes.Tables[0].Rows)
                {
                    Operacao a = new Entidades.Operacao();
                    a.ID = int.Parse(row["ID"].ToString());
                    a.Nome_Operacao = row["nome_operacao"].ToString();
                    a.Condicao = row["condicao"].ToString();
                    a.Tipo = row["tipo"].ToString();
                   

                    lista.Add(a);


                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            return lista;
        }







    }
}
