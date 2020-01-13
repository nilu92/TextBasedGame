using System;

namespace TextGame
{
    class Program
    {
        private Menu menu;

        static void Main(string[] args)
        {
          new Program().Run();
        }

        public Program() 
        {
            menu = new Menu();
        }
        private void Run() 
        {
            menu.MainMenu();
        }
    }



}
