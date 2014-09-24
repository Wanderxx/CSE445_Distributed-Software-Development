using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WeatherTyrIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Myservice.Service1Client  proxy = new Myservice.Service1Client ();
            string[] a = proxy.WeatherService(Txtzip.Text);
            if (a != null)
            {
                Txtweather.Text = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    Txtweather.Text = Txtweather.Text + Environment.NewLine + a[i];

                }
            }
            else
                Txtweather.Text = "Cant't find";
        }
    }
}