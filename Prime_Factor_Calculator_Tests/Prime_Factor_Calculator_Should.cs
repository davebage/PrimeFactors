using System;
using NUnit.Framework;
using PrimeFactors;

namespace Prime_Factor_Calculator_Tests
{
    public class Prime_Factor_Calculator_Should
    {
        private PrimeFactorCalculator primeFactorCalculator;

        [SetUp]
        public void Setup()
        {
            primeFactorCalculator = new PrimeFactorCalculator();
        }

        [Test]
        public void throw_exception_for_non_positive_input()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => primeFactorCalculator.GeneratePrimeFactorsFor(-1));
        }

        [Test]
        public void return_two_for_input_of_two()
        {
            Assert.That(primeFactorCalculator.GeneratePrimeFactorsFor(2), Is.EqualTo(2));
        }

        [Test]
        public void return_three_for_input_of_three()
        {
            Assert.That(primeFactorCalculator.GeneratePrimeFactorsFor(3), Is.EqualTo(3));
        }
    }
}