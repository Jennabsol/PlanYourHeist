using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Crook
    {
        public Crook(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        

    }
}