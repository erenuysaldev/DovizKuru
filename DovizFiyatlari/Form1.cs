using System;
using System.Windows.Forms;
using System.Xml;

namespace DovizFiyatlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml"; // URL to fetch XML data
            var xmldosya = new XmlDocument();

            try
            {
                
                xmldosya.Load(bugun);

                
                string dolaralýþ = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerText;
                lblDolarAlýþ.Text = dolaralýþ;

                string dolarsatýþ = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText;
                lblDolarSatis.Text = dolarsatýþ;

                string euroalýþ = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerText;
                lblEuroAlýþ.Text = euroalýþ;

                string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerText;
                lblEuroSatýþ.Text = eurosatis;
            }
            catch (Exception ex)
            {
                // Handle errors, such as issues with fetching or parsing the XML
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }
    }
}
