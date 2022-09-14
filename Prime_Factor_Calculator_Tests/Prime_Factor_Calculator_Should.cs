using System;
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
        public void throw_exception_for_non_positive_input()
        {
            PrimeFactorCalculator primeFactorCalculator = new PrimeFactorCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => primeFactorCalculator.GeneratePrimeFactorsFor(-1));
        }

        [Test]
        public void return_two_for_input_of_two()
        {
            PrimeFactorCalculator primeFactorCalculator = new PrimeFactorCalculator();

            Assert.That(primeFactorCalculator.GeneratePrimeFactorsFor(2), Is.EqualTo(2));
        }

        [Test]
        public void return_three_for_input_of_three()
        {
            PrimeFactorCalculator primeFactorCalculator = new PrimeFactorCalculator();

            Assert.That(primeFactorCalculator.GeneratePrimeFactorsFor(3), Is.EqualTo(3));
        }
    }
}