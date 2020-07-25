using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaDietetyczna
{
   /// <summary>
   /// Klasa ogólna programu
   /// </summary>
    static class Program
    {
/// <summary>
/// Metoda główna programu
/// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
        /// <summary>
        /// Utworzenie listy zasad zdrowego trybu zycia
        /// </summary>
        /// <returns>Zwraca listę</returns>
        public static List<Zasady> Tworzenielisty()
        {
            List<Zasady> zasady1 = new List<Zasady>();
            zasady1.Add(new Zasady() { id = 1, tresc = "Rozpocznij dzień od sycącego śniadania" });
            zasady1.Add(new Zasady() { id = 2, tresc = "Jedz regularnie" });
            zasady1.Add(new Zasady() { id = 3, tresc = "Unikaj produktów wysoko przetworzonych " });
            zasady1.Add(new Zasady() { id = 4, tresc = "Pij odpowiednią ilość wody" });
            zasady1.Add(new Zasady() { id = 5, tresc = "Wprowadź dużo aktywnośći fizyczną" });
            zasady1.Add(new Zasady() { id = 6, tresc = "Zadbaj o relaks" });
            zasady1.Add(new Zasady() { id = 7, tresc = "Pracuj nad poczuciem własnej wartości" });
            zasady1.Add(new Zasady() { id = 8, tresc = "Wysypiaj się" });
            zasady1.Add(new Zasady() { id = 9, tresc = "Ogranicz alkohol" });
            zasady1.Add(new Zasady() { id = 10, tresc = "Dbaj o psychikę" });
            zasady1.Add(new Zasady() { id = 11, tresc = "Zadbaj o prawidłowy wskaźnik BMI" });
            zasady1.Add(new Zasady() { id = 12, tresc = "Ogranicz ekspozycję ciała na słońceę" });
            zasady1.Add(new Zasady() { id = 13, tresc = "Regularnie badaj swój organizm!" });
            zasady1.Add(new Zasady() { id = 14, tresc = "Pozbądź się dodanego cukru" });
            zasady1.Add(new Zasady() { id = 15, tresc = "Warzywa i owoce to moc witamin" });
            zasady1.Add(new Zasady() { id = 16, tresc = "Zadbaj o odpowiednią ilość białka" });
            zasady1.Add(new Zasady() { id = 17, tresc = "Naucz się zwalczać stres" });
            zasady1.Add(new Zasady() { id = 18, tresc = "Wybieraj produkty pełnoziarniste" });
            zasady1.Add(new Zasady() { id = 19, tresc = "Sięgaj po zdrowe tłuszcze" });
            return zasady1;
        }
    }
}
