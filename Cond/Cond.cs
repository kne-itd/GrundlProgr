using System;

namespace GrundlProgrammering
{
    public class Cond
    {

        public static int AbsoluteValue (int a)
        {
            if (a < 0)
            {
                return -1 * a;
            }
            return a;
        }
        /// <summary>
        /// BOTH a AND b should be divisible by 2
        /// OR BOTH a AND b should be divisible by 3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int DivisibleBy2Or3(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0 ||
                a % 3 == 0 && b % 3 == 0)
            {
                return a * b;
            }
            return a + b;
        }

        public static bool IfConsistsOfUppercaseLetters(string a)
        {
            if (a[0] >= 65 && a[0] <= 90)
            {
                if (a[1] >= 65 && a[1] <= 90)
                {
                    if (a[2] >= 65 && a[2] <= 90)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public static bool IfGreaterThanThirdOne(int a, int b, int c)
        {
            if (a * b > c || a + b > c)
            {
                return true;
            }
            return false;
        }

        public static bool IfNumberIsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IfSortedAscending(int[] a)
        {
            return a[0] <= a[1] && a[1] <= a[2];
        }

        public static string PositiveNegativeOrZero(double a)
        {
            if (a < 0 )
            {
                return "negative";
            } else if (a == 0)
            {
                return "zero";
            }
            return "positive";
        }

        public static bool IfYearIsLeap (int a)
        {
            if (a % 4 == 0)
            {
                if (a % 400 == 0 || a % 100 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(AbsoluteValue(333));
            //Console.WriteLine(AbsoluteValue(-333));
            //Console.WriteLine(IfConsistsOfUppercaseLetters("Kaj"));
            //Console.WriteLine(IfConsistsOfUppercaseLetters("kaj"));
            //Console.WriteLine(IfConsistsOfUppercaseLetters("KAJ"));
            //Console.WriteLine(IfGreaterThanThirdOne(2, 7, 12));
            //Console.WriteLine(IfGreaterThanThirdOne(2, 4, 12));
            //Console.WriteLine(IfNumberIsEven(4));
            //Console.WriteLine(IfNumberIsEven(7));
            //Console.WriteLine(IfSortedAscending(new int[] { 2, 7, 11 }));
            //Console.WriteLine(IfSortedAscending(new int[] { 2, 11, 7 }));
            //Console.WriteLine(PositiveNegativeOrZero(-1));
            //Console.WriteLine(PositiveNegativeOrZero(0));
            //Console.WriteLine(PositiveNegativeOrZero(1));
            Console.WriteLine(IfYearIsLeap(2000));
            Console.WriteLine(IfYearIsLeap(2100));
            Console.WriteLine(IfYearIsLeap(2020));
        }
    }
}
