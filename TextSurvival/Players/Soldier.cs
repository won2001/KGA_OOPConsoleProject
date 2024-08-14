using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public class Soldier : Player
    {
        public Soldier(string name)
        {
            this.name = name;
            this.job = Job.Soldier;
            this.maxHP = 300;
            this.maxEndurance = 150;
            this.strength = 35;
            this.intelligence = 30;
            this.handicraft = 20;
            this.gold = 2000;
        }

        public override void Skill(Monster monster)
        {
            Console.WriteLine("총구로 때리기");
        }
    }
}
