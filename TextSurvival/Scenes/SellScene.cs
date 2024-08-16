using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;
using TextSurvival.Shops;

namespace TextSurvival.Scenes
{
    public class SellScene : Scene
    {
        Player player;
        Shop shop;
        private ConsoleKey inputKey;
        public SellScene(Game game) : base(game)
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
            Console.WriteLine("====== 아이템 판매 ======");
            Console.WriteLine($"소지금 : {player.Gold}");

            player.ShowInventory();

            Console.Write("판매할 아이템을 선택하세요 : ");
        }
        public override void Update()
        {
            int inputvalue = (int)inputKey - (int)ConsoleKey.D0;

            if (inputKey == ConsoleKey.D0)
            {
                Update();
            }
            else if (1 <= inputvalue && inputvalue <= player.InvenCount)
            {
                shop.Buy(player, player.GetItem(inputvalue - 1));
            }
            else
            {
                Console.WriteLine("다시 입력해주세요.");
                Thread.Sleep(1000);
            }
        }
    }
}
