using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    public class ForestScene : Scene
    {
        private string input;
        public ForestScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("숲으로 이동합니다...");
            
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
            Console.WriteLine("숲의 한 가운데에 도착했습니다.");
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
            }
        }
    }
}
