using System.Text.Json.Serialization;
using LojaTech.Enum;

namespace LojaTech.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public CargoEnum Cargo { get; set; }

        //Relacionamento
        public Endereco? Endereco { get; set; }
    }
}