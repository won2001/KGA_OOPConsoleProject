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

        public string Name { get; set; }

        public Job Job { get; set; }

        public int CurHP { get; set; }

        public int MaxHP { get; set; }

        public int Strength { get; set; }

        public int Endurance { get; set; }

        public int Intelligence { get; set; }

        public int Handicraft { get; set; }

        protected int gold;
        public int Gold {  get  => gold;  set { gold = value; } }
        public int InvenCount => inven.ItemCount;

        public bool GainItem(Item item)
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
        public void LoseItem(Item item)
        {
            if (item is IGainable)
            {
                IGainable gainable = (IGainable)item;
                gainable.Lose(this);
            }
            inven.RemoveItem(item);
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
            Console.WriteLine($" 이름 : {Name,-6} 직업 : {Job,-6}");
            Console.WriteLine($" 체력 : {CurHP,+3} / {MaxHP}");
            Console.WriteLine($" 스탯 : 힘({Strength}) 지능({Intelligence}) 지구력({Endurance}) 손재주({Handicraft})");
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
