using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Inventorys.Items;

namespace TextSurvival.Inventorys
{
    public class Inventory
    {
        public const int MAX_ITEM = 6;

        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>(MAX_ITEM);
        }

        public int ItemCount => items.Count;

        public bool AddItem(Item item)
        {
            if (items.Count >= MAX_ITEM)
            {
                Console.WriteLine("아이템이 가득차서 넣지 못합니다.");
                return false;
            }

            items.Add(item);
            return true;
        }

        public bool RemoveItem(Item item)
        {
            return items.Remove(item);
        }

        public bool RemoveItem(int index)
        {
            if (index < 0 || items.Count <= index)
            {
                Console.WriteLine("범위를 벗어나는 아이템을 삭제할 순 없습니다.");
                return false;
            }

            items.RemoveAt(index);
            return true;
        }

        public Item GetItem(int index)
        {
            return items[index];
        }

        public void ShowAllItem()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
                Console.WriteLine($" 설명 : {items[i].description}");
                Console.WriteLine($" 효과 : {items[i].effect}"); 
                Console.WriteLine();
            }
        }
    }
}
