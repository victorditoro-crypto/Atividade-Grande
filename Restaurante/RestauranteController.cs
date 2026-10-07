using Microsoft.AspNetCore.Mvc;

namespace RestauranteMVC.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            var pratos = new[]
            {
                new { Nome = "Arroz com Feijão", Preco = 25.00, Descricao = "Prato tradicional" },
                new { Nome = "Bife Acebolado", Preco = 35.00, Descricao = "Bife com cebola" },
                new { Nome = "Frango Grelhado", Preco = 30.00, Descricao = "Frango grelhado com arroz" },
                new { Nome = "Lasanha", Preco = 32.00, Descricao = "Lasanha de carne" },
                new { Nome = "Hambúrguer", Preco = 28.00, Descricao = "Hambúrguer artesanal" }
            };

            return View(pratos);
        }

        public IActionResult Bebidas()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}