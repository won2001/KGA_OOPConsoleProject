using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;

namespace TextSurvival.Scenes
{
    public class SelectScene : Scene
    {
        public enum State { Name, Job, Confirm}
        private State curState;

        private string input;
        private string nameInput;
        public SelectScene(Game game) : base(game)
        {
        }
        public override void Enter()
        {
            curState = State.Name;
        }
        public override void Exit()
        {
            input = Console.ReadLine();
        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Render()
        {
            Console.Clear();
            if (curState == State.Name)
            {
                Console.Write("캐릭터의 이름을 입력하세요 : ");
            }
            else if (curState == State.Job)
            {
                Console.WriteLine("직업을 선택하세요.");
                Console.WriteLine("1. 군인");
                Console.WriteLine("2. 의사");
                Console.WriteLine("3. 건달");
                Console.WriteLine("4. 마술사");
                Console.Write("선택할 직업 : ");
            }
            else if (curState == State.Confirm)
            {
                Console.WriteLine("=====================");
                Console.WriteLine($"이름 : {game.Player.Name}");
                Console.WriteLine($"직업 : {game.Player.Job}");
                Console.WriteLine($"체력 : {game.Player.MaxHP}");
                Console.WriteLine($"힘 : {game.Player.Strength}");
                Console.WriteLine($"지구력 : {game.Player.MaxEndurance}");
                Console.WriteLine($"지능 : {game.Player.Intelligence}");
                Console.WriteLine($"손재주 : {game.Player.Handicraft}");
                Console.WriteLine($"소지금 : {game.Player.Gold}");
                Console.WriteLine("======================");
                Console.WriteLine();
                Console.Write("이대로 플레이 하시겠습니까?(y/n)");
            }
        }
        public override void Update()
        {
            if (curState == State.Name)
            {
                if (input == string.Empty)//string.Empty 문자열 초기화 표면상 ""과 같음
                    return;

                nameInput = input;
                curState = State.Job;
            }
            else if (curState == State.Job)
            {
                if (Job.TryParse(input, out Job select) == false)
                    return;
                if (Enum.IsDefined(typeof(Job), select) == false)
                    return;

                switch (select)
                {
                    case Job.Soldier:
                        game.Player = new Soldier(nameInput);
                        break;
                    case Job.Doctor:
                        game.Player = new Doctor(nameInput);
                        break;
                    case Job.Scamp:
                        game.Player = new Scamp(nameInput);
                        break;
                    case Job.Magician:
                        game.Player = new Magician(nameInput);
                        break;
                }
                curState = State.Confirm;
            }
            else if (curState == State.Confirm)
            {
                switch (input)
                {
                    case "Y":
                    case "y":
                        game.ChangeScene(SceneType.Campsite);
                        break;
                    case "N":
                    case "n":
                        curState = State.Name;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
