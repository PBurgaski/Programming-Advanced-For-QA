using System.Resources;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Dictionary<string, int> mineralsAndTheirQuantity = new Dictionary<string, int>();
            // Logic
            while(true)
            {
                string mineral = Console.ReadLine();
                if (mineral == "stop")
                {
                    break;
                }
                else
                {
                    if (!(mineralsAndTheirQuantity.ContainsKey(mineral)))
                    {
                    mineralsAndTheirQuantity.Add(mineral, 0);
                    }
                }
                int quantity = int.Parse(Console.ReadLine());
                if (IsInRange(quantity))
                {
                    mineralsAndTheirQuantity[mineral] += quantity;
                }
            }
            foreach (var output in mineralsAndTheirQuantity)
            {
                Console.WriteLine($"{output.Key} -> {output.Value}");
            }
        }
    static bool IsInRange(int n)
        {
            return (n >= 1 && n <= 2000000000);
        }
    }
}
