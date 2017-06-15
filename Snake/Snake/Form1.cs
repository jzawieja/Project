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

        }
    }
}
