using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class AddElement
    {
        static void Main(string[] args)
        {
            Hashtable g = new Hashtable();
            g.Add(1, "welcome");
            g.Add(2, "to");
            g.Add(3, "tutorials");
            g.Add(4, "of");
            g.Add(5, "C#");

            ICollection key = g.Keys;

           
            Console.WriteLine("Hashtable:");
            Console.WriteLine();
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
                Console.ReadKey();
            }
        }
    }
}
