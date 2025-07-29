using LojaTech.Data;
using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaTech.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Cliente?> GetId(int id)
        {
            return await _context.Clientes
                 .Include(c => c.Endereco)
                 .AsNoTracking()
                 //.FirstOrDefaultAsync(c => c.Id == id)!;
                 .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}