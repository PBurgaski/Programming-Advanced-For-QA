namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            string result = "";
            // Logic
            while (text.Contains(wordToRemove))
            {
                int index = text.IndexOf(wordToRemove);
                result = text.Remove(index, wordToRemove.Length);
                text = result;
            }
            // Output
            Console.WriteLine(result);
        }
    }
}
