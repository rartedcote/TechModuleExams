using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionaryDef = new Dictionary<string, List<string>>();
            Regex reg = new Regex(@"[ | ]*([\w]+): ([\w ,]+)");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(" | ");
            string key = "";
            string value = "";
            for (int i = 0; i < splitInput.Length; i++)
            {
                if (reg.IsMatch(splitInput[i]))
                {
                    Match match = reg.Match(splitInput[i]);
                    key = match.Groups[1].Value;
                    value = match.Groups[2].Value;

                    if (!dictionaryDef.ContainsKey(key))
                    {
                        dictionaryDef.Add(key, new List<string>());
                        dictionaryDef[key].Add(value);
                    }

                    else
                    {
                        dictionaryDef[key].Add(value);
                    }
                }
            }

            input = Console.ReadLine();
            splitInput = input.Split(" | ");

            for (int i = 0; i < splitInput.Length; i++)
            {
                if (dictionaryDef.ContainsKey(splitInput[i]))
                {
                    key = splitInput[i];
                    Console.WriteLine(key);

                    dictionaryDef[key] = dictionaryDef[key].OrderByDescending(x => x.Length).ToList();
                    foreach (var item in dictionaryDef[key])
                    {
                        Console.WriteLine($"-{item}");
                    }
                }
            }

            input = Console.ReadLine();

            if (input == "End")
            {
                return;
            }

            else if (input == "List")
            {
                dictionaryDef = dictionaryDef.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(string.Join(" ", dictionaryDef.Keys));
            }
        }
    }
}