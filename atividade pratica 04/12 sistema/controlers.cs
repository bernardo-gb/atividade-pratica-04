using Microsoft.AspNetCore.Mvc;
using LojaMVC.Models;

namespace LojaMVC.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 3500, Estoque = 5 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 80, Estoque = 15 },
                new Produto { Id = 3, Nome = "Teclado", Preco = 150, Estoque = 0 },
                new Produto { Id = 4, Nome = "Monitor", Preco = 900, Estoque = 4 },
                new Produto { Id = 5, Nome = "Fone de ouvido", Preco = 200, Estoque = 8 }
            };

            return View(produtos);
        }
    }
}
