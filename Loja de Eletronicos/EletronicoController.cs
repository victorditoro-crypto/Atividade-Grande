using Microsoft.AspNetCore.Mvc;
using EletronicosMVC.Models;

namespace EletronicosMVC.Controllers
{
    public class EletronicoController : Controller
    {
        private List<Eletronico> produtos = new List<Eletronico>
        {
            new Eletronico { Id = 1, Nome = "Notebook", Marca = "Dell", Categoria = "Computador", Preco = 3500, Estoque = 5 },
            new Eletronico { Id = 2, Nome = "Celular", Marca = "Samsung", Categoria = "Celular", Preco = 1800, Estoque = 8 },
            new Eletronico { Id = 3, Nome = "TV", Marca = "LG", Categoria = "Televisão", Preco = 2500, Estoque = 3 },
            new Eletronico { Id = 4, Nome = "Mouse", Marca = "Logitech", Categoria = "Acessório", Preco = 100, Estoque = 15 },
            new Eletronico { Id = 5, Nome = "Teclado", Marca = "Redragon", Categoria = "Acessório", Preco = 200, Estoque = 10 },
            new Eletronico { Id = 6, Nome = "Monitor", Marca = "AOC", Categoria = "Computador", Preco = 900, Estoque = 4 },
            new Eletronico { Id = 7, Nome = "Tablet", Marca = "Lenovo", Categoria = "Tablet", Preco = 1200, Estoque = 6 },
            new Eletronico { Id = 8, Nome = "Fone", Marca = "JBL", Categoria = "Acessório", Preco = 300, Estoque = 0 },
            new Eletronico { Id = 9, Nome = "Impressora", Marca = "HP", Categoria = "Impressora", Preco = 700, Estoque = 2 },
            new Eletronico { Id = 10, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4000, Estoque = 1 },
            new Eletronico { Id = 11, Nome = "Webcam", Marca = "Logitech", Categoria = "Acessório", Preco = 250, Estoque = 7 },
            new Eletronico { Id = 12, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Relógio", Preco = 500, Estoque = 9 }
        };

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult EmEstoque()
        {
            return View(produtos.Where(p => p.Estoque > 0).ToList());
        }

        public IActionResult Categoria(string nome)
        {
            var lista = produtos.Where(p => p.Categoria == nome).ToList();
            return View(lista);
        }

        public IActionResult AbaixoDe(double valor = 1000)
        {
            var lista = produtos.Where(p => p.Preco < valor).ToList();
            return View(lista);
        }
    }
}