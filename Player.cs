using System;
namespace MyNamespace
{
     public class Player
    {
        //Constructor
        public Player(int position, int health, int keys)
        {
            Position = position;
            Health = health;
            Keys = keys;
        }
        public int Health { get; set; }
        public int Position { get; set; }
        public int Keys { get; set; }

    }
}