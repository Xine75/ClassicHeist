using System;
using System.Collections.Generic;

namespace ClassicHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker kevin = new Hacker()
            {
                Name = "Kevin Mitnick",
                SkillLevel = 50,
                PercentageCut = 10,
            };
            Hacker cameron = new Hacker()
            {
                Name = "Cameron Howe",
                SkillLevel = 50,
                PercentageCut = 25,
            };
            Muscle gina = new Muscle()
            {
                Name = "Gina the Gorilla",
                SkillLevel = 70,
                PercentageCut = 5,
            };
            Muscle bill = new Muscle()
            {
                Name = "Shoebill Stork",
                SkillLevel = 45,
                PercentageCut = 5,
            };
            LockSpecialist nancy = new LockSpecialist()
            {
                Name = "Anansi",
                SkillLevel = 100,
                PercentageCut = 10,
            };
            LockSpecialist edward = new LockSpecialist()
            {
                Name = "Edward ScissorHands",
                SkillLevel = 50,
                PercentageCut = 5,
            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                kevin, cameron, gina, bill, nancy, edward
            };


            BuildYourCrew();
            void BuildYourCrew()
            {
                Console.WriteLine($"The number of current operatives in the rolodex is {rolodex.Count}.");
                Console.Write("Please enter a possible new operative > ");
                string newOp = Console.ReadLine();
                if (newOp == "")
                {
                    Console.WriteLine("Looks like you've completed your crew! \n Time to begin THE HEIST");
                    return;
                }
                else
                {
                    Console.WriteLine($"Please select a role for {newOp}:");
                    Console.Write("Options are: \n [1] Hacker (Disables alarms) \n [2] Muscle (Disarms guards) \n [3] Lock Specialist (Cracks safe)\n [1, 2, or 3]? > ");
                    int newOpRole = Int32.Parse(Console.ReadLine());

                    IRobber criminal;

                    if (newOpRole == 1)
                    {
                        Console.WriteLine($"{newOp} is a Hacker.");
                        criminal = new Hacker()
                        {
                            Name = newOp
                        };
                        //add newOp to Hacker
                    }
                    else if (newOpRole == 2)
                    {
                        Console.WriteLine($"{newOp} is Muscle.");
                        criminal = new Muscle()
                        {
                            Name = newOp
                        };
                        //add newOp to Muscle
                    }
                    else
                    {
                        Console.WriteLine($"{newOp} is a Lock Specialist.");
                        criminal = new LockSpecialist()
                        {
                            Name = newOp
                        };
                        //add newOp to LockSpecialist
                    }

                    Console.Write($"What is {newOp}'s Skill Level? Please choose a rating between 1 and 100 >");
                    int newOpSkill = Int32.Parse(Console.ReadLine());
                    criminal.SkillLevel = newOpSkill;


                    Console.Write($"What cut are you giving {newOp}? Be smart about it. >");
                    int newOpCut = Int32.Parse(Console.ReadLine());
                    criminal.PercentageCut = newOpCut;

                    rolodex.Add(criminal);

                    BuildYourCrew();
                }
            }

            Bank mark = new Bank()
            {
                CashOnHand = new Random().Next(50000, 1000001),
                AlarmScore = new Random().Next(1, 101),
                VaultScore = new Random().Next(1, 101),
                SecurityGuardScore = new Random().Next(1, 101),
            };

            Recon();
            void Recon()
            {
                string MostSecure;
                string LeastSecure;

                //most secure

                if (mark.AlarmScore > mark.VaultScore && mark.AlarmScore > mark.SecurityGuardScore)
                {
                    MostSecure = "Alarm Score";
                }
                else if (mark.VaultScore > mark.AlarmScore && mark.VaultScore > mark.SecurityGuardScore)
                {
                    MostSecure = "Vault Score";
                }
                else
                {
                    MostSecure = "Security Guard Score";
                }

                //lease secure
                if (mark.AlarmScore < mark.VaultScore && mark.AlarmScore < mark.SecurityGuardScore)
                {
                    LeastSecure = "Alarm Score";
                }
                else if (mark.VaultScore < mark.AlarmScore && mark.VaultScore < mark.SecurityGuardScore)
                {
                    LeastSecure = "Vault Score";
                }
                else
                {
                    LeastSecure = "Security Guard Score";
                }

                Console.WriteLine($"The bank's most secure system is {MostSecure}.");
                Console.WriteLine($"The bank's least secure system is {LeastSecure}.");





            }



        }
    }
}
