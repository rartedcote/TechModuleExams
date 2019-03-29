using System;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int christmasSpirit = 0;
            int cost = 0;
            int lastDay = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    cost += 2 * quantity;
                    christmasSpirit += 5;
                }

                if (i % 3 == 0)
                {
                    cost += 5 * quantity;
                    cost += 3 * quantity;
                    christmasSpirit += 13;
                }

                if (i % 5 == 0)
                {
                    cost += 15 * quantity;
                    christmasSpirit += 17;

                    if (i % 3 == 0)
                    {
                        christmasSpirit += 30;
                    }
                }

                if (i % 10 == 0)
                {
                    christmasSpirit -= 20;
                    cost += 5 + 3 + 15;
                }

                lastDay = i;
            }

            if (lastDay % 10 == 0)
            {
                christmasSpirit -= 30;
            }

            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");
        }
    }
}