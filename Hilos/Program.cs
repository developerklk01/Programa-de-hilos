using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(metodo));
            t.Start();
            for (int i = 0; i < 1000; i++)
            
                Console.Write("A");
              
              //Probando si se actualiza online 5


                Console.Read();
        }

        static void metodo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("B");
            }
        }
    }
}
