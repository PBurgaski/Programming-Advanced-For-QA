using System.Diagnostics.Metrics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string input = Console.ReadLine();
            // StringBuilders
            StringBuilder digits = new();
            StringBuilder letters = new();
            StringBuilder otherChars = new();
            // Logic & Calculations 
            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                {
                    otherChars.Append(symbol);
                }
            }
            // Output
            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(otherChars.ToString());
        }
    }
}
