using Microsoft.AspNetCore.Mvc;
using CatalogoMVC.Models;

namespace CatalogoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Arroz", Categoria = "Alimentos", Estoque = 10, Preco = 25 },
            new Produto { Id = 2, Nome = "Feijão", Categoria = "Alimentos", Estoque = 8, Preco = 9 },
            new Produto { Id = 3, Nome = "Caderno", Categoria = "Papelaria", Estoque = 0, Preco = 15 },
            new Produto { Id = 4, Nome = "Caneta", Categoria = "Papelaria", Estoque = 20, Preco = 3 },
            new Produto { Id = 5, Nome = "Mochila", Categoria = "Papelaria", Estoque = 5, Preco = 80 },
            new Produto { Id = 6, Nome = "Leite", Categoria = "Alimentos", Estoque = 12, Preco = 6 },
            new Produto { Id = 7, Nome = "Biscoito", Categoria = "Alimentos", Estoque = 15, Preco = 5 },
            new Produto { Id = 8, Nome = "Lápis", Categoria = "Papelaria", Estoque = 30, Preco = 2 },
            new Produto { Id = 9, Nome = "Suco", Categoria = "Bebidas", Estoque = 0, Preco = 7 },
            new Produto { Id = 10, Nome = "Água", Categoria = "Bebidas", Estoque = 25, Preco = 4 }
        };

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Disponiveis()
        {
            var lista = produtos.Where(p => p.Estoque > 0).ToList();
            return View(lista);
        }
    }
}