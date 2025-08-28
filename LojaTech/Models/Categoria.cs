namespace LojaTech.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;

    public IEnumerable<Produto>? Produtos { get; set; }
}