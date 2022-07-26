using Projeto_AspNetCore_Mvc.Models;

namespace Projeto_AspNetCore_Mvc.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
