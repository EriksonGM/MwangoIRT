using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class CalcViewModel
    {
        public Escalao Escalao { get; set; }

        public Escalao AntigoEscalao { get; set; }
        public double Valor { get; set; }

        public double DescontoTaxa { get; set; }

        public double ExcessoValor { get; set; }

        public double IRT { get; set; }

        public double Resultado { get; set; }

        public double SegurancaSocial { get; set; }
    }
}
