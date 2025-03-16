namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            // Calculation & Logic
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>() { synonym });
                }
                else
                {
                    if (!words[word].Contains(synonym))
                    {
                        words[word].Add(synonym);
                    }
                }
            }
            // Output
            foreach (var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
