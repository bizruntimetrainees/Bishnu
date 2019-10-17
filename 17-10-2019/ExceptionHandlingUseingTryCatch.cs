using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous1
{
    class Text
    {
        public static async Task<String> Asyncfun()
        {
            try
            {
                throw new Exception("Exception");
            }
          catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
                 return null;
            }
        }
        public static async void Call()
        {
            await Asyncfun();
        }
        public  void Run()
       {
            Call();
            Console.ReadLine();
        }
    }
}