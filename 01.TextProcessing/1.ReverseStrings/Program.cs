namespace _1.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        { // Input
            string words;
            // Logic & Output
            while ((words = Console.ReadLine()) != "end")
            {
                string reversed = string.Join("", words.ToArray().Reverse());
                Console.WriteLine($"{words} = {reversed}");
            }
        }
    }
}
