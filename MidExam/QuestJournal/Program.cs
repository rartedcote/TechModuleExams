using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine()
                .Split(", ")
                .ToList();

            string questInput = Console.ReadLine();
            List<string> splitQuest = new List<string>();
            string quest = "";

            while (questInput != "Retire!")
            {
                splitQuest = questInput.Split(" - ").ToList();
                quest = splitQuest[1];

                switch (splitQuest[0])
                {
                    case "Start":
                        if (quests.Contains(quest))
                        {
                            break;
                        }

                        else
                        {
                            quests.Add(quest);
                        }
                        break;

                    case "Complete":
                        if (!quests.Contains(quest))
                        {
                            break;
                        }

                        else
                        {
                            quests.Remove(quest);
                        }

                        break;

                    case "Side Quest":
                        List<string> sideQuest = splitQuest[1].Split(":").ToList();

                        if (quests.Contains(sideQuest[0]) && !quests.Contains(sideQuest[1]))
                        {
                            int indexOfQuest = quests.IndexOf(sideQuest[0]);
                            quests.Insert(indexOfQuest + 1, sideQuest[1]);
                        }

                        else
                        {
                            break;
                        }
                        break;

                    case "Renew":
                        if (quests.Contains(quest))
                        {
                            quests.Remove(quest);
                            quests.Add(quest);
                        }

                        else
                        {
                            break;
                        }

                        break;
                }

                questInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
