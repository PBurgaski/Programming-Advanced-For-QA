namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            List<int> numbers = new List<int>();
            int startNumber = 1;
            int currentNumber = 1;
            // Logic & Exeption
            while (numbers.Count < 10)
            {
                try
                {
                    currentNumber = ReadNumber(startNumber, 100);
                    numbers.Add(currentNumber);
                    startNumber = currentNumber;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {currentNumber} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            //Output
            Console.WriteLine(string.Join(", ", numbers));

            // Method
            int ReadNumber(int start, int end)
            {

                int num = int.Parse(Console.ReadLine());
                if (num <= start || num >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return num;
            }
        }
    }
}
