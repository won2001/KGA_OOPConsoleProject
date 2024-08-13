using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    public class CampsiteScene : Scene
    {
        private string input;
        public CampsiteScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("야영지로 이동합니다...");
        }
        public override void Exit()
        {
        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Render()
        {
            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine("따뜻한 모닥불이 있는 야영지이다.");
            Console.WriteLine("어디로 이동하겠습니까?");
            Console.WriteLine("1. 숲");
            Console.WriteLine("2. 바다");
            Console.WriteLine("3. 폐도시");
            Console.WriteLine("4. 수상한 문");
            Console.WriteLine("5. 수상한 텐트");
            Console.WriteLine("6. 현재 인벤토리를 본다");
            Console.Write("선택 : ");
        }
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Forest);
                    break;
                case "2":
                    game.ChangeScene(SceneType.Ocean);
                    break;
                case "3":
                    game.ChangeScene(SceneType.AbandonedCity);
                    break;
                case "4":
                    game.ChangeScene(SceneType.SuspiciousDoor);
                    break;
                case "5":
                    game.ChangeScene(SceneType.SuspiciousTent);
                    break;
                case "6":
                    game.ChangeScene(SceneType.Inventory);
                    break;

            }
        }
    }
}
