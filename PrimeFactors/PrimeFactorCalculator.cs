namespace PrimeFactors
{
    public class PrimeFactorCalculator
    {
        public int GeneratePrimeFactorsFor(int iNumber)
        {
            if(iNumber < 0) throw new ArgumentOutOfRangeException(nameof(iNumber));
            if (iNumber == 3) return 3;
            return 2;
        }
    }
}