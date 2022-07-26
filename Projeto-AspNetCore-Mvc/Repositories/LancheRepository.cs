using Microsoft.EntityFrameworkCore;
using Projeto_AspNetCore_Mvc.Context;
using Projeto_AspNetCore_Mvc.Models;
using Projeto_AspNetCore_Mvc.Repositories.Interfaces;

namespace Projeto_AspNetCore_Mvc.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)   
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
