using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS1
{
    class Students
    {
        static String nm;
        static String adr;
        int Sno;
        String name;
        String Adress;
        static Students()
        {
            nm = "ST";
            adr = "BANGALORE";
        }
        Students(int x,string y,string z)
        {
            Sno = x;
            name = y;
            Adress = z;
        }
        static void Display()
        {
            Console.WriteLine(nm + " " + adr);
        }
        void Data()
        {
            Console.WriteLine(Sno);
            Console.WriteLine(name);
            Console.WriteLine( adr);
        }
       static void Main(string[]args)
        {
            Students s2 = new Students(101,"ABA","Hyy") ;
            s2.Data();
        }
        }

    }

