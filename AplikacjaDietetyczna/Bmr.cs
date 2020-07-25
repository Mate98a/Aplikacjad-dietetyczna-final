using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDietetyczna
{
/// <summary>
/// Pomocna przy obliczeniach i przechowywaniu danych związanych z bmr
/// </summary>
    public class Bmr
    {
        private double masa;
        private double wzrost;
        private double wiek;
        private int plec;
        /// <summary>
        /// Oblicza wartość BMR 
        /// </summary>
        /// <returns>Wartośc BMR</returns>
        public double ObliczBMR()
        {
            if (plec == 1)
            {
                return ((9.99 * masa) + (6.25 * wzrost) - (4.92 * wiek) + 5);
            }
            else 
            {
                return ((9.99 * masa) + (6.25 * wzrost) - (4.92 * wiek) - 161);
            }
        }


        /// <summary>
        /// Obiekty klasy bmr są inicjowane
        /// </summary>
        /// <param name="masa">wartośc wagi w kg  </param>
        /// <param name="wzrost">Wartośc wzrostu w cm</param>
        /// <param name="wiek">wartośc wieki </param>
        /// <param name="plec">wartośc płci 1- męzczyzna </param>
        public Bmr(double masa, double wzrost,double wiek,int plec)
        {
            this.masa = masa;
            this.wzrost = wzrost;
            this.wiek = wiek;
            this.plec = plec;
        }
    }

}