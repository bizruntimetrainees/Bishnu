using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String fname, lname;
            fname = "Biz";
            lname = "Runtime";
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            String s = fname + lname;
            Console.WriteLine(s);

            string greetings = new string(letters);
            Console.WriteLine(greetings);

            string message = String.Join(" ", sarray);
            Console.WriteLine(message);


            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine(chat);


           // LengthOfString t = new LengthOfString();
           // t.Run();
           // ComparingStrings r = new ComparingStrings();
           // r.callpointer();

        }
    }
        
        
    }

