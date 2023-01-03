using Projeto_AspNetCore_Mvc.Models;

namespace Projeto_AspNetCore_Mvc.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
