using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Tiger
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Cat : Tiger
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }

    }
    public class TestPolymorphism
    {
        public  void Compile()
        {
            Tiger a = new Cat();
            a.eat();
        }
    
    
        }
    }

