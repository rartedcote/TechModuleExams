using System;
using System.Linq;
using System.Collections.Generic;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int index;
            int santaIndex = 0;

            while (input != "Merry Xmas!")
            {
                string[] jump = input.Split();

                index = int.Parse(jump[1]);
                santaIndex += index;

                if (santaIndex > houses.Count - 1)
                {
                    while (santaIndex > houses.Count - 1)
                    {
                        santaIndex -= houses.Count;
                    }

                    if (santaIndex < 0)
                    {
                        santaIndex = 0;
                    }
                }

                if (houses[santaIndex] == 0)
                {
                    Console.WriteLine($"House {santaIndex} will have a Merry Christmas.");
                }

                else
                {
                    houses[santaIndex] -= 2;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {santaIndex}.");

            int numFail = 0;

            foreach (int item in houses)
            {
                if (item > 0)
                {
                    numFail++;
                }
            }

            if (numFail > 0)
            {
                Console.WriteLine($"Santa has failed {numFail} houses.");
            }

            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}