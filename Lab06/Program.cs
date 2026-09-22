/*
 * Student ID : 1690701865
 * Name       :Chonlawit Kedsa
 * Section    : 129C
 * No.        : 1
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 4;
            //if (lives == 0) //ใส่เงื่อนไขที่ต้องการ ต้องเป็น bool (true/fale)
            //{
            //    Console.WriteLine("Game Over!"); //โค้ดด้านในจะรันก็ต่อเมื่อ if เป็น true เท่านั้น
            //}
            //else
            //{
            //    Console.WriteLine("Keep Fighting");
            //}
            //ถ้า if ทำงานเสร็จแล้ว หรือ เป็น fale จะทำงานต่อมาบรรทัดด้านนอกทันที
            /*int level = 10;
            if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked");
                Console.WriteLine("The door open.");
            }
            else if (level >= 5 )
            {
                Console.WriteLine("The door open.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }*/
            /*Console.WriteLine("Your level (1-99)");
            bool hasKey = true;
            bool valid = int.TryParse(Console.ReadLine(), out int level);
            if ( !valid || level < 1 || level > 99 )
            {
                Console.WriteLine("Invalid");
            }
            else if (level >= 10 && hasKey )
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5 )
            {
                if (hasKey == true)
                {
                    Console.WriteLine("The door opens");
                }
                else
                {
                    Console.WriteLine("Locked. Find a key");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut");
            }*/
            int shipHp = 20000;
            int monHp = 15000;
            int shootCan = 5000;
            int repair = 1000;
            int shield = 10000;
            Console.WriteLine("==>Space Adventure Into The Darkness<==");
            Console.WriteLine("==Hero vs. Enemy==");
            Console.WriteLine("ACTOIN 1 : SHOOT CANNON");
            Console.WriteLine("ACTOIN 2 : REPIAR");
            Console.WriteLine("ACTOIN 3 : ACTIVATE BARRIER");

            Console.WriteLine("Choose your action (1-3)");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);
            
            if (!userInput || choice < 1 || choice >3 )
            {
                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Input isn't incorret. Please, Choose number between (1-3)");
                }
                else
                {
                    Console.WriteLine("ERROR, It isn't number. You must Choose number (1-3");
                }
            }
            else if (choice == 1)
            {
                monHp -= shootCan;
                if (monHp <= 0)
                {
                    Console.WriteLine("Enemy Destoyed!!!");
                }
                else
                {
                    Console.WriteLine($"Hero Shoot Enemy. Enemy have {monHp} HP Left");
                }
            }
            else if (choice == 2)
            {
                shipHp += repair;
                if (shipHp > 20000)
                {
                    Console.WriteLine($"Hero have Full HP");
                    shipHp = 20000;
                }
                else
                {
                    Console.WriteLine($"Hero repiar Ship. Ship have {shipHp}");
                }
            }
            else
            {
                shipHp += shield;
                Console.WriteLine($"Hero activates barrier. Ship have {shield} Shield");
                
            }
        }
    }
}
