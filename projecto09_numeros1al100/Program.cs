using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecto09_numeros1al100
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            while (x<=100)
            {
                //Console.WriteLine(x);
                Console.Write(x + " ");
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
