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
/// Okienko opcji Losuj z menu
/// </summary>
    public partial class menuLosuj : UserControl
    {
        public menuLosuj()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Wylosowanie wskazówki i wpisanie do odpowiedniego pola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Losowaniewsk(object sender, EventArgs e)
        {
            var random = new Random();
            List<Zasady> zasady1 = Program.Tworzenielisty();
            int index = random.Next(zasady1.Count);
            textwskazowka.Text = zasady1[index].tresc;


        }
    }
}
