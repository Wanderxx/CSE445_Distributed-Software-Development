using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace part4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gobtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);            //very simple  internet browser
        }

        private void part5_btn_Click(object sender, EventArgs e)
        {
            webEncrypt.ServiceClient myclient = new webEncrypt.ServiceClient();  //creat proxy
            part5_En.Text = myclient.Encrypt(part5_txtinput.Text);               //Encrypt
            part5_De.Text = myclient.Decrypt(part5_En.Text);                     //Decrypt
            myclient.Close();
        }

        private void part6_btn_Click(object sender, EventArgs e)
        {
            
            Webstock.Service mystock = new Webstock.Service();
           string rs= mystock.getStockquote(part6_txtinput.Text);                //output the value
           priceBox.Text = rs;
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void part8_btn_Click(object sender, EventArgs e)
        {
            Webweather.ForecastReturn forecasts = new Webweather.ForecastReturn();
            Webweather.Weather forecast = new Webweather.Weather();         
            Webweather.Forecast[] weatherData;
            TextBox[] description = new TextBox[5]{
                Day1_weather, Day2_weather, Day3_weather, Day4_weather, Day5_weather};       //set of 5days weather
            TextBox[] lowTmps = new TextBox[5]{
                Day1_lowTmp, Day2_lowTmp, Day3_lowTmp, Day4_lowTmp, Day5_lowTmp};         
            TextBox[] highTmps = new TextBox[5]{
                Day1_highTmp, Day2_highTmp, Day3_highTmp, Day4_highTmp, Day5_highTmp};
            forecasts = forecast.GetCityForecastByZIP(part8_input.Text);       //this method will return class as ForecastReturn
            if (forecasts.ForecastResult != null)             //Forecase[]  set
            {
                weatherData = forecasts.ForecastResult;
                part8_city.Text = forecasts.City  +","+ forecasts.State;     //location
                for (int i = 0; i < 5; i++)
                {
                    description[i].Text = weatherData[i].Desciption;        
                    lowTmps[i].Text = weatherData[i].Temperatures.MorningLow;
                    highTmps[i].Text = weatherData[i].Temperatures.DaytimeHigh;
                }
            }
            else
            {
                MessageBox.Show("No weather founded!");
            }

        }

    }
}
