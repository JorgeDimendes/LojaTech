using LojaTech.Models;

namespace LojaTech.Repository.Interfaces;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<Produto> filtroName(int id, string pesquisa);
}