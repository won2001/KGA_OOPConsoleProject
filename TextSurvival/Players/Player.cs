using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public abstract class Player
    {
        protected string name;

        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        protected int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHP { get { return MaxHP; } }

        protected int strength;
        public int Strength { get { return strength; } }

        protected int maxEndurance;
        public int MaxEndurance { get { return maxEndurance; } }

        protected int curEndurance;
        public int CurEndurance { get{ return curEndurance; } }

        protected int intelligence;
        public int Intelligence { get { return intelligence; } }

        protected int handicraft;
        public int Handicraft { get { return handicraft; } }

        protected int gold;
        public int Gold {  get { return gold; } set { gold = value; } }

        public abstract void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("=========================================");
            Console.WriteLine($" 이름 : {name,-6} 직업 : {job,-6}");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP}  스태미나 : {curEndurance} / {maxEndurance}");
            Console.WriteLine($" 스탯 : 힘({strength}) 지능({intelligence}) 손재주({handicraft})");
            Console.WriteLine($" 소지골드 : {gold} G");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }
    }
}
