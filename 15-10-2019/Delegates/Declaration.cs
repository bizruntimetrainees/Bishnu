using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Declaration
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        public static void Main(String[] args)
        {
            Declaration obj = new Declaration();

            addnum obj1 = new addnum(obj.sum);
            subnum obj2 = new subnum(obj.subtract);
            obj1(100, 40);
            obj2(100, 60);

        }
    }
}
