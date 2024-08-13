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
            throw new NotImplementedException();
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
