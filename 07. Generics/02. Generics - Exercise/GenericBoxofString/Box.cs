using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public List<T> List { get; set; } = new List<T>();

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