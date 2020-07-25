using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplikacjaDietetyczna
{
/// <summary>
/// Okienko dla opcji Waga w menu 
/// </summary>
    public partial class menuWaga : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mati\Documents\bwaga.mdf;Integrated Security=True;Connect Timeout=30");

        public menuWaga()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługa przycisku wstawiającego rekord do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BWstaw(object sender, EventArgs e)
        {
            try
            {
                DateTime time = DateTime.Now;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Tabelka values('" + textId.Text + "','" + textWaga2.Text + "','" + time + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                textId.Text = "";
                textWaga2.Text = "";
                wysw_data();
                MessageBox.Show("Dane wstawione pomyślnie");
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane");
                con.Close();
            }
        }
        /// <summary>
        /// Wyswietlanie bazy danych w oknie programu
        /// </summary>
        public void wysw_data()
        {
            try
            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tabelka";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bazadanych.DataSource = dt;
            con.Close();
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane");
                con.Close();
            }
        }
        /// <summary>
        /// Zainicjowanie wyswietlania danych przy załadowaniu okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWaga_Load(object sender, EventArgs e)
        {
            wysw_data();
        }
        /// <summary>
        /// Usuwanie rekordów z bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuwanie(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Tabelka where Id='" + textId.Text + "'" ;
            cmd.ExecuteNonQuery();
            con.Close();
            wysw_data();
            MessageBox.Show("Dane usunięte pomyślnie");
                            }
            catch
            {
                MessageBox.Show("Niepoprawne dane");
                con.Close();
            }
        }
        /// <summary>
        /// Wypisanie danych za pomocą wykresu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zaladuj(object sender, EventArgs e)

        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Tabelka";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                /*
                 *chart1.Series["Waga"].XValueMember = "Data";
                chart1.Series["Waga"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                */
                chart1.Series["Waga"].XValueMember = "Id";
                chart1.Series["Waga"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chart1.Series["Waga"].YValueMembers = "Waga";

                chart1.DataSource = dt;
                chart1.DataBind();


                con.Close();
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane");
                con.Close();
            }
        }
    }
}
