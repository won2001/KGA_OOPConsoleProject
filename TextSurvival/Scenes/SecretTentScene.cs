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
        private int input;
        private Shop shop;
        private Player player;
        private bool isRunning;
        enum ShopScene { Menu, Buy, Sell};
        ShopScene shopScene = ShopScene.Menu;
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
        public override void Input()
        {
            inputKey = Console.ReadKey().Key;
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("건장한 잡상인이 있다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 들어간다");
            
            Console.Write("선택 : ");

        }

        public override void Update()
        {
            while (isRunning)
            {
                switch (shopScene)
                {
                    case ShopScene.Menu:
                        MenuUpdate();
                        break;
                    case ShopScene.Buy:
                        BuyUpdate();
                        break;
                    case ShopScene.Sell:
                        SellUpdate();
                        break;
                }
            }
        }
        public void MenuUpdate()
        {
            if (input == 0)
            {
            }
            else
            {
                Console.Write("아이템 구매");
            }
            if (input == 1)
            {
            }
            else
            {
                Console.WriteLine("아이템 판매");
            }
            if (input == 2)
            {

            }
            else
            {
                Console.WriteLine("나가기");
            }

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
        private void BuyUpdate()
        {
            Console.Clear();
            Console.WriteLine("====== 아이템 구매 ======");
            Console.WriteLine($"보유한 골드 : {player.Gold}");

            shop.ShowAllItem();

            Console.Write("구매할 아이템을 선택하세요 (뒤로가기 0) : ");

            // Input();
            
            Console.WriteLine();
            int inputValue = (int)inputKey - (int)ConsoleKey.D0;

            // Update();
            if (inputKey == ConsoleKey.D0)
            {
                shopScene = ShopScene.Menu;
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

        private void SellUpdate()
        {
            Console.Clear();
            Console.WriteLine("====== 아이템 판매 ======");
            Console.WriteLine($"보유한 골드 : {player.Gold}");

            player.ShowInventory();

            Console.Write("판매할 아이템을 선택하세요 (뒤로가기 0) : ");

            // Input();
            
            Console.WriteLine();
            int inputValue = (int)inputKey - (int)ConsoleKey.D0;

            // Update();
            if (inputKey == ConsoleKey.D0)
            {
                shopScene = ShopScene.Menu;
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

