using Microsoft.AspNetCore.Mvc;

namespace Atividade.Escola
{
    public class EscolaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cursos()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}