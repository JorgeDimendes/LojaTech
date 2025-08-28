namespace LojaTech.DTO.Categoria;

public class CategoriaProdutoDTO
{
    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}