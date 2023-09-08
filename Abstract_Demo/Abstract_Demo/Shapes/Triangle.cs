using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Demo.Shapes
{
    internal class Triangle : Shape
    {
        public override int NumberOfSides { get; set; } = 3;
    }
}
