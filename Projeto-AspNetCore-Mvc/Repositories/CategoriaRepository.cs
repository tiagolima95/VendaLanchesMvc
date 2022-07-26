using Projeto_AspNetCore_Mvc.Context;
using Projeto_AspNetCore_Mvc.Models;
using Projeto_AspNetCore_Mvc.Repositories.Interfaces;

namespace Projeto_AspNetCore_Mvc.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
