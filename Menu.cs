using System;

namespace TextGame
{
    public class Menu
    {
        public Menu()
        {

        }
        public void MainMenu()
        {
            Console.Clear();
            bool running = true;
            while (running)
            {
                Console.WriteLine("[1]New game");
                Console.WriteLine("[2]exit");
                Console.ReadLine();

                string Action = Console.ReadLine();
                switch (Action)
                {
                    case "1":
                        Console.WriteLine("This will start a new game");
                        Console.ReadLine();
                        break;
                    case "2":
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        Console.ReadLine();
                        MainMenu();
                        break;
                }
            }
        }


    }

}

