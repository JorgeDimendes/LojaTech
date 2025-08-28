using System.Text.Json.Serialization;

namespace LojaTech.Models;

public class Venda
{
    public int Id { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; } = new DateTime();
    
    //Cliente
    public int? ClienteId { get; set; }
    public Cliente? Cliente { get; set; } 

    public IEnumerable<ItemVenda>? ItensVenda { get; set; }
    public IEnumerable<ServicoVenda>? ItensServico { get; set; }
}