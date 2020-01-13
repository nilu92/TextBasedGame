using System;

namespace TextGame
{

    public class Menu
    {
        int position;
        int health;
        int keys;
        bool isAlive;
        string name;
        



        public Game game;
        public Menu()
        {
            game = new Game();
        }
        public void MainMenu()
        {
            Console.Clear();
            int Action;
            Action = int.Parse(Console.ReadLine());
            Console.WriteLine("[1]New\n" + "[2]Exit");

            switch (Action)
            {
                case 1:
                    Game.GameStart(position, health,keys,isAlive, name);
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }







    }

}

