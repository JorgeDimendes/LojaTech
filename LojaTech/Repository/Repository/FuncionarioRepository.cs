using LojaTech.Data;
using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaTech.Repository;

public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
{
    public FuncionarioRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Funcionario> GetById(int id)
    {
        return await _entity
            .Include(c => c.Endereco)
            //.Include(c => c.Cargo)
            .AsNoTracking()
            .FirstOrDefaultAsync(f => f.Id == id);
    }
}