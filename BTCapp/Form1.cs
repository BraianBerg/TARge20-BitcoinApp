using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Currencyselect.SelectedItem.ToString() == "EUR")
            {
                Resulttxtbox.Visible = true;
                resultLabel.Visible = true;
                BTCRATES bitcoin = GetRates();
                float result = float.Parse(BTCAmmounttxtbox.Text) * bitcoin.bpi.EUR.rate_float;
                Resulttxtbox.Text = $"{result.ToString()} {bitcoin.bpi.EUR.code}";
            }
            if (Currencyselect.SelectedItem.ToString() == "GBP")
            {
                Resulttxtbox.Visible = true;
                resultLabel.Visible = true;
                BTCRATES bitcoin = GetRates();
                float result = float.Parse(BTCAmmounttxtbox.Text) * bitcoin.bpi.GBP.rate_float;
                Resulttxtbox.Text = $"{result.ToString()} {bitcoin.bpi.GBP.code}";
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static BTCRATES GetRates() 
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            BTCRATES bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BTCRATES>(response);
            }
            return bitcoin;
        }
    }
}
