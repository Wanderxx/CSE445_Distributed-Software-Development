using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace part2Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] WsOperation(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList nodes = doc.GetElementsByTagName("wsdl:portType");
            string[] result = null;
            if (nodes == null)
                return null ;
            else
            {
                foreach (XmlNode node in nodes)
                {
                    XmlNodeList list = node.ChildNodes;
                    result = new string[3*list.Count];
                    int i = 0;
                    foreach (XmlNode pot in list)
                    {

                        XmlNode innode = pot["wsdl:input"];
                        XmlNode outnode = pot["wsdl:output"];
                        result[i] = "OperationName:" + pot.Attributes["name"].Value;
                        result[i + 1] = "input:" + innode.Attributes["message"].Value;
                        result[i + 2] = "output:" + outnode.Attributes["message"].Value;
                        i+=3;
                    }
                }


            }


            return result;
        }

        public string[] WeatherService(string zip)
        {
            Webweather.ForecastReturn forecasts = new Webweather.ForecastReturn();
            Webweather.Weather forecast = new Webweather.Weather();
            Webweather.Forecast[] weatherData;
            string[] result = new string[6];
            forecasts = forecast.GetCityForecastByZIP(zip);       //this method will return class as ForecastReturn
            if (forecasts.ForecastResult != null)            //Forecase[]  set
            {
                weatherData = forecasts.ForecastResult;
                result[0] = forecasts.City + "," + forecasts.State;     //location
                for (int i = 0; i < 5; i++)
                {
                    result[i + 1] ="Day"+(i+1)+ " Description:" + weatherData[i].Desciption +
                        " LowTemp:" + weatherData[i].Temperatures.MorningLow +
                        " HighTemp:" + weatherData[i].Temperatures.DaytimeHigh;
                }
            }
            else
            {
                return null;
            }


            return result;
        }

        public string Hazard(string zip) {
            MyHazard.MapServerPortClient proxy = new MyHazard.MapServerPortClient();





            return null;
        }
    
    
    }
}
