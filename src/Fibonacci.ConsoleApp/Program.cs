using System;
using Fibonacci.Generator;

namespace Fibonacci.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Get which position in the Fibonacci sequence : ");
            var positionString = Console.ReadLine();

            var seqNumber = FibonacciGenerator.GetNumberInNPositonOfSequence(positionString);

            if (seqNumber == -1)
            {
                Console.WriteLine("The value '{0}' you entered was invalid!", positionString);
            }
            else
            {
                Console.WriteLine("The {0} number in the Fibonacci Sequence is : = {1}", positionString, seqNumber);
            }

            Console.ReadKey();
        }
    }
}