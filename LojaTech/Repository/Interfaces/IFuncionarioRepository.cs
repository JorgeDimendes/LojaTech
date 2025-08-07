using LojaTech.Models;

namespace LojaTech.Repository.Interfaces;

public interface IFuncionarioRepository : IRepository<Funcionario>
{
    Task<Funcionario> GetById(int id);
}