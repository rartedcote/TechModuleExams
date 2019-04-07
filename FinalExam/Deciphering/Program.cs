using System;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string cipheredInput = Console.ReadLine();
            string cipherKey = Console.ReadLine();
            string[] keysCipher = cipherKey.Split(' ');
            string newCipher = "";

            for (int i = 0; i < cipheredInput.Length; i++)
            {
                newCipher += (char)(cipheredInput[i] - 3);
            }

            string decipheredString = "";

            decipheredString = newCipher.Replace(keysCipher[0], keysCipher[1]);

            Regex reg = new Regex(@"^((?:(?![d])[\w {}|#])+)[da-z{}|# ]*$");

            if (reg.IsMatch(decipheredString))
            {
                Console.WriteLine(decipheredString);
            }

            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}