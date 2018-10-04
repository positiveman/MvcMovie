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
            IFigure figure3 = new Circle(1);
            IFigure figure4 = new Square(2);
            IFigure figure5 = new Circle(7);
            IFigure figure6 = new Square(4.5);

            IFigure[] FigureList = { figure1, figure2, figure3, figure4, figure5, figure6 };


        
            

      

            var sum = FigureList.Where(f => f.Area() > 5).Sum(f => f.Area());

            Console.WriteLine("Total area is {0}", sum);

            Console.Read();
        }

        
    }
}
