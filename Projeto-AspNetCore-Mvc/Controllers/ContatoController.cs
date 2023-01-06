using Microsoft.AspNetCore.Mvc;

namespace Projeto_AspNetCore_Mvc.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
