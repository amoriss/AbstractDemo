using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo
{
    //abstract base class
    internal abstract class Customer
    {
        //every class that inherits from these, must implement them
        public abstract void PrintCustomerName(); //stubbed out method
        public abstract string Age { get; set; }

        //if not marked abstract, provide the implementation in the abstract class
        
        //virtual keyword will allow you to override IF YOU WANT TO (optional)
        public virtual void PrintCurrentDate()
        {
            Console.WriteLine(DateTime.Now);
        }
            
        // override is keyword used for both abstract and virtual

      
    }
}
