using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class SingleDimensionalArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 5;
            arr[1] = 7;
            arr[2] = 9;
            arr[3] = 12;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
