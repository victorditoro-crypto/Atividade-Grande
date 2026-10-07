using Microsoft.AspNetCore.Mvc;

namespace CinemaMVC.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Filmes()
        {
            var filmes = new[]
            {
                new { Nome = "Interestelar", Genero = "Ficção", Classificacao = "10 anos", Horario = "18:00" },
                new { Nome = "Vingadores", Genero = "Ação", Classificacao = "12 anos", Horario = "19:30" },
                new { Nome = "Toy Story", Genero = "Animação", Classificacao = "Livre", Horario = "15:00" },
                new { Nome = "Batman", Genero = "Ação", Classificacao = "12 anos", Horario = "20:00" },
                new { Nome = "Jurassic Park", Genero = "Aventura", Classificacao = "12 anos", Horario = "21:00" }
            };

            return View(filmes);
        }

        public IActionResult Ingressos()
        {
            return View();
        }
    }
}