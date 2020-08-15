using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanElements
{
    class Enemy : PictureBox
    {
        public int Step { get; set; } = 2;
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 2;

        public Enemy()
        {
            InitializeEnemy();
        }
        private void InitializeEnemy()
        {
            this.BackColor = Color.Red;
            this.Size = new Size(40, 40);
            this.Tag = "enemy";
        }

        public void SetRandomDirection()
        {
            int directionCode = rand.Next(1, 5);
            switch (directionCode)
            {
                case 1:
                    HorizontalVelocity = Step;
                    VerticalVelocity = 0;
                case 2:
                    HorizontalVelocity = 0;
                    VerticalVelocity = Step;
                case 3:
                    HorizontalVelocity = Step;
                    VerticalVelocity = 0;
                case 4:
                    HorizontalVelocity = Step;
                    VerticalVelocity = 0;


            }
        }

    }

}
