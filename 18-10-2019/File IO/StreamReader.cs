using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Book
    {
        public void Request()
        {
            FileStream f = new FileStream("e:\\Output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            String line = " ";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            
            s.Close();
            f.Close();
            
        }

       
        
        }
    }
