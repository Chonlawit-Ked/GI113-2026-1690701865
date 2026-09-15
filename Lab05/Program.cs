/*
 * Student ID : 1690701865
 * Name       :Chonlawit Kedsa
 * Section    : 129C
 * No.        : 1
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> Kingdom Hound <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulation\n");

            // Hero stats input
            Console.WriteLine("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(),out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input
            Console.WriteLine("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID : {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID : {isMonIntValid}");

            Console.WriteLine($"[HERO]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monHp} ATK: {monAtk} DEF: {monDef}");
            //bool allIntValid = isHeroIntValid && isMonIntValid;
            //ถ้าเอาแค่ชื่อ bool มาเช็ค คือ เช็คว่าเป็นจริงไหม

            // Compound assignment : += จำลองสถานการณ์ผู้เล่นดื่ม Potion ก่อนต่อสู้
            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} Hp, Hero Hp now {heroHp}");

            // Arithmetic +
            int normDmg = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"\nNormal Attack would deal: {normDmg} DMG");

            // Precedence
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"\nPower Attack would deal: {pwrDmg} DMG");

            // Random, Simple percent chacne
            Random rng = new Random();
            double roll = rng.Next(1, 101);
            bool isCrit = roll <= 1;
            int critDmg = normDmg + Convert.ToInt32(isCrit) + normDmg;
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"If critical, normal attack would instand deal: {critDmg}");
        }
    }
}
