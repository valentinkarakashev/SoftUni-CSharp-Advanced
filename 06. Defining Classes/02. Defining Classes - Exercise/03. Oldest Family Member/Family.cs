namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person person)
        {
            people.Add(person);
        }

        public Person GetOldestMember()
        {
            int maxAge = people.Max(x => x.Age);
            Person oldest = people.FirstOrDefault(x => x.Age == maxAge);

            return oldest;
        }
    }
}