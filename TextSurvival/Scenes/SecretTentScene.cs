using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;
using TextSurvival.Shops;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TextSurvival.Scenes
{
    public class SecretTentScene : Scene
    { 
        private ConsoleKey inputKey;
        private Shop shop;
        private Player player;
        private bool isRunning;
        enum ShopScene {  Buy, Sell};
        ShopScene shopScene;
        public SecretTentScene(Game game) : base(game)
        {
            isRunning = true;
            player = new Player();
            shop = new Shop();
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
        public void ShopRun()
        {
            while (isRunning)
            {
                switch (shopScene)
                {
                    case ShopScene.Buy:
                        BuyUpdate();
                        break;
                    case ShopScene.Sell:
                        SellUpdate();
                        break;
                }//구매 창 판매 창으로 안넘어가는 오류 고치기
            }
        }
        public override void Input()
        {
            inputKey = Console.ReadKey().Key;
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine(" ====================");
            Console.WriteLine("I       상점        I");
            Console.WriteLine(" ====================");
            Console.WriteLine();
            Console.WriteLine("======= 상점 메뉴 =======");
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("3. 나간다.");
            Console.Write("무엇을 하시겠습니까? : ");

        }

        public override void Update()
        {
            switch (inputKey)
            {
                case ConsoleKey.D1:
                    shopScene = ShopScene.Buy;
                    break;
                case ConsoleKey.D2:
                    shopScene = ShopScene.Sell;
                    break;
                case ConsoleKey.D3:
                    game.ChangeScene(SceneType.Campsite);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("잘못입력했습니다.");
                    Thread.Sleep(1000);
                    break;
            }
        }
        public void BuyUpdate()
        {
            Console.Clear();
            Console.WriteLine("====== 아이템 구매 ======");
            Console.WriteLine($"보유한 골드 : {player.Gold}");

            shop.ShowAllItem();

            Console.Write("구매할 아이템을 선택하세요 : ");

            inputKey = Console.ReadKey().Key;
            Console.WriteLine();
            int inputValue = (int)inputKey - (int)ConsoleKey.D0;

            if (inputKey == ConsoleKey.D0)
            {
                game.ChangeScene(SceneType.SecretTent);
            }
            else if (1 <= inputValue && inputValue <= shop.ItemCount)
            {
                shop.Sell(player, inputValue - 1);
            }
            else
            {
                Console.WriteLine("잘못입력했습니다.");
                Thread.Sleep(1000);
            }
        }


        public void SellUpdate()
        {
            Console.Clear();
            Console.WriteLine("====== 아이템 판매 ======");
            Console.WriteLine($"보유한 골드 : {player.Gold}");

            player.ShowInventory();

            Console.Write("판매할 아이템을 선택하세요 : ");
            
            Console.WriteLine();
            int inputValue = (int)inputKey - (int)ConsoleKey.D0;

            if (inputKey == ConsoleKey.D0)
            {
                game.ChangeScene(SceneType.SecretTent);
            }
            else if (1 <= inputValue && inputValue <= player.InvenCount)
            {
                shop.Buy(player, player.GetItem(inputValue - 1));
            }
            else
            {
                Console.WriteLine("잘못입력했습니다.");
                Thread.Sleep(1000);
            }
        }


    }
}

