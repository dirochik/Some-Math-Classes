

// Math A (Math Additions)


// some math constants and math functions.



using System.Numerics;

/// <summary>
/// Provides additional math constants and math functions.
/// </summary>
public static class MathA
{
    public const double PHI = 1.61803398874989484820;
    public const float PHI_f = 1.6180339f;

    public const double OMEGA = 0.56714329040978387299;
    public const float OMEGA_f = 0.5671432f;

    public const double SQRT2 = 1.4142135623730951;
    public const float SQRT2_f = 1.4142135f;

    public const double SQRT3 = 1.7320508075688772;
    public const float SQRT3_f = 1.7320508f;

    public const double EulerGamma = 0.5772156649015329;
    public const float EulerGamma_f = 0.5772156f;

    public const double SilverRatio = 2.414213562373095;
    public const float SilverRatio_f = 2.4142135f;

    public const double SuperGoldenRatio = 1.465571231876768;
    public const float SuperGoldenRatio_f = 1.4655712f;

    public const double CubeRoot2 = 1.2599210498948732;
    public const float CubeRoot2_f = 1.2599210f;

    public const double CubeRoot3 = 1.4422495703074083;
    public const double CubeRoot3_f = 1.4422495f;

    public const double SqrtPi = 1.772453850905516;
    public const double SqrtPi_f = 1.7724538f;

    public static byte MagnitudeSq(byte a, byte b , bool check = false)
    {
        if (!check) return (byte)(a * a + b * b);
        else return checked((byte)(a * a + b *b));
    }
    public static sbyte MagnitudeSq(sbyte a, sbyte b, bool check = false)
    {
        if (!check) return (sbyte)(a * a + b * b);
        else return checked((sbyte)(a * a + b * b));
    }
    public static short MagnitudeSq(short a, short b, bool check = false)
    {
        if (!check) return (short)(a * a + b * b);
        else return checked((short)(a * a + b * b));
    }
    public static ushort MagnitudeSq(ushort a, ushort b, bool check = false)
    {
        if (!check) return (ushort)(a * a + b * b);
        else return checked((ushort)(a * a + b * b));
    }
    public static nint MagnitudeSq(nint a , nint b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static nuint MagnitudeSq(nuint a, nuint b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static int MagnitudeSq(int a, int b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static uint MagnitudeSq(uint a, uint b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static long MagnitudeSq(long a, long b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static ulong MagnitudeSq(ulong a, ulong b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static float MagnitudeSq(float a, float b)
    {
        return a * a + b * b;
    }
    public static double MagnitudeSq(double a, double b)
    {
        return a * a + b * b;
    }
    public static decimal MagnitudeSq(decimal a , decimal b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static Int128 MagnitudeSq(Int128 a, Int128 b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static UInt128 MagnitudeSq(UInt128 a, UInt128 b, bool check = false)
    {
        if (!check) return a * a + b * b;
        else return checked(a * a + b * b);
    }
    public static BigInteger MagnitudeSq(BigInteger a, BigInteger b)
    {
        
        return a * a + b * b;
    }



    public static byte Magnitude(byte a, byte b, bool check = false)
    {
        if (!check) return (byte)MathF.Sqrt(a * a + b * b);
        else return checked((byte)MathF.Sqrt(a * a + b * b));
    }
    public static sbyte Magnitude(sbyte a, sbyte b, bool check = false)
    {
        if (!check) return (sbyte)MathF.Sqrt(a * a + b * b);
        else return checked((sbyte)MathF.Sqrt(a * a + b * b));
    }
    public static short Magnitude(short a, short b, bool check = false)
    {
        if (!check) return (short)Math.Sqrt(a * a + b * b);
        else return checked((short)Math.Sqrt(a * a + b * b));
    }
    public static ushort Magnitude(ushort a, ushort b, bool check = false)
    {
        if (!check) return (ushort)Math.Sqrt(a * a + b * b);
        else return checked((ushort)Math.Sqrt(a * a + b * b));
    }
    public static nint Magnitude(nint a, nint b, bool check = false)
    {
        if (!check) return (nint)Math.Sqrt(a * a + b * b);
        else return checked((nint)Math.Sqrt(a * a + b * b));
    }
    public static nuint Magnitude(nuint a, nuint b, bool check = false)
    {
        if (!check) return (nuint)Math.Sqrt(a * a + b * b);
        else return checked((nuint)Math.Sqrt(a * a + b * b));
    }
    public static int Magnitude(int a, int b, bool check = false)
    {
        if (!check) return (int)Math.Sqrt(a * a + b * b);
        else return checked((int)Math.Sqrt(a * a + b * b));
    }
    public static uint Magnitude(uint a, uint b, bool check = false)
    {
        if (!check) return (uint)Math.Sqrt(a * a + b * b);
        else return checked((uint)Math.Sqrt(a * a + b * b));
    }
    public static long Magnitude(long a, long b, bool check = false)
    {
        if (!check) return (long)Math.Sqrt(a * a + b * b);
        else return checked((long)Math.Sqrt(a * a + b * b));
    }
    public static ulong Magnitude(ulong a, ulong b, bool check = false)
    {
        if (!check) return (ulong)Math.Sqrt(a * a + b * b);
        else return checked((ulong)Math.Sqrt(a * a + b * b));
    }
    public static float Magnitude(float a, float b)
    {
        return MathF.Sqrt(a * a + b * b);
    }
    public static double Magnitude(double a, double b)
    {
        return Math.Sqrt(a * a + b * b);
    }
    public static decimal Magnitude(decimal a, decimal b, bool check = false)
    {
        if (!check) return (decimal)Math.Sqrt((double)(a * a + b * b));
        else return checked((decimal)Math.Sqrt((double)(a * a + b * b)));
    }




    public static bool IsPrime(ulong num)
    {
        if (num <= 1) return false;
        if (num <= 3) return true;
        if (num % 2 == 0) return false;
        for (ulong i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    public static bool IsPowerOfTwo(ulong num)
    {
        return num > 0 && (num & (num - 1)) == 0;
    }
    public static bool IsPowerOfTwo_double(double num)
    {
        if (num <= 0) return false;
        double log2 = Math.Log(num, 2);
        return Math.Abs(log2 - Math.Round(log2)) < 1e-10;
    }
    public static bool IsEven(long num)
    {
        return num % 2 == 0;
    }
    public static bool IsOdd(long num)
    {
        return num % 2 != 0;
    }
   

    public static byte Mod(byte a, byte n) { return (byte)(((a % n) + n) % n); }
    public static sbyte Mod(sbyte a, sbyte n) { return (sbyte)(((a % n) + n) % n); }
    public static short Mod(short a, short n) { return (short)(((a % n) + n) % n); }
    public static ushort Mod(ushort a, ushort n) { return (ushort)(((a % n) + n) % n); }
    public static nint Mod(nint a, nint n) { return ((a % n) + n) % n; }
    public static nuint Mod(nuint a, nuint n) { return ((a % n) + n) % n; }
    public static int Mod(int a, int n) { return ((a % n) + n) % n; }
    public static uint Mod(uint a, uint n) { return ((a % n) + n) % n; }
    public static long Mod(long a, long n) { return ((a % n) + n) % n; }
    public static ulong Mod(ulong a, ulong n) { return ((a % n) + n) % n; }
    public static float Mod(float a, float n) { return ((a % n) + n) % n; }
    public static double Mod(double a, double n) { return ((a % n) + n) % n; }
    public static decimal Mod(decimal a, decimal n) { return ((a % n) + n) % n; }
    public static Int128 Mod(Int128 a, Int128 n) { return ((a % n) + n) % n; }
    public static UInt128 Mod(UInt128 a, UInt128 n) { return ((a % n) + n) % n; }
    public static BigInteger Mod(BigInteger a, BigInteger n) { return ((a % n) + n) % n; }


    public static float NormalizeF(float n, float min , float max)
    {
        if (max - min == 0) return 0;
        return (n - min) / (max - min);
    }
    public static decimal NormalizeD(decimal n, decimal min, decimal max)
    {
        
        if (max - min == 0) return 0;
        return (n - min) / (max - min);
    }
    public static double Normalize(double n, double min, double max)
    {
        if (max - min == 0) return 0;
        return (n - min) / (max - min);

        
    }



   
    public static float AverageF(params float[] a)
    {
        if (a.Length == 0) return 0;
        float sum = 0;
        foreach (float b in a) sum += b;
        return sum / a.Length;
    }
    public static double Average(params double[] a)
    {
        if (a.Length == 0) return 0;
        double sum = 0;
        foreach (double b in a) sum += b;
        return sum / a.Length;
    }
    public static decimal AverageD(params decimal[] a)
    {
        if (a.Length == 0) return 0;
        decimal sum = 0;
        foreach (decimal b in a) sum += b;
        return sum / a.Length;
    }
 


    public static double Sum(params double[] g)
    {
        double sum = 0;
        foreach(double b in g) sum += b;
        return sum;
    }
    public static decimal SumD(params decimal[] g)
    {
        decimal sum = 0;
        foreach (decimal b in g) sum += b;
        return sum;
    }
    public static float SumF(params float[] g)
    {
        float sum = 0;
        foreach (float b in g) sum += b;
        return sum;
    }
    
    public static int DigitSum(ulong n)
    {
        if (n == 0) return 0;
        else if( n == 1) return 1;
        else if( n == 2) return 2;
        else if( n == 3) return 3;
        else if( n == 4) return 4;
        else if( n == 5) return 5;
        else if( n == 6) return 6;
        else if( n == 7) return 7;
        else if( n == 8) return 8;
        else if( n == 9) return 9;
        char[] c = n.ToString().ToCharArray();
        int sum = 0;
        foreach (char cc in c)
        {
            sum += cc - '0';
        }
        return sum;
    }
    public static int DigitCount(ulong n)
    {
        return n.ToString().Length;
    }

    public static double MapRange(double n, double fromMin, double fromMax, double toMin, double toMax)
    {
        return toMin + (n - fromMin) * (toMax - toMin) / (fromMax - fromMin);
    }
    public static float MapRangeF(float n, float fromMin, float fromMax, float toMin, float toMax)
    {
        return toMin + (n - fromMin) * (toMax - toMin) / (fromMax - fromMin);
    }
    public static decimal MapRangeD(decimal n, decimal fromMin, decimal fromMax, decimal toMin, decimal toMax)
    {
        return toMin + (n - fromMin) * (toMax - toMin) / (fromMax - fromMin);
    }

    public static double CubeRoot(double x)
    {
        return Math.Pow(x,1.0/3.0);
    }
    public static float CubeRootF(float x)
    {
        return (float)Math.Pow(x, 1.0 / 3.0);
    }

    /// <summary>
    /// Finds a Greatest Common Divisor.
    /// </summary>
    public static int gcd(int a, int b)
    {
        while (b != 0) { int v = b; b = a % b; a = v; }
        return Math.Abs(a);
    }
    /// <summary>
    /// Finds a Greatest Common Divisor.
    /// </summary>
    public static uint gcd(uint a, uint b)
    {
        while (b != 0) {uint v = b; b = a % b; a = v; }
        return a;
    }
    /// <summary>
    /// Finds a Greatest Common Divisor.
    /// </summary>
    public static long gcd(long a, long b)
    {
        while (b != 0) { long v = b; b = a % b; a = v; }
        return Math.Abs(a);
    }
    /// <summary>
    /// Finds a Greatest Common Divisor.
    /// </summary>
    public static ulong gcd(ulong a, ulong b)
    {
        while (b != 0) { ulong v = b; b = a % b; a = v; }
        return a;
    }
    /// <summary>
    /// Finds a Least Common Multiple.
    /// </summary>
    public static int lcm(int a, int b)
    {
        if (a == 0 || b == 0) return 0;
        return Math.Abs(a*b) / gcd(a, b) ;
    }
    /// <summary>
    /// Finds a Least Common Multiple.
    /// </summary>
    public static uint lcm(uint a , uint b)
    {
        if (a == 0 || b == 0) return 0;
        return a*b / gcd(a, b) ;
    }
    /// <summary>
    /// Finds a Least Common Multiple.
    /// </summary>
    public static long lcm(long a, long b)
    {
        if (a == 0 || b == 0) return 0;
        return Math.Abs(a * b) / gcd(a, b) ;
    }
    /// <summary>
    /// Finds a Least Common Multiple.
    /// </summary>
    public static ulong lcm(ulong a, ulong b)
    {
        if (a == 0 || b == 0) return 0;
        return a * b / gcd(a, b);
    }



    public static int ModPow(int n, int exp, int mod)
    {
        int r = 1; n %= mod;
        while (exp > 0)
        {
            if ((exp & 1) == 1) r = (r * n) % mod;
            n = (n * n) % mod; exp >>= 1;
        }
        return r;
    }
    public static uint ModPow(uint n, uint exp, uint mod)
    {
        uint r = 1; n %= mod;
        while (exp > 0)
        {
            if ((exp & 1) == 1) r = (r * n) % mod;
            n = (n * n) % mod; exp >>= 1;
        }
        return r;
    }
    public static long ModPow(long n, long exp, long mod)
    {
        long r = 1; n %= mod;
        while (exp > 0) { if ((exp & 1) == 1) r = (r * n) % mod; 
            n = (n * n) % mod; exp >>= 1; }
        return r;
    }
    public static ulong ModPow(ulong n, ulong exp, ulong mod)
    {
        ulong r = 1; n %= mod;
        while (exp > 0)
        {
            if ((exp & 1) == 1) r = (r * n) % mod;
            n = (n * n) % mod; exp >>= 1;
        }
        return r;
    }

}

