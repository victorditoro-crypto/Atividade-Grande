using Microsoft.AspNetCore.Mvc;
using NotasMVC.Models;

namespace NotasMVC.Controllers
{
    public class AlunoController : Controller
    {
        private List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "João", Curso = "Informática", Nota1 = 8, Nota2 = 7, Nota3 = 9 },
            new Aluno { Id = 2, Nome = "Maria", Curso = "Administração", Nota1 = 5, Nota2 = 5, Nota3 = 4 },
            new Aluno { Id = 3, Nome = "Pedro", Curso = "Informática", Nota1 = 3, Nota2 = 2, Nota3 = 4 },
            new Aluno { Id = 4, Nome = "Ana", Curso = "Mecânica", Nota1 = 9, Nota2 = 8, Nota3 = 7 },
            new Aluno { Id = 5, Nome = "Lucas", Curso = "Eletrônica", Nota1 = 6, Nota2 = 6, Nota3 = 6 },
            new Aluno { Id = 6, Nome = "Julia", Curso = "Administração", Nota1 = 2, Nota2 = 3, Nota3 = 3 },
            new Aluno { Id = 7, Nome = "Carlos", Curso = "Informática", Nota1 = 7, Nota2 = 8, Nota3 = 7 },
            new Aluno { Id = 8, Nome = "Beatriz", Curso = "Mecânica", Nota1 = 5, Nota2 = 4, Nota3 = 5 },
            new Aluno { Id = 9, Nome = "Rafael", Curso = "Eletrônica", Nota1 = 9, Nota2 = 9, Nota3 = 8 },
            new Aluno { Id = 10, Nome = "Larissa", Curso = "Informática", Nota1 = 3, Nota2 = 3, Nota3 = 2 }
        };

        public IActionResult Index()
        {
            return View(alunos);
        }

        public IActionResult Aprovados()
        {
            return View(alunos.Where(a => a.Media >= 6).ToList());
        }

        public IActionResult Recuperacao()
        {
            return View(alunos.Where(a => a.Media >= 4 && a.Media < 6).ToList());
        }

        public IActionResult Reprovados()
        {
            return View(alunos.Where(a => a.Media < 4).ToList());
        }
    }
}