using System;

namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input, Calculation, Exception & Output
            try
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 0)
                {
                    throw new Exception("Invalid number.");
                }

                double calculatedNumber = Math.Sqrt(inputNumber);
                Console.WriteLine(calculatedNumber);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
