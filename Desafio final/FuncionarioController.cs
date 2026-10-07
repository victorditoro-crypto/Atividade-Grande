using Microsoft.AspNetCore.Mvc;
using CadastroMVC.Models;

namespace CadastroMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Funcionario { Id = 1, Nome = "João", Cargo = "Analista", Departamento = "TI", Salario = 4500, Ativo = true },
            new Funcionario { Id = 2, Nome = "Maria", Cargo = "Gerente", Departamento = "RH", Salario = 6000, Ativo = true },
            new Funcionario { Id = 3, Nome = "Pedro", Cargo = "Auxiliar", Departamento = "Financeiro", Salario = 2200, Ativo = false },
            new Funcionario { Id = 4, Nome = "Ana", Cargo = "Desenvolvedora", Departamento = "TI", Salario = 5200, Ativo = true },
            new Funcionario { Id = 5, Nome = "Carlos", Cargo = "Vendedor", Departamento = "Vendas", Salario = 2400, Ativo = true },
            new Funcionario { Id = 6, Nome = "Julia", Cargo = "Assistente", Departamento = "RH", Salario = 2800, Ativo = false },
            new Funcionario { Id = 7, Nome = "Lucas", Cargo = "Analista", Departamento = "Financeiro", Salario = 4200, Ativo = true },
            new Funcionario { Id = 8, Nome = "Beatriz", Cargo = "Diretora", Departamento = "Administração", Salario = 8000, Ativo = true },
            new Funcionario { Id = 9, Nome = "Rafael", Cargo = "Técnico", Departamento = "TI", Salario = 3500, Ativo = false },
            new Funcionario { Id = 10, Nome = "Larissa", Cargo = "Vendedora", Departamento = "Vendas", Salario = 2500, Ativo = true },
            new Funcionario { Id = 11, Nome = "Felipe", Cargo = "Auxiliar", Departamento = "Administração", Salario = 2300, Ativo = true },
            new Funcionario { Id = 12, Nome = "Camila", Cargo = "Analista", Departamento = "RH", Salario = 4000, Ativo = true },
            new Funcionario { Id = 13, Nome = "Bruno", Cargo = "Técnico", Departamento = "TI", Salario = 4800, Ativo = false },
            new Funcionario { Id = 14, Nome = "Amanda", Cargo = "Gerente", Departamento = "Vendas", Salario = 6500, Ativo = true },
            new Funcionario { Id = 15, Nome = "Diego", Cargo = "Auxiliar", Departamento = "Financeiro", Salario = 2000, Ativo = false }
        };

        public IActionResult Index()
        {
            return View(funcionarios);
        }

        public IActionResult Ativos()
        {
            return View(funcionarios.Where(f => f.Ativo).ToList());
        }

        public IActionResult Inativos()
        {
            return View(funcionarios.Where(f => !f.Ativo).ToList());
        }

        public IActionResult Departamento(string nome)
        {
            return View(funcionarios.Where(f => f.Departamento == nome).ToList());
        }

        public IActionResult Dashboard()
        {
            return View(funcionarios);
        }
    }
}