using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrInput = Console.ReadLine();

            int[] bestBatch = new int[1];
            int bestSum = int.MinValue;

            while (usrInput != "Bake It!")
            {
                int[] breadBatch = usrInput
                    .Split('#')
                    .Select(int.Parse)
                    .ToArray();

                int sum = breadBatch.Sum();

                if (sum > bestSum)
                {
                    bestBatch = breadBatch;
                    bestSum = sum;
                }

                else if (sum == bestSum)
                {
                    int batchAvrg = sum / breadBatch.Length;
                    int bestAvrg = sum / bestBatch.Length;

                    if (batchAvrg > bestAvrg)
                    {
                        bestBatch = breadBatch;
                        bestSum = sum;
                    }

                    else if (batchAvrg == bestAvrg)
                    {
                        if (breadBatch.Length < bestBatch.Length)
                        {
                            bestBatch = breadBatch;
                            bestSum = sum;
                        }
                    }
                }

                usrInput = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {bestSum}");
            Console.WriteLine(string.Join(' ', bestBatch));
        }
    }
}