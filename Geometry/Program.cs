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
            IFigure figure1 = new Circle(5);
            IFigure figure2 = new Square(4.5);

            IFigure[] FigureList = { figure1, figure2 };

            double TotalArea = 0;
            double TotalPerimeter = 0;

            foreach (IFigure figure in FigureList)
            {
                TotalArea += figure.Area();
                TotalPerimeter += figure.Perimeter();
            }

            Console.WriteLine("Total area is {0}",TotalArea);
            Console.WriteLine("Total perimeter is {0}", TotalPerimeter);

            Console.Read();
        }
    }
}
