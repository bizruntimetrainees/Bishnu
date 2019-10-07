using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS1
{
    abstract class Abstraction
    {
        public abstract int Area();
    }
    class Square : Abstraction
    {
        private int side;
        public Square(int x = 0)
        {
            side = x;
        }
        public override int Area()
        {
            Console.WriteLine("Area of Square:->");
            return (side * side);
        }

        class Text
        {
            static void Main(string[] args)
            {
                Abstraction s = new Square(4);
                double result = sh.area();
                Console.WriteLine("{10}", result);
            }
        }
    }
}
    

