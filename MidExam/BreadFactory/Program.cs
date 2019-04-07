using System;
using System.Collections.Generic;
using System.Linq;

namespace Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comands = Console.ReadLine().Split(new char[] { '|', '-' }).ToList();
            int coints = 100;
            int energy = 100;
            int maxEnegrgy = 100;

            if (comands.Count == 1)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coints}");
                Console.WriteLine($"Energy: {energy}"); return;
            }

            for (int i = 0; i < comands.Count; i++)
            {
                int value = int.Parse(comands[i + 1]);

                if (comands[i] == "rest")
                {
                    if (energy + value > maxEnegrgy)
                    {
                        Console.WriteLine($"You gained {maxEnegrgy - energy} energy.");
                        Console.WriteLine($"Current energy: {maxEnegrgy}.");
                        energy = maxEnegrgy;
                    }
                    else if (energy + value <= maxEnegrgy)
                    {
                        energy += value;
                        Console.WriteLine($"You gained {value} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (comands[i] == "order")
                {

                    if (energy - 30 >= 0)
                    {
                        coints += value;
                        Console.WriteLine($"You earned {value} coins.");
                        energy -= 30;
                    }
                    else if (energy - 30 < 0)
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                }
                else
                {
                    int comandValue = int.Parse(comands[i + 1]);
                    if (coints - comandValue > 0)
                    {
                        Console.WriteLine($"You bought {comands[i]}.");
                        coints -= comandValue;
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {comands[i]}."); return;
                    }
                }
                i++;
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coints}");
            Console.WriteLine($"Energy: {energy}");

        }
    }
}