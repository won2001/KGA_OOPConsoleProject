using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Monsters
{
    public class Monster
    {
        public string name;
        public int curHP;
        public int maxHP;
        public int attck;
        public string weapon;

        public Monster()
        {
            name = "야생동물";
            weapon = "몽둥이";
            attck = 1;
            maxHP = 100;
        }
    }
}
