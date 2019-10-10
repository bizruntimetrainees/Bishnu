using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class ClearElement
    {
        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();


            myTable.Add("2", "Even & Prime");
            myTable.Add("3", "Odd & Prime");
            myTable.Add("4", "Even & non-prime");
            myTable.Add("9", "Odd & non-prime");


            Console.WriteLine("Total number of entries in Hashtable : " + myTable.Count);



            myTable.Clear();


            Console.WriteLine("Total number of entries in Hashtable : " + myTable.Count);



            myTable.Add("g", "geeks");
            myTable.Add("c", "c++");
            myTable.Add("d", "data structures");


            Console.WriteLine("Total number of entries in Hashtable : " + myTable.Count);

        }
    }
}