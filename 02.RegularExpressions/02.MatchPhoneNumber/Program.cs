using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Input
            string input = Console.ReadLine();
            List<string> result = new List<string>();
            // Regex
            string pattern = @"\+359( |-)2(\1)\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            // Logic & Output
            foreach (Match m in match)
            {
                result.Add(m.Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
