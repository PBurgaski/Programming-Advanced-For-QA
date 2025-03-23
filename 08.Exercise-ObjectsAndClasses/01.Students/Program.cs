namespace _01.Students
{
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            // Logic
            for (int i = 0; i < n; i++)
            {
            string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            // Output
            foreach (var  st in students.OrderByDescending(s => s.Grade).ToArray())
            {
                Console.WriteLine($"{st.FirstName} {st.LastName}: {st.Grade:F2}");
            }
        }
    }
}
