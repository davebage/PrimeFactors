using NUnit.Framework;
using PrimeFactors;

namespace Prime_Factor_Calculator_Tests
{
    public class Prime_Factor_Calculator_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_two_for_input_of_two()
        {
            PrimeFactorCalculator primeFactorCalculator = new PrimeFactorCalculator();

            Assert.That(primeFactorCalculator.GeneratePrimeFactorsFor(2), Is.EqualTo(2));
        }
    }
}