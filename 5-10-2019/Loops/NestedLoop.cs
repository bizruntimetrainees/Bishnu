using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class NestedLoop
    {
       public void M2()
        {
           
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0)
                        break;
                if (j > (i / j))
              Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();
        }
    }
}
