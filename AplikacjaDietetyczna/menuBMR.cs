using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaDietetyczna
{
/// <summary>
/// Okienko dla opcji BMR
/// </summary>
    public partial class menuBMR : UserControl
    {
        public menuBMR()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługa przycisku obliczającego BMR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Oblicz(object sender, EventArgs e)
        {
            try
            {
                double waga = Convert.ToDouble(textWaga.Text);
                double wzrost = Convert.ToDouble(textWzrost.Text);
                double wiek = Convert.ToDouble(textWiek.Text);
                int plec=0;
                if (plecM.Checked)
                    plec = 1;
                if (plecK.Checked)
                    plec = 2;
                Bmr nowy1 =new Bmr(waga, wzrost, wiek, plec);
                textWynik.Text = "Twoje minimalne zapotrzebowanie kaloryczne wynosi około "+nowy1.ObliczBMR().ToString("#.#")+" kcal";
                
            }
            catch
            {
                textWynik.Text = "Podaj właściwe wartości";
            }
        }
        /// <summary>
        /// Obsługa przycisku resetującego dane w polach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset(object sender, EventArgs e)
        {
            textWaga.Text = "";
            textWzrost.Text = "";
            textWynik.Text = "";
        }
    }
}
