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
                this.Name = name;
                this.Job = Job.Scamp;
                this.MaxHP = 200;
                this.CurHP = MaxHP;
                this.Endurance = 100;
                this.Strength = 50;
                this.Intelligence = 10;
                this.Handicraft = 5;
                this.gold = 2000;
            }
        }
        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
