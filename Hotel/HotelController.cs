using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quartos()
        {
            var quartos = new[]
            {
                new { Nome = "Standard", Capacidade = 2, Descricao = "Quarto simples", Valor = 180.00 },
                new { Nome = "Luxo", Capacidade = 3, Descricao = "Quarto confortável", Valor = 280.00 },
                new { Nome = "Suíte", Capacidade = 4, Descricao = "Quarto completo", Valor = 400.00 }
            };

            return View(quartos);
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}