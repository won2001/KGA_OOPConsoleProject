using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Inventorys;

namespace TextSurvival.Scenes
{
    internal class InventoryScene : Scene
    {
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
            Console.ReadKey();
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine($"{game.Player.Name}인벤토리");
            Console.WriteLine("아이템 목록 ");
            Console.WriteLine($"소지금 : {game.Player.Gold}G");


        }
        public override void Update()
        {
        }
    }
}
