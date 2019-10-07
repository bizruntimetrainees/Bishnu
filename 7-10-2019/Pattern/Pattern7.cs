using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs
{
    class Pattern7
    {
        public static void Main(string[] args)
        {
            int n = 5;
            int px = 1;
            int py = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n * 2; j++)
                {
                    if (j >= px && j <= py)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                px++;
                py--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

