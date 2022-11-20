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
            Console.WriteLine("Type exit to exit");

            int total = 0;
            String input = Console.ReadLine();
            while (input != "exit")
            {
                switch (input)
                {
                    case "Small":
                        Console.WriteLine("You orderd a Small Coffee");
                        total += 3;
                        break;

                    case "Medium":
                        Console.WriteLine("You orderd a Medium Coffee");
                        total += 5;
                        break;

                    case "Large":
                        Console.WriteLine("You orderd a Medium Coffee");
                        total += 7;
                        break;

                    default:
                        Console.WriteLine("Your choice is unavailbale");
                        break;
                }
                Console.WriteLine("Total: $"+ total);
                Console.WriteLine("Do you want anything else?");
                input = Console.ReadLine();
            }
            Console.WriteLine("Thank you for your shopping");
            Console.ReadKey();

        }
    }
}
