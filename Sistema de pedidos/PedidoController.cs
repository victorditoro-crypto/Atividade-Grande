using Microsoft.AspNetCore.Mvc;
using PedidosMVC.Models;

namespace PedidosMVC.Controllers
{
    public class PedidoController : Controller
    {
        private List<Pedido> pedidos = new List<Pedido>
        {
            new Pedido { Id = 1, Cliente = "João", Produto = "Pizza", Quantidade = 2, PrecoUnitario = 40, Status = "Recebido" },
            new Pedido { Id = 2, Cliente = "Maria", Produto = "Hambúrguer", Quantidade = 1, PrecoUnitario = 25, Status = "Em preparo" },
            new Pedido { Id = 3, Cliente = "Pedro", Produto = "Pizza", Quantidade = 3, PrecoUnitario = 40, Status = "Pronto" },
            new Pedido { Id = 4, Cliente = "Ana", Produto = "Lasanha", Quantidade = 1, PrecoUnitario = 35, Status = "Entregue" },
            new Pedido { Id = 5, Cliente = "Carlos", Produto = "Suco", Quantidade = 2, PrecoUnitario = 8, Status = "Recebido" },
            new Pedido { Id = 6, Cliente = "Julia", Produto = "Pizza", Quantidade = 1, PrecoUnitario = 40, Status = "Em preparo" },
            new Pedido { Id = 7, Cliente = "Lucas", Produto = "Hambúrguer", Quantidade = 2, PrecoUnitario = 25, Status = "Pronto" },
            new Pedido { Id = 8, Cliente = "Beatriz", Produto = "Lasanha", Quantidade = 2, PrecoUnitario = 35, Status = "Entregue" },
            new Pedido { Id = 9, Cliente = "Rafael", Produto = "Pizza", Quantidade = 1, PrecoUnitario = 40, Status = "Recebido" },
            new Pedido { Id = 10, Cliente = "Larissa", Produto = "Suco", Quantidade = 3, PrecoUnitario = 8, Status = "Entregue" }
        };

        public IActionResult Index()
        {
            return View(pedidos);
        }

        public IActionResult EmPreparo()
        {
            return View(pedidos.Where(p => p.Status == "Em preparo").ToList());
        }

        public IActionResult Prontos()
        {
            return View(pedidos.Where(p => p.Status == "Pronto").ToList());
        }

        public IActionResult Entregues()
        {
            return View(pedidos.Where(p => p.Status == "Entregue").ToList());
        }

        public IActionResult Dashboard()
        {
            return View(pedidos);
        }
    }
}