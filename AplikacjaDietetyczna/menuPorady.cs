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
    /// Okienko opcji Porady z menu 
    /// </summary>
    public partial class menuPorady : UserControl
    {
        /// <summary>
        /// Inicjacja listy i komponentów
        /// </summary>
        public menuPorady()
        {
            InitializeComponent();


            List<Zasady> zasady1 = Program.Tworzenielisty();
            dataGridView1.DataSource = zasady1;
            dataGridView1.Columns["id"].Width = 60;
            dataGridView1.Columns["tresc"].Width = 500;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            }
            
        }
    }
}
