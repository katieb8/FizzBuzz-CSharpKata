using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzGenerateTest
    {
        private Generator _generator;

        [SetUp]

        public void SetUp()
        {
            _generator = new Generator();
        }

        [TestCase(2, "2"), 
         TestCase(4, "4"),
         TestCase(7, "7")
        ]
        public void CanReturnInputNumber2(int userInput, string expectedResult)
        {
            var result = _generator.Generate(userInput);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(3, "Fizz")]
        public void CanReturnFizzOnInputDivisibleBy3(int userInput, string expectedResult)
        {
            var result = _generator.Generate(userInput);
            Assert.AreEqual(expectedResult, result);
        }
    }
}