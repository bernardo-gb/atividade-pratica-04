using Microsoft.AspNetCore.Mvc;
using HotelMVC.Models;

namespace HotelMVC.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            var quartos = new List<Quarto>
            {
                new Quarto
                {
                    Id = 1,
                    Nome = "Quarto Standard",
                    Capacidade = 2,
                    Descricao = "Quarto confortável com cama de casal.",
                    Diaria = 180
                },

                new Quarto
                {
                    Id = 2,
                    Nome = "Quarto Luxo",
                    Capacidade = 3,
                    Descricao = "Quarto amplo com televisão e frigobar.",
                    Diaria = 280
                },

                new Quarto
                {
                    Id = 3,
                    Nome = "Suíte",
                    Capacidade = 4,
                    Descricao = "Suíte completa com sala e banheira.",
                    Diaria = 450
                }
            };

            return View(quartos);
        }
    }
}
