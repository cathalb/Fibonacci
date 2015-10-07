using System;
using NUnit.Framework;

namespace Fibonacci.Generator.Tests
{
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 1)]
        [TestCase("3", 2)]
        [TestCase("4", 3)]
        [TestCase("12", 144)]
        [TestCase("a", -1)]
        [TestCase("20", 6765)]
        [TestCase("30", 832040)]
        [TestCase("40", 102334155)]
        [TestCase("50", 12586269025)]
        [TestCase("60", 1548008755920)]
        [TestCase("70", 190392490709135)]
        [TestCase("80", 23416728348467685)]
        [TestCase("90", 2880067194370816120)]
        [TestCase("100", -1)]
        [TestCase("10000000000", -1)]
        public void GivenANumberWhenNumberGenerateThenItMatchesExpected(string input, Int64 expected)
        {
            var result = FibonacciGenerator.GetNumberInNPositonOfSequence(input);

            Assert.AreEqual(expected, result);
        }
    }
}