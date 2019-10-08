using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   
        class NumberManipulator
        {
            public int factorial(int num)
            {

                int result;
                if (num == 1)
                {
                    return 1;
                }
                else
                {
                    result = factorial(num - 1) * num;
                    return result;
                }
            }
            static void Main(string[] args)
            {
                NumberManipulator n = new NumberManipulator();

                Console.WriteLine( n.factorial(7));
                Console.WriteLine( n.factorial(8));
                Console.ReadLine();
            }
        }
    }

