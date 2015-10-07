using System;

namespace Fibonacci.Generator
{
    public static class FibonacciGenerator
    {
        public static Int64 GetNumberInNPositonOfSequence(string input)
        {
            var position = ValidateInput(input);
            return position == -1 ? position : GetSequenceUpToN(position);
        }

        private static int ValidateInput(string position)
        {
            int pos;
            if (int.TryParse(position, out pos))
            {
                return pos;
            }
            return -1;
        }

        private static Int64 GetSequenceUpToN(int position)
        {
            Int64 a = 0;
            Int64 b = 1;

            for (var i = 0; i < position; i++)
            {
                if (b < 0) return -1;
                Int64 temp = a;
                a = b;
                b = temp + a;
            }

            return a >= 0 ? a : -1;
        }
    }
}