using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UI.Models;

namespace UI.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] double valor)
        {
            var escalao = new Procesador().CalculaEscalao(valor-1);

            return View(new CalcViewModel
            {
                Escalao = escalao,
                Valor = valor,
                ExcessoValor = valor - escalao.Excesso,
                DescontoTaxa = (valor-escalao.Excesso) * (escalao.Procentual/100),
                IRT = (valor - escalao.Excesso) * (escalao.Procentual / 100) + escalao.ParcelaFixa,
                Resultado = valor - ((valor - escalao.Excesso) * (escalao.Procentual / 100) + escalao.ParcelaFixa)
            });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
