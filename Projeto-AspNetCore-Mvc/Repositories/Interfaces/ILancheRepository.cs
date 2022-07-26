using Projeto_AspNetCore_Mvc.Models;

namespace Projeto_AspNetCore_Mvc.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get;}
        Lanche GetLancheById(int lancheId);
    }
}
