using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo
{
    internal class SilverTierCustomer : Customer
    {
        public override string Age { get; set; }

        public override void PrintCustomerName()
        {
            Console.WriteLine("Print Silver Tier Customer's name... ");
        }

        public override void PrintCurrentDate()
        {
            Console.WriteLine($"Hello Gold Tiered Customer, the date is: {DateTime.Now}");
        }
    }
}
