using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ArrayListUsesForLoop
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("man");
            list.Add("woman");
            list.Add("plant");
            
            for (int i = 0; i < list.Count; i++)
            {
                string value = list[i] as string;
                Console.WriteLine(value);
            }
        }
    }
}
