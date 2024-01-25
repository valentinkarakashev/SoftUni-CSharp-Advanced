namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsAndGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++) 
            {
                string[] command = Console.ReadLine().Split();

                string studentName = command[0];
                decimal studentGrade = decimal.Parse(command[1]);

                if (!studentsAndGrades.ContainsKey(studentName))
                {
                    studentsAndGrades.Add(studentName, new List<decimal>());
                }

                studentsAndGrades[studentName].Add(studentGrade);
            }

            foreach (var item in studentsAndGrades)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var value in item.Value)
                {
                    Console.Write($"{value:F2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():F2})");
            }
        }
    }
}