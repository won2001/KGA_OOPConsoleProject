using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;


namespace TextSurvival.Inventorys.Items
{
    public class Key : Item, IGainable
    {
        public Key() : base("키 카드",10000,"어딘가에 사용할 수 있을거같다.","")
        {

        }
        public void Gain(Player user)
        {
            
            Console.WriteLine("수상한 키 카드를 얻었다.");
            Console.WriteLine(Effect);

        }
        public void Lose(Player user)
        {
            Console.WriteLine();
        }
    }
}
