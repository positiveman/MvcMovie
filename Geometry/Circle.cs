using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle : Figure
    {

        private int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double Area() => Math.PI * (Radius ^ 2);

        public override double Perimeter() => 2 * Math.PI * Radius;
    }
}
