using System;
using System.Collections.Generic;
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
        [TestCase(2, new int[] { 2 })]
        [TestCase(3, new int[] { 3 })]
        [TestCase(4, new int[] { 2, 2 })]
        [TestCase(5, new int[] { 5 })]
        [TestCase(6, new int[] { 2, 3 })]
        [TestCase(8, new int[] { 2, 2, 2 })]
        [TestCase(15, new int[] { 3, 5 })]
        [TestCase(460, new int[] { 2, 2, 5, 23 })]
        public void return_primefactors_for_input(int number, int[] expectedResult)
        {
            List<int> primeFactors = primeFactorCalculator.GeneratePrimeFactorsFor(number);
            Assert.Multiple(() =>
            {
                Assert.That(primeFactors.Count, Is.EqualTo((expectedResult.Length)));
                Assert.That(primeFactors, Is.EquivalentTo(expectedResult));
            });
        }
    }
}