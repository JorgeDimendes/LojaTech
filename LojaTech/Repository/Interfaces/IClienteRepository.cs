using LojaTech.Models;

namespace LojaTech.Repository.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente?> GetId(int id);
    }
}