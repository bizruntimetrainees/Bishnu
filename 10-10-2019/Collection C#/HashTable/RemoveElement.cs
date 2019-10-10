using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class RemoveElement
    {
         static void Main(string[] args)
        {


            Hashtable ht = new Hashtable();


            ht.Add("2", "Even & Prime");
            ht.Add("3", "Odd & Prime");
            ht.Add("4", "Even & non-prime");
            ht.Add("9", "Odd & non-prime");


            Console.WriteLine("Total number of entries in Hashtable : " + ht.Count);



            ht.Remove("3");


            Console.WriteLine("Total number of entries in Hashtable : " + ht.Count);
            Console.ReadKey();
        }
    }
}
