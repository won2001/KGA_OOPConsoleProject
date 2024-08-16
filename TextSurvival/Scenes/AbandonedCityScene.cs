using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    public class AbandonedCityScene : Scene
    {
        private string input;
        public AbandonedCityScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("폐도시로 이동합니다...");
            Console.WriteLine("좋지않은 바람이 붑니다...");
            Thread.Sleep(1000);
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
            Console.WriteLine("폐도시 한복판에 도착했습니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 야영지로 돌아간다.");
            Console.WriteLine("2. 더 깊이 들어가본다.");
            Console.Write("선택 : ");
        }
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Campsite);
                    break;
                case "2":
                    game.ChangeScene(SceneType.Battle);
                    break;
            }//폐도시에서만 나오는 몬스터를 만든다.
        }
    }
}
