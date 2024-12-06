using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFlow.Connection
{
    internal class ConnectionCadastro
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public ConnectionCadastro()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool Insert(ObjectUser user)
        {
            {
                bool success = false;

                string query = "INSERT INTO CADASTRO (NOME, SOBRENOME, GENERO, EMAIL, SENHA) VALUES (@nome, @sobrenome, @genero, @email, @senha)";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", user.Nome);
                        command.Parameters.AddWithValue("@sobrenome", user.Sobrenome);
                        command.Parameters.AddWithValue("@genero", user.Genero);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@senha", user.Senha);

                        int rowsAffected = command.ExecuteNonQuery();

                        success = rowsAffected > 0;
                    }
                }
                return success;
            }
        }

        public bool EmailExistente(string email)
        {
            bool existe = false;
            string query = "SELECT COUNT(*) FROM CADASTRO WHERE EMAIL = @Email";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    existe = count > 0;
                }
            }

            return existe;
        }
    }    
}