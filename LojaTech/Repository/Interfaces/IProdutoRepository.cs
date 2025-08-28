using LojaTech.Models;

namespace LojaTech.Repository.Interfaces;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<Produto> getId(int id);
}