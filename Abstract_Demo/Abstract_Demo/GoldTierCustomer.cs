using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo
{
    internal class GoldTierCustomer : Customer
    {
        // must have override keyword to implement the abstract properties/methods
        public override string Age { get; set; }

        public override void PrintCustomerName()
        {
            Console.WriteLine("Print Gold Tier Customer's name... "); 
        }
    }
}
