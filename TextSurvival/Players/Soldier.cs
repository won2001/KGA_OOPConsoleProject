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
            this.Name = name;
            this.Job = Job.Soldier;
            this.MaxHP = 300;
            this.CurHP = MaxHP;
            this.Endurance = 150;
            this.Strength = 35;
            this.Intelligence = 30;
            this.Handicraft = 20;
            this.gold = 2000;
        }

        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
