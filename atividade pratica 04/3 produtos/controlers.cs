using Microsoft.AspNetCore.Mvc;
using ProdutosMVC.Models;

namespace ProdutosMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Produto> produtos = new()
        {
            new Produto { Id = 1, Nome = "Notebook", Categoria = "Informática", Estoque = 5, Preco = 3500 },
            new Produto { Id = 2, Nome = "Mouse", Categoria = "Informática", Estoque = 10, Preco = 80 },
            new Produto { Id = 3, Nome = "Teclado", Categoria = "Informática", Estoque = 0, Preco = 120 },
            new Produto { Id = 4, Nome = "Monitor", Categoria = "Informática", Estoque = 3, Preco = 900 },
            new Produto { Id = 5, Nome = "Celular", Categoria = "Eletrônicos", Estoque = 7, Preco = 1800 },
            new Produto { Id = 6, Nome = "Fone", Categoria = "Eletrônicos", Estoque = 0, Preco = 150 },
            new Produto { Id = 7, Nome = "Tablet", Categoria = "Eletrônicos", Estoque = 4, Preco = 1200 },
            new Produto { Id = 8, Nome = "Webcam", Categoria = "Informática", Estoque = 6, Preco = 250 },
            new Produto { Id = 9, Nome = "Impressora", Categoria = "Informática", Estoque = 2, Preco = 800 },
            new Produto { Id = 10, Nome = "Cabo USB", Categoria = "Acessórios", Estoque = 20, Preco = 30 }
        };

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Disponiveis()
        {
            var disponiveis = produtos.Where(p => p.Estoque > 0).ToList();

            return View("Index", disponiveis);
        }
    }
}
