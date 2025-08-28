using Newtonsoft.Json;

namespace LojaTech.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }

        //Relacionamento
        public Endereco? Endereco { get; set; }
        public IEnumerable<Venda>? Vendas { get; set; }
    }
}