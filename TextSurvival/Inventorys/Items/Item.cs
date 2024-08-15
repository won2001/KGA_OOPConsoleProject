using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextSurvival.Inventorys.Items
{
    public class Item
    {
        public string name;
        private int cost;
        public string description;
        
        public string effect;

        public Item(string name, int cost, string desc, string effect)
        {
            this.name = name;
            this.cost = cost;
            this.description = desc;
            
            this.effect = effect;
        }

        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Description { get => description; set => description = value; }
        public string Effect { get => effect; }
    }
}
