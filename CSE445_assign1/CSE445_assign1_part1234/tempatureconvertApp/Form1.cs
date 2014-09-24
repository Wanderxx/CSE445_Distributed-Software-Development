using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tempatureconvertApp
{
    public partial class Form1 : Form
    {
        MyServiceRef.ServiceClient mysev = new MyServiceRef.ServiceClient();  //craet proxy
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 c = Convert.ToInt32(textBox1.Text);               //string to int
            textBox2.Text = Convert.ToString(mysev.c2f(c));         //int to string
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 f = Convert.ToInt32(textBox1.Text);              //string to int
            textBox2.Text = Convert.ToString(mysev.f2c(f));        //int to string
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
