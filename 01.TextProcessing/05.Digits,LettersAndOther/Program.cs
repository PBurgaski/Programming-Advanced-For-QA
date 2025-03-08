using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string input = Console.ReadLine();
            string digits = "";
            string letters = "";
            string otherChars = "";
            // Logic & Calculations 
            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    otherChars += symbol;
                }
            }
            // Output
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
