using Microsoft.AspNetCore.Mvc;
using CursosMVC.Models;

namespace CursosMVC.Controllers
{
    public class CursoController : Controller
    {
        private List<Curso> cursos = new List<Curso>
        {
            new Curso { Id = 1, Nome = "C#", CargaHoraria = 40, Modalidade = "Online", Vagas = 10, Valor = 200 },
            new Curso { Id = 2, Nome = "HTML e CSS", CargaHoraria = 30, Modalidade = "Presencial", Vagas = 5, Valor = 150 },
            new Curso { Id = 3, Nome = "JavaScript", CargaHoraria = 40, Modalidade = "Online", Vagas = 0, Valor = 220 },
            new Curso { Id = 4, Nome = "Banco de Dados", CargaHoraria = 50, Modalidade = "Presencial", Vagas = 8, Valor = 250 },
            new Curso { Id = 5, Nome = "Python", CargaHoraria = 40, Modalidade = "Online", Vagas = 12, Valor = 200 },
            new Curso { Id = 6, Nome = "Excel", CargaHoraria = 20, Modalidade = "Presencial", Vagas = 0, Valor = 100 },
            new Curso { Id = 7, Nome = "Git e GitHub", CargaHoraria = 20, Modalidade = "Online", Vagas = 7, Valor = 120 },
            new Curso { Id = 8, Nome = "Redes", CargaHoraria = 50, Modalidade = "Presencial", Vagas = 4, Valor = 280 },
            new Curso { Id = 9, Nome = "Linux", CargaHoraria = 30, Modalidade = "Online", Vagas = 0, Valor = 180 },
            new Curso { Id = 10, Nome = "Programação Web", CargaHoraria = 60, Modalidade = "Presencial", Vagas = 6, Valor = 300 }
        };

        public IActionResult Index()
        {
            return View(cursos);
        }

        public IActionResult Disponiveis()
        {
            return View(cursos.Where(c => c.Vagas > 0).ToList());
        }

        public IActionResult Online()
        {
            return View(cursos.Where(c => c.Modalidade == "Online").ToList());
        }

        public IActionResult Presenciais()
        {
            return View(cursos.Where(c => c.Modalidade == "Presencial").ToList());
        }

        public IActionResult Resumo()
        {
            return View(cursos);
        }
    }
}