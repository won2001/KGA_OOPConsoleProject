using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSurvival.Players;
using TextSurvival.Scenes;


namespace TextSurvival
{
    public class Game
    {
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;

        public Scene CurSCene { get {  return curScene; } }

        private Player player;
        public Player Player { get { return player; } }



        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

        private void Start()
        {
            isRunning = true;

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Campsite] = new CampsiteScene(this);
            scenes[(int)SceneType.Forest] = new ForestScene(this);
            scenes[(int)SceneType.Ocean] = new OceanScene(this);
            scenes[(int)SceneType.AbandonedCity] = new AbandonedCityScene(this);
            scenes[(int)SceneType.Battle] = new BattleScene(this);
            scenes[(int)SceneType.Inventory] = new InventoryScene(this);
            scenes[(int)SceneType.SuspiciousTent] = new SuspiciousTentScene(this);
            scenes[(int)SceneType.SuspiciousDoor] = new SuspiciousDoorScene(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
        }

        private void End()
        {
            curScene.Exit();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }



    }


}
