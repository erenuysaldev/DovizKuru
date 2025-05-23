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

                
                string dolaralış = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerText;
                lblDolarAlış.Text = dolaralış;

                string dolarsatış = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText;
                lblDolarSatis.Text = dolarsatış;

                string euroalış = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerText;
                lblEuroAlış.Text = euroalış;

                string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerText;
                lblEuroSatış.Text = eurosatis;
            }
            catch (Exception ex)
            {
                // Handle errors, such as issues with fetching or parsing the XML
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }
    }
}
