using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_03_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 100;

            while (x < y) {
                x = x + 2;
                Console.WriteLine("Condicion verdadera, X es: "+x);
            }

            Console.ReadKey();
        }
    }
}
