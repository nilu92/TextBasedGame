using System;
namespace TextGame
{
     public class Player
    {
        //Constructor
        public Player(int position, int health, int keys, string name)
        {
            Position = position;
            Health = health;
            Keys = keys;
            Name = name;
        }
        public int Health { get; set; }
        public int Position { get; set; }
        public int Keys { get; set; }

       public string Name { get; set; }

    }
}