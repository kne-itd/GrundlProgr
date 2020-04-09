using System;

namespace GrundlProgrammering
{
    public class Loop
    {
        public static string MultiplicationTable()
        {
            string output = String.Empty;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string s = (i * j).ToString();
                    s = s.PadLeft(4, ' ');
                    output += s;
                }
                output += Environment.NewLine;
            }
            return output;
        }

        public static int TheBiggestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers[0];
        }

        public static int Two7sNextToEachOther(int[] digits)
        {
            int count = 0;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] == 7 && digits[i+1] == 7){
                    count++;
                }
            }
            return count;
        }

        public static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i-1] + 1 == numbers[i] && numbers[i+1] - 1 == numbers[i])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method returns an array of all prime numbers below the given max
        /// 1. An array of consecutive integers from 2 through max is created
        /// 2. Initially start with the smallest prime number p (2)
        /// 3. Enumerate the multiples of p in increments of p from 2p to max and mark them.
        ///    p itself should not be marked
        /// 4. Find the first number in the list not marked. If there is no such number, stop
        ///    Otherwise let p equal this number (the next prime) and repeat step 3.
        /// 5. When the algorithm terminates, the numbers remaining not marked are the primes
        ///
        /// As a refinement, it is sufficient in step 3 starting from p^2 as
        /// the smaller multiples of p will already be marked.
        /// This means the algortihm can teminate when p^2 is greater tha max.
        /// </summary>
        /// <param name="max"></param>
        /// <returns>Array of primes</returns>
        public static int[] SieveOfEratosthenes(int max)
        {
            int[] initialList = new int[max];
            for (int i = 2; i < max; i++)
            {
                initialList[i] = i;
            }

            for (int i = 2; i * i < max; i++)
            {
                if (initialList[i] != 0)
                {
                    for (int j = i * i; j < max; j += i)
                    {
                        initialList[j] = 0;
                    }
                }
            }
            int count = 0;
            foreach (int i in initialList)
            {
                if (i > 0)
                {
                    count++;
                }
            }
            int[] primes = new int[count];
            int key = 0;
            foreach (int i in initialList)
            {
                if (i > 0)
                {
                    primes[key] = i;
                    key++;
                }
            }

            return primes;

        }

        public static string ExtractString(string input)
        {
            string output = string.Empty;

            for( int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '#' && input[i+1] == '#')
                {
                    for (int j = i + 2; j < input.Length - 1; j++) 
                    {
                        if (input[j] == '#' && input[j+1] == '#')
                        {
                            return output;
                        }
                        output += input[j];
                    }
                }
            }
            return string.Empty;
        }

        public static string FullSequenceOfLetters(string letters)
        {
            // Check for sequence
            if (letters[0] > letters[1])
            {
                throw new Exception("Wrong sequence");
            }
            string output = string.Empty;
            for (int i = letters[0], j = 0; i <= letters[1]; i++, j++)
            {
                output += (char)(letters[0] + j);
            }
            return output;

        }

        public static string SumAndAverage(int n, int m)
        {
            double sum = 0.0;
            double count = 0.0;
            double avg = 0.0;

            for (int i = n; i <= m; i++)
            {
                sum += i;
                count++;
                avg = sum / count;
            }

            sum = (int)sum;
            return $"Sum: {sum}, Average: {avg}";
        }

        public static string DrawTriangle()
        {
            string output = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i ; j--)
                {
                    output += " ";
                }
                for (int k = 10; k >= 10 - i; k--)
                {
                    output += "*";
                }
                output += Environment.NewLine;
            }
            return output;
        }

        public static double ToThePowerOf(int a, int b)
        {
            double output = 1;
            if (b >= 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    output *= a;
                }
            } else
            {
                for (int i = 1; i <= b * (-1); i++)
                {
                    output *= a;
                }
                output = 1 / output;
            }
            
            return output;
        }



        static void Main(string[] args)
        {
            //foreach (int number in SieveOfEratosthenes(30))
            //{
            //    Console.Write(number + " ");
            //}

            //Console.Write(MultiplicationTable());

            //Console.WriteLine(TheBiggestNumber(new int[] { 1, 3, 44, 78, 100, 4, 56 }));

            //Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
            //Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            //Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
            //Console.WriteLine(ExtractString("##abc##def"));
            //Console.WriteLine(ExtractString("12####78"));
            //Console.WriteLine(ExtractString("gar##d#en"));
            //Console.WriteLine(ExtractString("++##--##++"));
            //Console.WriteLine(FullSequenceOfLetters("ae"));
            //Console.WriteLine(SumAndAverage(11, 66));
            //Console.WriteLine(SumAndAverage(-10, 0));
            Console.Write(DrawTriangle());
            //Console.WriteLine(ToThePowerOf(5, 5));
            //Console.WriteLine(ToThePowerOf(-2, 3));
            //Console.WriteLine(ToThePowerOf(10, 0));
            //Console.WriteLine(ToThePowerOf(5, -2));
        }
    }
}
