using System;
namespace ClassicHeist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            int HackerTalent = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel}.");
            if (HackerTalent <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }

}