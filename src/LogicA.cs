

// Logic A (Logic Additions)

// some logic  functions.

// G_Parity is general parity.
// G_Majority is general majority.

/// <summary>
/// Provides additional logic functions.
/// </summary>


public static class LogicA
    {
        private static readonly Random _rand = new Random();
        public static bool Implication(bool a , bool b)
        {
            return !a || b;
        }
        public static bool Equivalence(bool a, bool b)
        {
            return a == b;
        }
        public static bool NAND(bool a, bool b)
        {
            return !(a && b);
        }
        public static bool NOR(bool a, bool b)
        {
            return !(a || b);
        }
        public static bool ReverseImplication(bool a, bool b)
        {
            return !b || a;
        }
        
        public static bool XOR(bool a, bool b)
        {
            return a ^ b;
        }
        public static bool XNOR(bool a, bool b)
        {
            return !(a ^ b);
        }

        public static bool Majority(bool a, bool b, bool c)
        {
          return(a && b) || (a && c) || (b && c);
        }
        public static bool Parity(bool a, bool b, bool c)
        {
            return a ^ b ^ c;
        }

        public static bool G_Majority(params bool[] booleans)
        {
            int t = 0;
            foreach (bool b in booleans) if (b) ++t;
            return t > booleans.Length/2;
        }

        public static bool G_Parity(params bool[] booleans)
        {
            int t = 0;
            foreach (bool b in booleans) if (b) ++t;
            return t % 2 == 1;
        }
        /// <summary>
        /// Returns true if exactly k conditions are satisfied among a set of booleans.
        /// </summary>
        public static bool k_in_n(  int k , params bool[] n )
        {
        int t = 0;
        foreach (bool b in n) if (b) ++t;
        return t == k;
        }   

    /// <summary>
    /// Returns true or false. (Randomly)
    /// </summary>
    public static bool RandTrueOrFalse()
        {
            return _rand.Next(2) == 0;
        }
    /// <summary>
    /// Returns true or false.(Randomly, but with some structure beneath)
    /// </summary>
    public static bool _A_or_B_(bool a , bool b)
        {
            bool b1 = _rand.Next(2) == 0;
            bool b2 = _rand.Next(2) == 1;

            if (b1 && b2) return a && b;
            else if (a && b2) return b1 && b;
            else if (!a && b1) return b1;
            else if (!b1 && b2) return b2;
            else if (a && b2) return a;
            else if (!a && b2 || b) return b1 || b;
            else if (!b || a) return b1 || b2 || b;
            else if (b2 || !a) return b1 || b2 || b || a;
            else return !a ^ b || !b && b2 || !a is false && b1 || a;
        }
    /// <summary>
    /// Returns a or b.(Randomly)
    /// </summary>
    public static bool Random_A_or_B(bool a, bool b)
        {
            return _rand.Next()  == 0 ? a : b;
        }

}

