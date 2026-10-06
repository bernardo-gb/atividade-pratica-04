using Microsoft.AspNetCore.Mvc;
using CursosMVC.Models;

namespace CursosMVC.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            var cursos = new List<Curso>
            {
                new Curso
                {
                    Id = 1,
                    Nome = "Desenvolvimento Web",
                    CargaHoraria = 80,
                    Modalidade = "Online",
                    Vagas = 20,
                    Valor = 500
                },

                new Curso
                {
                    Id = 2,
                    Nome = "Banco de Dados",
                    CargaHoraria = 60,
                    Modalidade = "Presencial",
                    Vagas = 15,
                    Valor = 400
                },

                new Curso
                {
                    Id = 3,
                    Nome = "Programação C#",
                    CargaHoraria = 100,
                    Modalidade = "Online",
                    Vagas = 10,
                    Valor = 650
                },

                new Curso
                {
                    Id = 4,
                    Nome = "Informática Básica",
                    CargaHoraria = 40,
                    Modalidade = "Presencial",
                    Vagas = 0,
                    Valor = 250
                },

                new Curso
                {
                    Id = 5,
                    Nome = "HTML e CSS",
                    CargaHoraria = 50,
                    Modalidade = "Online",
                    Vagas = 12,
                    Valor = 300
                }
            };

            return View(cursos);
        }
    }
}
