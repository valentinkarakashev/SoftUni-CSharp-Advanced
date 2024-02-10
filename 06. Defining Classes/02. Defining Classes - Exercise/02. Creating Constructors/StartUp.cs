namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(16);
            Person person2 = new Person("Ivo", 17);
        }
    }
}
