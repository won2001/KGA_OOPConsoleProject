using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Player
{
    public class Soldier : Player
    {
        public Soldier()
        {
            this.name = name;
            this.job = Job.Soldier;
            this.maxHP = 150;
            this.attack = 50;
            this.defense = 30;
            this.gold = 100;
        }

        public override void Skill(Monster monster)
        {
            Console.WriteLine("수류탄 투척")
        }
    }
}
