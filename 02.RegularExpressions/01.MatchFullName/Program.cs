using System.Text.RegularExpressions;
namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            string text = Console.ReadLine();
            // Regex
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            MatchCollection match = Regex.Matches(text, pattern);
            // Logic & Output
            foreach (Match matches in match)
            {
                Console.Write(matches.Value + " ");
            }
        }
    }
}
