using System;

namespace OddManOut
{
    class Program
    {
        static int OddManOut(int[] ints)
        {
            int a = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                a = a ^ ints[i]; // XOR - Exclusive OR
            }
            return a;
        }


        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 4, 6, 8, 9, 2, 1, 4, 5, 8, 9 };
            Console.WriteLine(OddManOut(a));
        }
    }
}
