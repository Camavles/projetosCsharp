﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.AspNetCore.Routing;
using Alura.LeilaoOnline.WebApp.Services;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IProdutoService _service;

        public HomeController(IProdutoService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var categorias = _service.ConsultaCategoriasComTotalDeLeiloesEmPregao();
            return View(categorias);
        }

        [Route("[controller]/StatusCode/{statusCode}")]
        public IActionResult StatusCodeError(int statusCode)
        {
            if (statusCode == 404) return View("404");
            return View(statusCode);
        }

        [Route("[controller]/Categoria/{categoria}")]
        public IActionResult Categoria(int categoria)
        {
            var categ = _service.ConsultaCategoriaPorIdComLeiloesEmPregao(categoria);
            return View(categ);
        }

        [HttpPost]
        [Route("[controller]/Busca")]
        public IActionResult Busca(string termo)
        {
            ViewData["termo"] = termo;
            var leiloes = _service.PesquisaLeiloesEmPregaoPorTermo(termo);
            return View(leiloes);
        }
    }
}
