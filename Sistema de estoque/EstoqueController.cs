using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;

namespace EstoqueMVC.Controllers
{
    public class EstoqueController : Controller
    {
        private List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Arroz", Categoria = "Alimento", Estoque = 0, EstoqueMinimo = 5, Preco = 25 },
            new Produto { Id = 2, Nome = "Feijão", Categoria = "Alimento", Estoque = 3, EstoqueMinimo = 5, Preco = 9 },
            new Produto { Id = 3, Nome = "Macarrão", Categoria = "Alimento", Estoque = 10, EstoqueMinimo = 5, Preco = 6 },
            new Produto { Id = 4, Nome = "Açúcar", Categoria = "Alimento", Estoque = 2, EstoqueMinimo = 4, Preco = 5 },
            new Produto { Id = 5, Nome = "Café", Categoria = "Alimento", Estoque = 0, EstoqueMinimo = 3, Preco = 15 },
            new Produto { Id = 6, Nome = "Leite", Categoria = "Bebida", Estoque = 12, EstoqueMinimo = 5, Preco = 6 },
            new Produto { Id = 7, Nome = "Suco", Categoria = "Bebida", Estoque = 4, EstoqueMinimo = 5, Preco = 7 },
            new Produto { Id = 8, Nome = "Água", Categoria = "Bebida", Estoque = 20, EstoqueMinimo = 5, Preco = 4 },
            new Produto { Id = 9, Nome = "Sabão", Categoria = "Limpeza", Estoque = 0, EstoqueMinimo = 4, Preco = 8 },
            new Produto { Id = 10, Nome = "Detergente", Categoria = "Limpeza", Estoque = 3, EstoqueMinimo = 5, Preco = 4 },
            new Produto { Id = 11, Nome = "Esponja", Categoria = "Limpeza", Estoque = 15, EstoqueMinimo = 5, Preco = 3 },
            new Produto { Id = 12, Nome = "Papel", Categoria = "Papelaria", Estoque = 8, EstoqueMinimo = 5, Preco = 10 },
            new Produto { Id = 13, Nome = "Caneta", Categoria = "Papelaria", Estoque = 2, EstoqueMinimo = 5, Preco = 3 },
            new Produto { Id = 14, Nome = "Caderno", Categoria = "Papelaria", Estoque = 0, EstoqueMinimo = 3, Preco = 15 },
            new Produto { Id = 15, Nome = "Lápis", Categoria = "Papelaria", Estoque = 20, EstoqueMinimo = 5, Preco = 2 }
        };

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Baixo()
        {
            return View(produtos.Where(p => p.Estoque > 0 && p.Estoque <= p.EstoqueMinimo).ToList());
        }

        public IActionResult Esgotados()
        {
            return View(produtos.Where(p => p.Estoque == 0).ToList());
        }

        public IActionResult Alertas()
        {
            return View(produtos.Where(p => p.Estoque <= p.EstoqueMinimo).ToList());
        }
    }
}