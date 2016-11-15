using System;

namespace GitExamples
{
    public class GitExamples
    {
        public static int Main(string[] args)
        {
            string[] persons = new string[] {
                "Andrysek Libor",
                "Biza Martin",
                "Bulicka Michal",
                "Cacek Filip",
                "Hercka Lubos",
                "Chromik Daniel",
                "Novak Zdenek",
                "Prouza Jakub",
                "Sarik Milan"
            };

            for(byte i = 0; i < persons.Length; i++)
            {
                Conosle.WriteLine(persons[i]);
            }

            return 0;
        }
    }
}
