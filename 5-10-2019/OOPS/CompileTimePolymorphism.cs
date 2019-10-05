using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class CompileTimePolymorphism
    {
        void print(int i)
        {
            Console.WriteLine(i);
        }
        void print(double d)
        {
            Console.WriteLine(d);
        }
        void print(string s)
        {
            Console.WriteLine(s);
        }
        public void Run()
        {
            CompileTimePolymorphism c = new CompileTimePolymorphism();
            c.print(5);
            c.print(500.263);
            c.print("Hello");

        }
    }}
