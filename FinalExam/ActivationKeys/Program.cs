using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split('&');
            Regex reg = new Regex(@"^[\w]+$");
            List<string> keys = new List<string>();
            string key = "";
            for (int i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i].Length == 16 
                    && reg.IsMatch(splitInput[i]))
                {
                    string activationKey = "";
                    key = splitInput[i];

                    for (int j = 0; j < key.Length; j++)
                    {
                        if (j % 4 == 0 && j != 0)
                        {
                            activationKey += '-';
                        }

                        if (char.IsNumber(key[j]))
                        {
                            activationKey += 9 - int.Parse(key[j].ToString());
                        }

                        else
                        {
                            activationKey += char.ToUpper(key[j]);
                        }
                    }

                    keys.Add(activationKey);
                }

                else if (splitInput[i].Length == 25
                         && reg.IsMatch(splitInput[i]))
                {
                    string activationKey = "";
                    key = splitInput[i];

                    for (int j = 0; j < key.Length; j++)
                    {
                        if (j % 5 == 0 && j != 0)
                        {
                            activationKey += '-';
                        }

                        if (char.IsNumber(key[j]))
                        {
                            activationKey += 9 - int.Parse(key[j].ToString());
                        }

                        else
                        {
                            activationKey += char.ToUpper(key[j]);
                        }
                    }

                    keys.Add(activationKey);
                }
            }

            Console.WriteLine(string.Join(", ", keys));
        }
    }
}