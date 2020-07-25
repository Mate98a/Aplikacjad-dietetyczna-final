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
    /// Okienko opcji BMI
    /// </summary>
    public partial class menuBMI : UserControl
    {
        public menuBMI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługa przycisku do obliczenia BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double waga = Convert.ToDouble(textWaga.Text);
                double wzrost = Convert.ToDouble(textWzrost.Text);
                wzrost = wzrost / 100;
                Bmi nowy = new Bmi(waga, wzrost);
                textWynik.Text = "Twoje BMI wynosi: " + nowy.ObliczBmi().ToString("#.#") + Environment.NewLine + nowy.Kategoria(nowy.ObliczBmi());
            }
            catch
            {
                textWynik.Text = "Podaj właściwe wartości";
            }
        }
        /// <summary>
        /// Obsługa przycisku do resetu pól
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textWaga.Text = "";
            textWzrost.Text = "";
            textWynik.Text = "";
        }
    }
}
