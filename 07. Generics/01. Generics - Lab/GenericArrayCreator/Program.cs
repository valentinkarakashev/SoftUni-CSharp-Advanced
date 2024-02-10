namespace GenericArrayCreator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", ArrayCreator.Create(50, "Fifty")));
        }
    }
}
