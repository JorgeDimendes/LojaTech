using LojaTech.Data;
using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaTech.Repository;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Produto> filtroName(int id, string pesquisa)
    {
        return await _entity
            .Include(c => c.Id == id)
            .FirstOrDefaultAsync(c => c.Nome == pesquisa);
    }
}