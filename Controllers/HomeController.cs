using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BatatinhaGourmert.Models;

namespace BatatinhaGourmert.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Professora professora = new Professora();
            professora.ProfessoraId = 1;
            professora.Nome = "Fran";
            professora.Idade = 32;
            professora.Tamanho = 1.55;
            //Aluna 2
            Professora professora2 = new Professora();
            professora2.ProfessoraId = 1;
            professora2.Nome = "Luana";
            professora2.Idade = 34;
            professora2.Tamanho = 1.65;
            //Aluna 3
            Professora professora3 = new Professora();
            professora3.ProfessoraId = 1;
            professora3.Nome = "Naiara";
            professora3.Idade = 32;
            professora3.Tamanho = 1.60;
            //Adicionando a Lista 
            List<Professora> professoras = new List<Professora>();
            professoras.Add(professora);
            professoras.Add(professora2);
            professoras.Add(professora3);
            ViewBag.Professoras = professoras;
            ViewBag.Disciplina = "Desenvolvimento de Sistemas";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro(string Name)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
