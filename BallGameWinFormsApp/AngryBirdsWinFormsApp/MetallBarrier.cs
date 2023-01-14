using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallGameWinFormsLibrary;
using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    
    public class MetallBarrier
    {
        protected SolidBrush show;
        SolidBrush clear;
        Rectangle rectangle;
        protected int rectangleWidth;
        protected int rectangleHeight;
        protected int pointX;
        protected int pointY;
        private Form form;
        protected Random random = new Random();
        private Timer timer;
        public MetallBarrier(Form form)
        {
            clear = new(Color.FromArgb(255, form.BackColor));
            show = new(Color.FromArgb(192, 192, 192));
            this.form = form;
            rectangleWidth = random.Next(30, 51);
            rectangleHeight = rectangleWidth * 3;
            pointX = random.Next(LeftSide(),RightSide());
            pointY = random.Next(TopSide(),DownSide());
            this.form = form;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            rectangle = GetRectangleType();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Show();
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

        public void Show()
        {
            HideOrShow(show);
        }
        public virtual void Clear()
        {
            HideOrShow(clear);
        }
        private Rectangle GetRectangleType()
        {
            var randomType = random.Next(1, 3);
            if(randomType == 1)
            {
                return new Rectangle(pointX, pointY, rectangleWidth, rectangleHeight);
            }
            return new Rectangle(pointX, pointY, rectangleHeight, rectangleWidth);
        }
        protected void HideOrShow(Brush brush)
        {            
            var graphics = form.CreateGraphics();
            graphics.FillRectangle(brush, rectangle);
        }
        protected int LeftSide()
        {
            return form.ClientSize.Width / 3;
        }
        protected int RightSide()
        {
            return form.ClientSize.Width - LeftSide();
        }
        protected int TopSide()
        {
            return form.ClientSize.Height / 3;
        }
        protected int DownSide()
        {
            return form.ClientSize.Height - TopSide();
        }
        public float GetX()
        {
            return pointX;
        }
        public float GetY()
        {
            return pointY;
        }
        public int GetWidth()
        {
            return rectangle.Width;
        }
        public int GetHeight()
        {
            return rectangle.Height;
        }
    }

}
