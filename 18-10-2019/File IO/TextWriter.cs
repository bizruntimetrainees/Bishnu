using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Runtime
    {
        public  void Comment()
        {
            string file = "e:\\f.txt";
            using (TextWriter writer = File.CreateText(file)) 
            {
                writer.WriteLine("Hello World ");
                writer.WriteLine("BizRuntime");
            }
            Console.WriteLine("File Created Succesfully");
        }
    }
}

