using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            Main();
            Child();
            Console.ReadKey();
        }

        public static async Task Main()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Main");
                }
            });
        }


        public static void Child()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Child");
            }
        }
    }

}
    

