using System;

namespace GrundlProgrammering
{
    class Program
    {
        public static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c;
        }

        public static string CtoF(float degreesCelsius)
        {
            if (degreesCelsius < -271.15)
            {
                return "Temperature below absolute zero";
            }
            float degreesFahrenheit = (degreesCelsius * 9 / 5) + 32;
            return $"T = {degreesFahrenheit}F"; // String interpolation
        }

        public static string ElementaryOperations(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;
            int multi = a * b;
            string div = "Division by zero not possible";
            if (b != 0)
            {
                // Don't do integer division ...
                float d = (float)a / (float)b;
                div = d.ToString();
            } 
            
            return $"{sum} {diff} {multi}, {div}";
        }

        public static bool IsResultTheSame(int a, int b)
        {
            return a == b;
        }

        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }

        public static int Cube(int a)
        {
            return a * a * a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">The first integer to be swapped</param>
        /// <param name="b">The second integer to be swapped</param>
        /// <returns>A string showing the before and after state of the two integers</returns>
        public static string SwapTwoNumbers(int a, int b)
        {
            string output = $"Before: a = {a}, b = {b} ";
            int temp = a;
            a = b;
            b = temp;
            output += $"After: a = {a}, b = {b}";
            return output;
        }

        static void Main(string[] args)
        {
            int result = AddAndMultiply(2, 4, 5);
//            Console.WriteLine(result);

            //Console.WriteLine(CtoF(0));
            //Console.WriteLine(CtoF(100));
            //Console.WriteLine(CtoF(-300));{

            //Console.WriteLine(ElementaryOperations(3, 8));

            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            //Console.WriteLine(IsResultTheSame(3 + 3, 3 * 3));
            //Console.WriteLine(ModuloOperations(8, 5, 2));
            Console.WriteLine(SwapTwoNumbers(11, 27));
        }
    }
}
