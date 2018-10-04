using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle : IFigure
    {

        private int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Area() => Math.PI * (Radius ^ 2);

        public double Perimeter() => 2 * Math.PI * Radius;
    }
}
