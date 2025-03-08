using System.Xml.Linq;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] bannedWords = Console.ReadLine().Split(", ");
            string textToBeEdited = Console.ReadLine();
            string result = "";
            // Logic
            foreach (string word in bannedWords)
            {
                while (textToBeEdited.Contains(word))
                {
                    string bannedWord = new string('*', word.Length);
                    int indexOfBannedWord = textToBeEdited.IndexOf(word);
                    result = textToBeEdited.Replace(word, bannedWord);
                    textToBeEdited = result;
                }
            }
            // Output
            Console.WriteLine(result);
        }
    }
}