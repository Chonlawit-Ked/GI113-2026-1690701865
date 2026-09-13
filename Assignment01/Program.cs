/*
 * Student ID : 1690701865
 * Name       :Chonlawit Kedsa
 * Section    : 129C
 * No.        : 1
 * Course     : GI113 Computer Programming (GI)
 */
using System.Diagnostics;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Space Adventure Into The Darkness";

            var shipName = "Panther";
            var shipRank = 'B';
            int shipLevel = 17;
            float shipShield = 1545.85f;
            double shipSpeed = 2758.7;
            bool isDrivable = true;

            Console.WriteLine($"/////////// {GameTitle} ///////////");
            Console.WriteLine($">>>>> Ship Name : {shipName}");
            Console.WriteLine($">>>>> Rank : {shipRank}");
            Console.WriteLine($">>>>> Level : {shipLevel}");
            Console.WriteLine($">>>>> Shield : {shipShield}");
            Console.WriteLine($">>>>> Speed : {shipSpeed}");
            Console.WriteLine($">>>>> Drivable : {isDrivable}");
            Console.WriteLine();
            Console.WriteLine("/-------------------------------------/");
            Console.WriteLine();
            double shipLevelAsDouble = shipLevel;
            Console.WriteLine($":::Level as double (implicit) : {shipLevelAsDouble}");

            int shipSpeedCast = (int) shipSpeed;
            int shipSpeedConvert = Convert.ToInt32(shipSpeed);
            Console.WriteLine($":::Speed Cast : {shipSpeedCast}");
            Console.WriteLine($":::Speed Convert : {shipSpeedConvert}");
            Console.WriteLine($" _____  _    ____    _____ ___     ____ _     ___  ____  _____ \r\n|_   _|/ \\  | __ )  |_   _/ _ \\   / ___| |   / _ \\/ ___|| ____|\r\n  | | / _ \\ |  _ \\    | || | | | | |   | |  | | | \\___ \\|  _|  \r\n  | |/ ___ \\| |_) |   | || |_| | | |___| |__| |_| |___) | |___ \r\n  |_/_/   \\_\\____/    |_| \\___/   \\____|_____\\___/|____/|_____|");
        }
    }
}
