using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers
{
    public class BibliotecaController : Controller
    {
        private List<Livro> livros = new List<Livro>
        {
            new Livro { Id = 1, Titulo = "Harry Potter", Autor = "J.K. Rowling", Ano = 1997, Disponivel = true },
            new Livro { Id = 2, Titulo = "Sherlock Holmes", Autor = "Arthur Conan Doyle", Ano = 1887, Disponivel = true },
            new Livro { Id = 3, Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", Ano = 1937, Disponivel = false },
            new Livro { Id = 4, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Ano = 1899, Disponivel = true },
            new Livro { Id = 5, Titulo = "1984", Autor = "George Orwell", Ano = 1949, Disponivel = false },
            new Livro { Id = 6, Titulo = "O Pequeno Príncipe", Autor = "Saint-Exupéry", Ano = 1943, Disponivel = true },
            new Livro { Id = 7, Titulo = "Percy Jackson", Autor = "Rick Riordan", Ano = 2005, Disponivel = true },
            new Livro { Id = 8, Titulo = "It", Autor = "Stephen King", Ano = 1986, Disponivel = false },
            new Livro { Id = 9, Titulo = "O Código Da Vinci", Autor = "Dan Brown", Ano = 2003, Disponivel = true },
            new Livro { Id = 10, Titulo = "As Crônicas de Nárnia", Autor = "C.S. Lewis", Ano = 1950, Disponivel = false }
        };

        public IActionResult Index()
        {
            return View(livros);
        }

        public IActionResult Disponiveis()
        {
            return View(livros.Where(l => l.Disponivel).ToList());
        }
    }
}