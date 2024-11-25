namespace NutriFlow.Objects
{
    public class ObjectUser
    {
        public string Nome { get; set; }
        public string Sobrenome {  get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ObjectUser(string name, string sobrenome, string genero, string email, string senha)
        {
            this.Nome = name;
            this.Sobrenome = sobrenome;
            this.Genero = genero;
            this.Email = email;
            this.Senha = senha;
        }
    }
}
