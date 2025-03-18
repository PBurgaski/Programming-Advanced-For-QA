using System.Collections.Generic;

namespace _02.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] input;
            List<Student> students = new List<Student>();
            string firstName;
            string lastName;
            string homeTown;
            int age;
            // Logic
            while (true)
            {
                input = Console.ReadLine()
                               .Split()
                               .ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                firstName = input[0];
                lastName = input[1];
                age = int.Parse(input[2]);
                homeTown = input[3];
                Student currentStudent = new Student(firstName, lastName, age, homeTown);
                students.Add(currentStudent);
            }
            string city = Console.ReadLine();
            // Output
            foreach (var st in students.Where(s => s.HomeTown == city))
            {
                Console.WriteLine($"{st.FirstName} {st.LastName} is {st.Age} years old.");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}