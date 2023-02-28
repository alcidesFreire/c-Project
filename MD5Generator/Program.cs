using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world elizeu");

            var nome = System.Console.ReadLine();
            
            var key = System.Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                key = System.Console.ReadKey();
            }
            Environment.Exit(0);
        }
    }
}
