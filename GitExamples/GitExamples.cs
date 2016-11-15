using System;

namespace GitExamples
{
    public class GitExamples
    {
        public static int Main(string[] args)
        {
            string[] peoples = new string[] {
                "Andrysek Libor",
                "Biza Martin",
                "Bulicka Michal",
                "Cacek Filip",
                "Chromik Daniel",
                "Hercka Lubos",
                "Novak Zdenek"
            };

            for(byte i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine(peoples[i]);
            }

            return 0;
        }
    }
}
