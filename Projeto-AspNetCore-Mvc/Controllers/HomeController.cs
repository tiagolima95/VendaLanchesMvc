using Microsoft.AspNetCore.Mvc;
using Projeto_AspNetCore_Mvc.Models;
using Projeto_AspNetCore_Mvc.Repositories.Interfaces;
using Projeto_AspNetCore_Mvc.ViewModels;
using System.Diagnostics;

namespace Projeto_AspNetCore_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.LanchesPreferidos = _lancheRepository.LanchesPreferidos;
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}