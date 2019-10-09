using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class LengthOfString
    {
        static void Main(string[] args)
        {

            int k = 0;
            string str = "Good Morning";
            for (int i = 0; i < str.Length; i++)
            {



                k++;
            }

            Console.WriteLine("Total number of  characters exists in string: " + k);
        }
    
    }
}
    


