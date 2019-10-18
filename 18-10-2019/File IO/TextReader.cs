using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Basic
    {
        public void Delegate()
        {
            string file = "e:\\f.txt";
            using (TextReader t = File.OpenText(file)) 
            {
                Console.WriteLine(t.ReadToEnd());
            }
        }
        
    }
}
