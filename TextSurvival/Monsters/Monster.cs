using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TextSurvival.Players;

namespace TextSurvival.Monsters
{
    public class Monster
    {
        public string name;
        public int curHP;
        public int maxHP;
        public int attck;
        public string weapon;
        public int hit;

        public Monster()
        {
            name = "야생동물";
            weapon = "몽둥이";
            attck = 50;
        }
        public void Attack(Player player)
        {
            Console.WriteLine($"{name}이 당신을 공격했다!");
            Console.WriteLine($"{attck}의 데미지를 주었다.");
        }
        public void TakeDamage(int damage)
        {
            if (damage > hit)
            {
                Console.WriteLine($"{damage - hit} 데미지를 받았다!");
                curHP -= damage - hit;
            }
            else
                Console.WriteLine();

            if (curHP <= 0)
            {
                Console.WriteLine($"{name}쓰려졌다!");

            }
            //곰, 멧돼지, 괴한 만들기
        }
    }
}
