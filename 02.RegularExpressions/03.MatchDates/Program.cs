using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            string input = Console.ReadLine();
            // Regex
            string pattern = @"(?<Day>\d{2})(?<Separator>[.\-\/])(?<Month>[A-Z][a-z]{2})\k<Separator>(?<Year>\d{4})\b";
            MatchCollection match = Regex.Matches(input, pattern);
            // Logic & Output
            foreach (Match result in match)
            {
                string day = result.Groups["Day"].Value;
                string month = result.Groups["Month"].Value;
                string year = result.Groups["Year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
