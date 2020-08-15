﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanElements
{
    public partial class Game : Form
    {
        private Level level = new Level();
        private Hero hero = new Hero();
        private Timer mainTimer = null;
        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeMainTimer();
        }

        private void InitializeGame()
        {
            //adjust game form size
            this.Size = new Size(500, 500);
            //add key down event handler
            this.KeyDown += Game_KeyDown;
            //adding level to the game
            this.Controls.Add(level);
            //adding hero to the game
            this.Controls.Add(hero);
            hero.BringToFront();
        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += MainTimer_Tick;
            mainTimer.Interval = 20;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            hero.Left += hero.HorizontalVelocity;
            hero.Top += hero.VerticalVelocity;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    break;
                case Keys.Up:
                    break;
            }      
        }
    }
}
