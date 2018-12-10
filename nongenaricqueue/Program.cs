using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nongenericqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue kuyruk = new Queue();
            kuyruk.Enqueue("selenay solmaz");
            kuyruk.Enqueue(5);
            foreach(object a in kuyruk)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("***********************");

            object silinen = kuyruk.Dequeue();
            Console.WriteLine("silinen oge : " + silinen);
            foreach(object b in kuyruk)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }


    }
    
}
