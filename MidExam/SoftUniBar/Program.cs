using System;
using System.Collections.Generic;

namespace SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            string input = Console.ReadLine();
            string name = "";
            bool nameFound = false;

            while (input != "end")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int charValue = input[i] - key;

                    if (charValue == 64)
                    {
                        name = GetName(input, i);
                        nameFound = true;
                    }

                    if (nameFound)
                    {
                        if (charValue == 33)
                        {
                            int goodBad = input[i + 1];

                            if (goodBad == 71)
                            {
                                names.Add(name);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }

        private static string GetName(string input, int i)
        {
            int start = i + 1;
            string name = "";

            for (int j = start; j < input.Length; j++)
            {
                int charValue = input[j];

                if ((charValue >= 65 && charValue <= 90)
                    || (charValue >= 97 && charValue <= 122))
                {
                    name += input[j];
                }

                else
                {
                    break;
                }
            }

            return name;
        }
    }
}