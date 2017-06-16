using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Ractangle> Snake = new List<Ractangle>();
        private Ractangle food = new Ractangle();

        public Form1()
        {
            InitializeComponent();

            new Settings();

            timer.Interval = 1000 / Settings.Speed;
            timer.Tick += UpdateScreen();
            timer.Start();

            StartGame();
        }
        private void StartGame()
        {
            new Settings();

            Snake.Clear();
            Ractangle head = new Ractangle();
            head.X = 20;
            head.Y = 20;
            Snake.Add(head);

            realscore.Text = Settings.Score.ToString();
            NewFood();

        }
        private void NewFood()
        {
        int maxXpos = playingfield.Size.Width / Settings.Width;
        int maxYpos = playingfield.Size.Height / Settings.Height;

        Random random = new Random();
        food = new Ractangle();
        food.X = random.Next(0, maxXpos);
        food.Y = random.Next(0, maxYpos);
            }
    private void UpdateScreen (object sender, EventArgs e)
    {
        if (Settings.GameOver == true)
        {
            if (Press.KeyPressed(Keys.Enter))
            {
                StartGame();
            }
        }
        else
            {
                if (Press.KeyPressed(Keys.Right) && Settings.direction != Direction.left)
                    Settings.direction = Direction.right;
               else if (Press.KeyPressed(Keys.Left) && Settings.direction != Direction.right)
                    Settings.direction = Direction.left;
               else if (Press.KeyPressed(Keys.Up) && Settings.direction != Direction.down)
                    Settings.direction = Direction.up;
               else if (Press.KeyPressed(Keys.Down) && Settings.direction != Direction.up)
                    Settings.direction = Direction.down;

                MovePlayer();
            }
          

    }

    }
}
