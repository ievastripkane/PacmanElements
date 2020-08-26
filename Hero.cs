using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanElements
{
    class Hero : PictureBox
    {
        public int Step { get; set; } = 3;
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 0;
        public string Direction { get; set; } = "right";
        public bool PredatorMode { get; set; } = false;

        private Timer animationTimer = null;
        private Timer predatorModeTimer = null;

        private int frameCounter = 1;

        public Hero()
        {
            InitializeHero();
            InitializeAnimationTimer();
        }

        public void PredatorModeOn()
        {
            this.PredatorMode = true;
            InitializePredatorModeTimer();
        }

        private void InitializePredatorModeTimer()
        {
            predatorModeTimer = new Timer();
            predatorModeTimer.Interval = 5000;
            predatorModeTimer.Tick += PredatorModeTimer_Tick;
            predatorModeTimer.Start();
        }

        private void PredatorModeTimer_Tick(object sender, EventArgs e)
        {
            predatorModeTimer.Stop();
            this.PredatorMode = false;
        }
        public void Melt()
        {
            animationTimer.Stop();
            frameCounter = 1;
            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 200;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void InitializePacmanMeltTimer()
        {
            Timer pacmanMeltTimer = new Timer();
            pacmanMeltTimer.Tick += PacmanMeltTimer_Tick;
            pacmanMeltTimer.Interval = 100;
        }

        private void PacmanMeltTimer_Tick(object sender, EventArgs e)
        {
            MeltAnimate();
        }

        private void MeltAnimate()
        {
            string imageName = "pacman_melt" + "_" + frameCounter.ToString();
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            frameCounter++;
            if (frameCounter > 14)
            {
                animationTimer.Stop();
            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Animate();
        }

        private void Animate()
        {
            string imageName = "pacman_" + this.Direction + "_" + frameCounter.ToString();
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            frameCounter++;
            if (frameCounter > 4)
            {
                frameCounter = 1;
            }
        }

        private void InitializeHero()
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(30, 30);
            this.Location = new Point(200, 200);
            this.Name = "Pacman";
        }
    }
}
