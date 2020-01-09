using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDice = 0;
            Console.WriteLine("----- Terningespil -----");
            Console.WriteLine("Hvor mange terninger ønsker du at spille med?");
            string DesiredNumberOfDice = Console.ReadLine();

            while (!Int32.TryParse(DesiredNumberOfDice, out numberOfDice))
            {
                Console.WriteLine("Du skal angive et heltal!");
                Console.WriteLine("Hvor mange terninger ønsker du at spille med?");
                DesiredNumberOfDice = Console.ReadLine();
            }
            
            Console.WriteLine($"Lad os se hvor mange slag der skal til for at slå {DesiredNumberOfDice} seksere.");
            Console.WriteLine("****************************************************************************");

            Random dice = new Random();
            int countSixes = 0;
            int countTries = 0;
            do
            {
                countSixes = 0;
                for (int i = 0; i < numberOfDice; i++)
                {
                    int result = dice.Next(1, 7);
                    countTries++;
                    Console.Write($"{result} ");
                    if (result == 6)
                    {
                        countSixes++;
                    }
                }
                Console.WriteLine();
            } while (countSixes < numberOfDice);

            Console.WriteLine($"Det tog {countTries} at slå {numberOfDice} seksere");
        }
    }
}
