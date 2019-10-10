using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ReversesArrayList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(70);
            list.Add(40);
            list.Add(30);
            list.Add(50);
            list.Add(60);
            list.Add(20);

            list.Sort();
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }


                list.Reverse();
                foreach (int i in list)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }

