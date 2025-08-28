using LojaTech.Models;

namespace LojaTech.Repository.Interfaces;

public interface ICategoriaRepository : IRepository<Categoria>
{
    Task<Categoria> ObterCategoriaPorId(int id);
}