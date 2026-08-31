/*
 * Student ID : 1690701865
 * Name       : Lab02
 * Section    : 129C
 * No.        : 1
 * Course     : GI113 Computer Programming (GI)
 */

using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("====Soul Demon RPG Game====");
            string Name01 = "Raven";
            int maxhp = 150;
            int currenthp = 132;
            bool alive = true;
            int speed = 54;
            int hpPercentRaven = currenthp * 100 / maxhp;
            Console.WriteLine("=Status-Raven=");
            Console.WriteLine($"Name: {Name01}");
            Console.WriteLine($"Hp: {currenthp} / {maxhp}");
            Console.WriteLine($"Hp Percent: {hpPercentRaven}%");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Alive: {alive}");
            Console.WriteLine();
            Console.WriteLine("=Weapon=");
            string sword = "Iron Sword";
            char rankS01 = 'C';
            float atk = 20.5f;
            double critrate = 5.79;
            double cridamage = 30;
            Console.WriteLine($"Name: {sword}");
            Console.WriteLine($"Rank: {rankS01}");
            Console.WriteLine($"ATK: {atk}");
            Console.WriteLine($"Crit Rate: {critrate}%");
            Console.WriteLine($"Crit DMG: {cridamage}%");
            Console.WriteLine();
            Console.WriteLine("=Enemy=");
            string enemy01 = "Skeleton";
            char rank02 = 'B';
            int currenthp01 = 120;
            int maxhp01 = 200;
            int atk01 = 25;
            int speed02 = 34;
            int hpPercentS = currenthp01 * 100 / maxhp01;
            Console.WriteLine($"Name: {enemy01}");
            Console.WriteLine($"Hp: {currenthp01} / {maxhp01}");
            Console.WriteLine($"Hp Percent: {hpPercentS}%");
            Console.WriteLine($"ATK: {atk01}");
            Console.WriteLine($"Speed: {speed02}");
            Console.WriteLine();
            Console.WriteLine("=Item Drop=");
            string item = "Bone";
            int dropchane = 33;
            int dropAmountlow = 1;
            int dropAmounthigh = 3;
            char rankS02 = 'C';
            float sellprice = 10.5f;
            Console.WriteLine($"Name: {item}");
            Console.WriteLine($"Rank: {rankS02}");
            Console.WriteLine($"Sell price: {sellprice}");
            Console.WriteLine($"Drop Amount: {dropAmountlow}-{dropAmounthigh}");
            Console.WriteLine($"Drop Chane: {dropchane}%");






        }
    }
}
