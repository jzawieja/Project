using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    };

    class Settings
    { 
        public static int Score  { get; set; }
        public static int Points { get; set; }
        public static int Speed  { get; set; }
        public static int Height { get; set; }
        public static int Width  { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Score = 0;
            Points = 10;
            Speed = 10;
            Height = 20;
            Width = 20;
            GameOver = false;
            direction = Direction.down;
        }
    }
}
