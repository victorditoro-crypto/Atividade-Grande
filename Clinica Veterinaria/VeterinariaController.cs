using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;

namespace VeterinariaMVC.Controllers
{
    public class VeterinariaController : Controller
    {
        private List<Animal> animais = new List<Animal>
        {
            new Animal { Id = 1, Nome = "Rex", Especie = "Cachorro", Idade = 5, Dono = "João" },
            new Animal { Id = 2, Nome = "Mel", Especie = "Cachorro", Idade = 3, Dono = "Maria" },
            new Animal { Id = 3, Nome = "Nina", Especie = "Gato", Idade = 2, Dono = "Pedro" },
            new Animal { Id = 4, Nome = "Tom", Especie = "Gato", Idade = 4, Dono = "Ana" },
            new Animal { Id = 5, Nome = "Bob", Especie = "Cachorro", Idade = 7, Dono = "Carlos" },
            new Animal { Id = 6, Nome = "Luna", Especie = "Gato", Idade = 1, Dono = "Julia" },
            new Animal { Id = 7, Nome = "Thor", Especie = "Cachorro", Idade = 6, Dono = "Lucas" },
            new Animal { Id = 8, Nome = "Mia", Especie = "Gato", Idade = 3, Dono = "Beatriz" }
        };

        public IActionResult Index()
        {
            return View(animais);
        }

        public IActionResult Cachorros()
        {
            return View(animais.Where(a => a.Especie == "Cachorro").ToList());
        }

        public IActionResult Gatos()
        {
            return View(animais.Where(a => a.Especie == "Gato").ToList());
        }
    }
}