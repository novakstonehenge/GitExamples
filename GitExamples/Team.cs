using System;

namespace GitExamples
{
    public class Team
    {
        private string[] persons;

        public Team(string[] persons)
        {
            this.persons = persons;
        }

        public override string ToString()
        {
            return string.Join("\n", this.persons);
        }
    }
}

