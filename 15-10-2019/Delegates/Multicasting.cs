using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Multicasting
    {
        public delegate void MultiDelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
        public static void Main(String[] args)
        {

            Multicasting rect = new Multicasting();

            MultiDelegate rectdele = new MultiDelegate(rect.area);

            rectdele += rect.perimeter;
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();
            rectdele.Invoke(16.3, 10.3);
        }
    }
}
