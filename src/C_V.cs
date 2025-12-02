using System.Numerics;




    // C V - Chance Variability

    // Supports only non-negative numbers.
    // Provides precomputed factorial constants from 3! to 20!.


   
    public static  class C_V
    {
        public const int Factorial3 = 6;
        public const int Factorial4 = 24;
        public const int Factorial5 = 120;
        public const int Factorial6 = 720;
        public const int Factorial7 = 5040;
        public const int Factorial8 = 40320;
        public const int Factorial9 = 362880;
        public const int Factorial10 = 3628800;
        public const int Factorial11 = 39916800;
        public const int Factorial12 = 479001600;
        public const long Factorial13 = 6227020800;
        public const long Factorial14 = 87178291200;
        public const long Factorial15 = 1307674368000;
        public const long Factorial16 = 20922789888000;
        public const long Factorial17 = 355687428096000;
        public const long Factorial18 = 6402373705728000;
        public const long Factorial19 = 121645100408832000;
        public const long Factorial20 = 2432902008176640000;
        

        private static Dictionary<ushort, BigInteger> FactorialCache = new Dictionary<ushort, BigInteger>();

        private static readonly long[] factorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000 };

        /// <summary>
        /// Returns a BigInteger representing the factorial in the range 0–65535.
        /// Provides an option to cache factorials larger than 20!.
        /// However, enabling this cache may cause unnecessary overflow since factorials grow very large.
        /// Therefore, the cache option is set to false by default.
        /// </summary>

        public static BigInteger Factorial(ushort k , bool cache = false)
        {
            if (k == 0 || k == 1) return BigInteger.One;
            else if (k == 2) return 2;


            BigInteger Pk = 1;
            if (cache &&  k > 20 && FactorialCache.TryGetValue(k, out Pk)) return Pk;
            else if ( k <= 20) return factorials[k];

            for (int i = 1; i <= k + 1; ++i)
            {
                Pk *= i;
            }
            if (cache && k > 20) FactorialCache[k] = Pk;
            return Pk;
        }


        /// <summary>
        /// Returns an int. Representing factorial in the range of 0 - 12.
        /// Returns factorial of 12! , if your argument  (int n) is bigger than 12.
        /// Automatically parses your number to the positive counterpart.
        /// (faster than Factorial one)
        /// </summary>
        public static int FactorialINT32(int n)
        {
            if (n < 0) n = Math.Abs(n);
            if (n > 12) return 479001600;

            switch (n)
            {
                case 0: return 1;
                case 1: return 1;
                case 2: return 2;
                case 3: return 6;
                case 4: return 24;
                case 5: return 120;
                case 6: return 720;
                case 7: return 5040;
                case 8: return 40320;
                case 9: return 362880;
                case 10: return 3628800;
                case 11: return 39916800;
                case 12: return 479001600;
                default: return 479001600;
            }
        }

        /// <summary>
        /// Returns a long. Representing factorial in the range of 0 - 20.
        /// Returns factorial of 20! , if your argument  (int n) is bigger than 20.
        /// Automatically parses your number to the positive counterpart.
        /// (faster than Factorial one)
        /// </summary>

        public static long FactorialINT64(int n)
        {
            if (n < 0) n = Math.Abs(n);
            if (n > 20) return 2432902008176640000;
            return factorials[n];
        }


        /// <summary>
        /// Returns a BigInteger representing the value of Permutation formula.
        /// </summary>
        public static BigInteger Permutations(ushort k, ushort n)
        {
            if (k < 0 || n < 0 || k > n) return BigInteger.Zero;
            if (k == 0) return BigInteger.One;

            BigInteger result = BigInteger.One;
            for (int i = 0; i < k; ++i)
            {
                result *= (n - i);
            }
            return result;
        }





        /// <summary>
        /// Returns a BigInteger representing the value of Combinations formula.
        /// </summary>
        public static BigInteger Combinations(ushort k, ushort n)
        {
            if (n == 0 || n < k) return BigInteger.Zero;
            
            if (k > n / 2)k = (ushort)(n - k);
            BigInteger result = BigInteger.One;
            for (int i = 1; i <= k; ++i)
            {
                result = result * (n - i + 1) / i;
            }
            return result;
        }

        /// <summary>
        /// Returns an int representing the value of Combinations formula.
        /// The Lite version of the Combinations, because it takes numbers in range of 0 - 255.
        /// (faster than Combinations)
        /// </summary>
        public static int CombinationsLite(byte k, byte n)
        {
            if (n == 0 || n < k) return 0;
            if (k > n / 2) k = (byte)(n - k);
            int result = 1;
            for (int i = 1; i <= k; ++i)
            {
                result = result * (n - i + 1) / i;
            }
            return result;
        }

        /// <summary>
        /// Returns a positive double in range of 0 - 1. The Value of Binomial Probability formula.
        /// </summary>
        public static double BinomialProbability(byte k, byte n, double p)
        {
            p = Math.Clamp(p,0,1);

            return CombinationsLite(k, n) * Math.Pow(p,k) * Math.Pow(1-p,n-k);
        }

        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static sbyte Probability(sbyte m, sbyte n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return (sbyte)(m / n);
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static byte Probability(byte m, byte n)
        {
            if (m == 0 || n == 0) return 0;
            return (byte)(m / n);
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static short Probability(short m, short n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return (short)(m / n);
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static ushort Probability(ushort m, ushort n)
        {
            if (m == 0 || n == 0) return 0;
            return (ushort)(m / n);
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static int Probability(int m, int n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static uint Probability(uint m, uint n)
        {
            if (m == 0 || n == 0) return 0;
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static long Probability(long m, long n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static ulong Probability(ulong m, ulong n)
        {
            if (m == 0 || n == 0) return 0;
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static decimal Probability(decimal m, decimal n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static Int128 Probability(Int128 m, Int128 n)
        {
            if (m == 0 || n == 0) return 0;
            if (m < 0) m = -m;
            if (n < 0) n = -n;
            
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static UInt128 Probability(UInt128 m, UInt128 n)
        {
            if (m == 0 || n == 0) return 0;
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static BigInteger Probability(BigInteger m, BigInteger n)
        {
            if (m == 0 || n == 0) return 0;
            if (m < 0) m = -m;
            if (n < 0) n = -n;
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static float Probability(float m, float n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return m / n;
        }
        /// <summary>
        /// Returns a positive probability of number , formula is P = m/n 
        /// </summary>
        public static double Probability(double m, double n)
        {
            if (m == 0 || n == 0) return 0;
            m = Math.Abs(m);
            n = Math.Abs(n);
            return m / n;
        }


    }

