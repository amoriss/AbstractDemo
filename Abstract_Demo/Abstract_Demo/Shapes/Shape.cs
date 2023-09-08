using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo.Shapes
{
    internal abstract class Shape
    {
        public abstract int NumberOfSides { get; set; }
        public virtual void GetArea()
        {
            Console.WriteLine("Does Something");            
        }
    }
}
