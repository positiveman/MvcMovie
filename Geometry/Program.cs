using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure1 = new Circle(5);
            Square figure2 = new Square(4.5);

            Console.WriteLine("Area of figure1 is {0}",figure1.Area());
            Console.WriteLine("Perimeter of figure2 is {0}", figure2.Perimeter());

            Console.Read();
        }
    }
}
