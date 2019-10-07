using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS1
{
    class Demo
    {
        int Sno;
        String name;
        Demo()
        {
            Sno = 101;
            name = "ABC";
        }
        void Display()
        {
            Console.WriteLine(Sno);
            Console.WriteLine(name);
        }
         static void main(string[] args)
        {
            Demo s1 = new Demo();
            s1.Display();

        }
    }
}


