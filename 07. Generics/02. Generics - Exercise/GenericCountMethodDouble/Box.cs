using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        public List<T> List { get; set; } = new List<T>();

        public int Count(T item)
        {
            int count = 0;

            foreach (T listItem in List)
            {
                if (listItem.CompareTo(item) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in List)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Add(T item)
        {
            List.Add(item);
        }
    }
}
