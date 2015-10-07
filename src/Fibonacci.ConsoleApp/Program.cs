using System;
using Fibonacci.Generator;

namespace Fibonacci.ConsoleApp
{
    internal class Program
    {
        private const string ExitString = "X";
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Get which position in the Fibonacci sequence (Type 'X' to finish) : ");
                var positionString = Console.ReadLine();

                if (positionString == null || positionString.ToUpper() == "X")
                    break;

                var seqNumber = FibonacciGenerator.GetNumberInNPositonOfSequence(positionString);

                if (seqNumber == -1)
                {
                    Console.WriteLine("The value '{0}' you entered was invalid!", positionString);
                }
                else
                {
                    Console.WriteLine("The {0} number in the Fibonacci Sequence is : = {1}", positionString, seqNumber);
                }
            }
        }
    }
}