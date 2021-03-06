﻿using System;

namespace TextGame
{
    public class Game
    {
        public Player player;
        private Enemy enemy;
        private Map map;


        public static void GameStart(int position, int health, int keys, bool isAlive, string name)
        {

            Player player = CreatePlayer(position, health, keys, name);
            Enemy enemy = CreateEnemy(position, isAlive);
            Map map = CreateMap();

            player.Keys = 0;
            player.Position = 0;
            player.Health = 10;

            Console.WriteLine("The game has started!");
            Console.WriteLine("Enter name");
            player.Name = Console.ReadLine();
            string Name = player.Name;
            int Health = player.Health;
            int Position = player.Position;
            int Keys = player.Keys;
            Console.WriteLine("Welcome {0}, Your Health is {1}, and your position is {2}, you have {3} keys at moment", Name, Health, Position, Keys);
            Console.ReadLine();

            GameLoop(Position, Health, Keys, Name);
        }
        public static void GameLoop(int Position, int Health, int Keys, string Name)
        {
            Player player = CreatePlayer(Position, Health, Keys, Name);
            
            while (true)
            {
                Console.WriteLine(player.Name + " Choose an Action!\n" + "[Left]\n"+"[Right]\n" + "[Up]\n" + "[Down]");
                string Action;
                Action = Console.ReadLine();
                Action.ToLower();
                if(Action == "Left") 
                {
                    player.Position = +1;

                }





            }

        }

        public static void Move() 
        {
            



        }
        public static bool CanMove(int position)
        {
            
            
            
            return false;
        }
        public  static int CheckPos(int position)
        {
            return position;
            
        }
        public static Map CreateMap()
        {
            Map map = new Map();
            return map;
        }
        public static Enemy CreateEnemy(int position, bool isAlive)
        {
            Enemy enemy = new Enemy(position, isAlive);
            return enemy;
        }
        public static Player CreatePlayer(int position, int health, int keys, string name)
        {
            Player player = new Player(position, health, keys, name);
            return player;

        }
        public Game()
        {


        }
    }
}
