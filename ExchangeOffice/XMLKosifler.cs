using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeOffice
{
    public partial class XMLKosifler : Form
    {
        public XMLKosifler() {
            InitializeComponent();
            string connectionString = @"server=LAPTOP-BU9LCROV\SQLEXPRESS;database=KosiflerXML;Integrated Security=True;";
            dbManager = new DatabaseManager(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlfile = new XmlDocument();
            xmlfile.Load(today);

            string dollarbuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDollarBuying.Text = dollarbuying;

            string dollarselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDollarSelling.Text = dollarselling;

            string eurobuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroBuying.Text = eurobuying;

            string euroselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSelling.Text = euroselling;

        }

        private void BtnDBuy_Click(object sender, EventArgs e) {
            UpdateCurrencyDisplay();
            TxtRate.Text = LblDollarBuying.Text;
            if (decimal.TryParse(LblDollarBuying.Text, out decimal dollarBuy)) {
                dbManager.SaveCurrencyRates(dollarBuy, 0, 0, 0);
            }
            else {
                MessageBox.Show("Invalid dollar buying rate!");
            }
        }

        private void BtnDSell_Click(object sender, EventArgs e) {
            UpdateCurrencyDisplay();
            TxtRate.Text = LblDollarSelling.Text;
            if (decimal.TryParse(LblDollarSelling.Text, out decimal dollarSell)) {
                dbManager.SaveCurrencyRates(0, dollarSell, 0, 0);
            }
            else {
                MessageBox.Show("Invalid dollar selling rate!");
            }
        }

        private void BtnEBuy_Click(object sender, EventArgs e) {
            UpdateCurrencyDisplay();
            TxtRate.Text = LblEuroBuying.Text;
            if (decimal.TryParse(LblEuroBuying.Text, out decimal euroBuy)) {
                dbManager.SaveCurrencyRates(0, 0, euroBuy, 0);
            }
            else {
                MessageBox.Show("Invalid euro buying rate!");
            }
        }

        private void BtnESell_Click(object sender, EventArgs e) {
            UpdateCurrencyDisplay();
            TxtRate.Text = LblEuroSelling.Text;
            if (decimal.TryParse(LblEuroSelling.Text, out decimal euroSell)) {
                dbManager.SaveCurrencyRates(0, 0, 0, euroSell);
            }
            else {
                MessageBox.Show("Invalid euro selling rate!");
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e) {
            if (double.TryParse(TxtRate.Text, out double rate) && double.TryParse(TxtPiece.Text, out double piece)) {
                double amount = rate * piece;
                TxtAmount.Text = amount.ToString("N2");
                TxtAmount.Text = amount.ToString();
            }
            else {
                MessageBox.Show("Please enter valid numbers for rate and piece.");
                TxtRate.Focus();
            }
        }

        private void BtnSell_Click(object sender, EventArgs e) {
            if (double.TryParse(TxtRate.Text, out double rate) && int.TryParse(TxtPiece.Text, out int piece)) {
                if (rate == 0) {
                    MessageBox.Show("Rate cannot be zero.");
                    return;
                }

                int amount = (int)(piece / rate);
                TxtAmount.Text = amount.ToString();
                double remainder = piece % rate;
                TxtReaminder.Text = remainder.ToString("N2");
            }
            else {
                MessageBox.Show("Please enter valid numbers for rate and piece.");
                TxtRate.Focus();
            }
        }
        private void UpdateCurrencyDisplay() {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlfile = new XmlDocument();
            xmlfile.Load(today);
            string dollarbuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDollarBuying.Text = dollarbuying;
            string dollarselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDollarSelling.Text = dollarselling;
            string eurobuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroBuying.Text = eurobuying;
            string euroselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSelling.Text = euroselling;
        }
    }
}
