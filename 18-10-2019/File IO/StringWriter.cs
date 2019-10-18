using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;



namespace FileHandling
{
    class Touchpad
    {
        public void Compund()
        {
            String txt = "Hello World \n" + "its nice \n" + "How r u";
            StringBuilder sb = new StringBuilder();
            StringWriter st = new StringWriter(sb);
            st.WriteLine(txt);
            st.Flush();
            st.Close();
        
            StringReader sr = new StringReader(sb.ToString());
            while(sr.Peek()>-1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
