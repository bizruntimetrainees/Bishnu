using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInheritance2 obj = new TestInheritance2();
            obj.CallParent();
            CompileTimePolymorphism r = new CompileTimePolymorphism();
            r.Run();
            TestPolymorphism t = new TestPolymorphism();
            t.Compile();



        }
    }
}
