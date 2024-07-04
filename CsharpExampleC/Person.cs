namespace CsharpExampleC
{
    internal class Person
    {
        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }


        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
