using Microsoft.Extensions.Options;
using UI.Models;

namespace UI
{
    public class Procesador
    {
        public double CalcularSS(double valor)
        {
            return valor * 0.03;
        }

        public double Porcentagem(double valor, double porcentagem)
        {
            return valor * (porcentagem / 100);
        }

        public Escalao CalculaEscalaoActual(double valor)
        {
            if (valor < 70001)
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Porcentual = 0,
                    Excesso = 0
                };

            if (valor > 70000 & valor < 100001)
            {
                return new Escalao
                {
                    ParcelaFixa = 3000,
                    Porcentual = 10,
                    Excesso = 70000
                };
            }

            if (valor > 100000 & valor < 150001)
            {
                return new Escalao
                {
                    ParcelaFixa = 6000,
                    Porcentual = 13,
                    Excesso = 100000
                };
            }

            if (valor > 150000 & valor < 200001)
            {
                return new Escalao
                {
                    ParcelaFixa = 12250,
                    Porcentual = 16,
                    Excesso = 150000
                };
            }

            if (valor > 200000 & valor < 300001)
            {
                return new Escalao
                {
                    ParcelaFixa = 31250,
                    Porcentual = 18,
                    Excesso = 200000
                };
            }

            if (valor > 300000 & valor < 500001)
            {
                return new Escalao
                {
                    ParcelaFixa = 49250,
                    Porcentual = 19,
                    Excesso = 300000
                };
            }

            if (valor > 500000 & valor < 1000001)
            {
                return new Escalao
                {
                    ParcelaFixa = 87250,
                    Porcentual = 20,
                    Excesso = 500000
                };
            }

            if (valor > 1000000 & valor < 1500001)
            {
                return new Escalao
                {
                    ParcelaFixa = 187250,
                    Porcentual = 21,
                    Excesso = 1000000
                };
            }

            if (valor > 1500000 & valor < 2000001)
            {
                return new Escalao
                {
                    ParcelaFixa = 292250,
                    Porcentual = 22,
                    Excesso = 1500000
                };
            }

            if (valor > 2000000 & valor < 2500001)
            {
                return new Escalao
                {
                    ParcelaFixa = 402250,
                    Porcentual = 23,
                    Excesso = 2000000
                };
            }

            if (valor > 2500000 & valor < 5000001)
            {
                return new Escalao
                {
                    ParcelaFixa = 517250,
                    Porcentual = 24,
                    Excesso = 2500000
                };
            }

            if (valor > 5000000 & valor < 10000001)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Porcentual = 24.5,
                    Excesso = 5000000
                };
            }

            return new Escalao
            {
                ParcelaFixa = 2342250,
                Porcentual = 25,
                Excesso = 10000000
            };

        }

        public Escalao CalcularEscalaoAntigo(double valor)
        {
            if (valor < 34451)
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Porcentual = 0,
                    Excesso = 0
                };

            if (valor > 34450 & valor < 35001)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Porcentual = 7,
                    Excesso = 34450
                };
            }
            /*
            if (valor > 34450 & valor < 35001)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Porcentual = 7,
                    Excesso = 34450
                };
            }

            if (valor > 34450 & valor < 35001)
            {
                return new Escalao
                {
                    ParcelaFixa = 550,
                    Porcentual = 7,
                    Excesso = 34450
                };
            }
            */
            if (valor > 35000 & valor < 40001)
            {
                return new Escalao
                {
                    ParcelaFixa = 550,
                    Porcentual = 7,
                    Excesso = 35000
                };
            }

            if (valor > 40000 & valor < 45001)
            {
                return new Escalao
                {
                    ParcelaFixa = 900,
                    Porcentual = 8,
                    Excesso = 40000
                };
            }

            if (valor > 45000 & valor < 50001)
            {
                return new Escalao
                {
                    ParcelaFixa = 1300,
                    Porcentual = 9,
                    Excesso = 45000
                };
            }
            if (valor > 50000 & valor < 70001)
            {
                return new Escalao
                {
                    ParcelaFixa = 1750,
                    Porcentual = 10,
                    Excesso = 50000
                };
            }
            if (valor > 700000 & valor < 90001)
            {
                return new Escalao
                {
                    ParcelaFixa = 3750,
                    Porcentual = 11,
                    Excesso = 70000
                };
            }
            if (valor > 90000 & valor < 110001)
            {
                return new Escalao
                {
                    ParcelaFixa = 5950,
                    Porcentual = 12,
                    Excesso = 90000
                };
            }

            if (valor > 110000 & valor < 140001)
            {
                return new Escalao
                {
                    ParcelaFixa = 83250,
                    Porcentual = 13,
                    Excesso = 110000
                };
            }

            if (valor > 140000 & valor < 170001)
            {
                return new Escalao
                {
                    ParcelaFixa = 12250,
                    Porcentual = 14,
                    Excesso = 140000
                };
            }
            if (valor > 170000 & valor < 200001)
            {
                return new Escalao
                {
                    ParcelaFixa = 16450,
                    Porcentual = 15,
                    Excesso = 170000
                };
            }
            if (valor > 200000 & valor < 230001)
            {
                return new Escalao
                {
                    ParcelaFixa = 20950,
                    Porcentual = 16,
                    Excesso = 200000
                };
            }
            return new Escalao
            {
                ParcelaFixa = 25750,
                Porcentual = 17,
                Excesso = 230000
            };
        }

        public Calculo CalcularIRT(double valor, Escalao escalao)
        {
            var res = new Calculo
            {
                Salario = valor - ((valor - escalao.Excesso) * (escalao.Porcentual / 100) + escalao.ParcelaFixa),

                ExcessoValor = valor - escalao.Excesso,
                //res.Irt = (valor - escalao.Excesso) * (escalao.Porcentual / 100) + escalao.ParcelaFixa;

                DescontoTaxa = (valor - escalao.Excesso) * (escalao.Porcentual / 100),

                TotalIRT = (valor - escalao.Excesso) * (escalao.Porcentual / 100) + escalao.ParcelaFixa,

                Escalao = escalao

                
            };

            return res;
        }




    }



    public class Escalao
    {
        public double ParcelaFixa { get; set; }
        public double Porcentual { get; set; }
        public double Excesso { get; set; }
    }

    public class Resultado
    {
        public double DescontoTaxa { get; set; }
        public double Irt { get; set; }
        public double Salario { get; set; }
    }
}