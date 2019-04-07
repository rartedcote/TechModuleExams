using System;
using System.Collections.Generic;
using System.Linq;

namespace Dungeonest
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            int roomsCount = 0;

            List<string> rooms = Console.ReadLine()
                .Split("|")
                .ToList();

            List<string> currentRoom = new List<string>();

            while (rooms.Count > 0)
            {
                currentRoom = rooms[0]
                    .Split()
                    .ToList();

                roomsCount++;

                switch (currentRoom[0])
                {
                    case "potion":
                        int healthHealed = int.Parse(currentRoom[1]);

                        if (health + healthHealed > 100)
                        {
                            int healthDiff = 100 - health;
                            health += healthDiff;
                            Console.WriteLine($"You healed for {healthDiff} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }

                        else
                        {
                            health += healthHealed;
                            Console.WriteLine($"You healed for {healthHealed} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }

                        break;

                    case "chest":
                        int coinsGet = int.Parse(currentRoom[1]);
                        coins += coinsGet;
                        Console.WriteLine($"You found {coinsGet} coins.");
                        break;

                    default:
                        string monster = currentRoom[0];
                        int damage = int.Parse(currentRoom[1]);

                        health -= damage;

                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {roomsCount}");
                            return;
                        }

                        else
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }

                        break;
                }

                rooms.RemoveAt(0);
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins} ");
            Console.WriteLine($"Health: {health}");
        }
    }
}