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
    public static class CargoDAO
    {
        public static Cargo ObterPorNome(string nome)
        {
            Cargo a = new Entidades.Cargo();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = $"select * from cargos where nome_cargo='{nome}';";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet cargos = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(cargos);

                foreach (DataRow row in cargos.Tables[0].Rows)
                {
                    
                    a.ID = int.Parse(row["id"].ToString());
                    a.Nome_Cargo = row["nome_cargo"].ToString();
                    a.Carga_Horaria = double.Parse(row["carga_horaria"].ToString());
                    a.Salario_Bruto = decimal.Parse(row["salario_bruto"].ToString());
                    return a;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            return a;
        }

        public static bool InserirCargo(Cargo cargo)
        {

            SqlConnection connection = ConexaoBD.ConexaoBD.obterConexao();

            try
            {
                connection.Open();

                string sql = @"INSERT INTO cargos (nome_cargo,carga_horaria,salario_bruto) 
                               VALUES (@nome_cargo, @carga_horaria, @salario_bruto)"
                ;

                SqlCommand command = new SqlCommand(sql, connection);

                // Adicionar os parâmetros com os valores do funcionário
                command.Parameters.AddWithValue("@nome_cargo", cargo.Nome_Cargo);
                command.Parameters.AddWithValue("@carga_horaria", cargo.Carga_Horaria);
                command.Parameters.AddWithValue("@salario_bruto", cargo.Salario_Bruto);
                
               

                int inseriu = command.ExecuteNonQuery();

                if (inseriu > 0)
                {
                    MessageBox.Show("Cargo inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static List<Cargo> ObterTodos()
        {
            List<Cargo> lista = new List<Cargo>();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = "select * from cargos;";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet cargos = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(cargos);

                foreach (DataRow row in cargos.Tables[0].Rows)
                {
                    Cargo a = new Entidades.Cargo();
                    a.ID = int.Parse(row["id"].ToString());
                    a.Nome_Cargo = row["nome_cargo"].ToString();
                    a.Carga_Horaria = double.Parse(row["carga_horaria"].ToString());
                    a.Salario_Bruto = Decimal.Parse(row["salario_bruto"].ToString());
                    

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
