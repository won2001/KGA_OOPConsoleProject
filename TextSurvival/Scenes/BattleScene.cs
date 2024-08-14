using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    internal class BattleScene : Scene
    {
        public BattleScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Bear:
                    Console.WriteLine("야생 곰이 나타났습니다.");
                    break;
                case (int)MonsterType.WildBoar:
                    Console.WriteLine("야생 멧돼지가 나타났습니다.");
                    break;
                case (int)MonsterType.Weirdo:
                    Console.WriteLine("수상한 괴한이 나타났습니다.");
                    break;
            }
        }
        public override void Exit() 
        {
        }
        public override void Input()
        {
            
        }
        public override void Render()
        {
            
        }
        public override void Update()
        {
            
        }
    }
}
