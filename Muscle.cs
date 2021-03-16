using System;
namespace ClassicHeist
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            int MuscleTalent = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is cancelling the security guards. Decreased security by {SkillLevel}.");
            if (MuscleTalent <= 0)
            {
                Console.WriteLine($"{Name} has dropped all the security guards!");
            }
        }
    }

}