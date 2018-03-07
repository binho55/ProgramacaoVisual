using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class PessoasController : Controller
    {
        public static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa {Id = 1, Nome = "Joao"},
            new Pessoa {Id = 2, Nome = "Juao"},
            new Pessoa {Id = 3, Nome = "Jiao"}
    };

        // localhost:5000/Pessoas
        //localhost:5000/Pessoas/Index

        public IActionResult Index()
        {
            //busca de dados
            var viewModel = new PessoaViewModel
            {

                Items = pessoaList
            };
            //transforma dados em dados de vizualização
            //vizualização dos dados
            return View(viewModel);
        }
    }
}