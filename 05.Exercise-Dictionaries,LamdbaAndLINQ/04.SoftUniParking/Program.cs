using _04.SoftUniParking;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int numOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingReg = new Dictionary<string, string>();
            string[] commands = new string[] { };
            string action;
            string userName;
            string licensePlateNumber;
            // Logic & Output
            for (int i = numOfCommands; i > 0; i--)
            {
                commands = Console.ReadLine()
                                       .Split()
                                       .ToArray();
                action = commands[0];
                userName = commands[1];
                if (action == "register")
                {
                licensePlateNumber = commands[2];
                    if (!(parkingReg.ContainsKey(userName)))
                    {
                        parkingReg.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        continue;
                    }
                    else
                    {
                        string registeredPlateNumber = parkingReg[userName];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                        continue;
                    }
                }
                else
                {
                    if (!(parkingReg.ContainsKey(userName)))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                        continue;
                    }
                    else
                    {
                        parkingReg.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                        continue;
                    }
                }
            }
            // Output
            foreach (var kvp in parkingReg)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}