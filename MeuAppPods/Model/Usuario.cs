using SQLite;

namespace MeuAppPods.Model
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public string DataNasc { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
