using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class WhileLoop
    {
        public void M1()
        {
            int a = 10;
            while(a<20)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
