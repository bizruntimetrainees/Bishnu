using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class ProductsQueue
    {
     
        
interface Iproduct
{
    void Add();
    void Remove();
    void Retriev();
    void Present();
}
class Implements : Iproduct
{
            public void Add()
    {

        Queue product = new Queue();
        product.Enqueue("BMW");
        product.Enqueue("PHONE");
        product.Enqueue("MARKER");
        product.Enqueue("Audi");
        product.Enqueue("PEN");
        product.Enqueue("LAPTOP");


        foreach (string i in product)
        {
            Console.WriteLine(i);
        }

    }

            public void Retriev()
            {
                Queue product = new Queue();
                product.Enqueue("BMW");
                product.Enqueue("PHONE");
                product.Enqueue("MARKER");
                product.Enqueue("Audi");
                product.Enqueue("PEN");
                product.Enqueue("LAPTOP");

                Console.WriteLine(product.Peek());

            }
                public void Present()
    {
        Queue product = new Queue();
                product.Enqueue("BMW");
                product.Enqueue("PHONE");
                product.Enqueue("MARKER");
                product.Enqueue("Audi");
                product.Enqueue("PEN");
                product.Enqueue("LAPTOP");

                Console.WriteLine(product.Contains("LAPTOP"));

    }
    public void Remove()
    {
        Queue product = new Queue();
                product.Enqueue("BMW");
                product.Enqueue("PHONE");
                product.Enqueue("MARKER");
                product.Enqueue("Audi");
                product.Enqueue("PEN");
                product.Enqueue("LAPTOP");


                while (product.Count > 0)
        {
            Console.WriteLine(product.Dequeue());
        }
        Console.WriteLine("----------------------------");
        Console.WriteLine(product.Count);

    }


}
    }
}

