namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            List<int> ints = Console.ReadLine()
                                    .Split(" ")
                                    .Select(int.Parse)
                                    .ToList();
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();
            // Logic
            foreach (int i in ints)
            {
                if (numbers.ContainsKey(i))
                {
                    numbers[i]++;
                }
                else
                {
                    numbers.Add(i, 1);
                }
            }
            // Output
            foreach (KeyValuePair<int, int> pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
