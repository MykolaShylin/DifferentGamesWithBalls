using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;

namespace BallGameWinFormsLibrary
{
    public class Ball 
    {
        public Timer timer;
        protected float vx = 3;
        protected float vy = 3;
        protected float centerX = 150;
        protected float centerY = 150;
        protected int radius = 20;
        protected Form form;
        protected int slowBallSpeed = 30;
        protected int normalBallSpeed = 10;
        protected static Random random = new Random();
        private SolidBrush clear;
        protected SolidBrush show;

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = normalBallSpeed;
            timer.Tick += Timer_Tick;
            clear = new(Color.FromArgb(255, form.BackColor));
            show = new(Color.Aqua);
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Clear();
            Go();
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
        public virtual void Show()
        {
            HideOrShow(show);
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;            
        }
        public virtual void Clear()
        {
            HideOrShow(clear);
        }
        protected virtual int LeftSide()
        {
            return radius;
        }
        protected virtual int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        protected virtual int TopSide()
        {
            return radius;
        }
        protected virtual int DownSide()
        {
            return form.ClientSize.Height - radius;
        }


        protected virtual void HideOrShow(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }
        public virtual bool IsBallOnMap()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }        

        public bool IsMousePointOnBall(int mouseX, int mouseY)
        {
            var dx = mouseX - centerX;
            var dy = mouseY - centerY;
            return (dx * dx) + ( dy * dy) <= radius * radius;
        }
        public void SlowDown()
        {
            timer.Interval = slowBallSpeed;
        }
        public virtual void SpeedUp()
        {
            timer.Interval = normalBallSpeed;
        }
    }
}
