using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Math Magician. What would you like me to do?");
            Console.WriteLine("1. print positive integers\n2. print Fibonacci numbers\n3. print prime numbers");
            Console.Write("Your choice? ");
            string choice = Console.ReadLine();  // need error handling
            Console.Write("OK, I'm going to generate a list of ");
            switch(choice)
            {
                case "1":
                    Console.WriteLine("positive integers.");
                    Output.printIntegers();
                    break;
                case "2":
                    Console.WriteLine("Fibonacci numbers.");
                    Output.printFibonacci();
                    break;
                case "3":
                    Console.WriteLine("prime numbers.");
                    Output.printPrimes();
                    break;
                default:
                    break;
            }
        }
    }
}
