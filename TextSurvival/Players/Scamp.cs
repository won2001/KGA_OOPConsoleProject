using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public class Scamp : Player
    {
        public Scamp(string name)
        {
            {
                this.name = name;
                this.job = Job.Scamp;
                this.maxHP = 200;
                this.maxEndurance = 100;
                this.strength = 50;
                this.intelligence = 10;
                this.handicraft = 5;
                this.gold = 2000;
            }
        }
        public override void Skill(Monster monster)
        {
            throw new NotImplementedException();
        }
    }
}
