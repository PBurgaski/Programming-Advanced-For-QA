namespace _06.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string[] input;
            string companyName;
            string employee;
            // Logic
            while (true)
            {
                input = Console.ReadLine()
                               .Split(" -> ")
                               .ToArray();
                companyName = input[0];
                if (companyName == "End")
                {
                    break;
                }
                employee = input[1];
                if (!(companies.ContainsKey(companyName)))
                {
                    companies.Add(companyName, new List<string>() { employee });
                }
                else
                {
                    if (!(companies[companyName].Contains(employee)))
                    {
                        companies[companyName].Add(employee);
                    }
                }
            }
            // Output
            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var emp in kvp.Value)
                {
                Console.WriteLine($"-- {emp}");
                }
            }
        }
    }
}
