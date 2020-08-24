﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanElements
{
    class Food : PictureBox
    {
        public int Type { get; set; } = 1;
        public Food()
        {
            InitializeFood();
        }

        private void InitializeFood()
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(20,20);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Name = "Food";
            this.SetType(1);
        }

        public void SetType(int type)
        {
            this.Type = type;
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_" + type.ToString());
        }
    }
}
