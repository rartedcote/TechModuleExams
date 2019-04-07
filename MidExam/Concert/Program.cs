using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrInput = Console.ReadLine();
            List<Band> bandList = new List<Band>();

            while (usrInput != "start of concert")
            {
                string[] inputSplit = usrInput.Split("; ");
                string command = inputSplit[0];
                string band = inputSplit[1];

                switch (command)
                {
                    case "Play":
                        int bandTime = int.Parse(inputSplit[2]);

                        foreach (Band item in bandList)
                        {
                            if (item.Bands == band)
                            {
                                int newBandTime = item.BandTime + bandTime;

                            }
                        }
                        break;

                    case "Add":
                        break;
                }

                usrInput = Console.ReadLine();
            }
        }
    }

    class Band
    {
        public Band()
        {

        }

        public List<string> Members { get; set; }
        public string Bands { get; set; }
        public int BandTime { get; set; }
    }
}