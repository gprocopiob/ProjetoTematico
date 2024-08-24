using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFlow.Connection
{
    internal class CadastroConnection
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public CadastroConnection()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool Insert(UserObject user)
        {
            {
                bool success = false;

                string query = "INSERT INTO CADASTRO (ID, NOME, SOBRENOME, GENERO, EMAIL, SENHA) VALUES (@id, @nome, @sobrenome, @genero, @email, @senha)";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
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

        public int GetLastID()
        {
            int id = 0;

            string query = "SELECT ISNULL(MAX(ID), 0) FROM CADASTRO";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    id = Convert.ToInt32(result);
                }
            }

            return id + 1;
        }
    }
}