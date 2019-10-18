using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class ReadingByte
    {
        public void Run()
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            f.Close();
        }
    }
}
