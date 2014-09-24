using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestWCFServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        //(1) Create a proxy tp WCF service.
            myServiceRef.ServiceClient myWcfProxy = new
                   myServiceRef.ServiceClient();
        //(2) Call the service operations through the proxy
       
            Console.WriteLine("input the C tempature: ");
            int a = int.Parse(Console.ReadLine());          // input Celsius temp
            int f = myWcfProxy.c2f(a);                      // convert Celsius temperature to Fahrenheit temperature
            Console.WriteLine("the conversion f should be: {0}", f);

            Console.WriteLine("input the F tempature: ");
            int b = int.Parse( Console.ReadLine());          // input Fahrenheit temp
            int c = myWcfProxy.f2c(b);                      // convert Fahrenheit temperature to Celsius temperature
            Console.WriteLine("the conversion f should be: {0}", c);

            myWcfProxy.Close();
            Console.ReadLine();
        }
    }
}
