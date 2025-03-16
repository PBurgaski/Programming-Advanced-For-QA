namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] input = Console.ReadLine()
                                    .Split(" ")
                                    .Where(n => n.Length % 2 == 0)
                                    .ToArray();

            // Logic & Output
            foreach (string word in  input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
