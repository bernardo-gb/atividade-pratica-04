using Microsoft.AspNetCore.Mvc;
using AlunosMVC.Models;

namespace AlunosMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            var alunos = new List<Aluno>
            {
                new Aluno { Id = 1, Nome = "João", Idade = 18, Curso = "Informática" },
                new Aluno { Id = 2, Nome = "Maria", Idade = 19, Curso = "Administração" },
                new Aluno { Id = 3, Nome = "Pedro", Idade = 20, Curso = "Eletrônica" },
                new Aluno { Id = 4, Nome = "Ana", Idade = 18, Curso = "Mecânica" },
                new Aluno { Id = 5, Nome = "Lucas", Idade = 21, Curso = "Informática" },
                new Aluno { Id = 6, Nome = "Julia", Idade = 19, Curso = "Administração" },
                new Aluno { Id = 7, Nome = "Carlos", Idade = 20, Curso = "Mecânica" },
                new Aluno { Id = 8, Nome = "Beatriz", Idade = 18, Curso = "Eletrônica" }
            };

            return View(alunos);
        }
    }
}
