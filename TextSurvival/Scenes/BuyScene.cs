using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;
using TextSurvival.Shops;

namespace TextSurvival.Scenes
{
    public class BuyScene : Scene
    {
        Player player;
        Shop shop = new Shop();
        
        private ConsoleKey inputKey;
        public BuyScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            
        }
        public override void Exit()
        {
        }
        public override void Input()
        {
            inputKey = Console.ReadKey().Key;
            Console.WriteLine();
            
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("====== 아이템 구매 ======");
            Console.WriteLine($"보유한 골드 : {player.Gold}");

            shop.ShowAllItem();

            Console.Write("구매할 아이템을 선택하시오 : ");
        }
        public override void Update()
        {
            int inputvalue = (int)inputKey - (int)ConsoleKey.D0;

            if (inputKey == ConsoleKey.D0)
            {
                game.ChangeScene(SceneType.Campsite);
            }
            else if (1 <= inputvalue && inputvalue <= shop.ItemCount)
            {
                shop.Sell(player, inputvalue - 1);
            }
            else
            {
                Console.WriteLine("다시 입력해주세요.");
                Thread.Sleep(1000);
            }
        }
    }
}

