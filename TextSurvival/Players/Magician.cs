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
                this.Name = name;
                this.Job = Job.Magician;
                this.MaxHP = 100;
                this.CurHP = MaxHP;
                this.Endurance = 50;
                this.Strength = 10;
                this.Intelligence = 30;
                this.Handicraft = 50;
                this.gold = 5000;
            }
        }
        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
