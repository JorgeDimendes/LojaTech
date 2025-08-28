using System.Text.Json.Serialization;

namespace LojaTech.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Numero { get; set; }
        
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public int? FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
    }
}