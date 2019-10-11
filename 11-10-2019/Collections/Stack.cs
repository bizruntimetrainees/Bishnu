using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class ProductsStack
    {
        interface Iproduct
        {
            void Add();
            void Remove();
            void Retriev();
            void Present();


        }
       public class Implements : Iproduct
        {

            public void Add()
            {

                Stack product = new Stack();
                product.Push("BMW");
                product.Push("PHONE");
                product.Push("MARKER");
                product.Push("Audi");
                product.Push("PEN");
                product.Push("LAPTOP");


                foreach (string i in product)
                {
                    Console.WriteLine(i);
                }

            }

            public void Retriev()
            {
                Stack product = new Stack();
                product.Push("BMW");
                product.Push("PHONE");
                product.Push("MARKER");
                product.Push("Audi");
                product.Push("PEN");
                product.Push("LAPTOP");

                Console.WriteLine(product.Peek());

            }

            public void Present()
            {
                Stack product = new Stack();
                product.Push("BMW");
                product.Push("PHONE");
                product.Push("MARKER");
                product.Push("Audi");
                product.Push("PEN");
                product.Push("LAPTOP");

                Console.WriteLine(product.Contains("Koenigsegg"));

            }
            public void Remove()
            {
                Stack product = new Stack();
                product.Push("BMW");
                product.Push("PHONE");
                product.Push("MARKER");
                product.Push("Audi");
                product.Push("PEN");
                product.Push("LAPTOP");


                while (product.Count > 0)
                {
                    Console.WriteLine(product.Pop());
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine(product.Count);

            }


        }
    }
}
