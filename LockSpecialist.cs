using System;
namespace ClassicHeist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            int LockTalent = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the locks. Decreased security by {SkillLevel}.");
            if (LockTalent == 0)
            {
                Console.WriteLine($"{Name} has cracked the safe!");
            }

        }
    }


}