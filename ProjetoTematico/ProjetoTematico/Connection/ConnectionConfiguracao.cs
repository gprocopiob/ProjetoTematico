using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFlow.Connection
{
    internal class ConnectionConfiguracao
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public ConnectionConfiguracao()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool UpdateDados(ObjectConfiguracao configuracao)
        {
            bool success = false;

            string query = @" UPDATE CADASTRO 
            SET 
            NOME = @NOME,
            SOBRENOME = @SOBRENOME,
            GENERO = @GENERO,
            SENHA = @SENHA
            WHERE 
            EMAIL = @EMAIL";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", configuracao.Email);
                        command.Parameters.AddWithValue("@NOME", configuracao.Nome);
                        command.Parameters.AddWithValue("@SOBRENOME", configuracao.Sobrenome);
                        command.Parameters.AddWithValue("@GENERO", configuracao.Genero);
                        command.Parameters.AddWithValue("@SENHA", configuracao.Senha);

                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao atualizar cadastro no banco de dados.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao atualizar cadastro.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }

        public ObjectConfiguracao GetUser(string email)
        {
            ObjectConfiguracao configuracao = null;

            string query = @"SELECT 
                        NOME, 
                        SOBRENOME, 
                        GENERO, 
                        SENHA 
                     FROM CADASTRO 
                     WHERE EMAIL = @EMAIL";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", email);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                configuracao = new ObjectConfiguracao(reader["NOME"].ToString(),reader["SOBRENOME"].ToString(),reader["GENERO"].ToString(), email,reader["SENHA"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao obter configurações de perfil.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao obter ao obter configurações de perfil.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return configuracao;
        }
    }
}
