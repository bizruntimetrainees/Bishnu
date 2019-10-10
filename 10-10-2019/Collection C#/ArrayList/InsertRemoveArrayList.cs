using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class InsertRemoveArrayList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Dot");
            list.Add("Net");
            list.Add("Perls");

            list.RemoveAt(1);
          


            list.Insert(0, "Carrot");


             list.RemoveRange(0, 2);
            foreach (string value in list)
            {
                Console.WriteLine(value);
                Console.ReadKey();
            }

        }
    }
}
