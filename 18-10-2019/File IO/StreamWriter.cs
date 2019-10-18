using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Text
    {
        public void Nesting()
        {
            FileStream f = new FileStream("e:\\output.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("Hello World");
            s.Close();
            f.Close();
            Console.WriteLine("File Created Succesfully");
        }
    }
}
