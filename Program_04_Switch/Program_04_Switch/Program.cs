using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_04_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra; // String letra
            Console.Write("Introduce una letra (a ó b): ");
            letra = Console.ReadKey().KeyChar; // letra = Console.ReadLine()
            Console.WriteLine();

            switch (letra) { // INicio del Switch
                case 'a': {
                    Console.WriteLine("Haz presisonado la letra 'a'.");
                    break;
                }

                case 'b': {
                    Console.WriteLine("Haz presisonado la letra 'b'.");
                    break;
                }
            }   // Fin del Switch
            Console.ReadKey();
        }
    }
}
