using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CallingMethods
    {
        public int FindMax(int num1, int num2)
        {

            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            CallingMethods n = new CallingMethods();

            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}
