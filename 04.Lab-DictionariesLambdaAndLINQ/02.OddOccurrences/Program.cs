namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            List<string> words = Console.ReadLine()
                                        .Split(" ")
                                        .Select(word => word.ToLower())
                                        .ToList();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            // Logic
            foreach (string word in words)
            {
                if (keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs[word]++;
                }
                else
                {
                    keyValuePairs.Add(word, 1);
                }
            }
            // Output
            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
