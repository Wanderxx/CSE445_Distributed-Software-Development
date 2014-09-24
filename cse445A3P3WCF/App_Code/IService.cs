using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    //elective 1
    [OperationContract]
    [WebGet]
    double L2Gal(double L);

    [OperationContract]
    [WebGet]
    double Gal2L(double Gal);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
