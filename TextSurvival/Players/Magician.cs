using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public class Magician : Player
    {
        public Magician(string name)
        {
            {
                this.name = name;
                this.job = Job.Magician;
                this.maxHP = 100;
                this.curHP = maxHP;
                this.endurance = 50;
                this.strength = 10;
                this.intelligence = 30;
                this.handicraft = 50;
                this.gold = 5000;
            }
        }
        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
