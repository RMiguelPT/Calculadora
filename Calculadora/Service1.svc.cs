using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicoCalculadora : iServicoCalculadora
    {
        public int divide(int a, int b)
        {
            try
            {
                return safeDivision(a, b);
            }
            catch (DivideByZeroException e)
            {
                return -1;
            }
           
        }

        public int multiplication(int a, int b)
        {
            return a * b;
        }

        public int subtraction(int a, int b)
        {
            return a - b;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }   
        
        private int safeDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }  

    }
}
