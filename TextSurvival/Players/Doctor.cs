using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public class Doctor : Player
    {
        public Doctor(string name)
        {
            this.Name = name;
            this.Job = Job.Doctor;
            this.MaxHP = 150;
            this.CurHP = MaxHP;
            this.Endurance = 50;
            this.Strength = 15;
            this.Intelligence = 50;
            this.Handicraft = 30;
            this.gold = 3000;
        }
        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
