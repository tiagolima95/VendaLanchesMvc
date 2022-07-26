using Microsoft.AspNetCore.Mvc;
using Projeto_AspNetCore_Mvc.Repositories.Interfaces;

namespace Projeto_AspNetCore_Mvc.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        
        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
