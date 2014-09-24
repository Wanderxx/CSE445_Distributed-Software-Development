using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q5WEB
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySearchService.Service1Client myproxy = new MySearchService.Service1Client();
            string[] a = myproxy.search(TxtSearchXml.Text, TxtSearchFirst.Text);
            TxtSearchResult.Text = "";
            for(int i=0;i<a.Length;i++){
                TxtSearchResult.Text = TxtSearchResult.Text + a[i] + Environment.NewLine;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySearchService.Service1Client myproxy = new MySearchService.Service1Client();
            string[] res = myproxy.XpathSearch(TxtPathXml.Text, TxtPath.Text);
            TxtXpathResult.Text = "";
            for (int i = 0; i < res.Length; i++)
            {
                TxtXpathResult.Text = TxtXpathResult.Text + res[i] + Environment.NewLine;
            }
        }
    }
}