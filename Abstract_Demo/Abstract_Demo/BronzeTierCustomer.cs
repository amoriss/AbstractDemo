using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo
{
    internal class BronzeTierCustomer : Customer
    {
        public override string Age { get; set; }

        public override void PrintCustomerName()
        {
            Console.WriteLine("Print Bronze Tier Customer's name... ");
        }
    }
}
