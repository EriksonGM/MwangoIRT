using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class CalculoViewModel
    {
        public double Valor { get; set; }

        public double SegurancaSocial { get; set; }

        public Calculo CalculoAntigo { get; set; }
        public Calculo CalculoActual { get; set; }
    }

    public class Calculo
    {

        public double DescontoTaxa { get; set; }

        public double ExcessoValor { get; set; }

        public double TotalIRT { get; set; }

        public double Salario { get; set; }

        public Escalao Escalao { get; set; }


        //public double Valor { get; set; }
    }
}
