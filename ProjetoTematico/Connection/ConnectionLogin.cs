using NutriFlow.Connection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.MSSQL
{
    internal class ConnectionLogin
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public ConnectionLogin()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool Login(string email, string senha)
        {
            bool loginSuccessful = false;

            if (ConnectionString != null)
            {

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM CADASTRO WHERE Email = @Email AND Senha = @Senha";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email.ToUpper());
                    cmd.Parameters.AddWithValue("@senha", senha);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    loginSuccessful = count > 0;
                }
            }
            return loginSuccessful;
        }
    }
}