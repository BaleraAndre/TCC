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
    public class HoleriteDAO
    {
        public static List<Holerite> ObterTodos()
        {
            SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
            string sql = $"select * from holerite;";
            SqlCommand command = new SqlCommand(sql, conect);
            DataSet pessoas = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(pessoas);

            List<Holerite> listaHolerites = new List<Holerite>(); // Criar uma lista para armazenar os objetos Holerite

            foreach (DataRow row in pessoas.Tables[0].Rows)
            {
                Holerite holerite = new Holerite(); // Criar uma nova instância de Holerite para cada registro

                holerite.Id = int.Parse(row["id_holerite"].ToString());
                holerite.Id_Holerite = int.Parse(row["id_funcionario"].ToString());
                holerite.Inss = double.Parse(row["inss"].ToString());
                holerite.Fgts = double.Parse(row["fgts"].ToString());
                holerite.Data_Adimissao_Funcionario = DateTime.Parse(row["data_adimissao"].ToString());
                holerite.Mes_Ano_Pagamento = DateTime.Parse(row["mes_ano"].ToString());
                holerite.Salario_Liquido = double.Parse(row["salario_liquido"].ToString());
                holerite.Salario_Bruto = double.Parse(row["salario_bruto"].ToString());
                holerite.Desc_Dias = double.Parse(row["desc_dias"].ToString());
                holerite.Cargo = row["cargo"].ToString();
                holerite.Data_Emissao = DateTime.Parse(row["data_emissao"].ToString());
                holerite.Nome_Funcionario = row["nome_funcionario"].ToString();

                listaHolerites.Add(holerite); // Adicionar o objeto Holerite à lista
            }
            return listaHolerites;
        }
        public static Holerite BuscarPorNomeEData(string nome, DateTime data)
        {
            Holerite holerite = new Holerite();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = $"select * from holerite where nome_funcionario='{nome}' and data_emissao = '{data.ToShortDateString()}';";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet pessoas = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(pessoas);

                foreach (DataRow row in pessoas.Tables[0].Rows)
                {
                    holerite.Id = int.Parse(row["id_holerite"].ToString());
                    holerite.Id_Holerite = int.Parse(row["id_funcionario"].ToString());
                    holerite.Inss = double.Parse(row["inss"].ToString());
                    holerite.Fgts = double.Parse(row["fgts"].ToString());
                    holerite.Data_Adimissao_Funcionario = DateTime.Parse(row["data_adimissao"].ToString());
                    holerite.Mes_Ano_Pagamento = DateTime.Parse(row["mes_ano"].ToString());
                    holerite.Salario_Liquido = double.Parse(row["salario_liquido"].ToString());
                    holerite.Salario_Bruto = double.Parse(row["salario_bruto"].ToString());
                    holerite.Desc_Dias  = double.Parse(row["desc_dias"].ToString());
                    holerite.Cargo = row["cargo"].ToString();
                    holerite.Data_Emissao = DateTime.Parse(row["data_emissao"].ToString());
                    holerite.Nome_Funcionario = row["nome_funcionario"].ToString();




                }
                return holerite;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            return holerite;
        }



        public static bool InserirHolerite(Holerite holerite)
        {

            SqlConnection connection = ConexaoBD.ConexaoBD.obterConexao();

            try
            {
                connection.Open();

                string sql = @"INSERT INTO holerite (id_funcionario, nome_funcionario, cargo, desc_dias, salario_liquido, salario_bruto, inss, fgts, horas_trabalhadas,data_emissao,mes_ano,data_adimissao) 
                               VALUES (@IdFuncionario, @NomeFuncionario, @Cargo, @DescDias, @SalarioLiquido, @SalarioBruto, @Inss, @Fgts, @HorasTrabalhadas, @DataEmissao, @MesAno, @DataAdimissao)"
                ;

                SqlCommand command = new SqlCommand(sql, connection);

                // Adicionar os parâmetros com os valores do funcionário
                command.Parameters.AddWithValue("@IdFuncionario", holerite.Id);
                command.Parameters.AddWithValue("@NomeFuncionario", holerite.Nome_Funcionario);
                command.Parameters.AddWithValue("@Cargo", holerite.Cargo);
                command.Parameters.AddWithValue("@DescDias", holerite.Desc_Dias);
                command.Parameters.AddWithValue("@SalarioLiquido", holerite.Salario_Liquido);
                command.Parameters.AddWithValue("@SalarioBruto", holerite.Salario_Bruto);
                command.Parameters.AddWithValue("@Inss", holerite.Inss);
                command.Parameters.AddWithValue("@Fgts", holerite.Fgts);
                command.Parameters.AddWithValue("@HorasTrabalhadas", holerite.Horas_Trabalhadas);
                command.Parameters.AddWithValue("@DataEmissao", holerite.Data_Emissao);
                command.Parameters.AddWithValue("@MesAno", holerite.Mes_Ano_Pagamento);
                command.Parameters.AddWithValue("@DataAdimissao", holerite.Data_Adimissao_Funcionario);


                int inseriu = command.ExecuteNonQuery();

                if (inseriu > 0)
                {
                    MessageBox.Show("Holerite inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
