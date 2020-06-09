using UI;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UI.Tests
{
    [TestClass]
    public class ProcesadorTests
    {
        //[TestMethod()]
        //public void CalcularIRTTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod]
        [TestCase(100, 20)]
        public void PorcentagemTest(double valor, double porcentagem)
        {
            var calc = new Procesador();

            var res = calc.Porcentagem(valor,porcentagem);

            NUnit.Framework.Assert.IsTrue(res == 20);
            
            //Assert.Fail();
        }
    }
}