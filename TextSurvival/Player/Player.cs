using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Monsters;

namespace TextSurvival.Player
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

        protected int attack;
        public int Attack { get { return attack; } }

        protected int defense;
        public int Defense { get { return defense; } }

        protected int gold;
        public int Gold {  get { return gold; } set { gold = value; } }

        public abstract void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("=========================================");
            Console.WriteLine("");
        }
    }
}
