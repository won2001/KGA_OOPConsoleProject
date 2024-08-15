using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Inventorys;
using TextSurvival.Inventorys.Items;
using TextSurvival.Monsters;

namespace TextSurvival.Players
{
    public class Player
    {
        private Inventory inven;
        protected string name;

        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } }

        protected int strength;
        public int Strength { get { return strength; } }

        protected int endurance;
        public int Endurance { get { return endurance; } }

        protected int intelligence;
        public int Intelligence { get { return intelligence; } }

        protected int handicraft;
        public int Handicraft { get { return handicraft; } }

        protected int gold;
        public int Gold {  get  => gold;  set { gold = value; } }
        public int InvenCount => inven.ItemCount;

        public bool GeinItem(Item item)
        {
            if(item is IGainable)
            {
                IGainable gainable = (IGainable)item;
                gainable.Gain(this);
            }
            return inven.AddItem(item);
        }

        public void LoseItem(int index)
        {
            Item item = inven.GetItem(index);
            if (item is IGainable)
            {
                IGainable gainable = (IGainable)item;
                gainable.Lose(this);
            }
            inven.RemoveItem(index);
            
        }
        public void UseItem(Item item)
        {
            if (item is IUsable)
            {
                if (item is IUsable)
                {
                    IUsable usable = (IUsable)item;
                    usable.Use(this);
                    inven.RemoveItem(item);
                }
                else
                {
                    Console.WriteLine($"{item.name}은 사용할 수 없습니다.");

                }
            }
        }
        public void UseItem(int index)
        {
            Item itme = inven.GetItem( index );
            UseItem(itme);
        }
        public void GainGold(int gold)
        {
            this.gold = gold;
        }
        public void LoseGold(int gold)
        {
            this.gold -= gold;
        }

        //public void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("=========================================");
            Console.WriteLine($" 이름 : {name,-6} 직업 : {job,-6}");
            Console.WriteLine($" 체력 : {curHP,+3} / {maxHP}");
            Console.WriteLine($" 스탯 : 힘({strength}) 지능({intelligence}) 지구력({endurance}) 손재주({handicraft})");
            Console.WriteLine($" 소지골드 : {gold} G");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }
        public void ShowInventory()
        {
            inven.ShowAllItem();
        }
        public Item GetItem(int index)
        {
            return inven.GetItem(index);
        }
    }
}
