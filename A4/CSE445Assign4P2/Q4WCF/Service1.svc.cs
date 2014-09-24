using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace Q4WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] search(string url, string firstname)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList nodes = doc.SelectNodes("Persons/Person");
            string[] result = null;
            if (nodes == null)
            {
                result = new string[1];
                result[0] = "Not Found";
                return result;
            }
            else
            {
                foreach (XmlNode node in nodes)
                {
                    if (node["Name"]["First"].InnerText.Equals(firstname))
                    {
                        result = new string[4];
                        result[0] = "Full Name: " + node["Name"]["First"].InnerText + node["Name"]["Last"].InnerText;

                        result[1] = "Credential:ID " + node["Credential"]["Id"].InnerText + " Password: " + node["Credential"]["Password"].Value
                                   + " Encryption? " + node["Credential"]["Password"].Attributes["Encryption"].Value;
                        if (node["Phone"]["Cell"].HasAttributes)
                            result[2] = "Phone: Work " + node["Phone"]["Work"].InnerText + " Mobile: " + node["Phone"]["Cell"].InnerText + node["Phone"]["Cell"].Attributes["Provider"].Value;
                        else
                        {
                            result[2] = "Phone: Work " + node["Phone"]["Work"].InnerText + " Mobile: " + node["Phone"]["Cell"].InnerText + " Provider noe defined";
                        }
                        result[3] = "Category: " + node["Category"].InnerText;
                        break;
                    }
                    else {
                        result = new string[1];
                        result[0] = "Not Found";
                    }
                }
            }
            return result;
        }
       
        public string[] XpathSearch(string url,string Xpath) {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList nodes = doc.SelectNodes(Xpath);
            string[] res;
            if (nodes == null)
            {
                return null;
            }
            else
            {
                res = new string[nodes.Count];
                int i = 0;
                foreach (XmlNode node in nodes)
                {
                    res[i] = node.InnerText;
                    i++;
                }
            }
           //    nodes[i].childNodes[0].nodeValue);
            return res;
        }

    }
}
