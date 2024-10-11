using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NutriFlow.Connection
{
    internal class ConnectionObjetivo
    {
        public Connection Connection { get; private set; }
        public string ConnectionString { get; private set; }

        public ConnectionObjetivo()
        {
            Connection = new Connection();

            ConnectionString = Connection.ConnectionString;
        }

        public bool Insert(ObjectObjetivos objetivo)
        {
            {
                bool success = false;

                string query = "INSERT INTO METAS (EMAIL, HIDRATACAO, CONSUMO, EXERCICIO, PESO_ATUAL, PESO_DESEJADO, PERDA_PESO, GANHO_PESO, MELHORA_SONO, MELHORA_HIDRATACAO, MELHORA_ALIMENTACAO)" +
                    "VALUES (@EMAIL, @HIDRATACAO, @CONSUMO, @EXERCICIO, @PESO_ATUAL, @PESO_DESEJADO, @PERDA_PESO, @GANHO_PESO, @MELHORA_SONO, @MELHORA_HIDRATACAO, @MELHORA_ALIMENTACAO)";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", objetivo.Email);
                        command.Parameters.AddWithValue("@HIDRATACAO", objetivo.Hidratacao);
                        command.Parameters.AddWithValue("@CONSUMO", objetivo.Consumo);
                        command.Parameters.AddWithValue("@EXERCICIO", objetivo.Exercicio);
                        command.Parameters.AddWithValue("@PESO_ATUAL", objetivo.Peso_Atual);
                        command.Parameters.AddWithValue("@PESO_DESEJADO", objetivo.Peso_Desejado);
                        command.Parameters.AddWithValue("@PERDA_PESO", objetivo.Perda_Peso);
                        command.Parameters.AddWithValue("@GANHO_PESO", objetivo.Ganho_Peso);
                        command.Parameters.AddWithValue("@MELHORA_SONO", objetivo.Melhora_Sono);
                        command.Parameters.AddWithValue("@MELHORA_HIDRATACAO", objetivo.Hidratacao);
                        command.Parameters.AddWithValue("@MELHORA_ALIMENTACAO", objetivo.Melhora_Alimentacao);

                        int rowsAffected = command.ExecuteNonQuery();

                        success = rowsAffected > 0;
                    }
                }
                return success;
            }
        }

        public bool isObjetivoCadastrado(string email)
        {
            bool exists = false;

            string query = "SELECT COUNT(1) FROM METAS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EMAIL", email);

                    int count = (int)command.ExecuteScalar();

                    exists = count > 0;
                }
            }
            return exists;
        }

        internal ObjectObjetivos GetObjetivos(string email)
        {
            ObjectObjetivos objetivo = null;

            string query = "SELECT * FROM METAS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string hidratacao, consumo, exercicio, peso_atual, peso_desejado, perda_peso, ganho_peso, melhora_sono, melhora_hidratacao, melhora_consumo;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EMAIL", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hidratacao = reader["HIDRATACAO"].ToString();
                            consumo = reader["CONSUMO"].ToString();
                            exercicio = reader["EXERCICIO"].ToString();
                            peso_atual = reader["PESO_ATUAL"].ToString();
                            peso_desejado = reader["PESO_DESEJADO"].ToString();
                            perda_peso = reader["PERDA_PESO"].ToString();
                            ganho_peso = reader["GANHO_PESO"].ToString();
                            melhora_sono = reader["MELHORA_SONO"].ToString();
                            melhora_hidratacao = reader["MELHORA_HIDRATACAO"].ToString();
                            melhora_consumo = reader["MELHORA_ALIMENTACAO"].ToString();

                            objetivo = new ObjectObjetivos(email, hidratacao, consumo, exercicio, peso_atual, peso_desejado, perda_peso, ganho_peso, melhora_sono, melhora_hidratacao, melhora_consumo);
                        }
                    }
                }
            }
            return objetivo;
        }

        internal bool AlteraObjetivo(ObjectObjetivos objetivos)
        {
            bool success = false;

            string query = @" UPDATE METAS 
            SET 
            HIDRATACAO = @HIDRATACAO,
            CONSUMO = @CONSUMO,
            EXERCICIO = @EXERCICIO,
            PESO_ATUAL = @PESO_ATUAL,
            PESO_DESEJADO = @PESO_DESEJADO,
            PERDA_PESO = @PERDA_PESO,
            GANHO_PESO = @GANHO_PESO,
            MELHORA_SONO = @MELHORA_SONO,
            MELHORA_HIDRATACAO = @MELHORA_HIDRATACAO,
            MELHORA_ALIMENTACAO = @MELHORA_ALIMENTACAO
            WHERE 
            EMAIL = @EMAIL";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", objetivos.Email);
                        command.Parameters.AddWithValue("@HIDRATACAO", objetivos.Hidratacao);
                        command.Parameters.AddWithValue("@CONSUMO", objetivos.Consumo);
                        command.Parameters.AddWithValue("@EXERCICIO", objetivos.Exercicio);
                        command.Parameters.AddWithValue("@PESO_ATUAL", objetivos.Peso_Atual);
                        command.Parameters.AddWithValue("@PESO_DESEJADO", objetivos.Peso_Desejado);
                        command.Parameters.AddWithValue("@PERDA_PESO", objetivos.Perda_Peso);
                        command.Parameters.AddWithValue("@GANHO_PESO", objetivos.Ganho_Peso);
                        command.Parameters.AddWithValue("@MELHORA_SONO", objetivos.Melhora_Sono);
                        command.Parameters.AddWithValue("@MELHORA_HIDRATACAO", objetivos.Melhora_Hidratacao);
                        command.Parameters.AddWithValue("@MELHORA_ALIMENTACAO", objetivos.Melhora_Alimentacao);

                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao atualizar objetivos no banco de dados.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao atualizar objetivos.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }
    }
}
