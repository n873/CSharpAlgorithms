using System;

namespace OnesComplement
{
    public static class OnesComplementExtension
    {
        public static int OnesComplement(this int n) {
            var numberOfBits = (int)(Math.Floor(Math.Log(n) / Math.Log(2))) + 1; //Find number of bits in the given integer
            return ((1 << numberOfBits) - 1) ^ n;
        }
    }
}
