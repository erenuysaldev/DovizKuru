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

                
                string dolaral�� = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerText;
                lblDolarAl��.Text = dolaral��;

                string dolarsat�� = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText;
                lblDolarSatis.Text = dolarsat��;

                string euroal�� = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerText;
                lblEuroAl��.Text = euroal��;

                string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerText;
                lblEuroSat��.Text = eurosatis;
            }
            catch (Exception ex)
            {
                // Handle errors, such as issues with fetching or parsing the XML
                MessageBox.Show("Error loading XML data: " + ex.Message);
            }
        }
    }
}
