using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaoProgrammLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }


        /* teeme konstruktori, et ei peaks iga kord uuesti meetodi sees hakkama neid
         * initsialiseerima. Teeme selleks konstruktori. */
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
    }

   
}
