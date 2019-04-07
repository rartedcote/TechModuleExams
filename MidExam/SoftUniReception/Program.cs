using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalEfficiency = employeeOne + employeeTwo + employeeThree;
            int hours = 0;

            while (students > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }

                students -= totalEfficiency;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}