using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Square : IFigure
    {
        private double Side;

        public Square(double side)
        {
            this.Side = side;         
        }

        public  double Area()
        {
            return Side * Side;
        }

        public  double Perimeter()
        {
            return Side*4;
        }
    }
}
