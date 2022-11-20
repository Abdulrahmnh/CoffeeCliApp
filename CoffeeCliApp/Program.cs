using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCliApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Shop");
            Console.WriteLine("Choice one of the Following:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Small\t\t$3");
            Console.WriteLine("Medium\t\t$5");
            Console.WriteLine("Large\t\t$7");

            String input = Console.ReadLine();

            if (input == "Small")
            {
                Console.WriteLine("You orderd a Small Coffee");
                Console.WriteLine("Total: $3");
            }
            else if (input == "Medium")
            {
                Console.WriteLine("You orderd a Medium Coffee");
                Console.WriteLine("Tottal: $5");
            }
            else if (input == "Large")
            {
                Console.WriteLine("You orderd a Large Coffee");
                Console.WriteLine("Total: $7");
            }
            else
            {
                Console.WriteLine("Your choice is unavailbale");
            }

            Console.ReadKey();

        }
    }
}
