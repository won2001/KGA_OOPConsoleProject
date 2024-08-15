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
            this.name = name;
            this.job = Job.Doctor;
            this.maxHP = 150;
            this.curHP = maxHP;
            this.endurance = 50;
            this.strength = 15;
            this.intelligence = 50;
            this.handicraft = 30;
            this.gold = 3000;
        }
        //public override void Skill(Monster monster)
        //{
        //
        //}
    }
}
