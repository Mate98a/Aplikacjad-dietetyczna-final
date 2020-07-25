using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplikacjaDietetyczna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDietetyczna.Tests
{
    [TestClass()]
    public class BmiTests
    {
        /// <summary>
        /// Metoda sprawdzająca czy program wylicza poprawnie bmi
        /// </summary>
        [TestMethod()]
        public void ObliczBmiTest()
        {
            Bmi testowy = new Bmi(70, 1.76);
            double testbmi = testowy.ObliczBmi();
            int prosto = (int)testbmi;
            Assert.AreEqual(prosto, 22);
        }
    }
}