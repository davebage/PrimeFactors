namespace PrimeFactors
{
    public class PrimeFactorCalculator
    {
        private readonly int[] prime_numbers = new int[] { 2, 3, 5, 7, 9, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293 };

        public List<int> GeneratePrimeFactorsFor(int iNumber)
        {
            if (iNumber < 0) throw new ArgumentOutOfRangeException(nameof(iNumber));
            if (iNumber == 0) return new List<int>();

            List<int> primeFactors = new List<int>();

            foreach (int prime_number in prime_numbers)
            {
                if (prime_number == iNumber)
                {
                    primeFactors.Add(prime_number);
                    break;
                }
                
                while (iNumber % prime_number == 0 && iNumber / prime_number != 0)
                {
                    iNumber /= prime_number;
                    primeFactors.Add(prime_number);
                }
            }

            return primeFactors;
        }
    }
}
