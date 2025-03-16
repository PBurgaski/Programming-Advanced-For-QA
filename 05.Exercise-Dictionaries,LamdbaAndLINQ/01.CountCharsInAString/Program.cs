namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] input = Console.ReadLine()
                                    .Split()
                                    .ToArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            // Logic
            foreach (string key in input)
            {
                foreach (char c in key)
                {
                    if (!(keyValuePairs.ContainsKey(c)))
                    {
                        keyValuePairs.Add(c, 1);
                    }
                    else
                    {
                        keyValuePairs[c]++;
                    }
                }
            }
            // Output
            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine($"{keyValue.Key} -> {keyValue.Value}");
            }
        }
    }
}
