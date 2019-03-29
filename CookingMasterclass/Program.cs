using System;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            int freeFlour = students / 5;
            double totalFlour = (students - freeFlour) * priceFlour;

            int apronNeeded = (int)Math.Ceiling(students * 1.2);
            double totalApron = apronNeeded * priceApron;

            double totalEggs = (students * 10) * priceEgg;
            double totalBudget = totalFlour + totalApron + totalEggs;

            if (budget >= totalBudget)
            {
                Console.WriteLine($"Items purchased for {totalBudget:F2}$.");
            }

            else
            {
                Console.WriteLine($"{totalBudget - budget:F2}$ more needed.");
            }
        }
    }
}