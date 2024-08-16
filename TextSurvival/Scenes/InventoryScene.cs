using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Inventorys;
using TextSurvival.Players;

namespace TextSurvival.Scenes
{
    public class InventoryScene : Scene
    {
        private Player player;
        private ConsoleKey input;
        public InventoryScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("인벤토리를 엽니다...");
            Thread.Sleep(1000);
        }
        public override void Exit()
        {
        }
        public override void Input()
        {
            input = Console.ReadKey().Key;
            
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine($"{game.Player.Name}인벤토리");
            Console.WriteLine($"소지금 : {game.Player.Gold}G");
            Console.WriteLine("아이템 목록 ");

            //player.ShowInventory();

            Console.Write("사용할 아이템을 선택하세요");

        }
        public override void Update()
        {
            int inputValue = (int)input - (int)ConsoleKey.D0;
            if (input == ConsoleKey.D0)
            {
                game.ChangeScene(SceneType.Campsite);
            }
            else if (1 <= inputValue && inputValue <= player.InvenCount)
            {
                player.UseItem(inputValue - 1);
            }
            else
            {
                
            }
        }
    }
}
