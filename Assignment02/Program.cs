/*
 * Student ID : 1690701865
 * Name       : Chonlawit Kedsa
 * Section    : 129C
 * No.        : 1
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Assignment02
{
    internal class Program
    {
        const string MaterialName = "Copper";
        const double SmeltRate = 0.25;
        const double SalvageRate = 0.30;
        const double MaxBatch = 500;

        static void Main(string[] args)
        {
            Console.WriteLine("=== THE FORGE ===");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> S: Smelt | B: Breakdown");

            Console.Write("=> Choose Menu: ");
            char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            bool isNumber = double.TryParse(Console.ReadLine(), out double amount);

            if (isNumber && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double ingotAmount = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingotAmount:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double oreAmount = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {oreAmount:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("=> Menu error: please choose S or B.");
                }
            }
            else
            {
                Console.WriteLine($"=> Amount error: enter a number above 0 and not more than {MaxBatch}.");
            }
        }
    }
}