namespace NutriFlow.Objects
{
    internal class ObjectObjetivos
    {
        public string Email { get; set; }
        public string Hidratacao { get; set; }
        public string Consumo { get; set; }
        public string Exercicio { get; set; }
        public string Peso_Atual { get; set; }
        public string Peso_Desejado { get; set; }
        public string Perda_Peso { get; set; }
        public string Ganho_Peso { get; set; }
        public string Melhora_Sono { get; set; }
        public string Melhora_Hidratacao { get; set; }
        public string Melhora_Alimentacao { get; set; }

        public ObjectObjetivos(string email, string hidratacao, string consumo, string exercicio, string peso_Atual, string peso_Desejado, string perda_Peso, string ganho_Peso, string melhora_Sono, string melhora_Hidratacao, string melhora_Alimentacao)
        {
            Email = email;
            Hidratacao = hidratacao;
            Consumo = consumo;
            Exercicio = exercicio;
            Peso_Atual = peso_Atual;
            Peso_Desejado = peso_Desejado;
            Perda_Peso = perda_Peso;
            Ganho_Peso = ganho_Peso;
            Melhora_Sono = melhora_Sono;
            Melhora_Hidratacao = melhora_Hidratacao;
            Melhora_Alimentacao = melhora_Alimentacao;
        }
    }
}
