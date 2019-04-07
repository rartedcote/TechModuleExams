using System;
using System.Text.RegularExpressions;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex artistReg = new Regex(@"^[A-Z] *[a-z]+[a-z ']*$");
            Regex songReg = new Regex(@"^[A-Z ]+$");
            string input = Console.ReadLine();
            int key = 0;
            string artist = "";
            string song = "";

            while (input != "end")
            {
                string[] splitInput = input.Split(':');
                artist = splitInput[0];
                song = splitInput[1];

                if (artistReg.IsMatch(artist)
                    && songReg.IsMatch(song))
                {
                    key = artist.Length;
                    int charValue = 0;
                    string encryptedArtist = "";
                    string encryptedSong = "";

                    for (int i = 0; i < artist.Length; i++)
                    {
                        if (artist[i] == ' ' || artist[i] == '\'')
                        {
                            encryptedArtist += artist[i];
                        }

                        else if (char.IsUpper(artist[i]))
                        {
                            charValue = artist[i] + key;

                            if (charValue > 90)
                            {
                                while (charValue > 90)
                                {
                                    int altKey = charValue - 90;
                                    charValue = 64 + altKey;
                                }
                            }

                            encryptedArtist += (char)charValue;
                        }

                        else if (char.IsLower(artist[i]))
                        {
                            charValue = artist[i] + key;

                            if (charValue > 122)
                            {
                                while (charValue > 122)
                                {
                                    int altKey = charValue - 90;
                                    charValue = 64 + altKey;
                                }
                            }

                            encryptedArtist += (char)charValue;
                        }
                    }

                    for (int i = 0; i < song.Length; i++)
                    {
                        if (song[i] == ' ')
                        {
                            encryptedSong += song[i];
                        }

                        else
                        {
                            charValue = song[i] + key;

                            if (charValue > 90)
                            {
                                while (charValue > 90)
                                {
                                    int altKey = charValue - 90;
                                    charValue = 64 + altKey;
                                }
                            }

                            encryptedSong += (char)charValue;
                        }
                    }

                    Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}