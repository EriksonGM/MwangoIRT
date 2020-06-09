using Microsoft.Extensions.Options;

namespace UI
{
    public class Procesador
    {
        
        //public double CalcularIRT(decimal valor)
        //{
            
        //}

        public double Porcentagem(double valor, double porcentagem)
        {
            return valor * (porcentagem / 100);
        }

        public Escalao CalculaEscalao(double valor)
        {
            if (valor < 70000)
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Procentual = 0,
                    Excesso = 0
                };

            if (valor > 70000 & valor < 100000)
            {
                return new Escalao
                {
                    ParcelaFixa = 3000,
                    Procentual = 10,
                    Excesso = 70000
                };
            }

            if (valor > 100000 & valor < 150000)
            {
                return new Escalao
                {
                    ParcelaFixa = 12250,
                    Procentual = 13,
                    Excesso = 100000
                };
            }

            if (valor > 150000 & valor < 200000)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Procentual = 16,
                    Excesso = 150000
                };
            }

            if (valor > 200000 & valor < 300000)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Procentual = 18,
                    Excesso = 0,
                };
            }

            if (valor > 300000 & valor < 500000)
            {
                return new Escalao
                {
                    ParcelaFixa = 49250,
                    Procentual = 19,
                    Excesso = 300000
                };
            }

            if (valor > 500000 & valor < 1000000)
            {
                return new Escalao
                {
                    ParcelaFixa = 87250,
                    Procentual = 20,
                    Excesso = 500000
                };
            }

            if (valor > 1000000 & valor < 1500000)
            {
                return new Escalao
                {
                    ParcelaFixa = 187250,
                    Procentual = 21,
                    Excesso = 1000000
                };
            }

            if (valor > 1500000 & valor < 2000000)
            {
                return new Escalao
                {
                    ParcelaFixa = 292250,
                    Procentual = 22,
                    Excesso = 1500000
                };
            }

            if (valor > 2000000 & valor < 2500000)
            {
                return new Escalao
                {
                    ParcelaFixa = 402250,
                    Procentual = 23,
                    Excesso = 2000000
                };
            }

            if (valor > 2500000 & valor < 5000000)
            {
                return new Escalao
                {
                    ParcelaFixa = 517250,
                    Procentual = 24,
                    Excesso = 2500000
                };
            }

            if (valor > 5000000 & valor < 10000000)
            {
                return new Escalao
                {
                    ParcelaFixa = 0,
                    Procentual = 24.5,
                    Excesso = 5000000
                };
            }

            return new Escalao
            {
                ParcelaFixa = 2342250,
                Procentual = 25,
                Excesso = 10000000
            };

        }
    }

    public class Escalao
    {
        public double ParcelaFixa { get; set; }
        public double Procentual { get; set; }
        public double Excesso { get; set; }
    }
}