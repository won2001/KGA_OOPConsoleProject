using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Inventorys.Items;
using TextSurvival.Players;

namespace TextSurvival.Shops
{
    public class Shop
    {
        private Item[] items;

        public Shop()
        {
            items = new Item[3];
            items[0] = new Key();
            items[1] = new Potion();
        }
        public int ItemCount => items.Length;

        public void ShowAllItem()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Name}");
                Console.WriteLine($" 가격 : {items[i].Cost}");
                Console.WriteLine($" 설명 : {items[i].Description}");
                Console.WriteLine();
            }
        }
        public void Sell(Player player, int index)
        {
            Item item = null;
            switch (index)
            {
                case 0:
                    item = new Key();
                    break;
                case 1:
                    item = new Potion();
                    break;
            }
            if (player.Gold < item.Cost)
            {
                Console.WriteLine("골드가 충분하지 않다.");
                Thread.Sleep(1000);
                return;
            }
            if (player.GainItem(item) == false)
            {
                Console.WriteLine("인벤토리가 가득차서 팔 수 없습니다.");
                Thread.Sleep(1000);
                return;
            }

            player.LoseGold(item.Cost);
            Console.WriteLine($"{item.Name} 을 구매합니다.");
            Console.WriteLine($"{item.Cost}G를 사용했습니다.");
            Console.WriteLine($"{player.Gold}G가 남았습니다.");
            Thread.Sleep(1000);
        }
        public void Buy(Player player, Item item)
        {
            player.LoseItem(item);
            player.GainGold(item.Cost);
            Console.WriteLine($"{item.Name} 을 판매합니다.");
            Console.WriteLine($"소지금 : {player.Gold}G");
            Thread.Sleep(1000);
        }
        
    }
}
