using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSurvival.Scenes
{
    public class SuspiciousDoorScene : Scene
    {
        private string input;
        public SuspiciousDoorScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("수상한 문 앞으로 이동중입니다...");
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
            Console.WriteLine("수상한 문 앞으로 왔다.");
            Console.WriteLine("문 앞에 보안프로그램이 보인다.");
            Console.WriteLine("왠지 키 카드가 필요해보인다.");
            Console.WriteLine("카드를 사용하시겠습니까?");
        }
        public override void Update()
        {
            //열쇠 존재여부에 따라 문 통과기능 이벤트를 사용해 구현해보기
        }
    }
}
