using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Currency_game_exchange
{
    public partial class Form1 : Form
    {
        int dayCount = 0;
        //static Random r = new Random();
        //static double k = r.NextDouble();
        double bankRUB = 100000;
        double bankUSD = 100;
        double currency = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dayCount = 0;
            bankRUB = 100000;
            bankUSD = 100;
            CurrentBankStatus();
            chart1.Series[0].Points.Clear();
            Currency();
            chart1.ChartAreas[0].AxisY.Maximum = currency + 0.5;
            chart1.ChartAreas[0].AxisY.Minimum = currency - 0.5;           
            UpdateLabels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentBankStatus();
            dayCount++;  
            Currency();
            UpdateLabels();
        }

        private void Currency()
        {
            string line = "";
            using (WebClient wc = new WebClient())//если все время показывает один и тот же курс, значит сайт упал
                line = wc.DownloadString("https://www.profinance.ru/chart/usdrub/");
            Match match = Regex.Match(line, @"<td>(\d{2}[.].*?)</td>");
            NumberFormatInfo provider = new NumberFormatInfo();
            currency = Convert.ToDouble(match.Groups[1].Value, provider);
        }
        private void CurrentBankStatus()
        {
            
            label2.Text = $"RUB: {bankRUB}";
            label3.Text = $"USD: {bankUSD}";
        }
        private void UpdateLabels()
        {
            Text = $"{dayCount}";
            label1.Text = $"USD/RUB {currency}";
            chart1.Series[0].Points.AddXY(dayCount, currency);
        }

        private void buyUsdButton_Click(object sender, EventArgs e)
        {
            double wannaBuy = (double)numericBuyCountUsd.Value;
            if (bankRUB >= wannaBuy * currency)
            {
                bankRUB -= wannaBuy * currency;
                bankUSD += wannaBuy;
            }
            CurrentBankStatus();
        }

        private void buyRubButton_Click(object sender, EventArgs e)
        {
            double wannaBuy = (double)numericBuyCountRUB.Value;
            if (bankUSD >= wannaBuy / currency)
            {
                bankUSD -= wannaBuy / currency;
                bankRUB += wannaBuy;
            }
            CurrentBankStatus();
        }
    }
}
