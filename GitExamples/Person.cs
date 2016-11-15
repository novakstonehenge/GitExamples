namespace GitExamples
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
