using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Square : Figure
    {
        private double Side;

        public Square(double side)
        {
            this.Side = side;         
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side*4;
        }
    }
}
