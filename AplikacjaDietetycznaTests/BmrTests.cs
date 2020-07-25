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
    public class BmrTests
    {
        /// <summary>
        /// Metoda sprawdzająca czy program wylicza poprawnie BMR
        /// </summary>
        [TestMethod()]
        public void ObliczBMRTest()
        {
            Bmr testowy = new Bmr(70, 176,25,1);
            double testbmr = testowy.ObliczBMR();
            int prosto = (int)testbmr;
            Assert.AreEqual(prosto, 1681);
        }
        //699.3+1100-123+5=1681.3
        //Mężczyźni [9,99 x masa ciała (kg)] + [6,25 x wzrost (cm)] - [4,92 x wiek (lata)] + 5


    }
}