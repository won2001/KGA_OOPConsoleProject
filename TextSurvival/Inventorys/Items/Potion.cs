using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;

namespace TextSurvival.Inventorys.Items
{
    public class Potion : Item, IUsable
    {
        public const int curHP = 100;

        public Potion() : base("체력 물약", 500, "수상하게 생겼다.",$"체력을 회복{curHP}")
        {
        }
        public void Use(Player user)
        {
            user.curHP += curHP;
            Console.WriteLine("물약을 마셨다.");
            Console.WriteLine(Effect);
        }
    }
}
