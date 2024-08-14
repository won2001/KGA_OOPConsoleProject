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
        private List<Item> items;
        public const int inventorySize = 9;

        public Inventory()
        {
            items = new(inventorySize);
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }
    }
}
