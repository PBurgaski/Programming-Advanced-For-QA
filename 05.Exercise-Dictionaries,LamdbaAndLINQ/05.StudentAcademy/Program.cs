namespace _05.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentInfo = new Dictionary<string, List<double>>();
            string name;
            double grade;
            // Logic & Calculations
            for (int i = rows; i > 0; i--)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());
                if (!(studentInfo.ContainsKey(name)))
                {
                    studentInfo.Add(name, new List<double> { grade });
                }
                else
                {
                    studentInfo[name].Add(grade);
                }
            }
            // Output
            foreach (var item in studentInfo.Where(s => s.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }
        }
    }
}