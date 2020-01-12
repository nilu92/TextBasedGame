using System;

namespace TextGame
{
     public class Enemy
    {
        //Constructor
        public Enemy(int position, bool Isalive)
        {
            isAlive = Isalive;
            Position = position;
        }

        public bool isAlive { get; set; }
        public int Position { get; set; }

    }
}