using System;

namespace GitExamples
{
    public class GitExamples
    {
        public static int Main(string[] args)
        {
            Team netincome = new Team(new string[] {
                "Prouza Jakub",
                "Sarik Milan"
            });

            Console.WriteLine(netincome);

            return 0;
        }
    }
}
