using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game)
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
            Console.WriteLine("     계속하려면 아무키나 누르세요     ");
            Console.ReadKey();
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("I                                      I");
            Console.WriteLine("I                                      I");
            Console.WriteLine("I                OutLand               I");
            Console.WriteLine("I                                      I");
            Console.WriteLine("I                                      I");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Select);
        }
    }
}
