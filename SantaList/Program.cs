using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> childList = Console.ReadLine()
                .Split('&')
                .ToList();

            string usrInput = Console.ReadLine();

            while (usrInput != "Finished!")
            {
                string[] command = usrInput.Split();

                string name = command[1];

                switch (command[0])
                {
                    case "Bad":
                        InsertKid(name, childList);
                        break;

                    case "Good":
                        RemoveKid(name, childList);
                        break;

                    case "Rename":
                        string newName = command[2];
                        RenameKid(name, newName, childList);
                        break;

                    case "Rearrange":
                        RearrangeKid(name, childList);
                        break;
                }

                usrInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", childList));
        }

        private static void RearrangeKid(string name, List<string> childList)
        {
            if (childList.Contains(name))
            {
                childList.Remove(name);
                childList.Add(name);
            }

            else
            {
                return;
            }
        }

        private static void RenameKid(string name, string newName, List<string> childList)
        {
            if (childList.Contains(name))
            {
                int index = childList.IndexOf(name);
                childList.RemoveAt(index);
                childList.Insert(index, newName);
            }

            else
            {
                return;
            }
        }

        private static void RemoveKid(string name, List<string> childList)
        {
            if (childList.Contains(name))
            {
                childList.Remove(name);
            }

            else
            {
                return;
            }
        }

        private static void InsertKid(string name, List<string> childList)
        {
            if (childList.Contains(name))
            {
                return;
            }

            else
            {
                childList.Insert(0, name);
            }
        }
    }
}