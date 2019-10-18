using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           // Demo obj = new Demo();
            //obj.Function();
            // ReadingByte r = new ReadingByte();
            // r.Run();
            // Text t = new Text();
            // t.Nesting();
            // Book b = new Book();
            //b.Request();
           //Runtime rt = new Runtime();
          // rt.Comment();
           // Basic obj = new Basic();
           // obj.Delegate();
            Touchpad obj = new Touchpad();
            obj.Compund();
            Test let = new Test();
            let.Analyze();
            Console.ReadKey();

        }
    }
}
