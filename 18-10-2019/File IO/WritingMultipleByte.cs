using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileHandling
{
    class Demo
    {
        public void Function()
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
            Console.ReadKey();
        }
    }
}

            
        
        

        
        
    

