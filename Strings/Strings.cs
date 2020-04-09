using System;

namespace GrundlProgrammering
{
    public class Strings
    {
        public static string AddSeparator(string input, string separator)
        {
            string output = string.Empty;
            char[] sep = new char[separator.Length];
            for ( int i = 0; i < input.Length; i++)
            {
                output += input[i] + separator;
            }
            // string output now has the separator in the end.
            // This needs to be trimmed away
            // String.TrimEnd takes an array of chars to be trimmed
            for (int i = 0; i < separator.Length; i++)
            {
                sep[i] = separator[i];
            }
            output = output.TrimEnd(sep);
            return output;
        }

        public static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length-1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int LengthOfAString(string input)
        {
            int length = 0;
            for (int i = 0; i < input.Length; i++)
            {
                length++;
            }
            return length;
        }

        public static string StringInReverseOrder(string input)
        {
            string output = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        public static int NumberOfWords(string input)
        {
            int countOfWhitespaces = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    countOfWhitespaces++;
                }
            }
            return countOfWhitespaces + 1;
        }

        public static string RevertWordsOrder(string input)
        {
            char endChar = input[input.Length - 1];
            char[] p = new char[1];

            if (char.IsPunctuation(endChar))
            {
                
                p[0] = endChar;
                input = input.TrimEnd(p);
            }
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string output = String.Join(' ', words);
            if (p[0] != default(char))
            {
                output += p[0];
            }
            return output;
        }

        public static int HowManyOccurrences(string haystack, string needle)
        {
            int position = 0;
            int count = 0;
            int start = 0;
            int end = haystack.Length;

            while (start <= end && position > -1)
            {
                int length = end - start;
                position = haystack.IndexOf(needle, start, length, StringComparison.CurrentCulture);
                if (position == -1)
                {
                    break;
                }
                count++;
                start = position + 1;
            }

            return count;
        }

        public static string SortCharactersDescending(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return String.Join("", arr);
        }

        public static string CompressString(string input)
        {
            int count = 0;
            char previous = input[0];
            string output = string.Empty;

            foreach( var s in input)
            {
                if (s == previous)
                {
                    count++;
                }
                else
                {
                    output += previous.ToString() + count;
                    previous = s;
                    count = 1;
                }
            }
            output += previous.ToString() + count;

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparator("chocolate", "*-*"));
            Console.WriteLine(IsPalindrome("chocolate"));
            Console.WriteLine(IsPalindrome("eyye"));
            Console.WriteLine(LengthOfAString("eyye"));
            Console.WriteLine(StringInReverseOrder("qwerty"));
            Console.WriteLine(NumberOfWords("This is sample sentence"));
            Console.WriteLine(RevertWordsOrder("This is sample sentence."));
            Console.WriteLine(RevertWordsOrder("This is sample sentence!"));
            Console.WriteLine(RevertWordsOrder("This is sample sentence,"));
            Console.WriteLine(RevertWordsOrder("This is sample sentence"));
            Console.WriteLine(HowManyOccurrences("This is sample sentence", "e"));
            Console.WriteLine(SortCharactersDescending("onomatopoeia"));
            Console.WriteLine(CompressString("aaaabbcccccdaa"));    //a4b2c5d1a2
            Console.WriteLine(CompressString("948kro"));            //914181k1r1o1
            Console.WriteLine(CompressString("$999j*#jjjfYyyy"));   //$193j1*1#1j3f1Y1y3
        }
    }
}
