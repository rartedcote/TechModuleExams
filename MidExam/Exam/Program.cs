using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            int numCoins = 0;

            for (int i = 1; i <= numDays; i++)
            {
                numCoins += 50;

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;

                }

                if (i % 3 == 0)
                {
                    numCoins -= 3 * partySize;
                }

                if (i % 5 == 0)
                {
                    numCoins += 20 * partySize;

                    if (i % 3 == 0)
                    {
                        numCoins -= 2 * partySize;
                    }
                }

                numCoins -= 2 * partySize;
            }

            Console.WriteLine($"{partySize} companions received {numCoins / partySize} coins each.");
        }
    }
}