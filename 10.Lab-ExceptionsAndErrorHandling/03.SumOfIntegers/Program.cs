using System.Xml.Linq;

namespace _03.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] input = Console.ReadLine()
                                    .Split()
                                    .ToArray();
            int currentNumber = 0;
            int currentSum = 0;
            // Logic & Exception
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    currentNumber = int.Parse(input[i]);
                    currentSum += currentNumber;
                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{input[i]}' is in wrong format!");
                }
                catch (OverflowException)
                {

                    Console.WriteLine($"The element '{input[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {currentSum}");

                }
            }
            // Output
            Console.WriteLine($"The total sum of all integers is: {currentSum}");
        }
    }
}
