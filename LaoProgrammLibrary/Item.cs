using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaoProgrammLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Desctiption { get; set; }
        public decimal Price { get; set; }
        public Boolean Sold { get; set; }
        public Boolean PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }

        //loome siia properti, mis on kokkuehitatud kahest üleval olevast propertist
        public string Display
        {
            get { return string.Format("{0} - {1}€", Name, Price); }    
        }
    }
}
