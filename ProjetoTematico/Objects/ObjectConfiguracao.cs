namespace NutriFlow.Objects
{
    internal class ObjectConfiguracao
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ObjectConfiguracao(string nome, string sobrenome, string genero, string email, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Genero = genero;
            Email = email;
            Senha = senha;
        }
    }
}
