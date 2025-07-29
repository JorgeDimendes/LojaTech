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


        [JsonIgnore]
        public int? ClienteId { get; set; }
        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        [JsonIgnore]
        public int? FuncionarioId { get; set; }
        [JsonIgnore]
        public Funcionario? Funcionario { get; set; }
    }
}