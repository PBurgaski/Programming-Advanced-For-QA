namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        { //Input
            string[] words = Console.ReadLine().Split(" ");
            string result = "";

            // Logic
            foreach (string word in words)
            {
                string repeatedWord = ""; 

                for (int i = 0; i < word.Length; i++) 
                {
                    repeatedWord += word;
                }
                result += repeatedWord; 
            }
             // Output
            Console.WriteLine(result);
        }
    }
}