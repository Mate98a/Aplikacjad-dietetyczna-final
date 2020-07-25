using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaDietetyczna
{
    /// <summary>
    /// Klasa głownego okienka projektu
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicjalizacja wstępnych działań i własciwosci
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            podswietlenie.Top = button1.Top;
            podswietlenie.Height = button1.Height;
            menuStart1.BringToFront();
            
        }
        /// <summary>
        /// Obsługa przycisku Start w menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Start(object sender, EventArgs e)
        {
            podswietlenie.Top = button1.Top;
            podswietlenie.Height = button1.Height;
            menuStart1.BringToFront();
        }
        /// <summary>
        /// Obsługa przycisku BMI w menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_BMI(object sender, EventArgs e)
        {
            podswietlenie.Top = button2.Top;
            podswietlenie.Height = button2.Height;
            menuBMI1.BringToFront();
        }
        /// <summary>
        /// Obsługa przycisku do wyjścia z aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Obsługa przycisku BMR z menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_BMR(object sender, EventArgs e)
        {
            podswietlenie.Top = button3.Top;
            podswietlenie.Height = button3.Height;
            menuBMR1.BringToFront();
        }
        /// <summary>
        /// Obsługa przycisku Porady z menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Porady(object sender, EventArgs e)
        {
            podswietlenie.Top = button4.Top;
            podswietlenie.Height = button4.Height;
            menuPorady1.BringToFront();
        }
        /// <summary>
        /// Obsługa przycisku Waga z menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Waga(object sender, EventArgs e)
        {
            podswietlenie.Top = button5.Top;
            podswietlenie.Height = button5.Height;
            menuWaga1.BringToFront();
        }
        /// <summary>
        /// Obsługa przycisku Losuj z menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Losuj(object sender, EventArgs e)
        {
            podswietlenie.Top = button6.Top;
            podswietlenie.Height = button6.Height;
            menuLosuj1.BringToFront();
        }
    }
}
