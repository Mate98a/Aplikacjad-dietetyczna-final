using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDietetyczna
{
/// <summary>
/// Klasa pomocna przy obliczaniu bmi i przechowywaniu danych związacych z tymi operacjami
/// </summary>
    public class Bmi
    {

        private double masa;
        private double wzrost;
        /// <summary>
        /// Oblicza Bmi dla danych obiektu
        /// </summary>
        /// <returns>Zwraca wartośc bmi</returns>
        public double ObliczBmi()
        {
            return masa / (wzrost * wzrost);
        }
        /// <summary>
        /// Oblicza kategorie w której znajduje się bmi 
        /// </summary>
        /// <param name="bmi">wskażnik masy ciała</param>
        /// <returns>Teks który definiuje w jakim przedziale miesci się bmi </returns>
        public string Kategoria(double bmi)
        {

            String wyn = "";
            if (bmi < 16.0)
                wyn = "Jesteś wygłodzony!";
            else if (bmi >= 16.0 && bmi <= 16.99)
                wyn = "Jesteś wychudzony!";
            else if (bmi >= 17.0 && bmi <= 18.49)
                wyn = "Masz niedowagę!";
            else if (bmi >= 18.5 && bmi < +24.99)
                wyn = "Mieścisz się w normie!";
            else if (bmi >= 30.0 && bmi <= 34.99)
                wyn = "Masz I stopień otyłości";
            else if (bmi >= 35.0 && bmi <= 39.99)
                wyn = "Masz II stopień otyłości(otyłość kliniczna)";
            else if (bmi >= 40.0)
                wyn = "Masz III stopień otyłości(otyłość skrajna)";
            return wyn;
        }
        /// <summary>
        /// Konstruktor inicjuje zmienne otrzymanymi danymi wagi i wzrostu
        /// </summary>
        /// <param name="masa"></param>
        /// <param name="wzrost"></param>
        public Bmi(double masa, double wzrost)
        {
            this.masa = masa;
            this.wzrost = wzrost;
        }
    }

}