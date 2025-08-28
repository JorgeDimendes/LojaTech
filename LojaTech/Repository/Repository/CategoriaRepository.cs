using LojaTech.Data;
using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaTech.Repository;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Categoria> ObterCategoriaPorId(int id)
    {
        return await _entity
            .Include(c => c.Produtos)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}