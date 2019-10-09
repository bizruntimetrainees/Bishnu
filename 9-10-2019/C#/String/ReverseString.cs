using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            String string1 = "Dream big";
             
            String reversedStr = "";

           
            for (int i = string1.Length - 1; i >= 0; i--)
            {
                reversedStr = reversedStr + string1[i];
            }

            Console.WriteLine("Original string: " + string1);
       
            Console.WriteLine("Reverse of given string: " + reversedStr);
        }
    }
}
