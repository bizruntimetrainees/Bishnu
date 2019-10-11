using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static Collection.ProductsStack;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Implements obj = new Implements();
            obj.Add();
            Console.WriteLine("----------------------------");
            obj.Retriev();
            Console.WriteLine("----------------------------");
            obj.Present();
            Console.WriteLine("----------------------------");
            obj.Remove();
            Console.WriteLine("----------------------------");







            Console.ReadKey();
        }
    }
}
