using Microsoft.AspNetCore.Mvc;
using FilmesMVC.Models;

namespace FilmesMVC.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            var filmes = new List<Filme>
            {
                new Filme { Id = 1, Nome = "Interestelar", Genero = "Ficção", Duracao = 169 },
                new Filme { Id = 2, Nome = "Avatar", Genero = "Aventura", Duracao = 162 },
                new Filme { Id = 3, Nome = "Toy Story", Genero = "Animação", Duracao = 81 },
                new Filme { Id = 4, Nome = "Batman", Genero = "Ação", Duracao = 176 },
                new Filme { Id = 5, Nome = "Shrek", Genero = "Comédia", Duracao = 90 }
            };

            return View(filmes);
        }
    }
}
