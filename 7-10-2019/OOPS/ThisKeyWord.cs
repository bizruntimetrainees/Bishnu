using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS1
{
    class Test
    {
        int x;
        Test(int x)
        {
            this.x = x;
        }
        void display(int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(this.x);
        }


    public class user
        {
            static void Main(string[] args)
            {
                Test t = new Test(20);
                t.display(500);
            }
        }
    }
}



