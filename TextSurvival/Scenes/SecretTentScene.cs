using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;
using TextSurvival.Shops;
using static System.Formats.Asn1.AsnWriter;

namespace TextSurvival.Scenes
{
    public class SecretTentScene : Scene
    { 
        private ConsoleKey inputKey;
        private string input;
        private Shop shop;
        private Player player;

        public SecretTentScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("수상한 텐트로 이동합니다...");
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
            Console.WriteLine("건장한 잡상인이 있다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.Write("선택 : ");

        }

        
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Buy);
                    break;
                case "2":
                    game.ChangeScene(SceneType.Sell);
                    break;

            }
        }
        
    }
}

