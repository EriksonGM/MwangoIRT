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
            var proc = new Procesador();

            var descontoSS = proc.CalcularSS(valor);
            /*
                        var escalao = proc.CalculaEscalao(valor - descontoSS);

                        var escalaoAntigo = proc.CalculaEscalao(valor - descontoSS);

                        var calc = new CalcViewModel
                        {

                            Valor = valor,
                            SegurancaSocial = descontoSS,
                            Escalao = escalao,
                            AntigoEscalao = escalaoAntigo,
                            //Resultado = 
                            //ExcessoValor = valor - descontoSS - escalao.Excesso,
                            //DescontoTaxa = (valor - escalao.Excesso) * (escalao.Procentual / 100),
                            //IRT = (valor - escalao.Excesso) * (escalao.Procentual / 100) + escalao.ParcelaFixa,
                            //Resultado = valor - ((valor - escalao.Excesso) * (escalao.Procentual / 100) + escalao.ParcelaFixa) - descontoSS
                        };

                        valor -= descontoSS;

                        calc.ExcessoValor = valor - escalao.Excesso;

                        calc.DescontoTaxa = (valor - escalao.Excesso) * (escalao.Porcentual / 100);

                        calc.IRT = (valor - escalao.Excesso) * (escalao.Porcentual / 100) + escalao.ParcelaFixa;

                        calc.Resultado = valor - ((valor - escalao.Excesso) * (escalao.Porcentual / 100) + escalao.ParcelaFixa);
            */

            var valorColetavel = valor - descontoSS;

            var escalaoAntigo = proc.CalcularEscalaoAntigo(valorColetavel);
            var escalaoActual = proc.CalculaEscalaoActual(valorColetavel);

            var calculo = new CalculoViewModel
            {
                Valor = valor,
                SegurancaSocial = descontoSS,
                CalculoActual = proc.CalcularIRT(valorColetavel, escalaoActual),
                CalculoAntigo = proc.CalcularIRT(valorColetavel, escalaoAntigo)
            };



            return View(calculo);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
