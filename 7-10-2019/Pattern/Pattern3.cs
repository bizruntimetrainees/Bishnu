﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs
{
    class Pattern3
    {
       public static void Main(string[] args)
        {
            int n = 5; 
            for(int i=1;i<=n;i++)
            {
                for(int j=n-1;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
