using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface iServicoCalculadora
    {

        [OperationContract]
        int sum(int a, int b);
        [OperationContract]
        int subtraction(int a, int b);
        [OperationContract]
        int multiplication(int a, int b);
        [OperationContract]
        int divide(int a, int b);

         // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
