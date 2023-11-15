using Folha_Pagamento.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Folha_Pagamento.DataAcessObject
{
    public class FuncionarioDAO
    {

        public static bool InserirFuncionario(Funcionario funcionario)
        {

            SqlConnection connection = ConexaoBD.ConexaoBD.obterConexao();

            try
            {
                connection.Open();

                string sql = @"INSERT INTO funcionarios (nome_completo, email, telefone, cpf, rg, orgao_emissor, nome_mae, nome_pai, data_admissao, cargo, pis, estado_civil, grau_escolaridade, regime_trabalhista, data_nascimento, raca, sexo, pais_origem, senha, cep, endereco, numero, complemento, bairro, cidade) 
                               VALUES (@NomeCompleto, @Email, @Telefone, @CPF, @RG, @OrgaoEmissor, @NomeMae, @NomePai, @DataAdmissao, @Cargo, @PIS, @EstadoCivil, @GrauEscolaridade, @RegimeTrabalhista, @DataNascimento, @Raca, @Sexo, @PaisOrigem, @Senha, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @Cidade)"
                ;

                SqlCommand command = new SqlCommand(sql, connection);

                // Adicionar os parâmetros com os valores do funcionário
                command.Parameters.AddWithValue("@NomeCompleto", funcionario.Nome_Completo);
                command.Parameters.AddWithValue("@Email", funcionario.Email);
                command.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                command.Parameters.AddWithValue("@CPF", funcionario.CPF);
                command.Parameters.AddWithValue("@RG", funcionario.RG);
                command.Parameters.AddWithValue("@OrgaoEmissor", funcionario.Orgao_Emissor);
                command.Parameters.AddWithValue("@NomeMae", funcionario.Nome_Mae);
                command.Parameters.AddWithValue("@NomePai", funcionario.Nome_Pai);
                command.Parameters.AddWithValue("@DataAdmissao", funcionario.Data_Admissao);
                command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                command.Parameters.AddWithValue("@PIS", funcionario.Pis);
                command.Parameters.AddWithValue("@EstadoCivil", funcionario.Estado_Civil);
                command.Parameters.AddWithValue("@GrauEscolaridade", funcionario.Grau_Escolaridade);
                command.Parameters.AddWithValue("@RegimeTrabalhista", funcionario.Regime_Trabalhista);
                command.Parameters.AddWithValue("@DataNascimento", funcionario.Data_Nascimento);
                command.Parameters.AddWithValue("@Raca", funcionario.Raca);
                command.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
                command.Parameters.AddWithValue("@PaisOrigem", funcionario.Pais_Origem);
                command.Parameters.AddWithValue("@Senha", funcionario.Senha);
                command.Parameters.AddWithValue("@CEP", funcionario.CEP);
                command.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
                command.Parameters.AddWithValue("@Numero", funcionario.Numero);
                command.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
                command.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
                command.Parameters.AddWithValue("@Cidade", funcionario.Cidade);

                int inseriu = command.ExecuteNonQuery();

                if (inseriu > 0)
                {
                    MessageBox.Show("Funcionário inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        public static Funcionario ObterPorNome(string nome)
        {
            Funcionario a = new Funcionario();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = $"select * from funcionarios where nome_completo='{nome}';";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet pessoas = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(pessoas);

                foreach (DataRow row in pessoas.Tables[0].Rows)
                {
                    // Funcionario a = new Entidades.Funcionario();
                    a.ID = int.Parse(row["ID"].ToString());
                    a.Nome_Completo = row["nome_completo"].ToString();
                    a.Email = row["email"].ToString();
                    a.Telefone = row["telefone"].ToString();
                    a.CPF = row["cpf"].ToString();
                    a.RG = row["rg"].ToString();
                    a.Orgao_Emissor = row["orgao_emissor"].ToString();
                    a.Nome_Mae = row["nome_mae"].ToString();
                    a.Nome_Pai = row["nome_pai"].ToString();
                    a.Data_Admissao = row["data_admissao"].ToString();
                    a.Cargo = row["cargo"].ToString();
                    a.Pis = row["pis"].ToString();
                    a.Estado_Civil = row["estado_civil"].ToString();
                    a.Grau_Escolaridade = row["grau_escolaridade"].ToString();
                    a.Regime_Trabalhista = row["regime_trabalhista"].ToString();
                    a.Data_Nascimento = row["data_nascimento"].ToString();
                    a.Raca = row["raca"].ToString();
                    a.Sexo = row["sexo"].ToString();
                    a.Pais_Origem = row["pais_origem"].ToString();
                    a.Senha = row["senha"].ToString();
                    a.CEP = row["cep"].ToString();
                    a.Endereco = row["endereco"].ToString();
                    a.Numero = row["numero"].ToString();
                    a.Complemento = row["complemento"].ToString();
                    a.Bairro = row["bairro"].ToString();
                    a.Cidade = row["cidade"].ToString();




                }
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            return a;
        }

        public static void RemoverRegistro(string nome)
        {
            SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
            string sql = $"DELETE FROM funcionarios WHERE nome_completo = '{nome}';";
            

            SqlCommand command = new SqlCommand(sql, conect);
            int removeu = command.ExecuteNonQuery();
            if (removeu > 0)
            {
                MessageBox.Show("Registro removido");
            }
            else
            {
                MessageBox.Show("Erro ao remover o registro");
            }


        }








        public static List<Funcionario> ObterTodos()
        {
            List<Funcionario> lista = new List<Funcionario>();
            try
            {
                SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
                string sql = "select * from funcionarios;";

                SqlCommand command = new SqlCommand(sql, conect);
                DataSet pessoas = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(pessoas);

                foreach (DataRow row in pessoas.Tables[0].Rows)
                {
                    Funcionario a = new Entidades.Funcionario();
                    a.ID = int.Parse(row["ID"].ToString());
                    a.Nome_Completo = row["nome_completo"].ToString();
                    a.Email = row["email"].ToString();
                    a.Telefone = row["telefone"].ToString();
                    a.CPF = row["cpf"].ToString();
                    a.RG = row["rg"].ToString();
                    a.Orgao_Emissor = row["orgao_emissor"].ToString();
                    a.Nome_Mae = row["nome_mae"].ToString();
                    a.Nome_Pai = row["nome_pai"].ToString();
                    a.Data_Admissao = row["data_admissao"].ToString();
                    a.Cargo = row["cargo"].ToString();
                    a.Pis = row["pis"].ToString();
                    a.Estado_Civil = row["estado_civil"].ToString();
                    a.Grau_Escolaridade = row["grau_escolaridade"].ToString();
                    a.Regime_Trabalhista = row["regime_trabalhista"].ToString();
                    a.Data_Nascimento = row["data_nascimento"].ToString();
                    a.Raca = row["raca"].ToString();
                    a.Sexo = row["sexo"].ToString();
                    a.Pais_Origem = row["pais_origem"].ToString();
                    a.Senha = row["senha"].ToString();
                    a.CEP = row["cep"].ToString();
                    a.Endereco = row["endereco"].ToString();
                    a.Numero = row["numero"].ToString();
                    a.Complemento = row["complemento"].ToString();
                    a.Bairro = row["bairro"].ToString();
                    a.Cidade = row["cidade"].ToString();

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




/* List<Funcionario> lista = new List<Funcionario>();




    // Consulta SQL parametrizada
    string sqlQuery = "SELECT ID, nome_completo, email, telefone, cpf, rg, orgao_emissor, nome_mae, nome_pai, data_admissao, cargo, pis, estado_civil, grau_escolaridade, regime_trabalhista, data_nascimento, raca, sexo, pais_origem, senha, cep, endereco, numero, complemento, bairro, cidade FROM funcionarios;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
       
            connection.Open();

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable pessoas = new DataTable();
                    adapter.Fill(pessoas);

                    foreach (DataRow row in pessoas.Rows)
                    {
                        Funcionario a = new Funcionario();
                        a.ID = Convert.ToInt32(row["ID"]);
                        a.Nome_Completo = row["nome_completo"].ToString();
                        a.Email = row["email"].ToString();
                        a.Telefone = row["telefone"].ToString();
                        a.CPF = row["cpf"].ToString();
                        a.RG = row["rg"].ToString();
                        a.Orgao_Emissor = row["orgao_emissor"].ToString();
                        a.Nome_Mae = row["nome_mae"].ToString();
                        a.Nome_Pai = row["nome_pai"].ToString();
                        a.Data_Admissao = row["data_admissao"].ToString();
                        a.Cargo = row["cargo"].ToString();
                        a.Pis = row["pis"].ToString();
                        a.Estado_Civil = row["estado_civil"].ToString();
                        a.Grau_Escolaridade = row["grau_escolaridade"].ToString();
                        a.Regime_Trabalhista = row["regime_trabalhista"].ToString();
                        a.Data_Nascimento = row["data_nascimento"].ToString();
                        a.Raca = row["raca"].ToString();
                        a.Sexo = row["sexo"].ToString();
                        a.Pais_Origem = row["pais_origem"].ToString();
                        a.Senha = row["senha"].ToString();
                        a.CEP = row["cep"].ToString();
                        a.Endereco = row["endereco"].ToString();
                        a.Numero = row["numero"].ToString();
                        a.Complemento = row["complemento"].ToString();
                        a.Bairro = row["bairro"].ToString();
                        a.Cidade = row["cidade"].ToString();

                        lista.Add(a);
                    }
                }
            }
        }
        
    }

    return lista;
}
}*/






/*public static Funcionario ObterPorNome(string nome)
{
    SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
    string sql = $"select * from funcionario where nome='{nome}';";
    SqlCommand command = new SqlCommand(sql, conect);
    SqlDataAdapter adapter = new SqlDataAdapter(command);
    DataSet data = new DataSet();
    adapter.Fill(data);
    Funcionario funcionario = new Folha_Pagamento.Entidades.Funcionario();
    foreach (DataRow row in data.Tables[0].Rows)
    {
        if (row["nome"].ToString() == nome)
        {
            funcionario.Id = int.Parse(row["id"].ToString());
            funcionario.Nome = row["nome"].ToString();
            funcionario.Cpf = row["cpf"].ToString();
            funcionario.Email = row["email"].ToString();
            funcionario.Salario = double.Parse(row["salario"].ToString());
            funcionario.Data_Registro = DateTime.Parse(row["data_registro"].ToString());
            return funcionario;

        }
        else
        {
            MessageBox.Show("funcionario nao lozalizado", "falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return funcionario;
        }

    }
    return funcionario;
}

public static bool RemoverFuncionario(string nome)
{
    SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
    string sql = $"delete from funcionario where nome='{nome}';";
    SqlCommand command = new SqlCommand(sql, conect);
    int removeu = command.ExecuteNonQuery();

    if (removeu > 0)
    {
        MessageBox.Show("funcionario removido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return true;
    }
    else
    {
        MessageBox.Show("Falha ao remover registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
    }

}

public static bool InserirFuncionario(Funcionario funcionario)
{

    SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
    string sql = $"insert into funcionario (nome_completo,email,telefone,cpf,rg,orgao_emissor,nome_mae,nome_pai,data_admissao,cargo,pis,estado_civil,grau_escolaridade" +
        $",regime_trabalhista, data_nascimento, raca, sexo, pais_origem, senha, endereco, numero, complemento, bairro, cidade) " +
        $"values('{funcionario.Nome_Completo}', '{funcionario.Email}', '{funcionario.Telefone}', '{funcionario.CPF}', '{funcionario.RG}', '{funcionario.Orgao_Emissor}'," +
        $"'{funcionario.Nome_Mae}', '{funcionario.Nome_Pai}', '{funcionario.Data_Admissao}','{funcionario.Cargo}', '{funcionario.Pis}', '{funcionario.Estado_Civil}', '{funcionario.Grau_Escolaridade}', '{funcionario.Regime_Trabalhista}', '{funcionario.Data_Nascimento}'," +
        $"'{funcionario.Raca}', '{funcionario.Sexo}','{funcionario.Pais_Origem}', '{funcionario.Senha}', '{funcionario.CEP}', '{funcionario.Endereco}', '{funcionario.Numero}', '{funcionario.Complemento}', '{funcionario.Bairro}', '{funcionario.Cidade}'); ";
;
    SqlCommand command = new SqlCommand(sql, conect);

    int inseriu = command.ExecuteNonQuery();

    if (inseriu > 0)
    {
        MessageBox.Show("Funcionario inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return true;
    }
    else
    {
        MessageBox.Show("Erro ao inserir o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
    }


}

public static bool EditarFuncionario(Funcionario funcionario, int id)
{
    string salario = funcionario.Salario.ToString().Replace(',', '.');
    SqlConnection conect = ConexaoBD.ConexaoBD.obterConexao();
    string sql = $"update funcionario set nome='{funcionario.Nome}',cpf='{funcionario.Cpf}',email='{funcionario.Email}',salario={salario.ToString()} where id='{id}';";
    SqlCommand command = new SqlCommand(sql, conect);

    int inseriu = command.ExecuteNonQuery();
    if (inseriu > 0)
    {
        MessageBox.Show("Registro editado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return true;
    }
    else
    {
        MessageBox.Show("Erro ao editar o registro", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
    }



}
}*/


