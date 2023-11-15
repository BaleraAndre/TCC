using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Folha_Pagamento.ConexaoBD
{
    public static class ConexaoBD
    {

        public static SqlConnection obterConexao()
        {
            // SqlServerConnection conect = new SqlServerConnection();
            string connectionString = "Server=DESKTOP-3D9K1GE;Database=pim;User Id=sa;Password=123456;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return connection;

            }
            finally
            {
                connection.Close();
            }
        }

    }
}
