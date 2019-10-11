using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Student
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> countrycode = new Dictionary<int, string>();
            countrycode.Add(1, "Bishnu");
            countrycode.Add(2, "Gyana");
            countrycode.Add(3, "Markar");
            countrycode.Add(4, "Lokas");
            countrycode.Add(5, "Zeeshan");
            countrycode.Add(6, "Chinu");

            foreach (KeyValuePair<int, string> item in countrycode)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine("--------");

            Console.WriteLine(countrycode.ContainsKey(6));
            Console.WriteLine("------------");

            Console.WriteLine(countrycode.Remove(3));
            Console.WriteLine("---------");

            foreach (KeyValuePair<int, string> item in countrycode)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
