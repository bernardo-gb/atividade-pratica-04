using Microsoft.AspNetCore.Mvc;
using RestauranteMVC.Models;

namespace RestauranteMVC.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Index()
        {
            var pratos = new List<Prato>
            {
                new Prato
                {
                    Id = 1,
                    Nome = "Hambúrguer",
                    Descricao = "Hambúrguer artesanal com queijo",
                    Preco = 25
                },

                new Prato
                {
                    Id = 2,
                    Nome = "Pizza",
                    Descricao = "Pizza de mussarela",
                    Preco = 40
                },

                new Prato
                {
                    Id = 3,
                    Nome = "Lasanha",
                    Descricao = "Lasanha de carne com queijo",
                    Preco = 35
                },

                new Prato
                {
                    Id = 4,
                    Nome = "Salada",
                    Descricao = "Salada com vegetais frescos",
                    Preco = 18
                },

                new Prato
                {
                    Id = 5,
                    Nome = "Frango",
                    Descricao = "Filé de frango grelhado",
                    Preco = 30
                }
            };

            return View(pratos);
        }
    }
}
