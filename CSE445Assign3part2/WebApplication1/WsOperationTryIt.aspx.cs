using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Number2WordTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Myservice.Service1Client proxy = new Myservice.Service1Client();
            string[] a = proxy.WsOperation(TxtUrl.Text);
            for (int i = 0; i < a.Length; i++) {
                TxtResult.Text = TxtResult.Text + Environment.NewLine + a[i];
            }
        }
    }
}