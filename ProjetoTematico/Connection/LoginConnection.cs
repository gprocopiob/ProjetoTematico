using NutriFlow.Connection;
using System.Data.SqlClient;

namespace ProjetoTematico.MSSQL
{
    internal class LoginConnection
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public LoginConnection()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool Login(string email, string senha)
        {
            bool loginSuccessful = false;

            if (ConnectionString != null)
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM CADASTRO WHERE EMAIL = @Email AND SENHA = @Senha";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    loginSuccessful = count > 0;
                }
            }
            return loginSuccessful;
        }
    }
}