namespace LojaTech.Enum;

public class teste
{
    //public class Funcionario { public int Id { get; set; } public string Nome { get; set; } }
    public class Cliente { public int Id { get; set; } public string Nome { get; set; } public List<Venda> Vendas { get; set; } }
    public class Produto { public int Id { get; set; } public string Nome { get; set; } public decimal Preco { get; set; } public int CategoriaId { get; set; } public Categoria Categoria { get; set; } }
    public class Categoria { public int Id { get; set; } public string Nome { get; set; } public List<Produto> Produtos { get; set; } }
    public class Venda { public int Id { get; set; } public DateTime Data { get; set; } public int ClienteId { get; set; } public Cliente Cliente { get; set; } public List<ItemVenda> Itens { get; set; } public List<ServicoVenda> Servicos { get; set; } public decimal Total { get; set; } }
    public class ItemVenda { public int Id { get; set; } public int ProdutoId { get; set; } public Produto Produto { get; set; } public int Quantidade { get; set; } }
    public class ServicoVenda { public int Id { get; set; } public string Descricao { get; set; } public decimal Valor { get; set; } }
}