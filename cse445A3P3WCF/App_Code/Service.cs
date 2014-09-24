using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    //Service 1 
    public double L2Gal(double L)
    {
        return Math.Round(L / 3.785, 3);
    }

    public double Gal2L(double Gal)
    {
        return Math.Round(Gal * 3.785, 3);
    }

    
	
}
