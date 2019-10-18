using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileHandling
{
    class Test
    {
        public void Analyze()
        {
            StringWriter st = new StringWriter();
            st.WriteLine("Hello World");
            st.Close();
            StringReader sr = new StringReader(st.ToString());
            while(sr.Peek()>.1)
            {
                Console.WriteLine();
            }
        }
    }
}
