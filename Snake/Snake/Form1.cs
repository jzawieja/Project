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
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            new Settings();

            timer.Interval = 1000 / Settings.Speed;
            timer.Tick += UpdateScreen;
            timer.Start();

            StartGame();
        }
        private void StartGame()
        {
            endgame.Visible = false;
            new Settings();

            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            realscore.Text = Settings.Score.ToString();
            NewFood();

        }
        private void NewFood()
        {
        int maxXpos = playingfield.Size.Width / Settings.Width;
        int maxYpos = playingfield.Size.Height / Settings.Height;

        Random random = new Random();
        food = new Circle();
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
            playingfield.Invalidate();

        }

        private void playingfield_Paint(object sender, PaintEventArgs e)
        {
            Graphics field = e.Graphics;
            if (!Settings.GameOver) // Ta linijka generuje jakiś problem. Przez nią aplikacja nie działa prawidłowo.
            {
                Brush snakeColour;
                for (int i = 0; i< Snake.Count; i++ )
                {
                    if (i == 0)
                        snakeColour = Brushes.Chocolate;
                    else
                        snakeColour = Brushes.Beige;
                    field.FillEllipse(snakeColour, 
                        new Rectangle(Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width,
                        Settings.Height));

                    field.FillEllipse(Brushes.DeepPink, 
                        new Rectangle(food.X * Settings.Width,
                        food.Y * Settings.Height,
                        Settings.Width,
                        Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game Over \n Finale Score: " + Settings.Score + "\n Press Enter for New Game";
                endgame.Text = gameOver;
                endgame.Visible = true;
            }
        }


        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.up:
                            Snake[i].Y--;
                            break;
                        case Direction.down:
                            Snake[i].Y++;
                            break;
                        case Direction.right:
                            Snake[i].X++;
                            break;
                        case Direction.left:
                            Snake[i].X--;
                            break;
                    }
                    int maxXpos = playingfield.Size.Width / Settings.Width;
                    int maxYpos = playingfield.Size.Height / Settings.Height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXpos || Snake[i].Y >= maxYpos) 
                    {
                         Die();
                    }

                    for (int j=1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                            Snake[i].Y == Snake[j].Y)
                        {
                          Die();
                        }
                    }
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                       Eat();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            Settings.Score += Settings.Points;
            realscore.Text = Settings.Score.ToString();

            NewFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Press.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Press.ChangeState(e.KeyCode, false);
        }

    }
}
