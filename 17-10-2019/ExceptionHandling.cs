using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous1
{
    class ExceptionHandling
    {
        public Task ShowAsync()
        {
            return Task.Run(() =>
            {
                Task.Delay(2000);
                throw new Exception("My Own Exception");
            });
        }
        public async void Call()
        {
            await ShowAsync();
        }
    }
    class Demo
    {
        public  void Callpointer()
        {
            ExceptionHandling obj = new ExceptionHandling();
            try
            {
                obj.Call();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}