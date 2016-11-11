using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaoProgrammLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Comission { get; set; }
        public decimal PaymentDue { get; set; }

        public string Display2
        {
            get
            {
                return String.Format("{0} {1} {2}€", FirstName, LastName, PaymentDue );
            }
        // komm
        }

        public Vendor()
        {
            Comission = .5;
        }
    }
}
